## dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark-20210811-201102
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA234EE0
-       mov       rdx,7FF9EA214ED0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,264FF321DD0
-       mov       rdx,14B03213238
        mov       r8,[r8]
+       mov       r8,264FF313020
-       mov       r8,14B23211028
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/93397a16-c72f-44bd-b6f2-6babf5355cc7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/18f90de9-2b5e-41d4-b730-15259a081cdb-diff.temp
index 50cf500..6625fdf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/18f90de9-2b5e-41d4-b730-15259a081cdb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/93397a16-c72f-44bd-b6f2-6babf5355cc7-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225408
-       mov       rdx,7FF9EA214ED0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1A395C95648
-       mov       rdx,14B03213238
        mov       r8,[r8]
+       mov       r8,1A395C93020
-       mov       r8,14B23211028
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b606c2a8-cc45-4a9f-90a2-35ec77459c0c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5d22d498-e46a-4b56-8b6c-2d4177875f18-diff.temp
index 50cf500..c88c261 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5d22d498-e46a-4b56-8b6c-2d4177875f18-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b606c2a8-cc45-4a9f-90a2-35ec77459c0c-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA214ED0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,286ACC215B8
-       mov       rdx,14B03213238
        mov       r8,[r8]
+       mov       r8,286ACC13020
-       mov       r8,14B23211028
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f90f408d-0da9-4905-9a46-8b65413f4600-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e911517-8622-4684-85db-9428d358cbce-diff.temp
index 50cf500..7c2345e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e911517-8622-4684-85db-9428d358cbce-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f90f408d-0da9-4905-9a46-8b65413f4600-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205338
-       mov       rdx,7FF9EA214ED0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,19AB6B53238
-       mov       rdx,14B03213238
        mov       r8,[r8]
+       mov       r8,19AD6B51028
-       mov       r8,14B23211028
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dc540c47-06c0-4c8b-ac1c-85584c8a4113-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/099292b3-825e-49ee-b433-cfcff7c64b16-diff.temp
index 50cf500..fc8cbaf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/099292b3-825e-49ee-b433-cfcff7c64b16-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dc540c47-06c0-4c8b-ac1c-85584c8a4113-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA214ED0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,138C7375A30
-       mov       rdx,14B03213238
        mov       r8,[r8]
+       mov       r8,138E7373020
-       mov       r8,14B23211028
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39daf592-7769-4db3-b4c3-1491272735ac-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/82fcbc10-f1b3-43a8-bf67-5f2e6289324e-diff.temp
index 50cf500..fdf4c2a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/82fcbc10-f1b3-43a8-bf67-5f2e6289324e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39daf592-7769-4db3-b4c3-1491272735ac-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA214ED0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,26BA16F1240
-       mov       rdx,14B03213238
        mov       r8,[r8]
+       mov       r8,26BB16F3020
-       mov       r8,14B23211028
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c46a1ba0-0fbc-4657-8174-c26e490e7201-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da5e5618-5af5-41d5-b39a-30d1f58e1e2b-diff.temp
index 50cf500..4c24f28 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da5e5618-5af5-41d5-b39a-30d1f58e1e2b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c46a1ba0-0fbc-4657-8174-c26e490e7201-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225408
-       mov       rdx,7FF9EA234EE0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1A395C95648
-       mov       rdx,264FF321DD0
        mov       r8,[r8]
+       mov       r8,1A395C93020
-       mov       r8,264FF313020
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0a14d5a3-2123-4de1-b825-31e613e0190c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/19a6f2ac-d942-49a3-9642-3aab57ccedec-diff.temp
index 6625fdf..c88c261 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/19a6f2ac-d942-49a3-9642-3aab57ccedec-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0a14d5a3-2123-4de1-b825-31e613e0190c-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA234EE0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,286ACC215B8
-       mov       rdx,264FF321DD0
        mov       r8,[r8]
+       mov       r8,286ACC13020
-       mov       r8,264FF313020
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6e883d2f-6f16-4de1-a670-ddf24e89fcc3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e981ede-b356-4085-babf-2d7e7dad076d-diff.temp
index 6625fdf..7c2345e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e981ede-b356-4085-babf-2d7e7dad076d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6e883d2f-6f16-4de1-a670-ddf24e89fcc3-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205338
-       mov       rdx,7FF9EA234EE0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,19AB6B53238
-       mov       rdx,264FF321DD0
        mov       r8,[r8]
+       mov       r8,19AD6B51028
-       mov       r8,264FF313020
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6807b250-d86d-4a94-b201-c32128483268-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0c66b768-e8f1-43eb-b352-84e82ed85774-diff.temp
index 6625fdf..fc8cbaf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0c66b768-e8f1-43eb-b352-84e82ed85774-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6807b250-d86d-4a94-b201-c32128483268-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA234EE0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,138C7375A30
-       mov       rdx,264FF321DD0
        mov       r8,[r8]
+       mov       r8,138E7373020
-       mov       r8,264FF313020
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/93c056ca-d146-4344-8efe-0d63ea7447f0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e962c53a-b8b1-413e-9498-d0f09390bc6f-diff.temp
index 6625fdf..fdf4c2a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e962c53a-b8b1-413e-9498-d0f09390bc6f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/93c056ca-d146-4344-8efe-0d63ea7447f0-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA234EE0
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,26BA16F1240
-       mov       rdx,264FF321DD0
        mov       r8,[r8]
+       mov       r8,26BB16F3020
-       mov       r8,264FF313020
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/963a7e42-8dc0-48b7-9753-e70430f24d71-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/792baad0-0787-4503-b19d-7ddea38c3631-diff.temp
index 6625fdf..4c24f28 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/792baad0-0787-4503-b19d-7ddea38c3631-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/963a7e42-8dc0-48b7-9753-e70430f24d71-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA225408
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,286ACC215B8
-       mov       rdx,1A395C95648
        mov       r8,[r8]
+       mov       r8,286ACC13020
-       mov       r8,1A395C93020
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/13c46d8e-3084-482c-88c3-f7df68680270-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/875eaa74-09e3-42f7-9a7d-9e716633428e-diff.temp
index c88c261..7c2345e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/875eaa74-09e3-42f7-9a7d-9e716633428e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/13c46d8e-3084-482c-88c3-f7df68680270-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205338
-       mov       rdx,7FF9EA225408
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,19AB6B53238
-       mov       rdx,1A395C95648
        mov       r8,[r8]
+       mov       r8,19AD6B51028
-       mov       r8,1A395C93020
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1cfb0c37-2dee-47e3-9e20-aeffe5db12a8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cb347a91-d3f0-461a-867a-83dce85b11cc-diff.temp
index c88c261..fc8cbaf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cb347a91-d3f0-461a-867a-83dce85b11cc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1cfb0c37-2dee-47e3-9e20-aeffe5db12a8-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA225408
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,138C7375A30
-       mov       rdx,1A395C95648
        mov       r8,[r8]
+       mov       r8,138E7373020
-       mov       r8,1A395C93020
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39d27f1c-393c-4a6b-ad3a-d6d60f731e94-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0f003796-80d6-4716-9132-2aac5d876e65-diff.temp
index c88c261..fdf4c2a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0f003796-80d6-4716-9132-2aac5d876e65-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39d27f1c-393c-4a6b-ad3a-d6d60f731e94-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA225408
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,26BA16F1240
-       mov       rdx,1A395C95648
        mov       r8,[r8]
+       mov       r8,26BB16F3020
-       mov       r8,1A395C93020
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/50e6edd0-b332-45bd-a5b1-791803029320-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/23925548-2318-4ed2-9604-142f48ddb256-diff.temp
index c88c261..4c24f28 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/23925548-2318-4ed2-9604-142f48ddb256-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/50e6edd0-b332-45bd-a5b1-791803029320-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205338
-       mov       rdx,7FF9EA2255D8
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,19AB6B53238
-       mov       rdx,286ACC215B8
        mov       r8,[r8]
+       mov       r8,19AD6B51028
-       mov       r8,286ACC13020
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e54acfb-4cad-414f-a39d-66b6712fc6b2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/41aa5630-29c2-460e-8598-53e952b5790a-diff.temp
index 7c2345e..fc8cbaf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/41aa5630-29c2-460e-8598-53e952b5790a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e54acfb-4cad-414f-a39d-66b6712fc6b2-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/42b861b4-5795-4782-b15a-9909a0c70e2b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/886d5d33-c97d-4571-95ea-e95771688277-diff.temp
index 7c2345e..fdf4c2a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/886d5d33-c97d-4571-95ea-e95771688277-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/42b861b4-5795-4782-b15a-9909a0c70e2b-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/106ecebe-a3b6-40e9-8288-f9328e79b81e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20cc45f4-5b47-4bf3-8a31-4af542ac85bb-diff.temp
index 7c2345e..4c24f28 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20cc45f4-5b47-4bf3-8a31-4af542ac85bb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/106ecebe-a3b6-40e9-8288-f9328e79b81e-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA205338
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,138C7375A30
-       mov       rdx,19AB6B53238
        mov       r8,[r8]
+       mov       r8,138E7373020
-       mov       r8,19AD6B51028
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fd2aa132-8d67-474a-959a-f4edc16a5dcf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d6c1195-d604-41aa-92b4-b7df16338217-diff.temp
index fc8cbaf..fdf4c2a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d6c1195-d604-41aa-92b4-b7df16338217-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fd2aa132-8d67-474a-959a-f4edc16a5dcf-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2255D8
-       mov       rdx,7FF9EA205338
        mov       rcx,rsi
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rdi
        jne       short M01_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,26BA16F1240
-       mov       rdx,19AB6B53238
        mov       r8,[r8]
