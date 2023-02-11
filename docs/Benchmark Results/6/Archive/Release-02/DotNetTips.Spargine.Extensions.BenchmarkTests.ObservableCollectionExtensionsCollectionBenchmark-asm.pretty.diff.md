## DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark-20220802-041436
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793CA00
-       mov       rdx,7FFB4791CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0a52ff42-286a-46f4-bf94-71323cf0bcd5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/071027ce-e95a-4dc3-ac92-c4a546c9d1e1-diff.temp
index 8535965..b19aecc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/071027ce-e95a-4dc3-ac92-c4a546c9d1e1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0a52ff42-286a-46f4-bf94-71323cf0bcd5-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793CA00
-       mov       rdx,7FFB4791CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e0ae1c4f-575e-40e6-86f3-50043be3e388-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a3051da0-9679-4cb9-bec8-9d487f9abfbd-diff.temp
index 8535965..b19aecc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a3051da0-9679-4cb9-bec8-9d487f9abfbd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e0ae1c4f-575e-40e6-86f3-50043be3e388-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792CA00
-       mov       rdx,7FFB4791CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d559e409-97d2-49bf-84c2-72b59d4851b3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/038c4f44-9c7a-4ecc-b8ca-2ad25edcc35f-diff.temp
index 8535965..a0ff553 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/038c4f44-9c7a-4ecc-b8ca-2ad25edcc35f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d559e409-97d2-49bf-84c2-72b59d4851b3-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1162eb58-e670-4c90-9a39-2cd162cee67b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d655f39e-aa6d-46f9-bff2-27e309fc841d-diff.temp
index 8535965..07795a2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d655f39e-aa6d-46f9-bff2-27e309fc841d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1162eb58-e670-4c90-9a39-2cd162cee67b-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791C7B8
-       mov       rdx,7FFB4791CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/653f1a80-7ab2-4d16-a4e9-eb8e0a907ce2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/58f26e1b-2d4a-4baf-9699-fe456eaa1a81-diff.temp
index 8535965..5c367fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/58f26e1b-2d4a-4baf-9699-fe456eaa1a81-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/653f1a80-7ab2-4d16-a4e9-eb8e0a907ce2-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793CA00
-       mov       rdx,7FFB4791CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c597d9cd-71b6-46fb-a247-5b40913e9a0f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dc3e9d5f-c21c-4691-a095-095a2f6358fb-diff.temp
index 8535965..b19aecc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dc3e9d5f-c21c-4691-a095-095a2f6358fb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c597d9cd-71b6-46fb-a247-5b40913e9a0f-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793CA00
-       mov       rdx,7FFB4791CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/113ca99c-d8eb-4038-89c3-c879cb2a9b19-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/90543f00-f66b-4aba-8197-3d5d446419f1-diff.temp
index 8535965..b19aecc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/90543f00-f66b-4aba-8197-3d5d446419f1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/113ca99c-d8eb-4038-89c3-c879cb2a9b19-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792CA00
-       mov       rdx,7FFB4791CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e9994d6b-6a14-420d-8126-4d3cd13a1d74-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/12e8648b-6b7c-47e8-9c6d-3cc56d318888-diff.temp
index 8535965..a0ff553 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/12e8648b-6b7c-47e8-9c6d-3cc56d318888-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e9994d6b-6a14-420d-8126-4d3cd13a1d74-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/73a9f641-0fa0-4caf-968d-338264b4471e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d23bc263-c9f5-4cb9-8fdb-9982fedfa135-diff.temp
index 8535965..07795a2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d23bc263-c9f5-4cb9-8fdb-9982fedfa135-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/73a9f641-0fa0-4caf-968d-338264b4471e-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791C7B8
-       mov       rdx,7FFB4791CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/16010164-cc04-4ebc-8098-5ce24c0f1745-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c7b7c093-2fcf-4ce8-9123-0a97d3d1c7c6-diff.temp
index 8535965..5c367fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c7b7c093-2fcf-4ce8-9123-0a97d3d1c7c6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/16010164-cc04-4ebc-8098-5ce24c0f1745-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791CA00
-       mov       rdx,7FFB4793CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/571dc9e7-a932-420c-983e-9aa1bd47b731-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e3c50df4-38de-4e79-9687-7a72b68f769f-diff.temp
index b19aecc..8535965 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e3c50df4-38de-4e79-9687-7a72b68f769f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/571dc9e7-a932-420c-983e-9aa1bd47b731-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792CA00
-       mov       rdx,7FFB4793CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6404df6c-dd7b-4aa2-88f1-e5630ba3025e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e6c78737-75fc-4ed5-aa47-4c93dbb46512-diff.temp
index b19aecc..a0ff553 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e6c78737-75fc-4ed5-aa47-4c93dbb46512-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6404df6c-dd7b-4aa2-88f1-e5630ba3025e-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C800
-       mov       rdx,7FFB4793CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/979e0ef8-17bc-426b-9271-2a35d25d93ab-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/06522a54-de4e-4f1d-8b3c-542a44ab35ae-diff.temp
index b19aecc..07795a2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/06522a54-de4e-4f1d-8b3c-542a44ab35ae-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/979e0ef8-17bc-426b-9271-2a35d25d93ab-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791C7B8
-       mov       rdx,7FFB4793CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2e953078-fb7a-4763-b98e-b4e409d776a9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/64a8ecdc-7ead-4b74-8a6c-8cc94411a7d2-diff.temp
index b19aecc..5c367fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/64a8ecdc-7ead-4b74-8a6c-8cc94411a7d2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2e953078-fb7a-4763-b98e-b4e409d776a9-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791CA00
-       mov       rdx,7FFB4793CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8b651296-2a9d-48d4-afb5-011302cf6ba6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/701c5cea-e96a-464b-9059-144fe20eb5b0-diff.temp
index b19aecc..8535965 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/701c5cea-e96a-464b-9059-144fe20eb5b0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8b651296-2a9d-48d4-afb5-011302cf6ba6-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792CA00
-       mov       rdx,7FFB4793CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e1c8b465-ec48-4563-bc54-6bc7f8d7c454-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/56d6465a-b792-4f36-ad25-d0dd672d81d2-diff.temp
index b19aecc..a0ff553 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/56d6465a-b792-4f36-ad25-d0dd672d81d2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e1c8b465-ec48-4563-bc54-6bc7f8d7c454-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C800
-       mov       rdx,7FFB4793CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cca5a143-e744-4605-a3ba-cb95cd838727-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9ebbab10-6687-4a1d-a3d0-843c7f79421d-diff.temp
index b19aecc..07795a2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9ebbab10-6687-4a1d-a3d0-843c7f79421d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cca5a143-e744-4605-a3ba-cb95cd838727-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791C7B8
-       mov       rdx,7FFB4793CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8161e0e4-dff9-4387-b99b-542b3d7123db-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61afa36b-2116-4d98-bc9a-815c4f0a7543-diff.temp
index b19aecc..5c367fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61afa36b-2116-4d98-bc9a-815c4f0a7543-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8161e0e4-dff9-4387-b99b-542b3d7123db-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792CA00
-       mov       rdx,7FFB4791CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/508e5996-724d-414d-a29e-a6da0275629b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1e119bd3-4518-44ef-aa50-a42e7ddd4b15-diff.temp
index 8535965..a0ff553 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1e119bd3-4518-44ef-aa50-a42e7ddd4b15-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/508e5996-724d-414d-a29e-a6da0275629b-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2c4df5c7-4758-4c1c-a7fd-4eb99530aec1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3f563ac4-3fd4-4bae-ab6c-9db17be33678-diff.temp
index 8535965..07795a2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3f563ac4-3fd4-4bae-ab6c-9db17be33678-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2c4df5c7-4758-4c1c-a7fd-4eb99530aec1-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791C7B8
-       mov       rdx,7FFB4791CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/630d8410-6d33-4633-bcdd-f4dd3e02ba05-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c9cae311-d98f-44b2-9b69-96d56ea7f1ff-diff.temp
index 8535965..5c367fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c9cae311-d98f-44b2-9b69-96d56ea7f1ff-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/630d8410-6d33-4633-bcdd-f4dd3e02ba05-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C800
-       mov       rdx,7FFB4792CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/471e88e1-e2ca-429d-ae90-60a3c27963bf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1888e712-0ffb-4b16-9aeb-c291ea1acab8-diff.temp
index a0ff553..07795a2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1888e712-0ffb-4b16-9aeb-c291ea1acab8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/471e88e1-e2ca-429d-ae90-60a3c27963bf-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791C7B8
-       mov       rdx,7FFB4792CA00
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d45c4038-b2d7-468e-adab-199f04bb9013-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5d0d4af7-97ad-4fa6-9991-2553262cfc52-diff.temp
index a0ff553..5c367fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5d0d4af7-97ad-4fa6-9991-2553262cfc52-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d45c4038-b2d7-468e-adab-199f04bb9013-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791C7B8
-       mov       rdx,7FFB4792C800
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/85f12053-1555-4e56-b727-7440926c9482-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9cac1f8e-b7d3-470d-86d8-34fa3c18001c-diff.temp
index 07795a2..5c367fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9cac1f8e-b7d3-470d-86d8-34fa3c18001c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/85f12053-1555-4e56-b727-7440926c9482-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB47890800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478C0800]
-       mov       r11,7FFB47260800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478907F8]
+       mov       r11,7FFB472307F8
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790DD78
-       mov       rdx,7FFB4793DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478907F8]
+       mov       r11,7FFB472307F8
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790DCA0
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47885C80]
+       vdivsd    xmm0,xmm0,[7FFB47885C78]
-       vucomisd  xmm0,qword ptr [7FFB478B5C80]
-       vdivsd    xmm0,xmm0,[7FFB478B5C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2EA2300D2E0
-       mov       rcx,238D4A08ED8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,2EA2300D2D8
-       mov       rdx,238D4A08ED0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2EA2300D2E0
-       mov       rcx,238D4A08ED8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1d05106c-f86b-4477-a87a-91b732c17124-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9894cd73-5cc1-41dd-8bc4-3a6b2b07036a-diff.temp
index e46ec0b..e3efca5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9894cd73-5cc1-41dd-8bc4-3a6b2b07036a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1d05106c-f86b-4477-a87a-91b732c17124-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB47890800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478C0800]
-       mov       r11,7FFB47260800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478907F8]
+       mov       r11,7FFB472307F8
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790DD78
-       mov       rdx,7FFB4793DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478907F8]
+       mov       r11,7FFB472307F8
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790DCA0
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47886020]
+       vdivsd    xmm0,xmm0,[7FFB47886018]
-       vucomisd  xmm0,qword ptr [7FFB478B5C80]
-       vdivsd    xmm0,xmm0,[7FFB478B5C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23985ECD2E0
-       mov       rcx,238D4A08ED8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,23985ECD2D8
-       mov       rdx,238D4A08ED0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23985ECD2E0
-       mov       rcx,238D4A08ED8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/feea6d57-c326-45b3-8e65-45939b6a6098-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/da550a3f-8225-4efa-b645-00774800a5b2-diff.temp
index e46ec0b..f6fb649 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/da550a3f-8225-4efa-b645-00774800a5b2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/feea6d57-c326-45b3-8e65-45939b6a6098-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478D0800]
+       mov       r11,7FFB47270800
-       call      qword ptr [7FFB478C0800]
-       mov       r11,7FFB47260800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DD78
-       mov       rdx,7FFB4793DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DCA0
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C6020]
+       vdivsd    xmm0,xmm0,[7FFB478C6018]
-       vucomisd  xmm0,qword ptr [7FFB478B5C80]
-       vdivsd    xmm0,xmm0,[7FFB478B5C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1EFA239B2E8
-       mov       rcx,238D4A08ED8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1EFA239B2E0
-       mov       rdx,238D4A08ED0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1EFA239B2E8
-       mov       rcx,238D4A08ED8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b0381c0c-60c0-4e9e-aa12-483fc2c2ed71-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f84bb81d-65d3-4700-9fe3-6b2efdf71a02-diff.temp
index e46ec0b..b67fc2c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f84bb81d-65d3-4700-9fe3-6b2efdf71a02-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b0381c0c-60c0-4e9e-aa12-483fc2c2ed71-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478D0800]
+       mov       r11,7FFB47270800
-       call      qword ptr [7FFB478C0800]
-       mov       r11,7FFB47260800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DD78
-       mov       rdx,7FFB4793DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DCA0
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C6020]
+       vdivsd    xmm0,xmm0,[7FFB478C6018]
-       vucomisd  xmm0,qword ptr [7FFB478B5C80]
-       vdivsd    xmm0,xmm0,[7FFB478B5C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F23ACB8ED8
-       mov       rcx,238D4A08ED8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1F23ACB8ED0
-       mov       rdx,238D4A08ED0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F23ACB8ED8
-       mov       rcx,238D4A08ED8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74d88bc0-51e2-43a4-b5bb-f8879338cceb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/617d716c-0158-495c-87ab-737ae3765db9-diff.temp
index e46ec0b..7096731 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/617d716c-0158-495c-87ab-737ae3765db9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74d88bc0-51e2-43a4-b5bb-f8879338cceb-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478D0800]
+       mov       r11,7FFB47270800
-       call      qword ptr [7FFB478C0800]
-       mov       r11,7FFB47260800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DD78
-       mov       rdx,7FFB4793DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DCA0
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C5C80]
+       vdivsd    xmm0,xmm0,[7FFB478C5C78]
-       vucomisd  xmm0,qword ptr [7FFB478B5C80]
-       vdivsd    xmm0,xmm0,[7FFB478B5C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,277B07DD2E0
-       mov       rcx,238D4A08ED8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,277B07DD2D8
-       mov       rdx,238D4A08ED0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,277B07DD2E0
-       mov       rcx,238D4A08ED8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1d78cd0e-b146-4d1a-af04-b8e745606032-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4b30f57a-758f-4ad6-bf71-f66f22666b9d-diff.temp
index e46ec0b..a802cf4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4b30f57a-758f-4ad6-bf71-f66f22666b9d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1d78cd0e-b146-4d1a-af04-b8e745606032-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB47890908]
+       mov       r11,7FFB47230908
-       call      qword ptr [7FFB478C0800]
-       mov       r11,7FFB47260800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949258
-       mov       rdx,7FFB4793DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949180
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47889060]
+       vdivsd    xmm0,xmm0,[7FFB47889058]
-       vucomisd  xmm0,qword ptr [7FFB478B5C80]
-       vdivsd    xmm0,xmm0,[7FFB478B5C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23C289AD2E0
-       mov       rcx,238D4A08ED8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,23C289AD2D8
-       mov       rdx,238D4A08ED0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23C289AD2E0
-       mov       rcx,238D4A08ED8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0294f89d-c687-47f5-ae1f-8ac9f5d043e7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/262f56f8-7105-4dad-a9e0-1df27c32e8f9-diff.temp
index e46ec0b..b0e1943 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/262f56f8-7105-4dad-a9e0-1df27c32e8f9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0294f89d-c687-47f5-ae1f-8ac9f5d043e7-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478B0908]
+       mov       r11,7FFB47250908
-       call      qword ptr [7FFB478C0800]
-       mov       r11,7FFB47260800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969100
-       mov       rdx,7FFB4793DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478C07F8]
-       mov       r11,7FFB472607F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969028
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A8EE0]
+       vdivsd    xmm0,xmm0,[7FFB478A8ED8]
-       vucomisd  xmm0,qword ptr [7FFB478B5C80]
-       vdivsd    xmm0,xmm0,[7FFB478B5C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,238D4A08ED8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E9CBDCD2D8
-       mov       rdx,238D4A08ED0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,238D4A08ED8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ad2c7dac-7b86-4947-bced-5976a8fcf1be-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7810ad05-c5f6-4a55-88d7-44cc2a188baf-diff.temp
index e46ec0b..7e851ff 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7810ad05-c5f6-4a55-88d7-44cc2a188baf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ad2c7dac-7b86-4947-bced-5976a8fcf1be-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23985ECD2E0
-       mov       rcx,2EA2300D2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,23985ECD2D8
-       mov       rdx,2EA2300D2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23985ECD2E0
-       mov       rcx,2EA2300D2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0d2cc115-2adc-4ec9-a1ac-63f5761a104d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c3e4c2a4-1f75-4d77-97a3-8efefc5f5b52-diff.temp
index e3efca5..f6fb649 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c3e4c2a4-1f75-4d77-97a3-8efefc5f5b52-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0d2cc115-2adc-4ec9-a1ac-63f5761a104d-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478D0800]
+       mov       r11,7FFB47270800
-       call      qword ptr [7FFB47890800]
-       mov       r11,7FFB47230800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DD78
-       mov       rdx,7FFB4790DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DCA0
-       mov       rdx,7FFB4790DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C6020]
+       vdivsd    xmm0,xmm0,[7FFB478C6018]
-       vucomisd  xmm0,qword ptr [7FFB47885C80]
-       vdivsd    xmm0,xmm0,[7FFB47885C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1EFA239B2E8
-       mov       rcx,2EA2300D2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1EFA239B2E0
-       mov       rdx,2EA2300D2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1EFA239B2E8
-       mov       rcx,2EA2300D2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c6e02539-76c4-48d1-a2bf-23d033bd72c1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/829b5a2f-96b3-4785-a24e-eab0863ec197-diff.temp
index e3efca5..b67fc2c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/829b5a2f-96b3-4785-a24e-eab0863ec197-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c6e02539-76c4-48d1-a2bf-23d033bd72c1-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478D0800]
+       mov       r11,7FFB47270800
-       call      qword ptr [7FFB47890800]
-       mov       r11,7FFB47230800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DD78
-       mov       rdx,7FFB4790DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DCA0
-       mov       rdx,7FFB4790DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C6020]
+       vdivsd    xmm0,xmm0,[7FFB478C6018]
-       vucomisd  xmm0,qword ptr [7FFB47885C80]
-       vdivsd    xmm0,xmm0,[7FFB47885C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F23ACB8ED8
-       mov       rcx,2EA2300D2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1F23ACB8ED0
-       mov       rdx,2EA2300D2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F23ACB8ED8
-       mov       rcx,2EA2300D2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9253e07a-0636-4037-93f0-430a7d3babe0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/941b0c55-5277-464c-8581-5455b9f9f4b8-diff.temp
index e3efca5..7096731 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/941b0c55-5277-464c-8581-5455b9f9f4b8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9253e07a-0636-4037-93f0-430a7d3babe0-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478D0800]
+       mov       r11,7FFB47270800
-       call      qword ptr [7FFB47890800]
-       mov       r11,7FFB47230800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DD78
-       mov       rdx,7FFB4790DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DCA0
-       mov       rdx,7FFB4790DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C5C80]
+       vdivsd    xmm0,xmm0,[7FFB478C5C78]
-       vucomisd  xmm0,qword ptr [7FFB47885C80]
-       vdivsd    xmm0,xmm0,[7FFB47885C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,277B07DD2E0
-       mov       rcx,2EA2300D2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,277B07DD2D8
-       mov       rdx,2EA2300D2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,277B07DD2E0
-       mov       rcx,2EA2300D2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/07211717-fa80-42e5-a99b-68b08ecaaa70-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/416880b0-767f-4651-a8d4-859e067a4a4d-diff.temp
index e3efca5..a802cf4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/416880b0-767f-4651-a8d4-859e067a4a4d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/07211717-fa80-42e5-a99b-68b08ecaaa70-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB47890908]
+       mov       r11,7FFB47230908
-       call      qword ptr [7FFB47890800]
-       mov       r11,7FFB47230800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949258
-       mov       rdx,7FFB4790DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949180
-       mov       rdx,7FFB4790DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47889060]
+       vdivsd    xmm0,xmm0,[7FFB47889058]
-       vucomisd  xmm0,qword ptr [7FFB47885C80]
-       vdivsd    xmm0,xmm0,[7FFB47885C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23C289AD2E0
-       mov       rcx,2EA2300D2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,23C289AD2D8
-       mov       rdx,2EA2300D2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23C289AD2E0
-       mov       rcx,2EA2300D2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1b984bc9-098b-4ecf-abc0-1a2bf05ca4c3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fffd16a8-9cc6-40e8-b998-71fbf1e568ef-diff.temp
index e3efca5..b0e1943 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fffd16a8-9cc6-40e8-b998-71fbf1e568ef-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1b984bc9-098b-4ecf-abc0-1a2bf05ca4c3-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478B0908]
+       mov       r11,7FFB47250908
-       call      qword ptr [7FFB47890800]
-       mov       r11,7FFB47230800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969100
-       mov       rdx,7FFB4790DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969028
-       mov       rdx,7FFB4790DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A8EE0]
+       vdivsd    xmm0,xmm0,[7FFB478A8ED8]
-       vucomisd  xmm0,qword ptr [7FFB47885C80]
-       vdivsd    xmm0,xmm0,[7FFB47885C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,2EA2300D2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E9CBDCD2D8
-       mov       rdx,2EA2300D2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,2EA2300D2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aff98a72-4797-4cb1-8a12-54f8b906f5f1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f5afa500-59df-455a-aac0-1b061d699e99-diff.temp
index e3efca5..7e851ff 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f5afa500-59df-455a-aac0-1b061d699e99-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aff98a72-4797-4cb1-8a12-54f8b906f5f1-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478D0800]
+       mov       r11,7FFB47270800
-       call      qword ptr [7FFB47890800]
-       mov       r11,7FFB47230800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DD78
-       mov       rdx,7FFB4790DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DCA0
-       mov       rdx,7FFB4790DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C6020]
+       vdivsd    xmm0,xmm0,[7FFB478C6018]
-       vucomisd  xmm0,qword ptr [7FFB47886020]
-       vdivsd    xmm0,xmm0,[7FFB47886018]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1EFA239B2E8
-       mov       rcx,23985ECD2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1EFA239B2E0
-       mov       rdx,23985ECD2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1EFA239B2E8
-       mov       rcx,23985ECD2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/577ffb6d-e5bb-45ff-a75d-cfddfc5e2472-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/32c0151c-0c93-4c2c-babd-692f7d4db07a-diff.temp
index f6fb649..b67fc2c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/32c0151c-0c93-4c2c-babd-692f7d4db07a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/577ffb6d-e5bb-45ff-a75d-cfddfc5e2472-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478D0800]
+       mov       r11,7FFB47270800
-       call      qword ptr [7FFB47890800]
-       mov       r11,7FFB47230800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DD78
-       mov       rdx,7FFB4790DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DCA0
-       mov       rdx,7FFB4790DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C6020]
+       vdivsd    xmm0,xmm0,[7FFB478C6018]
-       vucomisd  xmm0,qword ptr [7FFB47886020]
-       vdivsd    xmm0,xmm0,[7FFB47886018]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F23ACB8ED8
-       mov       rcx,23985ECD2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1F23ACB8ED0
-       mov       rdx,23985ECD2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F23ACB8ED8
-       mov       rcx,23985ECD2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/917b3c19-cd80-47da-abed-4e4b6b3ce2d5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0f04345c-46df-4e7c-93e1-7bc7fcab57ec-diff.temp
index f6fb649..7096731 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0f04345c-46df-4e7c-93e1-7bc7fcab57ec-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/917b3c19-cd80-47da-abed-4e4b6b3ce2d5-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478D0800]
+       mov       r11,7FFB47270800
-       call      qword ptr [7FFB47890800]
-       mov       r11,7FFB47230800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DD78
-       mov       rdx,7FFB4790DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DCA0
-       mov       rdx,7FFB4790DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C5C80]
+       vdivsd    xmm0,xmm0,[7FFB478C5C78]
-       vucomisd  xmm0,qword ptr [7FFB47886020]
-       vdivsd    xmm0,xmm0,[7FFB47886018]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,277B07DD2E0
-       mov       rcx,23985ECD2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,277B07DD2D8
-       mov       rdx,23985ECD2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,277B07DD2E0
-       mov       rcx,23985ECD2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dcf73c39-63ce-432b-994d-f09e037567f8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/497f6092-c484-4014-94b2-257ce8254a45-diff.temp
index f6fb649..a802cf4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/497f6092-c484-4014-94b2-257ce8254a45-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dcf73c39-63ce-432b-994d-f09e037567f8-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB47890908]
+       mov       r11,7FFB47230908
-       call      qword ptr [7FFB47890800]
-       mov       r11,7FFB47230800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949258
-       mov       rdx,7FFB4790DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949180
-       mov       rdx,7FFB4790DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47889060]
+       vdivsd    xmm0,xmm0,[7FFB47889058]
-       vucomisd  xmm0,qword ptr [7FFB47886020]
-       vdivsd    xmm0,xmm0,[7FFB47886018]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23C289AD2E0
-       mov       rcx,23985ECD2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,23C289AD2D8
-       mov       rdx,23985ECD2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23C289AD2E0
-       mov       rcx,23985ECD2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cfd3f5f9-5736-4106-9923-f565f5b75610-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9f72144c-385e-43e4-9432-5529b5a62016-diff.temp
index f6fb649..b0e1943 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9f72144c-385e-43e4-9432-5529b5a62016-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cfd3f5f9-5736-4106-9923-f565f5b75610-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478B0908]
+       mov       r11,7FFB47250908
-       call      qword ptr [7FFB47890800]
-       mov       r11,7FFB47230800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969100
-       mov       rdx,7FFB4790DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969028
-       mov       rdx,7FFB4790DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A8EE0]
+       vdivsd    xmm0,xmm0,[7FFB478A8ED8]
-       vucomisd  xmm0,qword ptr [7FFB47886020]
-       vdivsd    xmm0,xmm0,[7FFB47886018]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,23985ECD2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E9CBDCD2D8
-       mov       rdx,23985ECD2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,23985ECD2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/67942abd-5b8c-433f-b7eb-96ad1edbb93b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/283e0f67-9fc5-4161-8e06-aa9a09d098ed-diff.temp
index f6fb649..7e851ff 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/283e0f67-9fc5-4161-8e06-aa9a09d098ed-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/67942abd-5b8c-433f-b7eb-96ad1edbb93b-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/58debdf3-6efc-41be-a986-31a8a351af19-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f12ab95-060b-485b-802c-0723681274da-diff.temp
index b67fc2c..7096731 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f12ab95-060b-485b-802c-0723681274da-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/58debdf3-6efc-41be-a986-31a8a351af19-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,277B07DD2E0
-       mov       rcx,1EFA239B2E8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,277B07DD2D8
-       mov       rdx,1EFA239B2E0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,277B07DD2E0
-       mov       rcx,1EFA239B2E8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4ea115ed-0a37-407c-81ed-160ea509c6a4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f68ced07-aaea-4964-8406-b7ab2e2e0c21-diff.temp
index b67fc2c..a802cf4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f68ced07-aaea-4964-8406-b7ab2e2e0c21-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4ea115ed-0a37-407c-81ed-160ea509c6a4-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB47890908]
+       mov       r11,7FFB47230908
-       call      qword ptr [7FFB478D0800]
-       mov       r11,7FFB47270800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949258
-       mov       rdx,7FFB4794DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949180
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47889060]
+       vdivsd    xmm0,xmm0,[7FFB47889058]
-       vucomisd  xmm0,qword ptr [7FFB478C6020]
-       vdivsd    xmm0,xmm0,[7FFB478C6018]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23C289AD2E0
-       mov       rcx,1EFA239B2E8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,23C289AD2D8
-       mov       rdx,1EFA239B2E0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23C289AD2E0
-       mov       rcx,1EFA239B2E8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7724278e-8167-423e-ade0-71b2c92c041a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4603cd2a-8757-492c-a2da-a4459e58a2c1-diff.temp
index b67fc2c..b0e1943 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4603cd2a-8757-492c-a2da-a4459e58a2c1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7724278e-8167-423e-ade0-71b2c92c041a-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478B0908]
+       mov       r11,7FFB47250908
-       call      qword ptr [7FFB478D0800]
-       mov       r11,7FFB47270800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969100
-       mov       rdx,7FFB4794DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969028
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A8EE0]
+       vdivsd    xmm0,xmm0,[7FFB478A8ED8]
-       vucomisd  xmm0,qword ptr [7FFB478C6020]
-       vdivsd    xmm0,xmm0,[7FFB478C6018]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,1EFA239B2E8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E9CBDCD2D8
-       mov       rdx,1EFA239B2E0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,1EFA239B2E8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d7533aaf-1b4f-4b54-8dab-dc997c08e3b4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/80a9a461-28c4-4a22-9a3a-8a55f6770771-diff.temp
index b67fc2c..7e851ff 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/80a9a461-28c4-4a22-9a3a-8a55f6770771-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d7533aaf-1b4f-4b54-8dab-dc997c08e3b4-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,277B07DD2E0
-       mov       rcx,1F23ACB8ED8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,277B07DD2D8
-       mov       rdx,1F23ACB8ED0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,277B07DD2E0
-       mov       rcx,1F23ACB8ED8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ec0587c2-0477-4713-bde6-9570c42239e4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/95b215c7-d7d4-4efc-a948-99dfbd031f8d-diff.temp
index 7096731..a802cf4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/95b215c7-d7d4-4efc-a948-99dfbd031f8d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ec0587c2-0477-4713-bde6-9570c42239e4-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB47890908]
+       mov       r11,7FFB47230908
-       call      qword ptr [7FFB478D0800]
-       mov       r11,7FFB47270800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949258
-       mov       rdx,7FFB4794DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949180
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47889060]
+       vdivsd    xmm0,xmm0,[7FFB47889058]
-       vucomisd  xmm0,qword ptr [7FFB478C6020]
-       vdivsd    xmm0,xmm0,[7FFB478C6018]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23C289AD2E0
-       mov       rcx,1F23ACB8ED8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,23C289AD2D8
-       mov       rdx,1F23ACB8ED0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23C289AD2E0
-       mov       rcx,1F23ACB8ED8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1bee50ba-500f-4882-96f5-6066ca72d97b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e217e15c-4be7-4c7b-87fe-e6b932ccd40a-diff.temp
index 7096731..b0e1943 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e217e15c-4be7-4c7b-87fe-e6b932ccd40a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1bee50ba-500f-4882-96f5-6066ca72d97b-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478B0908]
+       mov       r11,7FFB47250908
-       call      qword ptr [7FFB478D0800]
-       mov       r11,7FFB47270800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969100
-       mov       rdx,7FFB4794DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969028
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A8EE0]
+       vdivsd    xmm0,xmm0,[7FFB478A8ED8]
-       vucomisd  xmm0,qword ptr [7FFB478C6020]
-       vdivsd    xmm0,xmm0,[7FFB478C6018]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,1F23ACB8ED8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E9CBDCD2D8
-       mov       rdx,1F23ACB8ED0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,1F23ACB8ED8
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/87c975dd-120c-4f12-b24d-140fcb9a32a1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d7ef2490-61fe-4a5c-bf1a-185891e7eb11-diff.temp
index 7096731..7e851ff 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d7ef2490-61fe-4a5c-bf1a-185891e7eb11-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/87c975dd-120c-4f12-b24d-140fcb9a32a1-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB47890908]
+       mov       r11,7FFB47230908
-       call      qword ptr [7FFB478D0800]
-       mov       r11,7FFB47270800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949258
-       mov       rdx,7FFB4794DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB47890900]
+       mov       r11,7FFB47230900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47949180
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47889060]
+       vdivsd    xmm0,xmm0,[7FFB47889058]
-       vucomisd  xmm0,qword ptr [7FFB478C5C80]
-       vdivsd    xmm0,xmm0,[7FFB478C5C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,23C289AD2E0
-       mov       rcx,277B07DD2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,23C289AD2D8
-       mov       rdx,277B07DD2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,23C289AD2E0
-       mov       rcx,277B07DD2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aa4bfd7d-cfa3-4676-a314-92917bcdf1c4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4782d757-f542-49c0-a1b7-a38fcec9f441-diff.temp
index a802cf4..b0e1943 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4782d757-f542-49c0-a1b7-a38fcec9f441-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aa4bfd7d-cfa3-4676-a314-92917bcdf1c4-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478B0908]
+       mov       r11,7FFB47250908
-       call      qword ptr [7FFB478D0800]
-       mov       r11,7FFB47270800
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969100
-       mov       rdx,7FFB4794DD78
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969028
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A8EE0]
+       vdivsd    xmm0,xmm0,[7FFB478A8ED8]
-       vucomisd  xmm0,qword ptr [7FFB478C5C80]
-       vdivsd    xmm0,xmm0,[7FFB478C5C78]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,277B07DD2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E9CBDCD2D8
-       mov       rdx,277B07DD2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,277B07DD2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/efbdebfd-2edd-48bb-af00-958b4f02cd69-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/06c38e1c-73f0-4ef6-9245-542fcaa591d7-diff.temp
index a802cf4..7e851ff 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/06c38e1c-73f0-4ef6-9245-542fcaa591d7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/efbdebfd-2edd-48bb-af00-958b4f02cd69-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,40
        xor       eax,eax