+       mov       r8,26BB16F3020
-       mov       r8,19AD6B51028
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
 ; Total bytes of code 59
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
        mov       r8,[rsi+30]
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2a984e0f-d2f5-4178-b2ec-ef46605c9dc8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/792ecba4-6f65-440f-8856-502c034cc0ea-diff.temp
index fc8cbaf..4c24f28 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/792ecba4-6f65-440f-8856-502c034cc0ea-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2a984e0f-d2f5-4178-b2ec-ef46605c9dc8-diff.temp
```
**Diff for FirstOrDefaultAlternate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3eae2841-1b72-45c4-b288-d717f97ec772-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4e05cb7e-75e5-4e2f-80b8-1584e3fbd52d-diff.temp
index fdf4c2a..4c24f28 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4e05cb7e-75e5-4e2f-80b8-1584e3fbd52d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3eae2841-1b72-45c4-b288-d717f97ec772-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA224F38
-       mov       rdx,7FF9EA234F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,1CECFD71248
-       mov       rdx,1A9A012F9C8
        mov       r8,[r8]
+       mov       r8,1CEDFD73020
-       mov       r8,1A980123020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1CECFD71240
-       mov       rdx,1A9A012F9C0
        mov       r8,[r8]
+       mov       r8,1CEDFD73020
-       mov       r8,1A980123020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/153b4945-ff0e-4290-a66d-fa821d625245-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08834efb-6096-49d8-929e-c3a0e250f767-diff.temp
index 6b6c478..93902a3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08834efb-6096-49d8-929e-c3a0e250f767-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/153b4945-ff0e-4290-a66d-fa821d625245-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215320
-       mov       rdx,7FF9EA234F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,25C91F71248
-       mov       rdx,1A9A012F9C8
        mov       r8,[r8]
+       mov       r8,25C81F73020
-       mov       r8,1A980123020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,25C91F71240
-       mov       rdx,1A9A012F9C0
        mov       r8,[r8]
+       mov       r8,25C81F73020
-       mov       r8,1A980123020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/768ed52e-f441-4236-b52f-9579a8fc6475-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7b066693-aff0-4d23-9db3-9e56ac0c560c-diff.temp
index 6b6c478..d861dbb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7b066693-aff0-4d23-9db3-9e56ac0c560c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/768ed52e-f441-4236-b52f-9579a8fc6475-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215320
-       mov       rdx,7FF9EA234F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,2950AD79628
-       mov       rdx,1A9A012F9C8
        mov       r8,[r8]
+       mov       r8,2950AD73020
-       mov       r8,1A980123020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2950AD79620
-       mov       rdx,1A9A012F9C0
        mov       r8,[r8]
+       mov       r8,2950AD73020
-       mov       r8,1A980123020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6536c23b-f9ad-475e-b2d2-c6c147db643d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/88f96860-3117-4da6-9534-95bd1b9f58df-diff.temp
index 6b6c478..7523b11 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/88f96860-3117-4da6-9534-95bd1b9f58df-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6536c23b-f9ad-475e-b2d2-c6c147db643d-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215590
-       mov       rdx,7FF9EA234F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,143EC191A60
-       mov       rdx,1A9A012F9C8
        mov       r8,[r8]
+       mov       r8,143FC193020
-       mov       r8,1A980123020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,143EC191A58
-       mov       rdx,1A9A012F9C0
        mov       r8,[r8]
+       mov       r8,143FC193020
-       mov       r8,1A980123020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/911b4da5-493a-4779-aa88-db032ab749d5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/26107d43-ec0b-4501-ba4a-025f12ea262f-diff.temp
index 6b6c478..2fa18f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/26107d43-ec0b-4501-ba4a-025f12ea262f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/911b4da5-493a-4779-aa88-db032ab749d5-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225590
-       mov       rdx,7FF9EA234F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,1761A743658
-       mov       rdx,1A9A012F9C8
        mov       r8,[r8]
+       mov       r8,1761A743020
-       mov       r8,1A980123020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1761A743650
-       mov       rdx,1A9A012F9C0
        mov       r8,[r8]
+       mov       r8,1761A743020
-       mov       r8,1A980123020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5815fa6b-e194-4f9b-af8d-015164bd9c77-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/494d43c5-6b72-443b-b6d8-5c73a1549b92-diff.temp
index 6b6c478..40cc3be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/494d43c5-6b72-443b-b6d8-5c73a1549b92-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5815fa6b-e194-4f9b-af8d-015164bd9c77-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252F0
-       mov       rdx,7FF9EA234F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C8
-       mov       rdx,1A9A012F9C8
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,1A980123020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C0
-       mov       rdx,1A9A012F9C0
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,1A980123020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2bed5030-2f7e-4249-a0ce-03b951043810-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/085e062c-a3d5-4d6e-8c19-df484ad3a6a1-diff.temp
index 6b6c478..eb0a45a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/085e062c-a3d5-4d6e-8c19-df484ad3a6a1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2bed5030-2f7e-4249-a0ce-03b951043810-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215320
-       mov       rdx,7FF9EA224F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,25C91F71248
-       mov       rdx,1CECFD71248
        mov       r8,[r8]
+       mov       r8,25C81F73020
-       mov       r8,1CEDFD73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,25C91F71240
-       mov       rdx,1CECFD71240
        mov       r8,[r8]
+       mov       r8,25C81F73020
-       mov       r8,1CEDFD73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8cd0855-c50e-44bf-8e7c-1ecd6dc7fbc5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f7ccaff6-8cff-400d-8ba2-7d1900ef4ce9-diff.temp
index 93902a3..d861dbb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f7ccaff6-8cff-400d-8ba2-7d1900ef4ce9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8cd0855-c50e-44bf-8e7c-1ecd6dc7fbc5-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215320
-       mov       rdx,7FF9EA224F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,2950AD79628
-       mov       rdx,1CECFD71248
        mov       r8,[r8]
+       mov       r8,2950AD73020
-       mov       r8,1CEDFD73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2950AD79620
-       mov       rdx,1CECFD71240
        mov       r8,[r8]
+       mov       r8,2950AD73020
-       mov       r8,1CEDFD73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cc93ad37-b3ee-4ba3-896c-e63112fbecd2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f5dabf5-6cdc-442d-99b3-2def516818d0-diff.temp
index 93902a3..7523b11 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f5dabf5-6cdc-442d-99b3-2def516818d0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cc93ad37-b3ee-4ba3-896c-e63112fbecd2-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215590
-       mov       rdx,7FF9EA224F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,143EC191A60
-       mov       rdx,1CECFD71248
        mov       r8,[r8]
+       mov       r8,143FC193020
-       mov       r8,1CEDFD73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,143EC191A58
-       mov       rdx,1CECFD71240
        mov       r8,[r8]
+       mov       r8,143FC193020
-       mov       r8,1CEDFD73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6b5b4507-8b27-486d-86f3-360048d1bc02-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eb0ae26d-a0b0-427b-a890-9c445aaf6169-diff.temp
index 93902a3..2fa18f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eb0ae26d-a0b0-427b-a890-9c445aaf6169-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6b5b4507-8b27-486d-86f3-360048d1bc02-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225590
-       mov       rdx,7FF9EA224F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,1761A743658
-       mov       rdx,1CECFD71248
        mov       r8,[r8]
+       mov       r8,1761A743020
-       mov       r8,1CEDFD73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1761A743650
-       mov       rdx,1CECFD71240
        mov       r8,[r8]
+       mov       r8,1761A743020
-       mov       r8,1CEDFD73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9412e500-2a85-4995-a3eb-8899ce8d4dec-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3925180a-b8d6-49e9-8f02-4b7bde2ff7b8-diff.temp
index 93902a3..40cc3be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3925180a-b8d6-49e9-8f02-4b7bde2ff7b8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9412e500-2a85-4995-a3eb-8899ce8d4dec-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252F0
-       mov       rdx,7FF9EA224F38
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C8
-       mov       rdx,1CECFD71248
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,1CEDFD73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C0
-       mov       rdx,1CECFD71240
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,1CEDFD73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/11e1006b-42d9-4881-875d-1798962b8b41-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed7ab8d8-341d-489f-bed8-653e15ba8d80-diff.temp
index 93902a3..eb0a45a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed7ab8d8-341d-489f-bed8-653e15ba8d80-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/11e1006b-42d9-4881-875d-1798962b8b41-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8aa5d94-a3e2-4b96-bad8-f75f77bd02ce-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/583a4107-072c-473b-95bd-6d9a8cfbb697-diff.temp
index d861dbb..7523b11 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/583a4107-072c-473b-95bd-6d9a8cfbb697-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8aa5d94-a3e2-4b96-bad8-f75f77bd02ce-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215590
-       mov       rdx,7FF9EA215320
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,143EC191A60
-       mov       rdx,25C91F71248
        mov       r8,[r8]
+       mov       r8,143FC193020
-       mov       r8,25C81F73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,143EC191A58
-       mov       rdx,25C91F71240
        mov       r8,[r8]
+       mov       r8,143FC193020
-       mov       r8,25C81F73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/27bd38b5-864f-4e82-a7c1-5cae5551f260-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6b4c7da-7284-4fe0-9265-8e7ed1a38cb4-diff.temp
index d861dbb..2fa18f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6b4c7da-7284-4fe0-9265-8e7ed1a38cb4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/27bd38b5-864f-4e82-a7c1-5cae5551f260-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225590
-       mov       rdx,7FF9EA215320
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,1761A743658
-       mov       rdx,25C91F71248
        mov       r8,[r8]
+       mov       r8,1761A743020
-       mov       r8,25C81F73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1761A743650
-       mov       rdx,25C91F71240
        mov       r8,[r8]
+       mov       r8,1761A743020
-       mov       r8,25C81F73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b53891ab-1b62-4196-a143-00ba022158d1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d48202ee-2fd7-4801-93d0-d3da2dd599f4-diff.temp
index d861dbb..40cc3be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d48202ee-2fd7-4801-93d0-d3da2dd599f4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b53891ab-1b62-4196-a143-00ba022158d1-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252F0
-       mov       rdx,7FF9EA215320
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C8
-       mov       rdx,25C91F71248
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,25C81F73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C0
-       mov       rdx,25C91F71240
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,25C81F73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/05700ca3-2b2f-4ffe-a2e2-bedfb1f7efc2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e167eb3-7071-4937-aba8-2327a1c6abe4-diff.temp
index d861dbb..eb0a45a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e167eb3-7071-4937-aba8-2327a1c6abe4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/05700ca3-2b2f-4ffe-a2e2-bedfb1f7efc2-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215590
-       mov       rdx,7FF9EA215320
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,143EC191A60
-       mov       rdx,2950AD79628
        mov       r8,[r8]
+       mov       r8,143FC193020
-       mov       r8,2950AD73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,143EC191A58
-       mov       rdx,2950AD79620
        mov       r8,[r8]
+       mov       r8,143FC193020
-       mov       r8,2950AD73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2dbdc34f-e7f3-4398-ac28-cee8a3df33b3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f577718-4a94-4885-9942-57301ea4f4b6-diff.temp
index 7523b11..2fa18f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f577718-4a94-4885-9942-57301ea4f4b6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2dbdc34f-e7f3-4398-ac28-cee8a3df33b3-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225590
-       mov       rdx,7FF9EA215320
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,1761A743658
-       mov       rdx,2950AD79628
        mov       r8,[r8]
+       mov       r8,1761A743020
-       mov       r8,2950AD73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1761A743650
-       mov       rdx,2950AD79620
        mov       r8,[r8]
+       mov       r8,1761A743020
-       mov       r8,2950AD73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8a60f48-d680-4288-b6f6-41233663151e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e89535d7-32b1-4349-b7f9-bdba11e64bdc-diff.temp
index 7523b11..40cc3be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e89535d7-32b1-4349-b7f9-bdba11e64bdc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8a60f48-d680-4288-b6f6-41233663151e-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252F0
-       mov       rdx,7FF9EA215320
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C8
-       mov       rdx,2950AD79628
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,2950AD73020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C0
-       mov       rdx,2950AD79620
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,2950AD73020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d43ea107-1160-4a6b-b5ed-2e084242a35e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e7fff201-eebf-49d7-a1b6-c03d1fea8dfb-diff.temp
index 7523b11..eb0a45a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e7fff201-eebf-49d7-a1b6-c03d1fea8dfb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d43ea107-1160-4a6b-b5ed-2e084242a35e-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225590
-       mov       rdx,7FF9EA215590
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,1761A743658
-       mov       rdx,143EC191A60
        mov       r8,[r8]
+       mov       r8,1761A743020
-       mov       r8,143FC193020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1761A743650
-       mov       rdx,143EC191A58
        mov       r8,[r8]
+       mov       r8,1761A743020
-       mov       r8,143FC193020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/45e0bb82-6cf4-4ca3-81a7-5176bc05c393-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/efd57b44-0f51-434d-8ea8-e89590895e95-diff.temp
index 2fa18f7..40cc3be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/efd57b44-0f51-434d-8ea8-e89590895e95-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/45e0bb82-6cf4-4ca3-81a7-5176bc05c393-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252F0
-       mov       rdx,7FF9EA215590
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C8
-       mov       rdx,143EC191A60
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,143FC193020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C0
-       mov       rdx,143EC191A58
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,143FC193020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/647340c6-1913-4ade-b13a-08c204062a2b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d609e40e-8d37-4689-babe-7ce41678ab0a-diff.temp
index 2fa18f7..eb0a45a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d609e40e-8d37-4689-babe-7ce41678ab0a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/647340c6-1913-4ade-b13a-08c204062a2b-diff.temp
```
**Diff for FirstOrDefaultAlternate02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252F0
-       mov       rdx,7FF9EA225590
        mov       rcx,rdi
 M02_L01:
        jmp       short M02_L02
        je        short M02_L01
        test      rcx,rcx
        mov       rcx,[r14+10]
        mov       r14,[rdi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        jne       short M02_L00
        test      rbx,rbx
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C8
-       mov       rdx,1761A743658
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,1761A743020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,10CE609F9C0
-       mov       rdx,1761A743650
        mov       r8,[r8]
+       mov       r8,10CD6093020
-       mov       r8,1761A743020
        mov       rsi,r9
        mov       rbp,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
 ; Total bytes of code 23
        jmp       near ptr System.String.Equals(System.String, System.String)
        mov       rdx,rax
        mov       rcx,rdx
        mov       rax,[rcx+48]
        mov       rcx,[rcx+30]
        mov       rdx,[rdx+48]
 ; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 113
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
        mov       r8,rdi
        mov       rdx,rbx
        mov       r9,[rsi+30]
        mov       [rdi+18],r9
        mov       r9,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rsi
        lea       rcx,[rdi+8]
        mov       rbx,[rsi+160]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e1748454-1d6b-431d-abdf-0ac5100cc52f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f97081b5-4a2a-49b5-b22a-db719ca23918-diff.temp
index 40cc3be..eb0a45a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f97081b5-4a2a-49b5-b22a-db719ca23918-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e1748454-1d6b-431d-abdf-0ac5100cc52f-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c9390636-103e-4d44-9109-2053508e1acc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6f4bf51-05f4-459b-a995-b4ce3b55cee1-diff.temp
index 8b857cd..460b62b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6f4bf51-05f4-459b-a995-b4ce3b55cee1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c9390636-103e-4d44-9109-2053508e1acc-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cc93f818-94f5-4fb9-8e18-806b25e1b40f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8c191bb6-ea68-4ec7-b495-6354a1323dc0-diff.temp
index 8b857cd..b73f67f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8c191bb6-ea68-4ec7-b495-6354a1323dc0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cc93f818-94f5-4fb9-8e18-806b25e1b40f-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dd34836e-2fba-49a0-b920-e59ad953cc12-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d96c9099-3cc8-4dc3-ae5f-3f11ad097431-diff.temp
index 8b857cd..fa773eb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d96c9099-3cc8-4dc3-ae5f-3f11ad097431-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dd34836e-2fba-49a0-b920-e59ad953cc12-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/300ac690-57f8-4732-a3bb-9966ee98b0ce-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d1548a91-5099-41b9-ad7d-9cad14be1bd8-diff.temp
index 8b857cd..0604fbf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d1548a91-5099-41b9-ad7d-9cad14be1bd8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/300ac690-57f8-4732-a3bb-9966ee98b0ce-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3dd44565-c85d-4a29-9183-d8830e12ce02-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/227842e1-12dd-495c-9271-2fd0ad12d72d-diff.temp
index 8b857cd..3480354 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/227842e1-12dd-495c-9271-2fd0ad12d72d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3dd44565-c85d-4a29-9183-d8830e12ce02-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e4bdb385-aab5-45ef-afda-52d58914565b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7569ce47-feca-43c8-bbd3-03189a95599d-diff.temp
index 8b857cd..9e7a000 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7569ce47-feca-43c8-bbd3-03189a95599d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e4bdb385-aab5-45ef-afda-52d58914565b-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cdf9b290-a1a9-49b3-b15c-087bd80c2ec5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4432e610-81ae-41ea-8797-ca0058c92fb5-diff.temp
index 460b62b..b73f67f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4432e610-81ae-41ea-8797-ca0058c92fb5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cdf9b290-a1a9-49b3-b15c-087bd80c2ec5-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/17ed97a5-08da-41c0-9987-03f7b8d47722-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f9db9d9d-9d86-45bd-b229-8e73b89d2572-diff.temp
index 460b62b..fa773eb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f9db9d9d-9d86-45bd-b229-8e73b89d2572-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/17ed97a5-08da-41c0-9987-03f7b8d47722-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f45cf7a-cdba-4494-8dc4-bb096606525b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4e7ee3aa-70f5-41af-b912-faf1eb05a8bc-diff.temp
index 460b62b..0604fbf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4e7ee3aa-70f5-41af-b912-faf1eb05a8bc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f45cf7a-cdba-4494-8dc4-bb096606525b-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f4894401-22c2-4e1f-b20d-d49b6ab2614e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7aba4a94-9985-47c2-8ec2-9dd34030d121-diff.temp
index 460b62b..3480354 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7aba4a94-9985-47c2-8ec2-9dd34030d121-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f4894401-22c2-4e1f-b20d-d49b6ab2614e-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4eac392e-ed90-4278-aed6-957f2f12d8bb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4702a4b4-0fac-454a-adae-fbe27fc7bb0b-diff.temp
index 460b62b..9e7a000 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4702a4b4-0fac-454a-adae-fbe27fc7bb0b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4eac392e-ed90-4278-aed6-957f2f12d8bb-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d378bf94-0c59-45ba-b3d5-0e2ee98a45b3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/758c567d-52c7-4f5c-8ed0-9855ee4c506c-diff.temp
index b73f67f..fa773eb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/758c567d-52c7-4f5c-8ed0-9855ee4c506c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d378bf94-0c59-45ba-b3d5-0e2ee98a45b3-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/70c63db9-51f0-4e25-96b1-7ac370223a69-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c09ef9b6-2b32-40ff-90fb-c41d5c2320e6-diff.temp
index b73f67f..0604fbf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c09ef9b6-2b32-40ff-90fb-c41d5c2320e6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/70c63db9-51f0-4e25-96b1-7ac370223a69-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dbf74056-fb6e-42a1-9885-190c1de506e4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/770289e2-e3f9-48b9-805b-db24969d9093-diff.temp
index b73f67f..3480354 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/770289e2-e3f9-48b9-805b-db24969d9093-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dbf74056-fb6e-42a1-9885-190c1de506e4-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/844b1e01-de59-4133-8e50-db56b186b225-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/07d5ddb7-c880-4a67-8149-f6265468ba2a-diff.temp
index b73f67f..9e7a000 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/07d5ddb7-c880-4a67-8149-f6265468ba2a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/844b1e01-de59-4133-8e50-db56b186b225-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c96cb72e-8e17-40bb-9c52-2044d4f92ff0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d401a542-9442-44d5-a753-307c3c84151a-diff.temp
index fa773eb..0604fbf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d401a542-9442-44d5-a753-307c3c84151a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c96cb72e-8e17-40bb-9c52-2044d4f92ff0-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f665c3e1-f3da-4fd1-8f4e-10d96c5cd944-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5c124c48-6bf9-4a7c-878f-e927ebee7786-diff.temp
index fa773eb..3480354 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5c124c48-6bf9-4a7c-878f-e927ebee7786-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f665c3e1-f3da-4fd1-8f4e-10d96c5cd944-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/06927b59-c707-4618-9730-ebc69401879f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d57bbe1b-63bf-4a35-84e1-282fc53f4758-diff.temp
index fa773eb..9e7a000 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d57bbe1b-63bf-4a35-84e1-282fc53f4758-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/06927b59-c707-4618-9730-ebc69401879f-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6608e4a7-40fd-4a3f-b7ba-373995ae745a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d89927c8-d868-454e-8082-e9c35a4b80dc-diff.temp
index 0604fbf..3480354 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d89927c8-d868-454e-8082-e9c35a4b80dc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6608e4a7-40fd-4a3f-b7ba-373995ae745a-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1d85f39-5a51-468e-a6be-1759fac33a6d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a86423f9-cbb2-47f5-97fe-2cb3179f52a3-diff.temp
index 0604fbf..9e7a000 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a86423f9-cbb2-47f5-97fe-2cb3179f52a3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1d85f39-5a51-468e-a6be-1759fac33a6d-diff.temp
```
**Diff for ToImmutableDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e1d2a064-14e8-469d-af42-ff62d942692e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3cb437a6-84b2-46d1-90de-85e94cab5c47-diff.temp
index 3480354..9e7a000 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3cb437a6-84b2-46d1-90de-85e94cab5c47-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e1d2a064-14e8-469d-af42-ff62d942692e-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/63a440bc-abe6-4710-82a8-4044d30823a3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/862cc5e0-c3bb-419f-a07b-6ff85230d5e2-diff.temp
index 67218fd..008f948 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/862cc5e0-c3bb-419f-a07b-6ff85230d5e2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/63a440bc-abe6-4710-82a8-4044d30823a3-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da4763c0-8c06-41c0-8bf6-0a062392b2c6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65e2f589-9519-41e5-92ba-53148f31bf0c-diff.temp
index 67218fd..5f9178f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65e2f589-9519-41e5-92ba-53148f31bf0c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da4763c0-8c06-41c0-8bf6-0a062392b2c6-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/05546ef6-9332-4eb8-89aa-447f090f1d14-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39f40283-70dc-4dc4-92e0-34f6562bc670-diff.temp
index 67218fd..564425f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39f40283-70dc-4dc4-92e0-34f6562bc670-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/05546ef6-9332-4eb8-89aa-447f090f1d14-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bd21a122-831c-4ba9-8e6a-e2c79181a7c0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/be500bfc-4d8e-4c52-93eb-974ee2def1a1-diff.temp
index 67218fd..4749aac 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/be500bfc-4d8e-4c52-93eb-974ee2def1a1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bd21a122-831c-4ba9-8e6a-e2c79181a7c0-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/776bc911-c4a7-4e73-ba29-d2a71d0305e5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fb0f06e2-9ecf-4957-bf69-a32932b6b8a4-diff.temp
index 67218fd..2e47271 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fb0f06e2-9ecf-4957-bf69-a32932b6b8a4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/776bc911-c4a7-4e73-ba29-d2a71d0305e5-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6836e7f0-1292-4c97-8480-5c07c36d533f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/64514344-7841-46e1-92da-ee9dd7b77c80-diff.temp
index 67218fd..ddd418e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/64514344-7841-46e1-92da-ee9dd7b77c80-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6836e7f0-1292-4c97-8480-5c07c36d533f-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/723504dd-ee48-46ad-9162-f506f379519e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2580a4ed-87db-4cba-ad9f-262984168195-diff.temp
index 008f948..5f9178f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2580a4ed-87db-4cba-ad9f-262984168195-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/723504dd-ee48-46ad-9162-f506f379519e-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/de2c7183-f151-4899-be25-2fa76fe9e0c4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7405ac6d-775f-4833-b4cc-ac3c261987f1-diff.temp
index 008f948..564425f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7405ac6d-775f-4833-b4cc-ac3c261987f1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/de2c7183-f151-4899-be25-2fa76fe9e0c4-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/182c15a3-fccd-4afb-a9f6-54a1d93abbc3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2725ecf9-da03-4b80-bbb4-cb3e4b5368ca-diff.temp
index 008f948..4749aac 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2725ecf9-da03-4b80-bbb4-cb3e4b5368ca-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/182c15a3-fccd-4afb-a9f6-54a1d93abbc3-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/373209f0-6a01-4e13-b76d-4a66e312a3fb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ca8b1dfc-778f-45d7-b3be-09048a6f507d-diff.temp
index 008f948..2e47271 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ca8b1dfc-778f-45d7-b3be-09048a6f507d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/373209f0-6a01-4e13-b76d-4a66e312a3fb-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1236f652-ff63-4a19-8470-c26401077d26-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1731970-6da6-40c1-a23a-b114104a7358-diff.temp
index 008f948..ddd418e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1731970-6da6-40c1-a23a-b114104a7358-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1236f652-ff63-4a19-8470-c26401077d26-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9606ba86-9e12-4daa-8441-cd442dcff51f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f144a92-2bd2-4a63-b7b0-470db92a63e0-diff.temp
index 5f9178f..564425f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f144a92-2bd2-4a63-b7b0-470db92a63e0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9606ba86-9e12-4daa-8441-cd442dcff51f-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8934a6a-ce11-47b4-b07f-477266ad56d2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ac0d7e11-3729-4eaf-952d-4748c9ed3bfd-diff.temp
index 5f9178f..4749aac 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ac0d7e11-3729-4eaf-952d-4748c9ed3bfd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8934a6a-ce11-47b4-b07f-477266ad56d2-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5ca27e34-9e04-49be-b923-6555aefa9c87-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e9305e8b-f3b2-4b76-87e1-61c5a73d8afd-diff.temp
index 5f9178f..2e47271 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e9305e8b-f3b2-4b76-87e1-61c5a73d8afd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5ca27e34-9e04-49be-b923-6555aefa9c87-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6a6e607e-16cb-46ab-ae62-aee83372961c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/619fb155-5ffe-4e80-9f53-9ac8c4d2b44c-diff.temp
index 5f9178f..ddd418e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/619fb155-5ffe-4e80-9f53-9ac8c4d2b44c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6a6e607e-16cb-46ab-ae62-aee83372961c-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1f5587a7-04a2-4f0d-83db-9fb1fade4510-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/95c75405-1632-4e70-bf9c-38cc0f3f1cdf-diff.temp
index 564425f..4749aac 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/95c75405-1632-4e70-bf9c-38cc0f3f1cdf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1f5587a7-04a2-4f0d-83db-9fb1fade4510-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/679cb058-39f2-4f42-a60a-fcb02771981f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e0ceeab5-db58-4004-b481-6631545b118f-diff.temp
index 564425f..2e47271 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e0ceeab5-db58-4004-b481-6631545b118f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/679cb058-39f2-4f42-a60a-fcb02771981f-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b13fb67f-1a9f-4241-abd5-b998a8b2dd2f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/26e56bd8-963a-4964-a2d0-c8a2df6c6368-diff.temp
index 564425f..ddd418e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/26e56bd8-963a-4964-a2d0-c8a2df6c6368-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b13fb67f-1a9f-4241-abd5-b998a8b2dd2f-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0f0ed876-661b-4694-90da-d8e0ba407d1d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed93737f-8d12-474d-b72b-470f6c09de94-diff.temp
index 4749aac..2e47271 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed93737f-8d12-474d-b72b-470f6c09de94-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0f0ed876-661b-4694-90da-d8e0ba407d1d-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d207e003-4148-4b84-a6b9-b2579db9ad5d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6f4e2635-6ad8-4b78-918f-c09b1dd560ad-diff.temp
index 4749aac..ddd418e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6f4e2635-6ad8-4b78-918f-c09b1dd560ad-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d207e003-4148-4b84-a6b9-b2579db9ad5d-diff.temp
```
**Diff for ToImmutableList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/37d0e59d-c8a8-42b2-be17-ebc3a94f820e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/77f29dce-53fa-403f-bab0-611019168a73-diff.temp
index 2e47271..ddd418e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/77f29dce-53fa-403f-bab0-611019168a73-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/37d0e59d-c8a8-42b2-be17-ebc3a94f820e-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6dd9f01b-44f7-4090-b0c7-22086e2c9ade-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6875867b-0b78-48b2-97c1-00d9d84eb7cd-diff.temp
index 0ebebd8..a92fac8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6875867b-0b78-48b2-97c1-00d9d84eb7cd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6dd9f01b-44f7-4090-b0c7-22086e2c9ade-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff

```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff

```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7025c048-8402-4488-89db-0735f78ef9b6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/745e8699-20f0-4331-ba14-d51117064d95-diff.temp
index 0ebebd8..a92fac8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/745e8699-20f0-4331-ba14-d51117064d95-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7025c048-8402-4488-89db-0735f78ef9b6-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/12d5d9fc-791f-4f16-8741-c79fb89e178b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cbc48f9d-adb6-4daa-b66e-ea913b55c2be-diff.temp
index 0ebebd8..00d133f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cbc48f9d-adb6-4daa-b66e-ea913b55c2be-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/12d5d9fc-791f-4f16-8741-c79fb89e178b-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aeeb32ee-281c-4a3f-85ee-d1ea99f55e50-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1fdd6d57-0934-4ac9-bc64-20afe0419b8e-diff.temp
index 0ebebd8..00d133f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1fdd6d57-0934-4ac9-bc64-20afe0419b8e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aeeb32ee-281c-4a3f-85ee-d1ea99f55e50-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0fcc872c-31e2-4564-a653-495ec0611763-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d3a4c5a-db04-423e-ac53-c36c14b846cd-diff.temp
index a92fac8..0ebebd8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d3a4c5a-db04-423e-ac53-c36c14b846cd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0fcc872c-31e2-4564-a653-495ec0611763-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3d606dd6-7044-4ae0-847c-1871f79306ba-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9231bb75-c096-4ba3-bb39-2942622a8e51-diff.temp
index a92fac8..0ebebd8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9231bb75-c096-4ba3-bb39-2942622a8e51-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3d606dd6-7044-4ae0-847c-1871f79306ba-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff

```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ab8e0857-f9b2-453d-9bc1-cafe4849fe47-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/221cb31a-c5ff-4a19-901a-b70d893b4fcc-diff.temp
index a92fac8..00d133f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/221cb31a-c5ff-4a19-901a-b70d893b4fcc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ab8e0857-f9b2-453d-9bc1-cafe4849fe47-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/63cba6e5-abae-42b9-b60b-333083d602e8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96ce2bae-a6e6-4b5c-806b-7fe1e14c94bd-diff.temp
index a92fac8..00d133f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96ce2bae-a6e6-4b5c-806b-7fe1e14c94bd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/63cba6e5-abae-42b9-b60b-333083d602e8-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff

```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/74602fe5-2abb-46b4-9315-a693081c4e5e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d588a5e7-0919-42ba-89a0-f958ef659f12-diff.temp
index 0ebebd8..a92fac8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d588a5e7-0919-42ba-89a0-f958ef659f12-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/74602fe5-2abb-46b4-9315-a693081c4e5e-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fca8e026-9a47-4ceb-b818-a697b44e6ed2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d9a03e69-d2e8-48a8-bca7-9c8799ed4248-diff.temp
index 0ebebd8..00d133f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d9a03e69-d2e8-48a8-bca7-9c8799ed4248-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fca8e026-9a47-4ceb-b818-a697b44e6ed2-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6d5d3b91-5850-41d8-a3e9-86c62d6e4391-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/688de503-32f0-45c6-8d8b-268089c32fee-diff.temp
index 0ebebd8..00d133f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/688de503-32f0-45c6-8d8b-268089c32fee-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6d5d3b91-5850-41d8-a3e9-86c62d6e4391-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/91508527-6335-445f-b31b-373fad9e42da-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3a1cc3d3-ab73-4e47-9e8a-4c4909d24f9b-diff.temp
index 0ebebd8..a92fac8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3a1cc3d3-ab73-4e47-9e8a-4c4909d24f9b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/91508527-6335-445f-b31b-373fad9e42da-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a76ff584-9405-4b59-8d76-8bd0ca35ef71-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/342b5626-2cff-4225-a80f-82066e28b089-diff.temp
index 0ebebd8..00d133f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/342b5626-2cff-4225-a80f-82066e28b089-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a76ff584-9405-4b59-8d76-8bd0ca35ef71-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/71e9f946-6f15-4da1-8e0f-321959bdc28a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1be02444-8508-4b45-bc07-f2772bd21b88-diff.temp
index 0ebebd8..00d133f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1be02444-8508-4b45-bc07-f2772bd21b88-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/71e9f946-6f15-4da1-8e0f-321959bdc28a-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c1aa9ae0-b130-4ee0-af32-7fa527ccbe23-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0061405b-4017-43d0-a28b-d3d443ebaf52-diff.temp
index a92fac8..00d133f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0061405b-4017-43d0-a28b-d3d443ebaf52-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c1aa9ae0-b130-4ee0-af32-7fa527ccbe23-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7cbff279-4ec4-4bd4-9584-8b66e926cb88-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/351ce2b7-742a-4b76-b724-9c20004b8d6c-diff.temp
index a92fac8..00d133f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/351ce2b7-742a-4b76-b724-9c20004b8d6c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7cbff279-4ec4-4bd4-9584-8b66e926cb88-diff.temp
```
**Diff for Count01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff

```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,28159569338
-       mov       rcx,28FBA49B330
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,28159569330
-       mov       rdx,28FBA49B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,28159569338
-       mov       rcx,28FBA49B330
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b4a1601b-16cb-417a-a19f-4ada30bae7ae-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f7a14c7-8ac3-43e9-bd90-80ec003094c3-diff.temp
index 848d0f7..ef06b6b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f7a14c7-8ac3-43e9-bd90-80ec003094c3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b4a1601b-16cb-417a-a19f-4ada30bae7ae-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,19D8F4A6F28
-       mov       rcx,28FBA49B330
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,19D8F4A6F20
-       mov       rdx,28FBA49B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,19D8F4A6F28
-       mov       rcx,28FBA49B330
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f007a9a-1fd7-4c99-8ed4-e2e7c0242246-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0b2580a9-5a6f-4ca3-92ac-89d682db124e-diff.temp
index 848d0f7..df62fae 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0b2580a9-5a6f-4ca3-92ac-89d682db124e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f007a9a-1fd7-4c99-8ed4-e2e7c0242246-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23CECEC8F20
-       mov       rcx,28FBA49B330
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,23CECEC8F18
-       mov       rdx,28FBA49B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23CECEC8F20
-       mov       rcx,28FBA49B330
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4575d3cb-789b-4d44-8d09-4fa802a74c6c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c3c7801d-cb3f-417e-90a7-8be7fd66d2f4-diff.temp
index 848d0f7..bee4df8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c3c7801d-cb3f-417e-90a7-8be7fd66d2f4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4575d3cb-789b-4d44-8d09-4fa802a74c6c-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,25E8AED6F28
-       mov       rcx,28FBA49B330
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,25E8AED6F20
-       mov       rdx,28FBA49B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,25E8AED6F28
-       mov       rcx,28FBA49B330
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e8cb4cb0-d781-4b57-8566-1f7287871c38-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b2997b69-41d9-4cc5-8267-df7c997beeab-diff.temp
index 848d0f7..996e324 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b2997b69-41d9-4cc5-8267-df7c997beeab-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e8cb4cb0-d781-4b57-8566-1f7287871c38-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2067B089338
-       mov       rcx,28FBA49B330
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,2067B089330
-       mov       rdx,28FBA49B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2067B089338
-       mov       rcx,28FBA49B330
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c0f152b6-9e98-493d-8cb6-a292bb2869ca-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fda81fb3-afd4-400b-b69f-a296934f6bf8-diff.temp
index 848d0f7..0bef595 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fda81fb3-afd4-400b-b69f-a296934f6bf8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c0f152b6-9e98-493d-8cb6-a292bb2869ca-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,19470859338
-       mov       rcx,28FBA49B330
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,19470859330
-       mov       rdx,28FBA49B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,19470859338
-       mov       rcx,28FBA49B330
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e9145742-11d7-41e1-85b6-a9864dda0e22-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4787128f-008e-4ea2-b8cd-184984184ce5-diff.temp
index 848d0f7..58fff56 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4787128f-008e-4ea2-b8cd-184984184ce5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e9145742-11d7-41e1-85b6-a9864dda0e22-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,19D8F4A6F28
-       mov       rcx,28159569338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,19D8F4A6F20
-       mov       rdx,28159569330
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,19D8F4A6F28
-       mov       rcx,28159569338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dcd3796d-977e-4d45-9ca3-350cdc52681f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/db5885c3-34bb-478c-8799-6db5d48b49d3-diff.temp
index ef06b6b..df62fae 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/db5885c3-34bb-478c-8799-6db5d48b49d3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dcd3796d-977e-4d45-9ca3-350cdc52681f-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23CECEC8F20
-       mov       rcx,28159569338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,23CECEC8F18
-       mov       rdx,28159569330
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23CECEC8F20
-       mov       rcx,28159569338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e27210d5-6c63-469d-9b0f-1053d7624d25-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ffbe11e1-7271-4eaf-ab66-03c6ad2c08e5-diff.temp
index ef06b6b..bee4df8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ffbe11e1-7271-4eaf-ab66-03c6ad2c08e5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e27210d5-6c63-469d-9b0f-1053d7624d25-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,25E8AED6F28
-       mov       rcx,28159569338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,25E8AED6F20
-       mov       rdx,28159569330
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,25E8AED6F28
-       mov       rcx,28159569338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d8b73cdc-22fc-49c5-bbca-34613415ca8f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/736f6f04-9ee4-47ee-b7b0-0797350df04d-diff.temp
index ef06b6b..996e324 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/736f6f04-9ee4-47ee-b7b0-0797350df04d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d8b73cdc-22fc-49c5-bbca-34613415ca8f-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2067B089338
-       mov       rcx,28159569338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,2067B089330
-       mov       rdx,28159569330
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2067B089338
-       mov       rcx,28159569338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4c3abd8e-e98f-4cf6-9e6b-ab34f0c63ff3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e3f37f5f-998c-45bd-a892-f12863d9bdc9-diff.temp
index ef06b6b..0bef595 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e3f37f5f-998c-45bd-a892-f12863d9bdc9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4c3abd8e-e98f-4cf6-9e6b-ab34f0c63ff3-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,19470859338
-       mov       rcx,28159569338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,19470859330
-       mov       rdx,28159569330
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,19470859338
-       mov       rcx,28159569338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5ec6ec4d-a1fc-4e10-9915-2b94ca167b6d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6a201c67-27a1-4546-be4c-b4368737459b-diff.temp
index ef06b6b..58fff56 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6a201c67-27a1-4546-be4c-b4368737459b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5ec6ec4d-a1fc-4e10-9915-2b94ca167b6d-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23CECEC8F20
-       mov       rcx,19D8F4A6F28
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,23CECEC8F18
-       mov       rdx,19D8F4A6F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23CECEC8F20
-       mov       rcx,19D8F4A6F28
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5f43f13c-a4a9-49df-ae0e-d0af055ddd7c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f2df2a79-3d09-44c0-b073-2d062c409a8f-diff.temp
index df62fae..bee4df8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f2df2a79-3d09-44c0-b073-2d062c409a8f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5f43f13c-a4a9-49df-ae0e-d0af055ddd7c-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,25E8AED6F28
-       mov       rcx,19D8F4A6F28
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,25E8AED6F20
-       mov       rdx,19D8F4A6F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,25E8AED6F28
-       mov       rcx,19D8F4A6F28
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/79cfa2cc-114a-4559-8e49-09fc8de5979f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c4046c06-64d5-4e71-8cc7-f79972ab55dd-diff.temp
index df62fae..996e324 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c4046c06-64d5-4e71-8cc7-f79972ab55dd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/79cfa2cc-114a-4559-8e49-09fc8de5979f-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2067B089338
-       mov       rcx,19D8F4A6F28
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,2067B089330
-       mov       rdx,19D8F4A6F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2067B089338
-       mov       rcx,19D8F4A6F28
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e84cd165-2a4c-4cb9-b484-61a603bd8a0a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fad25212-fbb8-4d13-8342-da502333dcfe-diff.temp
index df62fae..0bef595 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fad25212-fbb8-4d13-8342-da502333dcfe-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e84cd165-2a4c-4cb9-b484-61a603bd8a0a-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,19470859338
-       mov       rcx,19D8F4A6F28
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,19470859330
-       mov       rdx,19D8F4A6F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,19470859338
-       mov       rcx,19D8F4A6F28
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7b92a0af-7e84-4526-99b0-58a6e5d88e15-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a861eb3e-0dcd-4f75-9e42-ba10840f3ede-diff.temp
index df62fae..58fff56 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a861eb3e-0dcd-4f75-9e42-ba10840f3ede-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7b92a0af-7e84-4526-99b0-58a6e5d88e15-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,25E8AED6F28
-       mov       rcx,23CECEC8F20
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,25E8AED6F20
-       mov       rdx,23CECEC8F18
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,25E8AED6F28
-       mov       rcx,23CECEC8F20
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9e03aa58-4c6c-4065-be17-2abde8926730-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/41dd89e0-0960-439c-b8bd-aed50886e64e-diff.temp
index bee4df8..996e324 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/41dd89e0-0960-439c-b8bd-aed50886e64e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9e03aa58-4c6c-4065-be17-2abde8926730-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2067B089338
-       mov       rcx,23CECEC8F20
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,2067B089330
-       mov       rdx,23CECEC8F18
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2067B089338
-       mov       rcx,23CECEC8F20
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d027e837-5341-4c62-98aa-ae53ca22abcb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a580dd97-d2c9-4412-bef1-7eb8b1444bb3-diff.temp
index bee4df8..0bef595 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a580dd97-d2c9-4412-bef1-7eb8b1444bb3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d027e837-5341-4c62-98aa-ae53ca22abcb-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,19470859338
-       mov       rcx,23CECEC8F20
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,19470859330
-       mov       rdx,23CECEC8F18
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,19470859338
-       mov       rcx,23CECEC8F20
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/69f3b9ec-ba18-40e0-91f4-4d622cd01993-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ed90dff-81c5-4319-a950-903402da3def-diff.temp
index bee4df8..58fff56 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ed90dff-81c5-4319-a950-903402da3def-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/69f3b9ec-ba18-40e0-91f4-4d622cd01993-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2067B089338
-       mov       rcx,25E8AED6F28
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,2067B089330
-       mov       rdx,25E8AED6F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2067B089338
-       mov       rcx,25E8AED6F28
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/45a91079-5616-4ee2-9373-f1d5061dc627-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8a2a7bc-729e-452f-8dbd-c40f72f30f7b-diff.temp
index 996e324..0bef595 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8a2a7bc-729e-452f-8dbd-c40f72f30f7b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/45a91079-5616-4ee2-9373-f1d5061dc627-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,19470859338
-       mov       rcx,25E8AED6F28
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,19470859330
-       mov       rdx,25E8AED6F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,19470859338
-       mov       rcx,25E8AED6F28
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c719508e-ed30-498d-a877-5bbccb95e1fe-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5a2b7c07-1f08-47e4-ab7d-0e3e3715e414-diff.temp
index 996e324..58fff56 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5a2b7c07-1f08-47e4-ab7d-0e3e3715e414-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c719508e-ed30-498d-a877-5bbccb95e1fe-diff.temp
```
**Diff for FastAny01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,19470859338
-       mov       rcx,2067B089338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,19470859330
-       mov       rdx,2067B089330
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,19470859338
-       mov       rcx,2067B089338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastAny(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3d336e80-20d3-4ce7-8ccf-0010f2c982ce-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e0e1f3e8-6705-4fb8-afb6-149e695d9d23-diff.temp
index 0bef595..58fff56 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e0e1f3e8-6705-4fb8-afb6-149e695d9d23-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3d336e80-20d3-4ce7-8ccf-0010f2c982ce-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2457F0
-       mov       rdx,7FF9EA225370
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245328
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245328
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,24647221240
-       mov       rdx,1B98C421240
        mov       r8,[r8]
+       mov       r8,24667223020
-       mov       r8,1B9AC423020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,24647221248
-       mov       rdx,1B98C421248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2466722B338
-       mov       rcx,1B9AC42B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,2466722B328
-       mov       rdx,1B9AC42B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2466722B338
-       mov       rcx,1B9AC42B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/059cff43-ee0a-4784-8f42-f3b71d413b30-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/72942754-e10a-4eb2-a7a4-09194ef800b1-diff.temp
index 9335639..cba1090 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/72942754-e10a-4eb2-a7a4-09194ef800b1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/059cff43-ee0a-4784-8f42-f3b71d413b30-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2157F0
-       mov       rdx,7FF9EA225370
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215328
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215328
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1B33FB31240
-       mov       rdx,1B98C421240
        mov       r8,[r8]
+       mov       r8,1B35FB33020
-       mov       r8,1B9AC423020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,1B33FB31248
-       mov       rdx,1B98C421248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1B35FB3B338
-       mov       rcx,1B9AC42B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1B35FB3B328
-       mov       rdx,1B9AC42B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1B35FB3B338
-       mov       rcx,1B9AC42B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/79995a4f-de23-436c-aac0-5e5ed053d816-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/50ac9d0b-8eae-463c-8861-91bfd65f68f5-diff.temp
index 9335639..6992359 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/50ac9d0b-8eae-463c-8861-91bfd65f68f5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/79995a4f-de23-436c-aac0-5e5ed053d816-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215A90
-       mov       rdx,7FF9EA225370
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1D2472D1240
-       mov       rdx,1B98C421240
        mov       r8,[r8]
+       mov       r8,1D2672D3020
-       mov       r8,1B9AC423020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,1D2472D1248
-       mov       rdx,1B98C421248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1D2672DB338
-       mov       rcx,1B9AC42B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1D2672DB328
-       mov       rdx,1B9AC42B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1D2672DB338
-       mov       rcx,1B9AC42B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7aad1b2a-2b76-459f-b7a9-20752e606089-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bf745cfc-ca66-4789-befd-d0255d654a43-diff.temp
index 9335639..0fe0e10 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bf745cfc-ca66-4789-befd-d0255d654a43-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7aad1b2a-2b76-459f-b7a9-20752e606089-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2157F0
-       mov       rdx,7FF9EA225370
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215328
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215328
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1B405A23238
-       mov       rdx,1B98C421240
        mov       r8,[r8]
+       mov       r8,1B425A21028
-       mov       r8,1B9AC423020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,1B405A23240
-       mov       rdx,1B98C421248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1B435A26F30
-       mov       rcx,1B9AC42B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1B435A26F20
-       mov       rdx,1B9AC42B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1B435A26F30
-       mov       rcx,1B9AC42B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cb5d86ef-9af9-44fc-ac73-62b7409d952a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f6e8def0-8fe7-4457-b189-ddac3e0b62d7-diff.temp
index 9335639..3fb3df2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f6e8def0-8fe7-4457-b189-ddac3e0b62d7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cb5d86ef-9af9-44fc-ac73-62b7409d952a-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205890
-       mov       rdx,7FF9EA225370
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2053C8
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2053C8
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2669540F1A8
-       mov       rdx,1B98C421240
        mov       r8,[r8]
+       mov       r8,26675403020
-       mov       r8,1B9AC423020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,2669540F1B0
-       mov       rdx,1B98C421248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,26695408F28
-       mov       rcx,1B9AC42B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,26695408F18
-       mov       rdx,1B9AC42B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,26695408F28
-       mov       rcx,1B9AC42B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b10cfacd-5c79-42fb-a9d6-b5ad80750059-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a79b0781-ce8b-4a18-a213-1321aa7ca1ac-diff.temp
index 9335639..3173e82 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a79b0781-ce8b-4a18-a213-1321aa7ca1ac-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b10cfacd-5c79-42fb-a9d6-b5ad80750059-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215A90
-       mov       rdx,7FF9EA225370
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA224EA8
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,22438941240
-       mov       rdx,1B98C421240
        mov       r8,[r8]
+       mov       r8,22428943020
-       mov       r8,1B9AC423020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,22438941248
-       mov       rdx,1B98C421248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,22448948F28
-       mov       rcx,1B9AC42B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,22448948F18
-       mov       rdx,1B9AC42B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,22448948F28
-       mov       rcx,1B9AC42B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d9123d00-b541-4b1e-b28c-8d39a1d390fb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2c18d8e5-fa58-45e0-8d6c-1132f3e7b8ed-diff.temp
index 9335639..402c00f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2c18d8e5-fa58-45e0-8d6c-1132f3e7b8ed-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d9123d00-b541-4b1e-b28c-8d39a1d390fb-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2157F0
-       mov       rdx,7FF9EA2457F0
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215328
-       mov       rdx,7FF9EA245328
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215328
-       mov       rdx,7FF9EA245328
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1B33FB31240
-       mov       rdx,24647221240
        mov       r8,[r8]
+       mov       r8,1B35FB33020
-       mov       r8,24667223020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,1B33FB31248
-       mov       rdx,24647221248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1B35FB3B338
-       mov       rcx,2466722B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1B35FB3B328
-       mov       rdx,2466722B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1B35FB3B338
-       mov       rcx,2466722B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e2203ffe-b233-4aa4-9fd8-fb7f567b27c9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/795c2845-15a2-4186-a07a-f3abd7131496-diff.temp
index cba1090..6992359 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/795c2845-15a2-4186-a07a-f3abd7131496-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e2203ffe-b233-4aa4-9fd8-fb7f567b27c9-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215A90
-       mov       rdx,7FF9EA2457F0
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA245328
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA245328
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1D2472D1240
-       mov       rdx,24647221240
        mov       r8,[r8]
+       mov       r8,1D2672D3020
-       mov       r8,24667223020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,1D2472D1248
-       mov       rdx,24647221248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1D2672DB338
-       mov       rcx,2466722B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1D2672DB328
-       mov       rdx,2466722B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1D2672DB338
-       mov       rcx,2466722B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bde96918-b2dc-4388-beae-54a91d96927f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/34c11665-c697-429e-b44f-be84677dc8c0-diff.temp
index cba1090..0fe0e10 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/34c11665-c697-429e-b44f-be84677dc8c0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bde96918-b2dc-4388-beae-54a91d96927f-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2157F0
-       mov       rdx,7FF9EA2457F0
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215328
-       mov       rdx,7FF9EA245328
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215328
-       mov       rdx,7FF9EA245328
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1B405A23238
-       mov       rdx,24647221240
        mov       r8,[r8]
+       mov       r8,1B425A21028
-       mov       r8,24667223020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,1B405A23240
-       mov       rdx,24647221248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1B435A26F30
-       mov       rcx,2466722B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1B435A26F20
-       mov       rdx,2466722B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1B435A26F30
-       mov       rcx,2466722B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/37aaae6e-08c3-49e9-9196-2cacec72018a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0304beef-411f-406f-aa3c-8421e4a55ea6-diff.temp
index cba1090..3fb3df2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0304beef-411f-406f-aa3c-8421e4a55ea6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/37aaae6e-08c3-49e9-9196-2cacec72018a-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205890
-       mov       rdx,7FF9EA2457F0
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2053C8
-       mov       rdx,7FF9EA245328
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2053C8
-       mov       rdx,7FF9EA245328
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2669540F1A8
-       mov       rdx,24647221240
        mov       r8,[r8]
+       mov       r8,26675403020
-       mov       r8,24667223020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,2669540F1B0
-       mov       rdx,24647221248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,26695408F28
-       mov       rcx,2466722B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,26695408F18
-       mov       rdx,2466722B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,26695408F28
-       mov       rcx,2466722B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a4fd4e9c-45d7-43ec-a8a0-e519c946c4c6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/341262eb-2119-49bd-b34f-433ca3684578-diff.temp
index cba1090..3173e82 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/341262eb-2119-49bd-b34f-433ca3684578-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a4fd4e9c-45d7-43ec-a8a0-e519c946c4c6-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215A90
-       mov       rdx,7FF9EA2457F0
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA245328
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA245328
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,22438941240
-       mov       rdx,24647221240
        mov       r8,[r8]
+       mov       r8,22428943020
-       mov       r8,24667223020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,22438941248
-       mov       rdx,24647221248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,22448948F28
-       mov       rcx,2466722B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,22448948F18
-       mov       rdx,2466722B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,22448948F28
-       mov       rcx,2466722B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5d7b0448-81a2-4306-b682-4ed0019ce688-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/70317443-2546-47cb-84f4-565981abd761-diff.temp
index cba1090..402c00f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/70317443-2546-47cb-84f4-565981abd761-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5d7b0448-81a2-4306-b682-4ed0019ce688-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215A90
-       mov       rdx,7FF9EA2157F0
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA215328
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA215328
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1D2472D1240
-       mov       rdx,1B33FB31240
        mov       r8,[r8]
+       mov       r8,1D2672D3020
-       mov       r8,1B35FB33020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,1D2472D1248
-       mov       rdx,1B33FB31248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1D2672DB338
-       mov       rcx,1B35FB3B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1D2672DB328
-       mov       rdx,1B35FB3B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1D2672DB338
-       mov       rcx,1B35FB3B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c25ffe7a-a8cc-4fb7-8adf-1477fe02da27-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2bf0ff8a-717b-488d-900a-cc1c86e8af22-diff.temp
index 6992359..0fe0e10 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2bf0ff8a-717b-488d-900a-cc1c86e8af22-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c25ffe7a-a8cc-4fb7-8adf-1477fe02da27-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1B435A26F30
-       mov       rcx,1B35FB3B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1B435A26F20
-       mov       rdx,1B35FB3B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1B435A26F30
-       mov       rcx,1B35FB3B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/71fc5188-4077-4273-918b-89e08908cb74-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4a2a0a0f-3160-4358-b241-e9e82b94c15b-diff.temp
index 6992359..3fb3df2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4a2a0a0f-3160-4358-b241-e9e82b94c15b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/71fc5188-4077-4273-918b-89e08908cb74-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205890
-       mov       rdx,7FF9EA2157F0
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2053C8
-       mov       rdx,7FF9EA215328
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2053C8
-       mov       rdx,7FF9EA215328
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2669540F1A8
-       mov       rdx,1B33FB31240
        mov       r8,[r8]
+       mov       r8,26675403020
-       mov       r8,1B35FB33020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,2669540F1B0
-       mov       rdx,1B33FB31248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,26695408F28
-       mov       rcx,1B35FB3B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,26695408F18
-       mov       rdx,1B35FB3B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,26695408F28
-       mov       rcx,1B35FB3B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/05eb691d-02cb-47ee-91f4-5f1c30f09bd3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/53c41000-69ce-40a0-bdb3-a6a9bae80158-diff.temp
index 6992359..3173e82 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/53c41000-69ce-40a0-bdb3-a6a9bae80158-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/05eb691d-02cb-47ee-91f4-5f1c30f09bd3-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215A90
-       mov       rdx,7FF9EA2157F0
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA215328
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA215328
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,22438941240
-       mov       rdx,1B33FB31240
        mov       r8,[r8]
+       mov       r8,22428943020
-       mov       r8,1B35FB33020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,22438941248
-       mov       rdx,1B33FB31248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,22448948F28
-       mov       rcx,1B35FB3B338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,22448948F18
-       mov       rdx,1B35FB3B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,22448948F28
-       mov       rcx,1B35FB3B338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/01be678f-3adc-4990-8135-6e9a5d982f41-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b352ddc6-89e9-4cc5-b6f3-32890f858929-diff.temp
index 6992359..402c00f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b352ddc6-89e9-4cc5-b6f3-32890f858929-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/01be678f-3adc-4990-8135-6e9a5d982f41-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2157F0
-       mov       rdx,7FF9EA215A90
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215328
-       mov       rdx,7FF9EA2155C8
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215328
-       mov       rdx,7FF9EA2155C8
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1B405A23238
-       mov       rdx,1D2472D1240
        mov       r8,[r8]
+       mov       r8,1B425A21028
-       mov       r8,1D2672D3020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,1B405A23240
-       mov       rdx,1D2472D1248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1B435A26F30
-       mov       rcx,1D2672DB338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1B435A26F20
-       mov       rdx,1D2672DB328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1B435A26F30
-       mov       rcx,1D2672DB338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6b183a6e-481e-4fe9-85bf-433d0c596cb1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96632e3d-1709-4fd5-8d1a-43f3224aec9f-diff.temp
index 0fe0e10..3fb3df2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96632e3d-1709-4fd5-8d1a-43f3224aec9f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6b183a6e-481e-4fe9-85bf-433d0c596cb1-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205890
-       mov       rdx,7FF9EA215A90
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2053C8
-       mov       rdx,7FF9EA2155C8
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2053C8
-       mov       rdx,7FF9EA2155C8
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2669540F1A8
-       mov       rdx,1D2472D1240
        mov       r8,[r8]
+       mov       r8,26675403020
-       mov       r8,1D2672D3020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,2669540F1B0
-       mov       rdx,1D2472D1248
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,26695408F28
-       mov       rcx,1D2672DB338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,26695408F18
-       mov       rdx,1D2672DB328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,26695408F28
-       mov       rcx,1D2672DB338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dc20cb0a-0610-4cee-8546-f41f94967eb8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/44a1baf5-e056-467e-80cd-e7089052431d-diff.temp
index 0fe0e10..3173e82 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/44a1baf5-e056-467e-80cd-e7089052431d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dc20cb0a-0610-4cee-8546-f41f94967eb8-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,22448948F28
-       mov       rcx,1D2672DB338
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,22448948F18
-       mov       rdx,1D2672DB328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,22448948F28
-       mov       rcx,1D2672DB338
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0126fb91-f97a-45ca-a84c-a4bde9f9c659-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65274040-26dc-4622-8b01-f75669c018a0-diff.temp
index 0fe0e10..402c00f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65274040-26dc-4622-8b01-f75669c018a0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0126fb91-f97a-45ca-a84c-a4bde9f9c659-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205890
-       mov       rdx,7FF9EA2157F0
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2053C8
-       mov       rdx,7FF9EA215328
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2053C8
-       mov       rdx,7FF9EA215328
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2669540F1A8
-       mov       rdx,1B405A23238
        mov       r8,[r8]
+       mov       r8,26675403020
-       mov       r8,1B425A21028
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,2669540F1B0
-       mov       rdx,1B405A23240
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,26695408F28
-       mov       rcx,1B435A26F30
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,26695408F18
-       mov       rdx,1B435A26F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,26695408F28
-       mov       rcx,1B435A26F30
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8a0a4d32-104f-430c-bd84-2818cae54c4f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7369467e-ba73-42bc-b43a-da21e84dbd36-diff.temp
index 3fb3df2..3173e82 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7369467e-ba73-42bc-b43a-da21e84dbd36-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8a0a4d32-104f-430c-bd84-2818cae54c4f-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215A90
-       mov       rdx,7FF9EA2157F0
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA215328
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA215328
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,22438941240
-       mov       rdx,1B405A23238
        mov       r8,[r8]
+       mov       r8,22428943020
-       mov       r8,1B425A21028
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,22438941248
-       mov       rdx,1B405A23240
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,22448948F28
-       mov       rcx,1B435A26F30
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,22448948F18
-       mov       rdx,1B435A26F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,22448948F28
-       mov       rcx,1B435A26F30
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/316bade8-1d72-4c1c-ada5-174ed13bb917-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/506ff488-7056-4e96-a6d9-d38ab035c744-diff.temp
index 3fb3df2..402c00f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/506ff488-7056-4e96-a6d9-d38ab035c744-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/316bade8-1d72-4c1c-ada5-174ed13bb917-diff.temp
```
**Diff for FastCount01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L06:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215A90
-       mov       rdx,7FF9EA205890
        mov       rcx,rsi
 M02_L05:
        jmp       short M02_L06
        je        short M02_L05
        test      rcx,rcx
        mov       rcx,[rbp+18]
        mov       rdi,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
        mov       rcx,r14
 M02_L04:
        mov       r14,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA2053C8
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r14,r14
        je        short M02_L07
        test      rax,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rdi
 M02_L02:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2155C8
-       mov       rdx,7FF9EA2053C8
        mov       rcx,rsi
 M02_L01:
        jmp       short M02_L02
        mov       rcx,r14
        je        short M02_L01
        test      r14,r14
        mov       r14,[rbp+10]
        mov       rbp,[rsi+10]
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        xor       eax,eax
        je        short M02_L00
        test      eax,eax
        movzx     eax,al
        sete      al
        test      rdi,rdi
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,22438941240
-       mov       rdx,2669540F1A8
        mov       r8,[r8]
+       mov       r8,22428943020
-       mov       r8,26675403020
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 84
        int       3
        call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
        mov       ecx,7
 M01_L00:
        ret
        add       rsp,28
        movzx     eax,al
        setge     al
        test      eax,eax
        call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
        mov       r9d,1
        mov       edx,r9d
        mov       rcx,rdx
        add       r8,0C
        cmp       [r8],r8d
        mov       r9d,[rcx+8]
        lea       rdx,[rcx+0C]
        je        short M01_L00
        test      r8,r8
        mov       r8,[rdx]
+       mov       rdx,22438941248
-       mov       rdx,2669540F1B0
        cmp       [rcx],ecx
        mov       rcx,[rdx+20]
        sub       rsp,28
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 154
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M00_L01:
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+40],eax
        mov       rdx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,22448948F28
-       mov       rcx,26695408F28
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,22448948F18
-       mov       rdx,26695408F18
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,22448948F28
-       mov       rcx,26695408F28
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.FastCount(p => p.City.Contains("A"));
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1d51da15-23b1-4b82-8292-99467f3ab8c3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0dd840ab-4b44-467c-9cc2-985763cf7c47-diff.temp
index 3173e82..402c00f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0dd840ab-4b44-467c-9cc2-985763cf7c47-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1d51da15-23b1-4b82-8292-99467f3ab8c3-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/56a0368f-22a2-456d-987c-d4e4097db42f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/588792c2-80a8-46eb-8302-c7bd62682c3d-diff.temp
index 26efeb8..7742a2f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/588792c2-80a8-46eb-8302-c7bd62682c3d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/56a0368f-22a2-456d-987c-d4e4097db42f-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e70136ba-702f-44f2-ae7e-db2483376b0e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d9fb07c8-e1b8-4354-9915-982b9015886f-diff.temp
index 26efeb8..7c57d4c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d9fb07c8-e1b8-4354-9915-982b9015886f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e70136ba-702f-44f2-ae7e-db2483376b0e-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2d887451-4fef-4e24-80f1-94d5476af7b0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/77eeadc7-41bd-4670-b054-037a43a1503b-diff.temp
index 26efeb8..ea0df1d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/77eeadc7-41bd-4670-b054-037a43a1503b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2d887451-4fef-4e24-80f1-94d5476af7b0-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f1ef89b-a5d1-4232-81fb-a6332845bef2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/06aecb96-d92e-4220-9c26-181039bdb9dd-diff.temp
index 26efeb8..4447667 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/06aecb96-d92e-4220-9c26-181039bdb9dd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f1ef89b-a5d1-4232-81fb-a6332845bef2-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c26d0ed7-82a7-4c52-b5d8-618d7d482594-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cba154f8-5914-4c2e-921a-39cd78acad97-diff.temp
index 26efeb8..0082658 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cba154f8-5914-4c2e-921a-39cd78acad97-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c26d0ed7-82a7-4c52-b5d8-618d7d482594-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/30e27177-e32b-4cc3-8255-38bb54e061cc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7cbe367c-30b9-4e71-84f0-fef913dc696e-diff.temp
index 26efeb8..bd478b3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7cbe367c-30b9-4e71-84f0-fef913dc696e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/30e27177-e32b-4cc3-8255-38bb54e061cc-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1122b664-ca42-4151-8133-f7119e6cdb59-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a80cef25-c7e7-44c2-bddb-3ae0e73872dd-diff.temp
index 7742a2f..7c57d4c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a80cef25-c7e7-44c2-bddb-3ae0e73872dd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1122b664-ca42-4151-8133-f7119e6cdb59-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3b90220c-410f-492d-b14e-fc6022b92766-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/27ff6e5c-c8a7-4ab6-bdfa-7df6b4b5dbcb-diff.temp
index 7742a2f..ea0df1d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/27ff6e5c-c8a7-4ab6-bdfa-7df6b4b5dbcb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3b90220c-410f-492d-b14e-fc6022b92766-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cdef7f0a-8645-425a-8060-00803e8d20c8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ec97a6dc-a2be-4ff2-9e61-7fa702487eec-diff.temp
index 7742a2f..4447667 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ec97a6dc-a2be-4ff2-9e61-7fa702487eec-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cdef7f0a-8645-425a-8060-00803e8d20c8-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7be49691-3047-41ce-a2e3-d154de7a0e06-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3dcd3041-cfa9-48f7-987b-923885922398-diff.temp
index 7742a2f..0082658 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3dcd3041-cfa9-48f7-987b-923885922398-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7be49691-3047-41ce-a2e3-d154de7a0e06-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7cd8e978-b4c0-4f4e-b259-5ad571ea6cab-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a4e0d9d5-517e-4244-b1c3-ec0e06552b8b-diff.temp
index 7742a2f..bd478b3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a4e0d9d5-517e-4244-b1c3-ec0e06552b8b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7cd8e978-b4c0-4f4e-b259-5ad571ea6cab-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3be01e85-efe1-459f-ac4f-948642dabdc3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/93dd1154-9955-44c3-b039-d32d2c0ba1b5-diff.temp
index 7c57d4c..ea0df1d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/93dd1154-9955-44c3-b039-d32d2c0ba1b5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3be01e85-efe1-459f-ac4f-948642dabdc3-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/80b728ce-4ad8-4fb6-8fcc-fa4fa93f1e23-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9166c922-88b6-4f75-a4ce-f13f24c8c81e-diff.temp
index 7c57d4c..4447667 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9166c922-88b6-4f75-a4ce-f13f24c8c81e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/80b728ce-4ad8-4fb6-8fcc-fa4fa93f1e23-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc218773-7828-4528-bf15-78ef1873f0a8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a3a9fe13-b4f7-40f9-ba1a-5ee0d2a01c8a-diff.temp
index 7c57d4c..0082658 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a3a9fe13-b4f7-40f9-ba1a-5ee0d2a01c8a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc218773-7828-4528-bf15-78ef1873f0a8-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/07006050-a4a0-41e4-9360-99c2afc94d8d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5b650a46-328e-43ca-9753-ad4caead0bff-diff.temp
index 7c57d4c..bd478b3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5b650a46-328e-43ca-9753-ad4caead0bff-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/07006050-a4a0-41e4-9360-99c2afc94d8d-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3dad993f-7712-4666-95b8-c9c2f25105d6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3c5af658-6123-43eb-9d08-cabbbbbea1ff-diff.temp
index ea0df1d..4447667 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3c5af658-6123-43eb-9d08-cabbbbbea1ff-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3dad993f-7712-4666-95b8-c9c2f25105d6-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d3e45b1-3044-4ce5-b2bb-a7f38cde1140-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c2a1072b-2531-434f-bb29-332c69977487-diff.temp
index ea0df1d..0082658 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c2a1072b-2531-434f-bb29-332c69977487-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d3e45b1-3044-4ce5-b2bb-a7f38cde1140-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7955f5aa-aecb-4841-b9b9-883b2394b7d5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/27d4710d-6bff-4f97-9fa5-d7d593689dea-diff.temp
index ea0df1d..bd478b3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/27d4710d-6bff-4f97-9fa5-d7d593689dea-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7955f5aa-aecb-4841-b9b9-883b2394b7d5-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b0101069-fcf4-429e-ae49-53919f6b918c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/07b87a48-cde2-414d-ae3f-b29d7578fd3e-diff.temp
index 4447667..0082658 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/07b87a48-cde2-414d-ae3f-b29d7578fd3e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b0101069-fcf4-429e-ae49-53919f6b918c-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6f30f97e-1735-4130-8d42-a72b5c6bd8e6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/36765f2e-46e7-4a64-a3e2-b1f0b4fbf14d-diff.temp
index 4447667..bd478b3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/36765f2e-46e7-4a64-a3e2-b1f0b4fbf14d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6f30f97e-1735-4130-8d42-a72b5c6bd8e6-diff.temp
```
**Diff for FirstOrNull01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d0d98f22-1388-4568-bc99-f37e70a1eb0a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d92ab905-1a9e-4436-a00e-b955f7ba4095-diff.temp
index 0082658..bd478b3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d92ab905-1a9e-4436-a00e-b955f7ba4095-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d0d98f22-1388-4568-bc99-f37e70a1eb0a-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215378
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
        call      qword ptr [7FF9EA100658]
        mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2152A0
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2152A0
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b6396acc-a723-48b7-9d74-b80f4c3901a7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fb1e2ebf-41a8-4214-b7b2-d95f415ed1e8-diff.temp
index a5c14cb..ebb68cb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fb1e2ebf-41a8-4214-b7b2-d95f415ed1e8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b6396acc-a723-48b7-9d74-b80f4c3901a7-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA120668]
+       mov       r11,7FF9E9D10668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235378
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235378
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120658]
+       mov       r11,7FF9E9D10658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352A0
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352A0
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/883fd439-887a-49f5-9d70-9e1d52dda19d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9e84f6ae-da80-4511-9d9e-3401d0aac7e4-diff.temp
index a5c14cb..d4e3f26 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9e84f6ae-da80-4511-9d9e-3401d0aac7e4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/883fd439-887a-49f5-9d70-9e1d52dda19d-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA110668]
+       mov       r11,7FF9E9D00668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA110650]
+       mov       r11,7FF9E9D00650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA110658]
+       mov       r11,7FF9E9D00658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/43c98949-8230-42b5-ad6c-0e979384790a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/644ce8fc-29fb-4478-8ed5-c6a87cc721be-diff.temp
index a5c14cb..acc6c7b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/644ce8fc-29fb-4478-8ed5-c6a87cc721be-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/43c98949-8230-42b5-ad6c-0e979384790a-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA120668]
+       mov       r11,7FF9E9D10668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235448
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235448
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120658]
+       mov       r11,7FF9E9D10658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235370
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235370
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f21093ee-7a98-4e2c-89da-575d3e6e0ebc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e15c73e7-0728-4b02-bfb8-8699512127c1-diff.temp
index a5c14cb..ab55d8b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e15c73e7-0728-4b02-bfb8-8699512127c1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f21093ee-7a98-4e2c-89da-575d3e6e0ebc-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA110668]
+       mov       r11,7FF9E9D00668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA110650]
+       mov       r11,7FF9E9D00650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA110658]
+       mov       r11,7FF9E9D00658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d589d92a-6c60-4017-b20e-a3b0d0dfcf7e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d472281c-65a6-4d77-a62b-f6f287ca5dca-diff.temp
index a5c14cb..acc6c7b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d472281c-65a6-4d77-a62b-f6f287ca5dca-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d589d92a-6c60-4017-b20e-a3b0d0dfcf7e-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA120668]
+       mov       r11,7FF9E9D10668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2353A8
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2353A8
-       mov       rdx,7FF9EA214F80
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120658]
+       mov       r11,7FF9E9D10658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA214EA8
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5d944cbb-56de-4c16-b529-4b8d20a2a1a4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eb885ebf-97c3-485d-ab27-6789c921796b-diff.temp
index a5c14cb..9cce687 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eb885ebf-97c3-485d-ab27-6789c921796b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5d944cbb-56de-4c16-b529-4b8d20a2a1a4-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA120668]
+       mov       r11,7FF9E9D10668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235378
-       mov       rdx,7FF9EA215378
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235378
-       mov       rdx,7FF9EA215378
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120658]
+       mov       r11,7FF9E9D10658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352A0
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352A0
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a7b59fe9-ae9b-4fa4-8124-aacdeb66884e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20d651ef-f9f1-4674-be5c-a9d5343b38df-diff.temp
index ebb68cb..d4e3f26 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20d651ef-f9f1-4674-be5c-a9d5343b38df-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a7b59fe9-ae9b-4fa4-8124-aacdeb66884e-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA110668]
+       mov       r11,7FF9E9D00668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA110650]
+       mov       r11,7FF9E9D00650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA215378
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA215378
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA110658]
+       mov       r11,7FF9E9D00658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6785d740-2936-4b74-bbe1-49796f9f9ab1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a65eef5b-cb3a-4e0d-8344-f204f50c28fa-diff.temp
index ebb68cb..acc6c7b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a65eef5b-cb3a-4e0d-8344-f204f50c28fa-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6785d740-2936-4b74-bbe1-49796f9f9ab1-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA120668]
+       mov       r11,7FF9E9D10668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235448
-       mov       rdx,7FF9EA215378
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235448
-       mov       rdx,7FF9EA215378
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120658]
+       mov       r11,7FF9E9D10658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235370
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235370
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c18f5d3e-d0f0-4be8-b159-d6e04cff0e45-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e714b2b-ad04-4cf8-80fc-c6740edb6acc-diff.temp
index ebb68cb..ab55d8b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e714b2b-ad04-4cf8-80fc-c6740edb6acc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c18f5d3e-d0f0-4be8-b159-d6e04cff0e45-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA110668]
+       mov       r11,7FF9E9D00668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA110650]
+       mov       r11,7FF9E9D00650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA215378
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA215378
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA110658]
+       mov       r11,7FF9E9D00658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d7d20992-e0cb-49de-a2c6-a384a4d58fae-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2db7570c-e568-45b1-b3c0-fe1a769ccb67-diff.temp
index ebb68cb..acc6c7b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2db7570c-e568-45b1-b3c0-fe1a769ccb67-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d7d20992-e0cb-49de-a2c6-a384a4d58fae-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA120668]
+       mov       r11,7FF9E9D10668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2353A8
-       mov       rdx,7FF9EA215378
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2353A8
-       mov       rdx,7FF9EA215378
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120658]
+       mov       r11,7FF9E9D10658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e68d23e-04b9-42e2-a19b-21381ff1f8a7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1eb147d8-0cd7-4005-81a8-2c9129ed8d83-diff.temp
index ebb68cb..9cce687 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1eb147d8-0cd7-4005-81a8-2c9129ed8d83-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e68d23e-04b9-42e2-a19b-21381ff1f8a7-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA110668]
+       mov       r11,7FF9E9D00668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA110650]
+       mov       r11,7FF9E9D00650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA235378
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA235378
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA110658]
+       mov       r11,7FF9E9D00658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d1f22145-bc43-471e-bc87-6285119fc69b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/049ff040-90b0-43d5-b27f-4a96fb05cbb9-diff.temp
index d4e3f26..acc6c7b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/049ff040-90b0-43d5-b27f-4a96fb05cbb9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d1f22145-bc43-471e-bc87-6285119fc69b-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235448
-       mov       rdx,7FF9EA235378
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
        call      qword ptr [7FF9EA120658]
        mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFD0]
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235370
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235370
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39e98da1-a3b3-46a7-9b96-d06dc92a553f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/12e98077-d735-46b9-a4af-57a4bbf04c29-diff.temp
index d4e3f26..ab55d8b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/12e98077-d735-46b9-a4af-57a4bbf04c29-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39e98da1-a3b3-46a7-9b96-d06dc92a553f-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA110668]
+       mov       r11,7FF9E9D00668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA110650]
+       mov       r11,7FF9E9D00650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA235378
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA235378
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA110658]
+       mov       r11,7FF9E9D00658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83a5b90c-8e4b-4b31-abd2-08f0702cdc55-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/82fe8dbe-6d7c-4018-b7ae-75a45fa1d237-diff.temp
index d4e3f26..acc6c7b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/82fe8dbe-6d7c-4018-b7ae-75a45fa1d237-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83a5b90c-8e4b-4b31-abd2-08f0702cdc55-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2353A8
-       mov       rdx,7FF9EA235378
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
        call      qword ptr [7FF9EA120658]
        mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFD0]
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5de43eeb-2abd-4f2a-9761-e0eb4b3e3e61-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fdb68805-d9a7-4893-90f3-54ac3fc3b859-diff.temp
index d4e3f26..9cce687 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fdb68805-d9a7-4893-90f3-54ac3fc3b859-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5de43eeb-2abd-4f2a-9761-e0eb4b3e3e61-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA120668]
+       mov       r11,7FF9E9D10668
-       call      qword ptr [7FF9EA110668]
-       mov       r11,7FF9E9D00668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235448
-       mov       rdx,7FF9EA225618
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235448
-       mov       rdx,7FF9EA225618
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120658]
+       mov       r11,7FF9E9D10658
-       call      qword ptr [7FF9EA110658]
-       mov       r11,7FF9E9D00658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235370
-       mov       rdx,7FF9EA225540
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235370
-       mov       rdx,7FF9EA225540
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/66577571-b7c8-4676-b83c-d682d6ae31af-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/486915dc-3194-4c55-bf1a-66da711743ac-diff.temp
index acc6c7b..ab55d8b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/486915dc-3194-4c55-bf1a-66da711743ac-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/66577571-b7c8-4676-b83c-d682d6ae31af-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff

```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA120668]
+       mov       r11,7FF9E9D10668
-       call      qword ptr [7FF9EA110668]
-       mov       r11,7FF9E9D00668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2353A8
-       mov       rdx,7FF9EA225618
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2353A8
-       mov       rdx,7FF9EA225618
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120658]
+       mov       r11,7FF9E9D10658
-       call      qword ptr [7FF9EA110658]
-       mov       r11,7FF9E9D00658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA225540
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA225540
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/188a89ca-cd02-4c45-801a-0fc2ed56eb47-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96c11951-1edc-4fc7-9994-8d668be25799-diff.temp
index acc6c7b..9cce687 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96c11951-1edc-4fc7-9994-8d668be25799-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/188a89ca-cd02-4c45-801a-0fc2ed56eb47-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA110668]
+       mov       r11,7FF9E9D00668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA110650]
+       mov       r11,7FF9E9D00650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA235448
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225618
-       mov       rdx,7FF9EA235448
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA110658]
+       mov       r11,7FF9E9D00658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA235370
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225540
-       mov       rdx,7FF9EA235370
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/362a2a25-fd90-4ee5-886a-df5cd5d90e8c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/264b5347-e87e-4a6f-a563-75f7d49d137f-diff.temp
index ab55d8b..acc6c7b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/264b5347-e87e-4a6f-a563-75f7d49d137f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/362a2a25-fd90-4ee5-886a-df5cd5d90e8c-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2353A8
-       mov       rdx,7FF9EA235448
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
        call      qword ptr [7FF9EA120658]
        mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFD0]
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA235370
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA235370
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/124f6373-84fe-4dc2-8eb5-22e7a33d8240-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/19108594-68b8-4598-bf22-c7b82840f6ac-diff.temp
index ab55d8b..9cce687 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/19108594-68b8-4598-bf22-c7b82840f6ac-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/124f6373-84fe-4dc2-8eb5-22e7a33d8240-diff.temp
```
**Diff for StartsWith01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,30
        nop
 M01_L19:
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rcx,[rbp+0FFC8]
        je        short M01_L19
        cmp       qword ptr [rbp+0FFC8],0
        lea       rbp,[rbp+60]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 M01_L18:
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        mov       eax,1
        lea       rsp,[rbp+0FFE0]
        xor       eax,eax
 M01_L16:
+       call      qword ptr [7FF9EA120668]
+       mov       r11,7FF9E9D10668
-       call      qword ptr [7FF9EA110668]
-       mov       r11,7FF9E9D00668
        mov       rcx,[rbp+0FFD0]
        je        short M01_L16
        cmp       qword ptr [rbp+0FFD0],0
 M01_L15:
        jmp       short M01_L17
        call      M01_L20
        mov       rcx,rsp
        mov       rcx,rsp
 M01_L13:
        jmp       short M01_L14
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rcx,[rbp+0FFC8]
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        je        short M01_L13
        test      eax,eax
        call      System.Object.Equals(System.Object, System.Object)
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2353A8
-       mov       rdx,7FF9EA225618
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2353A8
-       mov       rdx,7FF9EA225618
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120658]
+       mov       r11,7FF9E9D10658
-       call      qword ptr [7FF9EA110658]
-       mov       r11,7FF9E9D00658
        mov       rcx,[rbp+0FFD0]
 M01_L07:
        jmp       short M01_L12
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA225540
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA225540
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2a8795a0-9291-4483-acd0-744520917024-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08d43b84-0c79-49d1-a4e8-2ce2c998a8a9-diff.temp
index acc6c7b..9cce687 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08d43b84-0c79-49d1-a4e8-2ce2c998a8a9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2a8795a0-9291-4483-acd0-744520917024-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA110668]
+       mov       r11,7FF9E9D00668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA110650]
+       mov       r11,7FF9E9D00650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA110660]
+       mov       r11,7FF9E9D00660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225438
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225438
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA110658]
+       mov       r11,7FF9E9D00658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA110650]
+       mov       r11,7FF9E9D00650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252D0
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252D0
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b7dc4f5d-aa8f-4170-8943-b7ff764d43ba-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1b093012-b2d5-478b-90b7-e27c64126188-diff.temp
index 3ab0459..f10f759 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1b093012-b2d5-478b-90b7-e27c64126188-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b7dc4f5d-aa8f-4170-8943-b7ff764d43ba-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235408
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
        call      qword ptr [7FF9EA120658]
        mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFC8]
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352A0
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352A0
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a14509e4-3581-4fed-8013-ad44a1488785-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/87b16e49-9a93-4f87-be45-2df00dc9cef2-diff.temp
index 3ab0459..f970717 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/87b16e49-9a93-4f87-be45-2df00dc9cef2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a14509e4-3581-4fed-8013-ad44a1488785-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA100668]
+       mov       r11,7FF9E9CF0668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100660]
+       mov       r11,7FF9E9CF0660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215408
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215408
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100658]
+       mov       r11,7FF9E9CF0658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2152A0
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2152A0
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f1a9726d-5ae2-440e-865a-72e1145cfac4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2b21bd39-f377-4879-af0a-d0deb4622ab1-diff.temp
index 3ab0459..4b27f79 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2b21bd39-f377-4879-af0a-d0deb4622ab1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f1a9726d-5ae2-440e-865a-72e1145cfac4-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA130668]
+       mov       r11,7FF9E9D20668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130660]
+       mov       r11,7FF9E9D20660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2456A8
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2456A8
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130658]
+       mov       r11,7FF9E9D20658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245540
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245540
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/42cbcaa0-311d-4bcb-a0d1-9451a9f942f6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a72fbce4-316d-4875-9f7b-3a9359052d8e-diff.temp
index 3ab0459..7801366 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a72fbce4-316d-4875-9f7b-3a9359052d8e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/42cbcaa0-311d-4bcb-a0d1-9451a9f942f6-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA130668]
+       mov       r11,7FF9E9D20668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130660]
+       mov       r11,7FF9E9D20660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245438
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245438
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130658]
+       mov       r11,7FF9E9D20658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2452D0
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2452D0
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/523d2f9f-d58f-4aa2-b6de-61cdbf84f343-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/88e63fb8-ebe7-412a-9059-16f6c72a9968-diff.temp
index 3ab0459..b92c840 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/88e63fb8-ebe7-412a-9059-16f6c72a9968-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/523d2f9f-d58f-4aa2-b6de-61cdbf84f343-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA100668]
+       mov       r11,7FF9E9CF0668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100660]
+       mov       r11,7FF9E9CF0660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA234FA0
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100658]
+       mov       r11,7FF9E9CF0658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA234E38
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/697bf6f2-c872-4a2c-80db-2d7fbd929769-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a50ce33d-da1f-4a53-b863-cfab40601111-diff.temp
index 3ab0459..5421ab9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a50ce33d-da1f-4a53-b863-cfab40601111-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/697bf6f2-c872-4a2c-80db-2d7fbd929769-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA120668]
+       mov       r11,7FF9E9D10668
-       call      qword ptr [7FF9EA110668]
-       mov       r11,7FF9E9D00668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120660]
+       mov       r11,7FF9E9D10660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235408
-       mov       rdx,7FF9EA225438
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235408
-       mov       rdx,7FF9EA225438
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA120658]
+       mov       r11,7FF9E9D10658
-       call      qword ptr [7FF9EA110658]
-       mov       r11,7FF9E9D00658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA120650]
+       mov       r11,7FF9E9D10650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352A0
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352A0
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ac53b82e-9df6-405d-b520-36949bf33dc1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/31edb79a-6422-4985-ba81-e9524cd855d5-diff.temp
index f10f759..f970717 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/31edb79a-6422-4985-ba81-e9524cd855d5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ac53b82e-9df6-405d-b520-36949bf33dc1-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA100668]
+       mov       r11,7FF9E9CF0668
-       call      qword ptr [7FF9EA110668]
-       mov       r11,7FF9E9D00668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100660]
+       mov       r11,7FF9E9CF0660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215408
-       mov       rdx,7FF9EA225438
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215408
-       mov       rdx,7FF9EA225438
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100658]
+       mov       r11,7FF9E9CF0658
-       call      qword ptr [7FF9EA110658]
-       mov       r11,7FF9E9D00658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2152A0
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2152A0
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/525cde51-763f-4d13-a15e-02672c968377-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/05117108-81d3-42b7-899c-3f54f7521415-diff.temp
index f10f759..4b27f79 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/05117108-81d3-42b7-899c-3f54f7521415-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/525cde51-763f-4d13-a15e-02672c968377-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA130668]
+       mov       r11,7FF9E9D20668
-       call      qword ptr [7FF9EA110668]
-       mov       r11,7FF9E9D00668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130660]
+       mov       r11,7FF9E9D20660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2456A8
-       mov       rdx,7FF9EA225438
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2456A8
-       mov       rdx,7FF9EA225438
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130658]
+       mov       r11,7FF9E9D20658
-       call      qword ptr [7FF9EA110658]
-       mov       r11,7FF9E9D00658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245540
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245540
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/35ebdd1b-a827-4519-a1c0-9b4986cba921-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/afef4149-9328-4da1-b10c-e4af60148a9a-diff.temp
index f10f759..7801366 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/afef4149-9328-4da1-b10c-e4af60148a9a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/35ebdd1b-a827-4519-a1c0-9b4986cba921-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA130668]
+       mov       r11,7FF9E9D20668
-       call      qword ptr [7FF9EA110668]
-       mov       r11,7FF9E9D00668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130660]
+       mov       r11,7FF9E9D20660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245438
-       mov       rdx,7FF9EA225438
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245438
-       mov       rdx,7FF9EA225438
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130658]
+       mov       r11,7FF9E9D20658
-       call      qword ptr [7FF9EA110658]
-       mov       r11,7FF9E9D00658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2452D0
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2452D0
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4e935a38-effa-493a-8d61-c6209f18a7f2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fa766c97-abfa-43a5-ac36-9fd7faee0fdd-diff.temp
index f10f759..b92c840 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fa766c97-abfa-43a5-ac36-9fd7faee0fdd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4e935a38-effa-493a-8d61-c6209f18a7f2-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA100668]
+       mov       r11,7FF9E9CF0668
-       call      qword ptr [7FF9EA110668]
-       mov       r11,7FF9E9D00668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100660]
+       mov       r11,7FF9E9CF0660
-       call      qword ptr [7FF9EA110660]
-       mov       r11,7FF9E9D00660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA225438
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA225438
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100658]
+       mov       r11,7FF9E9CF0658
-       call      qword ptr [7FF9EA110658]
-       mov       r11,7FF9E9D00658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA110650]
-       mov       r11,7FF9E9D00650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f6205176-d938-4d81-8bae-e42d8b9b4469-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed015732-d599-4ec7-bb7d-29a344dc1708-diff.temp
index f10f759..5421ab9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed015732-d599-4ec7-bb7d-29a344dc1708-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f6205176-d938-4d81-8bae-e42d8b9b4469-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA100668]
+       mov       r11,7FF9E9CF0668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100660]
+       mov       r11,7FF9E9CF0660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215408
-       mov       rdx,7FF9EA235408
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215408
-       mov       rdx,7FF9EA235408
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100658]
+       mov       r11,7FF9E9CF0658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2152A0
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2152A0
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f0aa2462-944e-4cbb-bfdd-2dc1f26d0c6a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/22e64192-2f6d-489f-8dc7-932bd20af45a-diff.temp
index f970717..4b27f79 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/22e64192-2f6d-489f-8dc7-932bd20af45a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f0aa2462-944e-4cbb-bfdd-2dc1f26d0c6a-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA130668]
+       mov       r11,7FF9E9D20668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130660]
+       mov       r11,7FF9E9D20660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2456A8
-       mov       rdx,7FF9EA235408
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2456A8
-       mov       rdx,7FF9EA235408
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130658]
+       mov       r11,7FF9E9D20658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245540
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245540
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/94f4c23f-016b-4a0c-a689-b610f59d4b46-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/847baa16-aab6-4a04-afad-b8454cd60ec1-diff.temp
index f970717..7801366 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/847baa16-aab6-4a04-afad-b8454cd60ec1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/94f4c23f-016b-4a0c-a689-b610f59d4b46-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA130668]
+       mov       r11,7FF9E9D20668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130660]
+       mov       r11,7FF9E9D20660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245438
-       mov       rdx,7FF9EA235408
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245438
-       mov       rdx,7FF9EA235408
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130658]
+       mov       r11,7FF9E9D20658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2452D0
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2452D0
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bfe0f1e7-8711-4f8b-a1cb-69625c835bea-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1d3c2aca-5ae7-420a-9960-0e67997e5261-diff.temp
index f970717..b92c840 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1d3c2aca-5ae7-420a-9960-0e67997e5261-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bfe0f1e7-8711-4f8b-a1cb-69625c835bea-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA100668]
+       mov       r11,7FF9E9CF0668
-       call      qword ptr [7FF9EA120668]
-       mov       r11,7FF9E9D10668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100660]
+       mov       r11,7FF9E9CF0660
-       call      qword ptr [7FF9EA120660]
-       mov       r11,7FF9E9D10660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA235408
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA235408
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100658]
+       mov       r11,7FF9E9CF0658
-       call      qword ptr [7FF9EA120658]
-       mov       r11,7FF9E9D10658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA120650]
-       mov       r11,7FF9E9D10650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA2352A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e93f4c2d-bf79-41b4-a346-8ed33a025c3e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8ba3fe0e-4363-47a0-9faf-5fba81a353a6-diff.temp
index f970717..5421ab9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8ba3fe0e-4363-47a0-9faf-5fba81a353a6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e93f4c2d-bf79-41b4-a346-8ed33a025c3e-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA130668]
+       mov       r11,7FF9E9D20668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130660]
+       mov       r11,7FF9E9D20660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2456A8
-       mov       rdx,7FF9EA215408
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2456A8
-       mov       rdx,7FF9EA215408
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130658]
+       mov       r11,7FF9E9D20658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245540
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245540
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4a20c636-11d0-4371-bf06-74dc3e86c625-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6d221f43-c1db-4b7c-977c-f5efc2dd16a9-diff.temp
index 4b27f79..7801366 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6d221f43-c1db-4b7c-977c-f5efc2dd16a9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4a20c636-11d0-4371-bf06-74dc3e86c625-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA130668]
+       mov       r11,7FF9E9D20668
-       call      qword ptr [7FF9EA100668]
-       mov       r11,7FF9E9CF0668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130660]
+       mov       r11,7FF9E9D20660
-       call      qword ptr [7FF9EA100660]
-       mov       r11,7FF9E9CF0660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245438
-       mov       rdx,7FF9EA215408
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245438
-       mov       rdx,7FF9EA215408
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA130658]
+       mov       r11,7FF9E9D20658
-       call      qword ptr [7FF9EA100658]
-       mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA130650]
+       mov       r11,7FF9E9D20650
-       call      qword ptr [7FF9EA100650]
-       mov       r11,7FF9E9CF0650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2452D0
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2452D0
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0364ae49-017b-4e43-8f1e-dd1bfa88aa93-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6de750cd-c0f0-482d-9b6e-7d0cfdd221cf-diff.temp
index 4b27f79..b92c840 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6de750cd-c0f0-482d-9b6e-7d0cfdd221cf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0364ae49-017b-4e43-8f1e-dd1bfa88aa93-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA215408
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
        call      qword ptr [7FF9EA100658]
        mov       r11,7FF9E9CF0658
        mov       rcx,[rbp+0FFC8]
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA2152A0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/15391d21-91f1-4c45-b29d-42ccf46fdc19-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67426e2b-9111-41ef-bdd9-ad392441238e-diff.temp
index 4b27f79..5421ab9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67426e2b-9111-41ef-bdd9-ad392441238e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/15391d21-91f1-4c45-b29d-42ccf46fdc19-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA245438
-       mov       rdx,7FF9EA2456A8
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
        call      qword ptr [7FF9EA130658]
        mov       r11,7FF9E9D20658
        mov       rcx,[rbp+0FFC8]
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2452D0
-       mov       rdx,7FF9EA245540
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2452D0
-       mov       rdx,7FF9EA245540
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/45483f3f-1091-4153-9a73-65ed67b321ab-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da533f22-ae29-44dc-937e-255f4373d598-diff.temp
index 7801366..b92c840 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da533f22-ae29-44dc-937e-255f4373d598-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/45483f3f-1091-4153-9a73-65ed67b321ab-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA100668]
+       mov       r11,7FF9E9CF0668
-       call      qword ptr [7FF9EA130668]
-       mov       r11,7FF9E9D20668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA130650]
-       mov       r11,7FF9E9D20650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100660]
+       mov       r11,7FF9E9CF0660
-       call      qword ptr [7FF9EA130660]
-       mov       r11,7FF9E9D20660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA2456A8
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA2456A8
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100658]
+       mov       r11,7FF9E9CF0658
-       call      qword ptr [7FF9EA130658]
-       mov       r11,7FF9E9D20658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA130650]
-       mov       r11,7FF9E9D20650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA245540
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA245540
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/19feeddc-2649-45d5-9d17-4d5e4fda27a1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ee7d0a33-e30e-40cb-998b-fa2292d7f9f3-diff.temp
index 7801366..5421ab9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ee7d0a33-e30e-40cb-998b-fa2292d7f9f3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/19feeddc-2649-45d5-9d17-4d5e4fda27a1-diff.temp
```
**Diff for StructuralSequenceEqual01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L14
        movzx     esi,sil
        sete      sil
        test      eax,eax