+       call      qword ptr [7FFB478B0908]
+       mov       r11,7FFB47250908
-       call      qword ptr [7FFB47890908]
-       mov       r11,7FFB47230908
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB47890900]
-       mov       r11,7FFB47230900
        mov       rcx,[rbp+0FFC8]
        jne       short M02_L05
        test      eax,eax
        call      qword ptr [rax+18]
        mov       rcx,[rax+8]
        mov       rax,rdi
        mov       rdx,rax
        call      qword ptr [r11]
        mov       rcx,[rbp+0FFC8]
 M02_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969100
-       mov       rdx,7FFB47949258
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0900]
+       mov       r11,7FFB47250900
-       call      qword ptr [7FFB47890900]
-       mov       r11,7FFB47230900
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969028
-       mov       rdx,7FFB47949180
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      r11,r11
        mov       r11,[r14+20]
        mov       r14,[rsi+10]
        je        near ptr M02_L09
        test      rdi,rdi
        je        near ptr M02_L08
        test      rbx,rbx
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFC0],rsp
        lea       rbp,[rsp+60]
        sub       rsp,40
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A8EE0]
+       vdivsd    xmm0,xmm0,[7FFB478A8ED8]
-       vucomisd  xmm0,qword ptr [7FFB47889060]
-       vdivsd    xmm0,xmm0,[7FFB47889058]
        vcvtsi2sd xmm0,xmm0,rax
        vxorps    xmm0,xmm0,xmm0
        sub       rax,rdx
        and       rdx,rcx
        and       rax,rcx
        mov       rcx,0FFFFFFFFFFFF
        or        rdx,rcx
        mov       rcx,0
        and       rdx,[rsp+28]
        mov       rdx,0FFFFFFFFFFFF
        or        rax,rdx
        mov       rdx,0
        and       rax,[rsp+58]
        mov       rax,0FFFFFFFFFFFF
        vmovupd   [rsp+20],xmm0
        vmovupd   xmm0,[rsp+40]
        vmovupd   [rsp+40],xmm0
        vmovupd   xmm0,[rsi+68]
        vmovupd   [rsp+50],xmm0
        vmovupd   xmm0,[rsp+30]
        mov       word ptr [rsp+30],0
        mov       [rsp+38],rax
        call      System.DateTime.get_UtcNow()
        cmp       [rsi],esi
        mov       rsi,rdx
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                        ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 159
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rax+54],bl
        mov       rax,[rsi+18]
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,23C289AD2E0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E9CBDCD2D8
-       mov       rdx,23C289AD2D8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E9CBDCD2E0
-       mov       rcx,23C289AD2E0
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._people.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ce58174d-d5a0-47b0-8f7e-1a2b2ebf26f5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63b68491-bb52-4476-a5ef-be06bea31be7-diff.temp
index b0e1943..7e851ff 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63b68491-bb52-4476-a5ef-be06bea31be7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ce58174d-d5a0-47b0-8f7e-1a2b2ebf26f5-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791C9F8
-       mov       rdx,7FFB4792C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/68a06f29-d053-4973-9f85-8d97477e3e3e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d807513e-eaad-4c52-8663-da4e9ed72113-diff.temp
index 05cf95b..aaa5a1f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d807513e-eaad-4c52-8663-da4e9ed72113-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/68a06f29-d053-4973-9f85-8d97477e3e3e-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793C9F8
-       mov       rdx,7FFB4792C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/006fff05-1322-41fc-a1c4-e2b49ca331d4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0030ed58-4eb1-409a-afe0-9946371285cf-diff.temp
index 05cf95b..af13988 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0030ed58-4eb1-409a-afe0-9946371285cf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/006fff05-1322-41fc-a1c4-e2b49ca331d4-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C7F8
-       mov       rdx,7FFB4792C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a0834635-59c1-4f86-8b30-06a4d99f7163-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f0e640cd-a882-4826-ac23-5b93877bc1e4-diff.temp
index 05cf95b..4687067 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f0e640cd-a882-4826-ac23-5b93877bc1e4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a0834635-59c1-4f86-8b30-06a4d99f7163-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794C7B0
-       mov       rdx,7FFB4792C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ca4839cc-fedf-44e4-9f7d-2c7a2f12b2ef-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/00b8d599-bafc-47a4-9e89-300f0ce489de-diff.temp
index 05cf95b..f9622b4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/00b8d599-bafc-47a4-9e89-300f0ce489de-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ca4839cc-fedf-44e4-9f7d-2c7a2f12b2ef-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793C9F8
-       mov       rdx,7FFB4791C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c7e6e34d-704d-4167-b244-37545ff36e73-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0e453a76-8765-48eb-9cd8-38dccdd6af69-diff.temp
index aaa5a1f..af13988 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0e453a76-8765-48eb-9cd8-38dccdd6af69-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c7e6e34d-704d-4167-b244-37545ff36e73-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C9F8
-       mov       rdx,7FFB4791C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ae15ae48-ce29-470a-8003-c749920b9357-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/647115ef-232f-4281-b7b3-eb8b5a7c88a3-diff.temp
index aaa5a1f..05cf95b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/647115ef-232f-4281-b7b3-eb8b5a7c88a3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ae15ae48-ce29-470a-8003-c749920b9357-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C9F8
-       mov       rdx,7FFB4791C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b4b681a5-3e28-4289-8f28-c6479f85bdbd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/97026362-2886-4b3c-9056-557570eb41e7-diff.temp
index aaa5a1f..05cf95b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/97026362-2886-4b3c-9056-557570eb41e7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b4b681a5-3e28-4289-8f28-c6479f85bdbd-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C9F8
-       mov       rdx,7FFB4791C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7b5b311d-2092-4746-8a06-d4c79f525bbc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e7d9fc26-b197-42ad-af82-82d2381ef861-diff.temp
index aaa5a1f..05cf95b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e7d9fc26-b197-42ad-af82-82d2381ef861-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7b5b311d-2092-4746-8a06-d4c79f525bbc-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e79f22d1-195b-4d6f-aa02-1ba860cc0ca6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1200ff8f-6834-4579-9e21-c1d729734fe0-diff.temp
index aaa5a1f..4687067 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1200ff8f-6834-4579-9e21-c1d729734fe0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e79f22d1-195b-4d6f-aa02-1ba860cc0ca6-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794C7B0
-       mov       rdx,7FFB4791C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4a6e8e5f-b03f-4742-89aa-6161a38fe1d7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/90909df6-8f53-4ece-8bf1-68194e415d48-diff.temp
index aaa5a1f..f9622b4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/90909df6-8f53-4ece-8bf1-68194e415d48-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4a6e8e5f-b03f-4742-89aa-6161a38fe1d7-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C9F8
-       mov       rdx,7FFB4793C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/badbcca9-4f38-4c58-8e4d-c36bedb8801b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aa214588-66fb-4844-8e6e-4ea7932d581b-diff.temp
index af13988..05cf95b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aa214588-66fb-4844-8e6e-4ea7932d581b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/badbcca9-4f38-4c58-8e4d-c36bedb8801b-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C9F8
-       mov       rdx,7FFB4793C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a115ec9e-42bb-4d55-83dc-631c1f64c4d9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/645ab379-fcf1-40e8-987d-4c74acc95f1a-diff.temp
index af13988..05cf95b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/645ab379-fcf1-40e8-987d-4c74acc95f1a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a115ec9e-42bb-4d55-83dc-631c1f64c4d9-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C9F8
-       mov       rdx,7FFB4793C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e556d902-2944-476e-b852-e1ba97da6cb0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b48ec5c4-16a4-4324-858c-0048905166ed-diff.temp
index af13988..05cf95b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b48ec5c4-16a4-4324-858c-0048905166ed-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e556d902-2944-476e-b852-e1ba97da6cb0-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C7F8
-       mov       rdx,7FFB4793C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fbdf7651-ae29-4db0-8ffa-85e70c2515c1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a77e035c-7bcf-4fb0-b160-61fd262c1891-diff.temp
index af13988..4687067 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a77e035c-7bcf-4fb0-b160-61fd262c1891-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fbdf7651-ae29-4db0-8ffa-85e70c2515c1-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6709668e-644f-4414-861d-1ff46b9f0f06-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7c480a35-1863-4e44-883b-405df4ccb9fc-diff.temp
index af13988..f9622b4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7c480a35-1863-4e44-883b-405df4ccb9fc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6709668e-644f-4414-861d-1ff46b9f0f06-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C7F8
-       mov       rdx,7FFB4792C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2864691f-36dd-420d-bc74-9c81b59daa15-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/71fa69cc-95b2-4aaa-89c3-206a3eeff953-diff.temp
index 05cf95b..4687067 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/71fa69cc-95b2-4aaa-89c3-206a3eeff953-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2864691f-36dd-420d-bc74-9c81b59daa15-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794C7B0
-       mov       rdx,7FFB4792C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/eeadfa3f-1fd2-4af0-af35-029f0ce269f3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/00bed7eb-22aa-4e58-b2c6-9c98a88b7d98-diff.temp
index 05cf95b..f9622b4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/00bed7eb-22aa-4e58-b2c6-9c98a88b7d98-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/eeadfa3f-1fd2-4af0-af35-029f0ce269f3-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C7F8
-       mov       rdx,7FFB4792C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/90380b43-89f3-4151-9105-1c4354578a95-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6cffe7ec-1284-412e-ab8c-42a6dc1e884a-diff.temp
index 05cf95b..4687067 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6cffe7ec-1284-412e-ab8c-42a6dc1e884a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/90380b43-89f3-4151-9105-1c4354578a95-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794C7B0
-       mov       rdx,7FFB4792C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c6b41b48-a152-46ce-8153-8a9dc4d3bdce-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ea82c2a2-9cba-4230-8645-866210dd0487-diff.temp
index 05cf95b..f9622b4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ea82c2a2-9cba-4230-8645-866210dd0487-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c6b41b48-a152-46ce-8153-8a9dc4d3bdce-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792C7F8
-       mov       rdx,7FFB4792C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0f308ebf-01e7-440a-8326-b6bd93a396c5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/00c90d1d-9f50-4b6d-be6e-5972eb2eb969-diff.temp
index 05cf95b..4687067 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/00c90d1d-9f50-4b6d-be6e-5972eb2eb969-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0f308ebf-01e7-440a-8326-b6bd93a396c5-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794C7B0
-       mov       rdx,7FFB4792C9F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/72f20604-bf24-49ed-8d77-80f1d7adfe8b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c4992e2f-26e0-4559-8232-d9fb37ad8443-diff.temp
index 05cf95b..f9622b4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c4992e2f-26e0-4559-8232-d9fb37ad8443-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/72f20604-bf24-49ed-8d77-80f1d7adfe8b-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794C7B0
-       mov       rdx,7FFB4792C7F8
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rdx,rdx
        mov       rdx,[rax+18]
        je        short M01_L02
        test      edx,edx
        movzx     edx,dl
        setne     dl
        test      rsi,rsi
        mov       rsi,rdx
        mov       rax,[rcx+10]
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/17be7349-ce3d-4edf-991a-8e30e5ccf62b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fbcaeecc-9db1-4a2b-83bb-6390d3a909e5-diff.temp
index 4687067..f9622b4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fbcaeecc-9db1-4a2b-83bb-6390d3a909e5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/17be7349-ce3d-4edf-991a-8e30e5ccf62b-diff.temp
```