+       call      qword ptr [7FF9EA100668]
+       mov       r11,7FF9E9CF0668
-       call      qword ptr [7FF9EA130668]
-       mov       r11,7FF9E9D20668
        mov       rcx,[rbp+0FFC8]
 M01_L12:
        jne       near ptr M01_L07
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA130650]
-       mov       r11,7FF9E9D20650
        mov       rcx,[rbp+0FFD0]
        je        short M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100660]
+       mov       r11,7FF9E9CF0660
-       call      qword ptr [7FF9EA130660]
-       mov       r11,7FF9E9D20660
        mov       rdx,rbx
        mov       rcx,rdi
        mov       r8,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M01_L11:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA245438
        mov       rcx,rsi
 M01_L10:
        jmp       short M01_L11
        je        short M01_L10
        test      r11,r11
        mov       r11,[r14+18]
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFD0]
 M01_L09:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2156A8
-       mov       rdx,7FF9EA245438
        mov       rcx,rsi
 M01_L08:
        jmp       short M01_L09
        je        short M01_L08
        test      r11,r11
        mov       r11,[r14+18]
        mov       rdi,rax
        call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
        je        near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF9EA100658]
+       mov       r11,7FF9E9CF0658
-       call      qword ptr [7FF9EA130658]
-       mov       r11,7FF9E9D20658
        mov       rcx,[rbp+0FFC8]
 M01_L07:
        je        near ptr M01_L12
        test      eax,eax
+       call      qword ptr [7FF9EA100650]
+       mov       r11,7FF9E9CF0650
-       call      qword ptr [7FF9EA130650]
-       mov       r11,7FF9E9D20650
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFC8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA2452D0
        mov       rcx,rsi
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      r11,r11
        mov       r11,[r14+10]
        mov       [rbp+0FFD0],rax
        call      qword ptr [r11]
        mov       rcx,rdi
 M01_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA215540
-       mov       rdx,7FF9EA2452D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e205750b-d630-4e7f-84b9-6f1e0288918e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b4aeefe0-7ed2-4225-95df-f794db8d1fca-diff.temp
index b92c840..5421ab9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b4aeefe0-7ed2-4225-95df-f794db8d1fca-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e205750b-d630-4e7f-84b9-6f1e0288918e-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/24bda26c-0db9-4906-ab5f-173cea2f8c5e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4e11d0be-9ea1-4565-9643-25d1f5f92bc0-diff.temp
index 12d1159..3b4db60 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4e11d0be-9ea1-4565-9643-25d1f5f92bc0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/24bda26c-0db9-4906-ab5f-173cea2f8c5e-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cbb184e7-eef8-400c-b184-0431b55832e5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8ceb1927-b174-4ca5-8474-dad6a75b6782-diff.temp
index 12d1159..f1a3d14 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8ceb1927-b174-4ca5-8474-dad6a75b6782-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cbb184e7-eef8-400c-b184-0431b55832e5-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96a5f030-eb1f-4fb9-9033-fb1500bd47f3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/46ff12fd-1c2e-4861-8f1a-0e5afd632517-diff.temp
index 12d1159..285e5e8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/46ff12fd-1c2e-4861-8f1a-0e5afd632517-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96a5f030-eb1f-4fb9-9033-fb1500bd47f3-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e8e9c7ea-c354-4985-ac49-92a4c861d9f1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/41ba2db7-e57d-4eaf-846d-5acb6fc129a9-diff.temp
index 12d1159..dc4bdc7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/41ba2db7-e57d-4eaf-846d-5acb6fc129a9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e8e9c7ea-c354-4985-ac49-92a4c861d9f1-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/99811349-09ce-4300-816e-40305616f780-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/619fd28c-e501-423b-b677-6538db4cc4b1-diff.temp
index 12d1159..9db2491 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/619fd28c-e501-423b-b677-6538db4cc4b1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/99811349-09ce-4300-816e-40305616f780-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c345b0c0-65d4-4aa6-a266-fd103d6a81bb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39d7368c-aed4-4d4e-b5f9-3e660a6ed459-diff.temp
index 12d1159..099cc1f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39d7368c-aed4-4d4e-b5f9-3e660a6ed459-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c345b0c0-65d4-4aa6-a266-fd103d6a81bb-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e310800-f76f-48b7-a872-1fb193b3261c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/575a75ca-1fae-40f8-85c0-65a7402cb67e-diff.temp
index 3b4db60..f1a3d14 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/575a75ca-1fae-40f8-85c0-65a7402cb67e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e310800-f76f-48b7-a872-1fb193b3261c-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8b56299a-43ec-44f2-a66c-2016ab64d883-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/87627b9e-b96f-422e-84b3-fefe698d53e4-diff.temp
index 3b4db60..285e5e8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/87627b9e-b96f-422e-84b3-fefe698d53e4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8b56299a-43ec-44f2-a66c-2016ab64d883-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8799f440-dd68-46b0-8eb8-371e28933081-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a36e791-1365-4e30-8af9-a071cae65e40-diff.temp
index 3b4db60..dc4bdc7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a36e791-1365-4e30-8af9-a071cae65e40-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8799f440-dd68-46b0-8eb8-371e28933081-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f801685b-8b6c-4b75-a2e0-6ab992bc3b2d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/903061e9-02dc-4e71-8de7-c449b8183e69-diff.temp
index 3b4db60..9db2491 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/903061e9-02dc-4e71-8de7-c449b8183e69-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f801685b-8b6c-4b75-a2e0-6ab992bc3b2d-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3c577969-e90f-4abd-90d1-6505241c8070-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6ffcf13f-82bd-46fd-89cb-24819e828810-diff.temp
index 3b4db60..099cc1f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6ffcf13f-82bd-46fd-89cb-24819e828810-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3c577969-e90f-4abd-90d1-6505241c8070-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/85900bac-add2-44ba-864c-dea96c1fba60-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e6cf0fc0-63ef-465e-8982-0da686fa9d8d-diff.temp
index f1a3d14..285e5e8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e6cf0fc0-63ef-465e-8982-0da686fa9d8d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/85900bac-add2-44ba-864c-dea96c1fba60-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d96a70b2-52f1-423f-9c65-583ddce0a793-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f429cb36-148b-4aed-b800-78a030b70b88-diff.temp
index f1a3d14..dc4bdc7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f429cb36-148b-4aed-b800-78a030b70b88-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d96a70b2-52f1-423f-9c65-583ddce0a793-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/624ae8f6-cb1a-4f0d-8b25-a5fc4e407f1a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6da8db14-9fec-4494-9357-11ac05569395-diff.temp
index f1a3d14..9db2491 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6da8db14-9fec-4494-9357-11ac05569395-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/624ae8f6-cb1a-4f0d-8b25-a5fc4e407f1a-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cfb5777c-8373-49cc-a7c7-3ed7905090c9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b5a2a456-b382-4fe0-af0b-2abee179f078-diff.temp
index f1a3d14..099cc1f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b5a2a456-b382-4fe0-af0b-2abee179f078-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cfb5777c-8373-49cc-a7c7-3ed7905090c9-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/97454513-c728-4e64-82a8-70ed0610fd85-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08802804-2340-492b-988d-b0d305fc3d01-diff.temp
index 285e5e8..dc4bdc7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08802804-2340-492b-988d-b0d305fc3d01-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/97454513-c728-4e64-82a8-70ed0610fd85-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/80c61030-bdb4-4586-8e7b-8f1d65e0b6e7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a0c009c7-0d80-474b-84d7-9941121c56d4-diff.temp
index 285e5e8..9db2491 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a0c009c7-0d80-474b-84d7-9941121c56d4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/80c61030-bdb4-4586-8e7b-8f1d65e0b6e7-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e78a99cc-884f-4112-96cc-33f62944245c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9885d2fd-3b4b-4ce8-a263-d36a12baf372-diff.temp
index 285e5e8..099cc1f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9885d2fd-3b4b-4ce8-a263-d36a12baf372-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e78a99cc-884f-4112-96cc-33f62944245c-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/826e26d2-b20b-4dea-a1f5-39730a5c79c9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bff168ce-4f30-41fe-b7b7-79e6ff303487-diff.temp
index dc4bdc7..9db2491 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bff168ce-4f30-41fe-b7b7-79e6ff303487-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/826e26d2-b20b-4dea-a1f5-39730a5c79c9-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4694c099-cbef-426f-aa2f-3da5fd16b701-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2d297909-1157-45f6-9d64-ef380c7f3e5b-diff.temp
index dc4bdc7..099cc1f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2d297909-1157-45f6-9d64-ef380c7f3e5b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4694c099-cbef-426f-aa2f-3da5fd16b701-diff.temp
```
**Diff for ToBlockingCollection01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/46744524-6464-474d-9f11-378cf10df4b8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a28d7e47-b4bf-4441-97ef-cf1360ace136-diff.temp
index 9db2491..099cc1f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a28d7e47-b4bf-4441-97ef-cf1360ace136-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/46744524-6464-474d-9f11-378cf10df4b8-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352D0
-       mov       rdx,7FF9EA244E68
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23652BC3020
-       mov       rax,1E7E88D3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2352C0
-       mov       rdx,7FF9EA244E58
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8ea1327a-2839-4722-8d45-74c4d616bbb3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/70d67174-52eb-4442-8132-df44147763b4-diff.temp
index ab638d7..41dd798 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/70d67174-52eb-4442-8132-df44147763b4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8ea1327a-2839-4722-8d45-74c4d616bbb3-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225570
-       mov       rdx,7FF9EA244E68
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2805FA51028
-       mov       rax,1E7E88D3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225560
-       mov       rdx,7FF9EA244E58
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/afe6d4fa-19a3-4be5-942b-35c1bc96bb6f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f19cca2f-0cf7-4aac-8865-5d254a776984-diff.temp
index ab638d7..d689187 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f19cca2f-0cf7-4aac-8865-5d254a776984-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/afe6d4fa-19a3-4be5-942b-35c1bc96bb6f-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252D0
-       mov       rdx,7FF9EA244E68
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,263FFDF3020
-       mov       rax,1E7E88D3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252C0
-       mov       rdx,7FF9EA244E58
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8971b2cd-65e8-4b1a-a8f1-4ab63289e5ac-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dbdc398a-19fe-47f9-b6d9-2919c9f946e6-diff.temp
index ab638d7..ef6a21d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dbdc398a-19fe-47f9-b6d9-2919c9f946e6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8971b2cd-65e8-4b1a-a8f1-4ab63289e5ac-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235570
-       mov       rdx,7FF9EA244E68
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23FFCC63020
-       mov       rax,1E7E88D3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235560
-       mov       rdx,7FF9EA244E58
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/73ed132d-d299-444b-8b8f-8d153a86334d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/625f2c28-2005-4f44-8656-d98b4c06fa32-diff.temp
index ab638d7..5e973ae 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/625f2c28-2005-4f44-8656-d98b4c06fa32-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/73ed132d-d299-444b-8b8f-8d153a86334d-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225570
-       mov       rdx,7FF9EA244E68
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1D0DB883020
-       mov       rax,1E7E88D3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225560
-       mov       rdx,7FF9EA244E58
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d0c11322-280d-428c-9dd0-f654c8c7576a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2a239b15-ad8b-4d1b-b5d5-884a269570dd-diff.temp
index ab638d7..7f17749 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2a239b15-ad8b-4d1b-b5d5-884a269570dd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d0c11322-280d-428c-9dd0-f654c8c7576a-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205570
-       mov       rdx,7FF9EA244E68
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2124BF83020
-       mov       rax,1E7E88D3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205560
-       mov       rdx,7FF9EA244E58
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/70ec652c-f3a1-48f1-a8cf-5c4e4fa67340-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3fc99998-2ead-4f0c-aadf-1e0dfa44187e-diff.temp
index ab638d7..d3005bd 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3fc99998-2ead-4f0c-aadf-1e0dfa44187e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/70ec652c-f3a1-48f1-a8cf-5c4e4fa67340-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225570
-       mov       rdx,7FF9EA2352D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2805FA51028
-       mov       rax,23652BC3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225560
-       mov       rdx,7FF9EA2352C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8b317599-258f-4848-a18d-f783d4b83b39-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/54e87690-415c-4968-ac9f-ab397066b94a-diff.temp
index 41dd798..d689187 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/54e87690-415c-4968-ac9f-ab397066b94a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8b317599-258f-4848-a18d-f783d4b83b39-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252D0
-       mov       rdx,7FF9EA2352D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,263FFDF3020
-       mov       rax,23652BC3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252C0
-       mov       rdx,7FF9EA2352C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/04ada0c6-8184-4cba-8304-b86cc86a97d1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1d4ea41b-3752-498c-aa17-b95c8b3447e0-diff.temp
index 41dd798..ef6a21d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1d4ea41b-3752-498c-aa17-b95c8b3447e0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/04ada0c6-8184-4cba-8304-b86cc86a97d1-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235570
-       mov       rdx,7FF9EA2352D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23FFCC63020
-       mov       rax,23652BC3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235560
-       mov       rdx,7FF9EA2352C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f0db9d4b-e574-430b-9343-3ed9c4f04b03-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6067772-1088-45c9-92a0-eac0de49db58-diff.temp
index 41dd798..5e973ae 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6067772-1088-45c9-92a0-eac0de49db58-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f0db9d4b-e574-430b-9343-3ed9c4f04b03-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225570
-       mov       rdx,7FF9EA2352D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1D0DB883020
-       mov       rax,23652BC3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225560
-       mov       rdx,7FF9EA2352C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c2c025fe-9893-41e1-acf5-8a78ef81ce3a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/72c43b18-96fc-47ee-9682-0f9a41ae1a9b-diff.temp
index 41dd798..7f17749 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/72c43b18-96fc-47ee-9682-0f9a41ae1a9b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c2c025fe-9893-41e1-acf5-8a78ef81ce3a-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205570
-       mov       rdx,7FF9EA2352D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2124BF83020
-       mov       rax,23652BC3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205560
-       mov       rdx,7FF9EA2352C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e03bbfad-8284-42db-b9f6-79bc9c44cf4a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65336f08-f65d-4714-9aa8-836e744f9b29-diff.temp
index 41dd798..d3005bd 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65336f08-f65d-4714-9aa8-836e744f9b29-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e03bbfad-8284-42db-b9f6-79bc9c44cf4a-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252D0
-       mov       rdx,7FF9EA225570
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,263FFDF3020
-       mov       rax,2805FA51028
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2252C0
-       mov       rdx,7FF9EA225560
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b907a1db-21cf-4746-83ca-897d0d37f78b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e2e3e205-6ad0-4afa-95e5-16e711264df7-diff.temp
index d689187..ef6a21d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e2e3e205-6ad0-4afa-95e5-16e711264df7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b907a1db-21cf-4746-83ca-897d0d37f78b-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235570
-       mov       rdx,7FF9EA225570
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23FFCC63020
-       mov       rax,2805FA51028
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235560
-       mov       rdx,7FF9EA225560
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1b42f150-f415-4929-9545-a6523093b9f2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d879f86-9b52-47d3-9825-2db3386bd13e-diff.temp
index d689187..5e973ae 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d879f86-9b52-47d3-9825-2db3386bd13e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1b42f150-f415-4929-9545-a6523093b9f2-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8a172d61-0944-4923-bdba-20d83608c8a8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eabc9488-aa75-408c-9aaa-afa83856ec86-diff.temp
index d689187..7f17749 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eabc9488-aa75-408c-9aaa-afa83856ec86-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8a172d61-0944-4923-bdba-20d83608c8a8-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205570
-       mov       rdx,7FF9EA225570
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2124BF83020
-       mov       rax,2805FA51028
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205560
-       mov       rdx,7FF9EA225560
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/29ed9ee4-47ee-4c77-9c89-bf746ba1f1f5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/350055cc-6522-4e49-af8d-6c2bf6b5d99f-diff.temp
index d689187..d3005bd 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/350055cc-6522-4e49-af8d-6c2bf6b5d99f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/29ed9ee4-47ee-4c77-9c89-bf746ba1f1f5-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235570
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23FFCC63020
-       mov       rax,263FFDF3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA235560
-       mov       rdx,7FF9EA2252C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0382ad45-9568-471a-ab5e-bcf467f41812-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0636bc24-58e7-4dd4-8885-9a9390cb203a-diff.temp
index ef6a21d..5e973ae 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0636bc24-58e7-4dd4-8885-9a9390cb203a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0382ad45-9568-471a-ab5e-bcf467f41812-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225570
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1D0DB883020
-       mov       rax,263FFDF3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225560
-       mov       rdx,7FF9EA2252C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/41e475b9-66f4-42f6-8120-c9a6611b705a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da0482ad-f196-4bb0-b78f-6547ee37e1e4-diff.temp
index ef6a21d..7f17749 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da0482ad-f196-4bb0-b78f-6547ee37e1e4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/41e475b9-66f4-42f6-8120-c9a6611b705a-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205570
-       mov       rdx,7FF9EA2252D0
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2124BF83020
-       mov       rax,263FFDF3020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205560
-       mov       rdx,7FF9EA2252C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1329175b-b092-463d-814e-456dd9d4a5e8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2f528dd2-6d91-4966-8e1c-37e85ec66b8c-diff.temp
index ef6a21d..d3005bd 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2f528dd2-6d91-4966-8e1c-37e85ec66b8c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1329175b-b092-463d-814e-456dd9d4a5e8-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225570
-       mov       rdx,7FF9EA235570
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1D0DB883020
-       mov       rax,23FFCC63020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA225560
-       mov       rdx,7FF9EA235560
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/64bf83ed-0220-4e7e-8e79-e889d03f6aef-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e06c58f4-3c5a-4d66-b650-5cfe99a8464a-diff.temp
index 5e973ae..7f17749 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e06c58f4-3c5a-4d66-b650-5cfe99a8464a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/64bf83ed-0220-4e7e-8e79-e889d03f6aef-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205570
-       mov       rdx,7FF9EA235570
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2124BF83020
-       mov       rax,23FFCC63020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205560
-       mov       rdx,7FF9EA235560
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6d765cd9-fbdc-4034-ab22-f3195153e6c2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83a0cce4-bcf0-45d5-9b2d-4e16581a4ee3-diff.temp
index 5e973ae..d3005bd 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83a0cce4-bcf0-45d5-9b2d-4e16581a4ee3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6d765cd9-fbdc-4034-ab22-f3195153e6c2-diff.temp
```
**Diff for ToDelimitedString01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L04:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205570
-       mov       rdx,7FF9EA225570
        mov       rcx,rsi
 M01_L03:
        jmp       short M01_L04
        je        short M01_L03
        test      rcx,rcx
        mov       rcx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r14+8]
        call      System.Text.StringBuilder..ctor(Int32, Int32)
        mov       r8d,7FFFFFFF
        mov       rcx,rbx
        jo        near ptr M01_L07
        imul      edx,eax,0A
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2124BF83020
-       mov       rax,1D0DB883020
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        je        short M01_L02
        test      rdi,rdi
        mov       [r14+10],bx
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA205560
-       mov       rdx,7FF9EA225560
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        mov       rcx,[rbp+10]
        je        short M01_L00
        cmp       qword ptr [rbp+10],0
        mov       rbp,[rsi+10]
        mov       ebx,r8d
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
 ; Total bytes of code 61
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
        mov       r8d,2C
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
        mov       rdx,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDelimitedString(',');
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ba39cb9e-7fe3-4bd9-93a4-083fd1755c10-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a1ac37d-67c5-4d5d-a1a8-f76f19bc498e-diff.temp
index 7f17749..d3005bd 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a1ac37d-67c5-4d5d-a1a8-f76f19bc498e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ba39cb9e-7fe3-4bd9-93a4-083fd1755c10-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA130680]
+       mov       r11,7FF9E9D20680
-       call      qword ptr [7FF9EA0F0680]
-       mov       r11,7FF9E9CE0680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA130678]
+       mov       r11,7FF9E9D20678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA248428
-       mov       rdx,7FF9EA207ED8
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA130678]
+       mov       r11,7FF9E9D20678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA248308
-       mov       rdx,7FF9EA207DB8
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2482F0
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA248978
-       mov       rdx,7FF9EA208428
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA248660
-       mov       rdx,7FF9EA208110
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA248A28
-       mov       rdx,7FF9EA2084D8
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA248638
-       mov       rdx,7FF9EA2080E8
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2482F0
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA248620
-       mov       rdx,7FF9EA2080D0
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA247D00
-       mov       rdx,7FF9EA2077B0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F5B88FB340
-       mov       rcx,22B19926F38
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1F5B88FB328
-       mov       rdx,22B19926F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F5B88FB340
-       mov       rcx,22B19926F38
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b19c17d8-f198-4417-9057-4cdb35cea71a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/473e55f9-1d8a-4b64-b4a6-f551e9bb8e7b-diff.temp
index a8a13ea..b781a3b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/473e55f9-1d8a-4b64-b4a6-f551e9bb8e7b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b19c17d8-f198-4417-9057-4cdb35cea71a-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA120680]
+       mov       r11,7FF9E9D10680
-       call      qword ptr [7FF9EA0F0680]
-       mov       r11,7FF9E9CE0680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238248
-       mov       rdx,7FF9EA207ED8
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238128
-       mov       rdx,7FF9EA207DB8
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238110
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238798
-       mov       rdx,7FF9EA208428
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238480
-       mov       rdx,7FF9EA208110
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238848
-       mov       rdx,7FF9EA2084D8
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238458
-       mov       rdx,7FF9EA2080E8
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238110
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238440
-       mov       rdx,7FF9EA2080D0
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA237B20
-       mov       rdx,7FF9EA2077B0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E2CE71B340
-       mov       rcx,22B19926F38
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1E2CE71B328
-       mov       rdx,22B19926F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E2CE71B340
-       mov       rcx,22B19926F38
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20882101-6593-4763-9991-94444837fbf9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5b12ed31-fc60-42fd-a0f0-c79e627a72ba-diff.temp
index a8a13ea..7d05bd7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5b12ed31-fc60-42fd-a0f0-c79e627a72ba-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20882101-6593-4763-9991-94444837fbf9-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA120680]
+       mov       r11,7FF9E9D10680
-       call      qword ptr [7FF9EA0F0680]
-       mov       r11,7FF9E9CE0680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2384E8
-       mov       rdx,7FF9EA207ED8
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2383C8
-       mov       rdx,7FF9EA207DB8
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2383B0
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238A38
-       mov       rdx,7FF9EA208428
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238720
-       mov       rdx,7FF9EA208110
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238AE8
-       mov       rdx,7FF9EA2084D8
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2386F8
-       mov       rdx,7FF9EA2080E8
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2383B0
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2386E0
-       mov       rdx,7FF9EA2080D0
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA237DC0
-       mov       rdx,7FF9EA2077B0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,17AB5A18F30
-       mov       rcx,22B19926F38
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,17AB5A18F18
-       mov       rdx,22B19926F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,17AB5A18F30
-       mov       rcx,22B19926F38
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c0e28807-2778-4704-995d-c38b217a190f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e390889f-2be3-4f64-a482-cf473a94bd23-diff.temp
index a8a13ea..9c1ddc7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e390889f-2be3-4f64-a482-cf473a94bd23-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c0e28807-2778-4704-995d-c38b217a190f-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA120680]
+       mov       r11,7FF9E9D10680
-       call      qword ptr [7FF9EA0F0680]
-       mov       r11,7FF9E9CE0680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238460
-       mov       rdx,7FF9EA207ED8
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238340
-       mov       rdx,7FF9EA207DB8
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238328
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2389B0
-       mov       rdx,7FF9EA208428
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238698
-       mov       rdx,7FF9EA208110
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238A60
-       mov       rdx,7FF9EA2084D8
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238670
-       mov       rdx,7FF9EA2080E8
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238328
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238658
-       mov       rdx,7FF9EA2080D0
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA237D38
-       mov       rdx,7FF9EA2077B0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,27CA052B340
-       mov       rcx,22B19926F38
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,27CA052B328
-       mov       rdx,22B19926F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,27CA052B340
-       mov       rcx,22B19926F38
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cbfe96e4-e050-4ad2-a50e-e8d6b49b26d3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5af18e2b-b240-47d9-a77d-381ab3323b5c-diff.temp
index a8a13ea..63205b2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5af18e2b-b240-47d9-a77d-381ab3323b5c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cbfe96e4-e050-4ad2-a50e-e8d6b49b26d3-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA100680]
+       mov       r11,7FF9E9CF0680
-       call      qword ptr [7FF9EA0F0680]
-       mov       r11,7FF9E9CE0680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2181C0
-       mov       rdx,7FF9EA207ED8
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180A0
-       mov       rdx,7FF9EA207DB8
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218088
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218710
-       mov       rdx,7FF9EA208428
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183F8
-       mov       rdx,7FF9EA208110
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2187C0
-       mov       rdx,7FF9EA2084D8
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183D0
-       mov       rdx,7FF9EA2080E8
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218088
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183B8
-       mov       rdx,7FF9EA2080D0
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217A98
-       mov       rdx,7FF9EA2077B0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1BB04D2AF28
-       mov       rcx,22B19926F38
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1BB04D2AF10
-       mov       rdx,22B19926F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1BB04D2AF28
-       mov       rcx,22B19926F38
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e6761b4-ee2b-4287-86ad-6810ed381018-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cccd1bc9-4c91-45e7-823b-dd1c3bcf665e-diff.temp
index a8a13ea..6551565 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cccd1bc9-4c91-45e7-823b-dd1c3bcf665e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e6761b4-ee2b-4287-86ad-6810ed381018-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA100680]
+       mov       r11,7FF9E9CF0680
-       call      qword ptr [7FF9EA0F0680]
-       mov       r11,7FF9E9CE0680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217F00
-       mov       rdx,7FF9EA207ED8
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA0F0678]
-       mov       r11,7FF9E9CE0678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DE0
-       mov       rdx,7FF9EA207DB8
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218450
-       mov       rdx,7FF9EA208428
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218138
-       mov       rdx,7FF9EA208110
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218500
-       mov       rdx,7FF9EA2084D8
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218110
-       mov       rdx,7FF9EA2080E8
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA207DA0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180F8
-       mov       rdx,7FF9EA2080D0
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2177D8
-       mov       rdx,7FF9EA2077B0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F84CCF6F38
-       mov       rcx,22B19926F38
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1F84CCF6F20
-       mov       rdx,22B19926F20
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F84CCF6F38
-       mov       rcx,22B19926F38
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ca8d8d06-c47d-4bb4-ba39-de174990f19b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c2070e0f-6631-4808-b75c-19aad89b57e5-diff.temp
index a8a13ea..daa09b8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c2070e0f-6631-4808-b75c-19aad89b57e5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ca8d8d06-c47d-4bb4-ba39-de174990f19b-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA120680]
+       mov       r11,7FF9E9D10680
-       call      qword ptr [7FF9EA130680]
-       mov       r11,7FF9E9D20680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA130678]
-       mov       r11,7FF9E9D20678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238248
-       mov       rdx,7FF9EA248428
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA130678]
-       mov       r11,7FF9E9D20678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238128
-       mov       rdx,7FF9EA248308
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238110
-       mov       rdx,7FF9EA2482F0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238798
-       mov       rdx,7FF9EA248978
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238480
-       mov       rdx,7FF9EA248660
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238848
-       mov       rdx,7FF9EA248A28
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238458
-       mov       rdx,7FF9EA248638
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238110
-       mov       rdx,7FF9EA2482F0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238440
-       mov       rdx,7FF9EA248620
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA237B20
-       mov       rdx,7FF9EA247D00
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E2CE71B340
-       mov       rcx,1F5B88FB340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1E2CE71B328
-       mov       rdx,1F5B88FB328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E2CE71B340
-       mov       rcx,1F5B88FB340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/91d7b087-0b22-484f-b203-0b5480406a89-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/16c0b6fc-ebe2-4574-bc33-5682499f1b07-diff.temp
index b781a3b..7d05bd7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/16c0b6fc-ebe2-4574-bc33-5682499f1b07-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/91d7b087-0b22-484f-b203-0b5480406a89-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA120680]
+       mov       r11,7FF9E9D10680
-       call      qword ptr [7FF9EA130680]
-       mov       r11,7FF9E9D20680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA130678]
-       mov       r11,7FF9E9D20678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2384E8
-       mov       rdx,7FF9EA248428
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA130678]
-       mov       r11,7FF9E9D20678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2383C8
-       mov       rdx,7FF9EA248308
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2383B0
-       mov       rdx,7FF9EA2482F0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238A38
-       mov       rdx,7FF9EA248978
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238720
-       mov       rdx,7FF9EA248660
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238AE8
-       mov       rdx,7FF9EA248A28
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2386F8
-       mov       rdx,7FF9EA248638
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2383B0
-       mov       rdx,7FF9EA2482F0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2386E0
-       mov       rdx,7FF9EA248620
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA237DC0
-       mov       rdx,7FF9EA247D00
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,17AB5A18F30
-       mov       rcx,1F5B88FB340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,17AB5A18F18
-       mov       rdx,1F5B88FB328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,17AB5A18F30
-       mov       rcx,1F5B88FB340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e3aa1ba5-07aa-4a31-b74d-5315fd3e978b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/411ac01e-f387-41b9-8e72-cd104fc1e90c-diff.temp
index b781a3b..9c1ddc7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/411ac01e-f387-41b9-8e72-cd104fc1e90c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e3aa1ba5-07aa-4a31-b74d-5315fd3e978b-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA120680]
+       mov       r11,7FF9E9D10680
-       call      qword ptr [7FF9EA130680]
-       mov       r11,7FF9E9D20680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA130678]
-       mov       r11,7FF9E9D20678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238460
-       mov       rdx,7FF9EA248428
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA120678]
+       mov       r11,7FF9E9D10678
-       call      qword ptr [7FF9EA130678]
-       mov       r11,7FF9E9D20678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238340
-       mov       rdx,7FF9EA248308
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238328
-       mov       rdx,7FF9EA2482F0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2389B0
-       mov       rdx,7FF9EA248978
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238698
-       mov       rdx,7FF9EA248660
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238A60
-       mov       rdx,7FF9EA248A28
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238670
-       mov       rdx,7FF9EA248638
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238328
-       mov       rdx,7FF9EA2482F0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238658
-       mov       rdx,7FF9EA248620
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA237D38
-       mov       rdx,7FF9EA247D00
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,27CA052B340
-       mov       rcx,1F5B88FB340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,27CA052B328
-       mov       rdx,1F5B88FB328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,27CA052B340
-       mov       rcx,1F5B88FB340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9b9b1f73-f28f-4ee9-a2ad-ddfe2e245797-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c0e2c4d7-b4c7-4c3f-808c-130d66d2a2cd-diff.temp
index b781a3b..63205b2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c0e2c4d7-b4c7-4c3f-808c-130d66d2a2cd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9b9b1f73-f28f-4ee9-a2ad-ddfe2e245797-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA100680]
+       mov       r11,7FF9E9CF0680
-       call      qword ptr [7FF9EA130680]
-       mov       r11,7FF9E9D20680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA130678]
-       mov       r11,7FF9E9D20678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2181C0
-       mov       rdx,7FF9EA248428
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA130678]
-       mov       r11,7FF9E9D20678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180A0
-       mov       rdx,7FF9EA248308
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218088
-       mov       rdx,7FF9EA2482F0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218710
-       mov       rdx,7FF9EA248978
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183F8
-       mov       rdx,7FF9EA248660
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2187C0
-       mov       rdx,7FF9EA248A28
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183D0
-       mov       rdx,7FF9EA248638
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218088
-       mov       rdx,7FF9EA2482F0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183B8
-       mov       rdx,7FF9EA248620
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217A98
-       mov       rdx,7FF9EA247D00
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1BB04D2AF28
-       mov       rcx,1F5B88FB340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1BB04D2AF10
-       mov       rdx,1F5B88FB328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1BB04D2AF28
-       mov       rcx,1F5B88FB340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/30afc888-9652-47a7-9d2a-31e30ac70acb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8c260b7e-9833-4bec-af29-d9d60dd68622-diff.temp
index b781a3b..6551565 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8c260b7e-9833-4bec-af29-d9d60dd68622-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/30afc888-9652-47a7-9d2a-31e30ac70acb-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA100680]
+       mov       r11,7FF9E9CF0680
-       call      qword ptr [7FF9EA130680]
-       mov       r11,7FF9E9D20680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA130678]
-       mov       r11,7FF9E9D20678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217F00
-       mov       rdx,7FF9EA248428
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA130678]
-       mov       r11,7FF9E9D20678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DE0
-       mov       rdx,7FF9EA248308
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA2482F0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218450
-       mov       rdx,7FF9EA248978
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218138
-       mov       rdx,7FF9EA248660
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218500
-       mov       rdx,7FF9EA248A28
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218110
-       mov       rdx,7FF9EA248638
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA2482F0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180F8
-       mov       rdx,7FF9EA248620
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2177D8
-       mov       rdx,7FF9EA247D00
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F84CCF6F38
-       mov       rcx,1F5B88FB340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1F84CCF6F20
-       mov       rdx,1F5B88FB328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F84CCF6F38
-       mov       rcx,1F5B88FB340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/99a5a647-ca0b-4ae3-a3b1-c1f375fb5045-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b0202488-fc0e-4605-a8df-57a4e8700814-diff.temp
index b781a3b..daa09b8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b0202488-fc0e-4605-a8df-57a4e8700814-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/99a5a647-ca0b-4ae3-a3b1-c1f375fb5045-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2383C8
-       mov       rdx,7FF9EA238128
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2383B0
-       mov       rdx,7FF9EA238110
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238A38
-       mov       rdx,7FF9EA238798
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238720
-       mov       rdx,7FF9EA238480
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238AE8
-       mov       rdx,7FF9EA238848
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2386F8
-       mov       rdx,7FF9EA238458
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2383B0
-       mov       rdx,7FF9EA238110
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2386E0
-       mov       rdx,7FF9EA238440
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA237DC0
-       mov       rdx,7FF9EA237B20
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,17AB5A18F30
-       mov       rcx,1E2CE71B340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,17AB5A18F18
-       mov       rdx,1E2CE71B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,17AB5A18F30
-       mov       rcx,1E2CE71B340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4bf8a3bd-0928-438d-8350-7a819170fc07-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/92303547-9d68-41cd-bcb5-763516a1431d-diff.temp
index 7d05bd7..9c1ddc7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/92303547-9d68-41cd-bcb5-763516a1431d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4bf8a3bd-0928-438d-8350-7a819170fc07-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238340
-       mov       rdx,7FF9EA238128
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238328
-       mov       rdx,7FF9EA238110
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2389B0
-       mov       rdx,7FF9EA238798
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238698
-       mov       rdx,7FF9EA238480
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238A60
-       mov       rdx,7FF9EA238848
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238670
-       mov       rdx,7FF9EA238458
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238328
-       mov       rdx,7FF9EA238110
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238658
-       mov       rdx,7FF9EA238440
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA237D38
-       mov       rdx,7FF9EA237B20
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,27CA052B340
-       mov       rcx,1E2CE71B340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,27CA052B328
-       mov       rdx,1E2CE71B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,27CA052B340
-       mov       rcx,1E2CE71B340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3fa05242-dc90-4c9d-9e80-77c0a10c0717-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f636ca1-c57f-4fec-8cff-af6081748222-diff.temp
index 7d05bd7..63205b2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f636ca1-c57f-4fec-8cff-af6081748222-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3fa05242-dc90-4c9d-9e80-77c0a10c0717-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA100680]
+       mov       r11,7FF9E9CF0680
-       call      qword ptr [7FF9EA120680]
-       mov       r11,7FF9E9D10680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2181C0
-       mov       rdx,7FF9EA238248
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180A0
-       mov       rdx,7FF9EA238128
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218088
-       mov       rdx,7FF9EA238110
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218710
-       mov       rdx,7FF9EA238798
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183F8
-       mov       rdx,7FF9EA238480
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2187C0
-       mov       rdx,7FF9EA238848
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183D0
-       mov       rdx,7FF9EA238458
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218088
-       mov       rdx,7FF9EA238110
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183B8
-       mov       rdx,7FF9EA238440
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217A98
-       mov       rdx,7FF9EA237B20
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1BB04D2AF28
-       mov       rcx,1E2CE71B340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1BB04D2AF10
-       mov       rdx,1E2CE71B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1BB04D2AF28
-       mov       rcx,1E2CE71B340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dbf94317-d507-4fc2-a818-451a2e3cf2f4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f57d501-95d4-4455-9724-4e37c1727c3c-diff.temp
index 7d05bd7..6551565 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4f57d501-95d4-4455-9724-4e37c1727c3c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dbf94317-d507-4fc2-a818-451a2e3cf2f4-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA100680]
+       mov       r11,7FF9E9CF0680
-       call      qword ptr [7FF9EA120680]
-       mov       r11,7FF9E9D10680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217F00
-       mov       rdx,7FF9EA238248
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DE0
-       mov       rdx,7FF9EA238128
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA238110
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218450
-       mov       rdx,7FF9EA238798
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218138
-       mov       rdx,7FF9EA238480
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218500
-       mov       rdx,7FF9EA238848
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218110
-       mov       rdx,7FF9EA238458
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA238110
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180F8
-       mov       rdx,7FF9EA238440
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2177D8
-       mov       rdx,7FF9EA237B20
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F84CCF6F38
-       mov       rcx,1E2CE71B340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1F84CCF6F20
-       mov       rdx,1E2CE71B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F84CCF6F38
-       mov       rcx,1E2CE71B340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/42267a69-d777-41fc-ae6b-39c1021f9436-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a6eb3eb-1c91-4938-8149-49f6fec0f34f-diff.temp
index 7d05bd7..daa09b8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a6eb3eb-1c91-4938-8149-49f6fec0f34f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/42267a69-d777-41fc-ae6b-39c1021f9436-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238340
-       mov       rdx,7FF9EA2383C8
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238328
-       mov       rdx,7FF9EA2383B0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2389B0
-       mov       rdx,7FF9EA238A38
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238698
-       mov       rdx,7FF9EA238720
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238A60
-       mov       rdx,7FF9EA238AE8
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238670
-       mov       rdx,7FF9EA2386F8
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238328
-       mov       rdx,7FF9EA2383B0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA238658
-       mov       rdx,7FF9EA2386E0
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA237D38
-       mov       rdx,7FF9EA237DC0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,27CA052B340
-       mov       rcx,17AB5A18F30
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,27CA052B328
-       mov       rdx,17AB5A18F18
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,27CA052B340
-       mov       rcx,17AB5A18F30
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2b716786-f74f-4864-81d0-d54c0d07733e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0b13ca3f-78c2-4c6d-8572-57c558e6c4db-diff.temp
index 9c1ddc7..63205b2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0b13ca3f-78c2-4c6d-8572-57c558e6c4db-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2b716786-f74f-4864-81d0-d54c0d07733e-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA100680]
+       mov       r11,7FF9E9CF0680
-       call      qword ptr [7FF9EA120680]
-       mov       r11,7FF9E9D10680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2181C0
-       mov       rdx,7FF9EA2384E8
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180A0
-       mov       rdx,7FF9EA2383C8
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218088
-       mov       rdx,7FF9EA2383B0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218710
-       mov       rdx,7FF9EA238A38
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183F8
-       mov       rdx,7FF9EA238720
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2187C0
-       mov       rdx,7FF9EA238AE8
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183D0
-       mov       rdx,7FF9EA2386F8
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218088
-       mov       rdx,7FF9EA2383B0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183B8
-       mov       rdx,7FF9EA2386E0
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217A98
-       mov       rdx,7FF9EA237DC0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1BB04D2AF28
-       mov       rcx,17AB5A18F30
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1BB04D2AF10
-       mov       rdx,17AB5A18F18
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1BB04D2AF28
-       mov       rcx,17AB5A18F30
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/087c6b39-707a-4be0-8e6b-1cdd0bd6facf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e8d6e7ce-0879-44ae-8262-f9d88dcc051d-diff.temp
index 9c1ddc7..6551565 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e8d6e7ce-0879-44ae-8262-f9d88dcc051d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/087c6b39-707a-4be0-8e6b-1cdd0bd6facf-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA100680]
+       mov       r11,7FF9E9CF0680
-       call      qword ptr [7FF9EA120680]
-       mov       r11,7FF9E9D10680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217F00
-       mov       rdx,7FF9EA2384E8
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DE0
-       mov       rdx,7FF9EA2383C8
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA2383B0
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218450
-       mov       rdx,7FF9EA238A38
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218138
-       mov       rdx,7FF9EA238720
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218500
-       mov       rdx,7FF9EA238AE8
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218110
-       mov       rdx,7FF9EA2386F8
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA2383B0
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180F8
-       mov       rdx,7FF9EA2386E0
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2177D8
-       mov       rdx,7FF9EA237DC0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F84CCF6F38
-       mov       rcx,17AB5A18F30
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1F84CCF6F20
-       mov       rdx,17AB5A18F18
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F84CCF6F38
-       mov       rcx,17AB5A18F30
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/066739dd-e3b1-44b6-bad8-f215a3dd91e7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/16d4b0e1-d9b3-4013-bec5-9fd366ef1eea-diff.temp
index 9c1ddc7..daa09b8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/16d4b0e1-d9b3-4013-bec5-9fd366ef1eea-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/066739dd-e3b1-44b6-bad8-f215a3dd91e7-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA100680]
+       mov       r11,7FF9E9CF0680
-       call      qword ptr [7FF9EA120680]
-       mov       r11,7FF9E9D10680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2181C0
-       mov       rdx,7FF9EA238460
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180A0
-       mov       rdx,7FF9EA238340
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218088
-       mov       rdx,7FF9EA238328
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218710
-       mov       rdx,7FF9EA2389B0
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183F8
-       mov       rdx,7FF9EA238698
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2187C0
-       mov       rdx,7FF9EA238A60
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183D0
-       mov       rdx,7FF9EA238670
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218088
-       mov       rdx,7FF9EA238328
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2183B8
-       mov       rdx,7FF9EA238658
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217A98
-       mov       rdx,7FF9EA237D38
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1BB04D2AF28
-       mov       rcx,27CA052B340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1BB04D2AF10
-       mov       rdx,27CA052B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1BB04D2AF28
-       mov       rcx,27CA052B340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed92016b-6c31-4e75-b470-63a8691c405d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0a20593f-d9e1-48ad-8a93-f0049a18c6cf-diff.temp
index 63205b2..6551565 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0a20593f-d9e1-48ad-8a93-f0049a18c6cf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed92016b-6c31-4e75-b470-63a8691c405d-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFC8]
        mov       rax,r12
+       call      qword ptr [7FF9EA100680]
+       mov       r11,7FF9E9CF0680
-       call      qword ptr [7FF9EA120680]
-       mov       r11,7FF9E9D10680
        mov       rcx,[rbp+0FFA8]
 M02_L26:
        jne       short M02_L23
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
        mov       r9d,2
        mov       r8,rbx
        mov       rcx,r12
        mov       rdx,rax
        call      qword ptr [rax+18]
        mov       rdx,rbx
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFA8]
 M02_L25:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217F00
-       mov       rdx,7FF9EA238460
        mov       rcx,rsi
 M02_L24:
        jmp       short M02_L25
        je        short M02_L24
        test      r11,r11
        mov       r11,[rcx+58]
        jle       short M02_L24
        cmp       qword ptr [rcx+10],58
        mov       rcx,[rsi+10]
 M02_L23:
        je        short M02_L26
        test      eax,eax
+       call      qword ptr [7FF9EA100678]
+       mov       r11,7FF9E9CF0678
-       call      qword ptr [7FF9EA120678]
-       mov       r11,7FF9E9D10678
        mov       rcx,[rbp+0FFA8]
        mov       [rbp+0FFA8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DE0
-       mov       rdx,7FF9EA238340
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA238328
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218450
-       mov       rdx,7FF9EA2389B0
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218138
-       mov       rdx,7FF9EA238698
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218500
-       mov       rdx,7FF9EA238A60
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218110
-       mov       rdx,7FF9EA238670
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA238328
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180F8
-       mov       rdx,7FF9EA238658
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2177D8
-       mov       rdx,7FF9EA237D38
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F84CCF6F38
-       mov       rcx,27CA052B340
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1F84CCF6F20
-       mov       rdx,27CA052B328
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F84CCF6F38
-       mov       rcx,27CA052B340
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b941144e-d9f1-4ac3-aeb9-1cbdc5011be8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c7b75a1e-1a8a-4c80-8512-b5adee0003e2-diff.temp
index 63205b2..daa09b8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c7b75a1e-1a8a-4c80-8512-b5adee0003e2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b941144e-d9f1-4ac3-aeb9-1cbdc5011be8-diff.temp
```
**Diff for ToDictionary01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L22:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DE0
-       mov       rdx,7FF9EA2180A0
        mov       rcx,rsi
 M02_L21:
        jmp       short M02_L22
        je        short M02_L21
        test      r11,r11
        mov       r11,[rcx+50]
        jle       short M02_L21
        cmp       qword ptr [rcx+10],50
        mov       rcx,[rsi+10]
        call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
        mov       r8,r14
        mov       edx,r15d
        mov       rcx,r12
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
 M02_L20:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA218088
        mov       rcx,rsi
 M02_L19:
        jmp       short M02_L20
        je        short M02_L19
        test      rcx,rcx
        mov       rcx,[rcx+48]
        jle       short M02_L19
        cmp       qword ptr [rcx+10],48
        mov       rcx,[rsi+10]
 M02_L17:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218450
-       mov       rdx,7FF9EA218710
        mov       rcx,rsi
 M02_L16:
        jmp       short M02_L17
        je        short M02_L16
        test      rcx,rcx
        mov       rcx,[rcx+78]
        jle       short M02_L16
        cmp       qword ptr [rbp+0FFB8],78
        mov       rcx,r13
        je        short M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,r12
 M02_L15:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218138
-       mov       rdx,7FF9EA2183F8
        mov       rcx,rsi
 M02_L14:
        jmp       short M02_L15
        je        short M02_L14
        test      rcx,rcx
        mov       rcx,[rcx+70]
        jle       short M02_L14
        cmp       qword ptr [rbp+0FFB8],70
        mov       rcx,r13
        mov       rax,[rbp+0FFB0]
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218500
-       mov       rdx,7FF9EA2187C0
        mov       rcx,rsi
 M02_L11:
        jmp       short M02_L11
        mov       [rbp+0FFB0],rax
 M02_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA218110
-       mov       rdx,7FF9EA2183D0
        mov       rcx,rsi
 M02_L07:
        jmp       short M02_L08
        je        short M02_L07
        test      rcx,rcx
        mov       rcx,[rcx+68]
        jle       short M02_L07
        cmp       rax,68
        mov       [rbp+0FFB8],rax
        mov       rax,rdx
        mov       rdx,[rcx+10]
        mov       rcx,r13
        mov       r13,rcx
        mov       rcx,[rsi+10]
 M02_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA217DC8
-       mov       rdx,7FF9EA218088
        mov       rcx,rsi
 M02_L04:
        jmp       short M02_L05
        je        short M02_L04
        test      rcx,rcx
        mov       rcx,[r15+48]
        jle       short M02_L04
        cmp       rbx,48
        mov       rbx,[r15+10]
        mov       r15,[rsi+10]
        jne       short M02_L06
        test      r15d,r15d
        mov       r15d,eax
        call      qword ptr [r11]
        mov       rcx,r12
 M02_L03:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2180F8
-       mov       rdx,7FF9EA2183B8
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      r11,r11
        mov       r11,[rcx+60]
        jle       short M02_L02
        cmp       qword ptr [rcx+10],60
        mov       rcx,[rsi+10]
        je        near ptr M02_L18
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFINTERFACE
        mov       rdx,rbx
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF9EA2177D8
-       mov       rdx,7FF9EA217A98
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rcx+40]
        jle       short M02_L00
        cmp       qword ptr [rcx+10],40
        mov       rcx,[rsi+10]
        xor       r15d,r15d
        je        near ptr M02_L28
        test      rdi,rdi
        je        near ptr M02_L27
        test      rbx,rbx
        mov       r14,r9
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFA0],rsp
        lea       rbp,[rsp+80]
        sub       rsp,48
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
 ; Total bytes of code 5
        ret
        mov       rax,[rdx+30]
 ; 			                                                     ^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
 ; Total bytes of code 169
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F84CCF6F38
-       mov       rcx,1BB04D2AF28
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        je        short M00_L01
        test      rdx,rdx
        mov       rdx,[rdx]
+       mov       rdx,1F84CCF6F20
-       mov       rdx,1BB04D2AF10
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F84CCF6F38
-       mov       rcx,1BB04D2AF28
        mov       rdi,[rsi+160]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToDictionary(p => p.Email);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7d16574a-b234-489d-b7df-1be882a8bbc3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b19d3d32-ebf4-4e85-83b5-6618b88eadca-diff.temp
index 6551565..daa09b8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b19d3d32-ebf4-4e85-83b5-6618b88eadca-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7d16574a-b234-489d-b7df-1be882a8bbc3-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d743056d-1495-4455-bd03-25fbe527c9bc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eb67afae-0bb0-4f5f-9fdb-ac618d7c98e6-diff.temp
index 3690ee8..b8a174b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eb67afae-0bb0-4f5f-9fdb-ac618d7c98e6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d743056d-1495-4455-bd03-25fbe527c9bc-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2d191e3f-f4ef-4c5c-bffe-8fc92a3b9f80-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5e62df3a-18ec-4e74-bc5b-ea0d4512a826-diff.temp
index 3690ee8..3695f85 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5e62df3a-18ec-4e74-bc5b-ea0d4512a826-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2d191e3f-f4ef-4c5c-bffe-8fc92a3b9f80-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c516acc3-f473-4a6e-9f69-8322c54f001e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d4d627da-6ad6-4620-8ecb-9dce626fc67e-diff.temp
index 3690ee8..8dd394a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d4d627da-6ad6-4620-8ecb-9dce626fc67e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c516acc3-f473-4a6e-9f69-8322c54f001e-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fa77d967-97fd-4530-81d4-0d471d5b35e7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f367aa4d-87ca-483e-8b79-990568b8e979-diff.temp
index 3690ee8..c2710e9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f367aa4d-87ca-483e-8b79-990568b8e979-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fa77d967-97fd-4530-81d4-0d471d5b35e7-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/13944ab8-a5ca-40a5-bfa6-6bf632f23dfc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b2f27c3a-7708-44c1-aabe-a62e94581a27-diff.temp
index 3690ee8..dfc782f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b2f27c3a-7708-44c1-aabe-a62e94581a27-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/13944ab8-a5ca-40a5-bfa6-6bf632f23dfc-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f30f0c9b-8bb3-4e29-b25a-feb7cc35de04-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/449fe679-383f-42be-b17b-74b7fb090c6a-diff.temp
index 3690ee8..522869e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/449fe679-383f-42be-b17b-74b7fb090c6a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f30f0c9b-8bb3-4e29-b25a-feb7cc35de04-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/95feac5a-1ff8-49ba-b938-f827ff96ae82-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/77d61c46-8364-4a42-bd97-36a5c4a58411-diff.temp
index b8a174b..3695f85 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/77d61c46-8364-4a42-bd97-36a5c4a58411-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/95feac5a-1ff8-49ba-b938-f827ff96ae82-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c64a0705-b835-406d-8da2-f928b1112809-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/03dbc28b-6d99-4abb-af4d-534e7751e1d8-diff.temp
index b8a174b..8dd394a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/03dbc28b-6d99-4abb-af4d-534e7751e1d8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c64a0705-b835-406d-8da2-f928b1112809-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e0cbf41-4c30-411d-996d-c76a587d532f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b9cd0202-e3b9-404f-b6f3-dd954c257e46-diff.temp
index b8a174b..c2710e9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b9cd0202-e3b9-404f-b6f3-dd954c257e46-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e0cbf41-4c30-411d-996d-c76a587d532f-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/95b11678-8e03-4818-9db4-2a38a0bbd212-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/30c7c833-9770-4e6b-b6ad-b030d9e54d72-diff.temp
index b8a174b..dfc782f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/30c7c833-9770-4e6b-b6ad-b030d9e54d72-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/95b11678-8e03-4818-9db4-2a38a0bbd212-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d2346345-bb74-45a2-bb19-bd99813b2e23-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e7edd34-c0ae-43cb-a7ae-0fb868bd8af7-diff.temp
index b8a174b..522869e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e7edd34-c0ae-43cb-a7ae-0fb868bd8af7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d2346345-bb74-45a2-bb19-bd99813b2e23-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8052c80e-fe14-4fd2-92fb-349375e2f385-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/be5968ea-d9cb-495a-8e44-235759b8a352-diff.temp
index 3695f85..8dd394a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/be5968ea-d9cb-495a-8e44-235759b8a352-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8052c80e-fe14-4fd2-92fb-349375e2f385-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c7586d12-d3d9-485c-bcea-9fa6f0b1f837-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1856bce8-5194-472d-b4b4-c9da3fb96f61-diff.temp
index 3695f85..c2710e9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1856bce8-5194-472d-b4b4-c9da3fb96f61-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c7586d12-d3d9-485c-bcea-9fa6f0b1f837-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/de08bce0-7312-4210-aa6b-3ffe2c0737e4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5471ea36-cf16-4ea4-bd5b-e8fb4c1f5855-diff.temp
index 3695f85..dfc782f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5471ea36-cf16-4ea4-bd5b-e8fb4c1f5855-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/de08bce0-7312-4210-aa6b-3ffe2c0737e4-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/be90adcd-4fb0-464a-b3d2-f9e9979cc885-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/98330005-7592-4837-8a57-07dc981be520-diff.temp
index 3695f85..522869e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/98330005-7592-4837-8a57-07dc981be520-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/be90adcd-4fb0-464a-b3d2-f9e9979cc885-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/784bbda6-5b05-4dc3-b2ce-407d798faf3d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/55310977-9846-4d90-a899-06b549a54849-diff.temp
index 8dd394a..c2710e9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/55310977-9846-4d90-a899-06b549a54849-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/784bbda6-5b05-4dc3-b2ce-407d798faf3d-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f43e4bfb-9167-4172-a64f-65ffcddd9baf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6e7b155d-ac72-4974-87f4-0934114c7311-diff.temp
index 8dd394a..dfc782f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6e7b155d-ac72-4974-87f4-0934114c7311-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f43e4bfb-9167-4172-a64f-65ffcddd9baf-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/17123c75-8e09-4f9e-bfb2-1c6237308cce-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4485a8e4-9fe6-496a-a553-3dbb415c1bc7-diff.temp
index 8dd394a..522869e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4485a8e4-9fe6-496a-a553-3dbb415c1bc7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/17123c75-8e09-4f9e-bfb2-1c6237308cce-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e29be6df-4134-40c4-a9e9-8b8dd73c4baf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/11b0298a-e900-4efc-bff5-6a2ec6ad8972-diff.temp
index c2710e9..dfc782f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/11b0298a-e900-4efc-bff5-6a2ec6ad8972-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e29be6df-4134-40c4-a9e9-8b8dd73c4baf-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c5f50a59-e704-4184-bfcd-07ba99441aab-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e246dc8-337c-4d91-9b26-ada5f977fbd2-diff.temp
index c2710e9..522869e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e246dc8-337c-4d91-9b26-ada5f977fbd2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c5f50a59-e704-4184-bfcd-07ba99441aab-diff.temp
```
**Diff for ToLinkedList01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8a45df5e-4394-4038-b288-86be2ed7bf83-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/34f74ad4-dd65-49fb-9d38-38a558813ffe-diff.temp
index dfc782f..522869e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/34f74ad4-dd65-49fb-9d38-38a558813ffe-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8a45df5e-4394-4038-b288-86be2ed7bf83-diff.temp
```
