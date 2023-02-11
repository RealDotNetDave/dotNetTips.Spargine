## DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark-20220801-224935
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E9B0
-       mov       rdx,7FFB4793E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2e3f2519-9527-435f-9954-b784cf62c68c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b3563a79-554b-4401-96b9-d1dc668be631-diff.temp
index b552c92..a60eb8e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b3563a79-554b-4401-96b9-d1dc668be631-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2e3f2519-9527-435f-9954-b784cf62c68c-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0810]
+       mov       r11,7FFB47270810
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E9B0
-       mov       rdx,7FFB4793E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2048abf1-a952-4917-8365-3552abae37e2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7caa96f6-e334-426a-84ef-5b1f977a2299-diff.temp
index b552c92..aa65014 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7caa96f6-e334-426a-84ef-5b1f977a2299-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2048abf1-a952-4917-8365-3552abae37e2-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E9B0
-       mov       rdx,7FFB4793E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/411971c8-698c-4fbb-97dc-78e445552999-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3b175be8-0905-47ee-a6ef-699a8fed97d2-diff.temp
index b552c92..a60eb8e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3b175be8-0905-47ee-a6ef-699a8fed97d2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/411971c8-698c-4fbb-97dc-78e445552999-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/13bfbd71-d5f8-48ed-904a-c8c6080ce512-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cdf4c9a1-91a7-4e9d-97c4-f699faca9d13-diff.temp
index b552c92..95031d0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cdf4c9a1-91a7-4e9d-97c4-f699faca9d13-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/13bfbd71-d5f8-48ed-904a-c8c6080ce512-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E9B0
-       mov       rdx,7FFB4793E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7866401c-5737-4f99-8ca0-8f25b798b0f6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/07b4da03-a578-43b3-8a9b-6ea70c72fc80-diff.temp
index b552c92..a60eb8e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/07b4da03-a578-43b3-8a9b-6ea70c72fc80-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7866401c-5737-4f99-8ca0-8f25b798b0f6-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979978
-       mov       rdx,7FFB4793E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1e1f7ea7-b0d2-482f-86b9-1ca310eb081f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/553c2588-3e78-4bdb-be10-b582cc4e354b-diff.temp
index b552c92..b917238 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/553c2588-3e78-4bdb-be10-b582cc4e354b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1e1f7ea7-b0d2-482f-86b9-1ca310eb081f-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB47890910]
+       mov       r11,7FFB47230910
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479499B0
-       mov       rdx,7FFB4793E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c1e68438-6d85-4973-abaf-95fe84a09d66-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/20620aa9-b503-4fd5-aeaa-15a903c8aa51-diff.temp
index b552c92..d5669f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/20620aa9-b503-4fd5-aeaa-15a903c8aa51-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c1e68438-6d85-4973-abaf-95fe84a09d66-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0810]
+       mov       r11,7FFB47270810
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E9B0
-       mov       rdx,7FFB4792E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f14fc333-2c50-47c8-92af-376a1201b34d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8b311da0-86a8-40e0-bcf9-e647dc2a522c-diff.temp
index a60eb8e..aa65014 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8b311da0-86a8-40e0-bcf9-e647dc2a522c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f14fc333-2c50-47c8-92af-376a1201b34d-diff.temp
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
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0810]
+       mov       r11,7FFB47260810
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E8B0
-       mov       rdx,7FFB4792E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f7a24e16-040a-40b5-b559-ffaa44f7d3d0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/04ee4610-b9a2-4ea1-b45e-82ff46d1699b-diff.temp
index a60eb8e..95031d0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/04ee4610-b9a2-4ea1-b45e-82ff46d1699b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f7a24e16-040a-40b5-b559-ffaa44f7d3d0-diff.temp
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
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979978
-       mov       rdx,7FFB4792E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5231fbd1-b39d-4034-a760-8a7c25bcb85f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0fbd320d-fa64-4659-b251-deb4505aff0d-diff.temp
index a60eb8e..b917238 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0fbd320d-fa64-4659-b251-deb4505aff0d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5231fbd1-b39d-4034-a760-8a7c25bcb85f-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB47890910]
+       mov       r11,7FFB47230910
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479499B0
-       mov       rdx,7FFB4792E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0e48583f-8262-4dc6-b552-5666e00ef7a0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c802b1e-86b3-4cad-9ce4-2e784f3337e0-diff.temp
index a60eb8e..d5669f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c802b1e-86b3-4cad-9ce4-2e784f3337e0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0e48583f-8262-4dc6-b552-5666e00ef7a0-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB478D0810]
-       mov       r11,7FFB47270810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E9B0
-       mov       rdx,7FFB4794E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/27eeaef4-acb7-426d-a7a6-fac070669f4d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/eee95d2b-04f0-458c-9e88-a42a89e2ccbc-diff.temp
index aa65014..a60eb8e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/eee95d2b-04f0-458c-9e88-a42a89e2ccbc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/27eeaef4-acb7-426d-a7a6-fac070669f4d-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0810]
+       mov       r11,7FFB47260810
-       call      qword ptr [7FFB478D0810]
-       mov       r11,7FFB47270810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E8B0
-       mov       rdx,7FFB4794E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/95fa9064-2bde-4f31-8a45-f612db07e887-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fbb8aa07-5d77-4060-acb3-4e98e75732fb-diff.temp
index aa65014..95031d0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fbb8aa07-5d77-4060-acb3-4e98e75732fb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/95fa9064-2bde-4f31-8a45-f612db07e887-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB478D0810]
-       mov       r11,7FFB47270810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E9B0
-       mov       rdx,7FFB4794E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/38a7b825-343f-4b13-8189-3d3ad057319e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/695c65dd-8d9a-43f7-a699-34414ca454a5-diff.temp
index aa65014..a60eb8e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/695c65dd-8d9a-43f7-a699-34414ca454a5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/38a7b825-343f-4b13-8189-3d3ad057319e-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB478D0810]
-       mov       r11,7FFB47270810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979978
-       mov       rdx,7FFB4794E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2efd493c-9600-4f41-8819-9458e081eed4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6bf7f10b-316f-48a1-ae6f-af73a22ccd2f-diff.temp
index aa65014..b917238 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6bf7f10b-316f-48a1-ae6f-af73a22ccd2f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2efd493c-9600-4f41-8819-9458e081eed4-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB47890910]
+       mov       r11,7FFB47230910
-       call      qword ptr [7FFB478D0810]
-       mov       r11,7FFB47270810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479499B0
-       mov       rdx,7FFB4794E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/df245e7e-f162-4d56-b479-a009ff1aebcd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/80cf4d00-2e8d-4aab-a369-0d3da081c438-diff.temp
index aa65014..d5669f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/80cf4d00-2e8d-4aab-a369-0d3da081c438-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/df245e7e-f162-4d56-b479-a009ff1aebcd-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0810]
+       mov       r11,7FFB47260810
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E8B0
-       mov       rdx,7FFB4792E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f2ec098-1f4a-4adc-93db-929dd5cf0679-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/79be3299-2ca9-4d38-9f2d-47498b048d36-diff.temp
index a60eb8e..95031d0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/79be3299-2ca9-4d38-9f2d-47498b048d36-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f2ec098-1f4a-4adc-93db-929dd5cf0679-diff.temp
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
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979978
-       mov       rdx,7FFB4792E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6a53165b-86cf-4acc-a1b8-cd3c98ecdc4f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2ea80c59-c6de-4c43-8afb-9d77f11fffe2-diff.temp
index a60eb8e..b917238 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2ea80c59-c6de-4c43-8afb-9d77f11fffe2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6a53165b-86cf-4acc-a1b8-cd3c98ecdc4f-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB47890910]
+       mov       r11,7FFB47230910
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479499B0
-       mov       rdx,7FFB4792E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1563b0d2-4a91-4350-a105-00485b621891-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/78039679-2040-4263-80f0-1258be52ebf2-diff.temp
index a60eb8e..d5669f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/78039679-2040-4263-80f0-1258be52ebf2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1563b0d2-4a91-4350-a105-00485b621891-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E9B0
-       mov       rdx,7FFB4793E8B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a5e739db-7d42-4a03-b2ab-877dac628250-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/270dde18-5c79-440e-a58b-e8c56d150518-diff.temp
index 95031d0..a60eb8e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/270dde18-5c79-440e-a58b-e8c56d150518-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a5e739db-7d42-4a03-b2ab-877dac628250-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979978
-       mov       rdx,7FFB4793E8B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1d68fc51-3ffd-4952-8cab-b46ff28fc1ff-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a0dec192-1071-4c68-a3a8-7d6ab823bc49-diff.temp
index 95031d0..b917238 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a0dec192-1071-4c68-a3a8-7d6ab823bc49-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1d68fc51-3ffd-4952-8cab-b46ff28fc1ff-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB47890910]
+       mov       r11,7FFB47230910
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479499B0
-       mov       rdx,7FFB4793E8B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/64e6d506-e4da-4b07-b7be-1c48321be8a8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9e67f82d-0288-4c21-b3ac-ad0d10882c9d-diff.temp
index 95031d0..d5669f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9e67f82d-0288-4c21-b3ac-ad0d10882c9d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/64e6d506-e4da-4b07-b7be-1c48321be8a8-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979978
-       mov       rdx,7FFB4792E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d81c585a-b963-4210-89e5-f82396fa1457-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0eec1997-fa00-4def-bb26-ead32739cc04-diff.temp
index a60eb8e..b917238 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0eec1997-fa00-4def-bb26-ead32739cc04-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d81c585a-b963-4210-89e5-f82396fa1457-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB47890910]
+       mov       r11,7FFB47230910
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479499B0
-       mov       rdx,7FFB4792E9B0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/39a64e9e-cd49-4a65-a78c-1bb6bf2b242c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8a59cb79-0dbb-4fc6-8f82-7064d8eca003-diff.temp
index a60eb8e..d5669f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8a59cb79-0dbb-4fc6-8f82-7064d8eca003-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/39a64e9e-cd49-4a65-a78c-1bb6bf2b242c-diff.temp
```
**Diff for HasItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB47890910]
+       mov       r11,7FFB47230910
-       call      qword ptr [7FFB478C0910]
-       mov       r11,7FFB47260910
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479499B0
-       mov       rdx,7FFB47979978
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 67
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c3047b96-783f-436d-8db3-ffb7a6382662-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7806719b-9fc5-4f54-bace-22328cab2034-diff.temp
index b917238..d5669f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7806719b-9fc5-4f54-bace-22328cab2034-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c3047b96-783f-436d-8db3-ffb7a6382662-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1F7FF2A1028
-       mov       r9,1F03F833020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1F7FF2AB288
-       mov       rcx,1F03F83D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1F7FF2AB280
-       mov       rdx,1F03F83D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1F7FF2AB288
-       mov       rcx,1F03F83D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/33104d9e-8432-4edb-ac87-d6b454053295-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98d8a99d-9454-490c-9522-7e672d17f68b-diff.temp
index 3279ef4..272a8aa 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98d8a99d-9454-490c-9522-7e672d17f68b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/33104d9e-8432-4edb-ac87-d6b454053295-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2A0F75B3020
-       mov       r9,1F03F833020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2A0F75BD280
-       mov       rcx,1F03F83D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,2A0F75BD278
-       mov       rdx,1F03F83D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2A0F75BD280
-       mov       rcx,1F03F83D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/96270a1c-1a2a-42db-958e-2c381f91f439-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2058d9fa-9b50-442e-ad58-82a183550d77-diff.temp
index 3279ef4..0aea5dc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2058d9fa-9b50-442e-ad58-82a183550d77-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/96270a1c-1a2a-42db-958e-2c381f91f439-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1A9F0C33020
-       mov       r9,1F03F833020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1A9F0C33020
-       mov       r9,1F03F833020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D9E8
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A6120]
+       vdivsd    xmm0,xmm0,[7FFB478A6118]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1A9F0C3D280
-       mov       rcx,1F03F83D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1A9F0C3D278
-       mov       rdx,1F03F83D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1A9F0C3D280
-       mov       rcx,1F03F83D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f8d7e172-2453-429a-a58f-575508d157db-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98180433-0ff6-45a4-b8f3-a7ab04918e16-diff.temp
index 3279ef4..1ca1f9d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98180433-0ff6-45a4-b8f3-a7ab04918e16-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f8d7e172-2453-429a-a58f-575508d157db-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,247F1E93020
-       mov       r9,1F03F833020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,247F1E93020
-       mov       r9,1F03F833020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D9E8
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A6120]
+       vdivsd    xmm0,xmm0,[7FFB478A6118]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,247F1E9D280
-       mov       rcx,1F03F83D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,247F1E9D278
-       mov       rdx,1F03F83D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,247F1E9D280
-       mov       rcx,1F03F83D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/51ca08d9-c42e-4907-bc19-8b859ce7cf68-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c85d161f-92f1-4f61-a0bd-dd863e176e81-diff.temp
index 3279ef4..14a93cd 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c85d161f-92f1-4f61-a0bd-dd863e176e81-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/51ca08d9-c42e-4907-bc19-8b859ce7cf68-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1D420B83020
-       mov       r9,1F03F833020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1D420B83020
-       mov       r9,1F03F833020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D9E8
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A6120]
+       vdivsd    xmm0,xmm0,[7FFB478A6118]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1D440B88E78
-       mov       rcx,1F03F83D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1D440B88E70
-       mov       rdx,1F03F83D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1D440B88E78
-       mov       rcx,1F03F83D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dd13c914-64a4-4c9c-9f52-9faa647b5378-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/27af83ef-3390-4f7b-bbb4-85ba7da3c10f-diff.temp
index 3279ef4..dd02ed5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/27af83ef-3390-4f7b-bbb4-85ba7da3c10f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dd13c914-64a4-4c9c-9f52-9faa647b5378-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,1F03F833020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DA10
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,1F03F833020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794D898
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B9960]
+       vdivsd    xmm0,xmm0,[7FFB478B9958]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E5CEBAD280
-       mov       rcx,1F03F83D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E5CEBAD278
-       mov       rdx,1F03F83D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E5CEBAD280
-       mov       rcx,1F03F83D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0af1e445-1af4-436d-be82-aaf1d1dc0ee7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0440ecea-f236-49ab-a2ba-f3b64f519283-diff.temp
index 3279ef4..fe4c4a7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0440ecea-f236-49ab-a2ba-f3b64f519283-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0af1e445-1af4-436d-be82-aaf1d1dc0ee7-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,1F03F833020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DA28
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,1F03F833020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D8B0
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47899A60]
+       vdivsd    xmm0,xmm0,[7FFB47899A58]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2198608B288
-       mov       rcx,1F03F83D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,2198608B280
-       mov       rdx,1F03F83D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2198608B288
-       mov       rcx,1F03F83D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a78280a4-3bb4-436b-bed3-8a171ffde2d8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/07241bfc-4c94-4a7b-9e34-565ddef4b6ee-diff.temp
index 3279ef4..ace3f95 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/07241bfc-4c94-4a7b-9e34-565ddef4b6ee-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a78280a4-3bb4-436b-bed3-8a171ffde2d8-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2A0F75B3020
-       mov       r9,1F7FF2A1028
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2A0F75BD280
-       mov       rcx,1F7FF2AB288
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,2A0F75BD278
-       mov       rdx,1F7FF2AB280
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2A0F75BD280
-       mov       rcx,1F7FF2AB288
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3653bf45-286a-483f-be61-4049b71c0088-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cd3f2c8e-97a7-4dcd-b9af-eb7c737a56bb-diff.temp
index 272a8aa..0aea5dc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cd3f2c8e-97a7-4dcd-b9af-eb7c737a56bb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3653bf45-286a-483f-be61-4049b71c0088-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1A9F0C33020
-       mov       r9,1F7FF2A1028
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1A9F0C33020
-       mov       r9,1F7FF2A1028
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D9E8
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A6120]
+       vdivsd    xmm0,xmm0,[7FFB478A6118]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1A9F0C3D280
-       mov       rcx,1F7FF2AB288
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1A9F0C3D278
-       mov       rdx,1F7FF2AB280
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1A9F0C3D280
-       mov       rcx,1F7FF2AB288
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/780fa328-4845-4ce9-9d26-61f12d1315ae-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1a383e94-7130-4a59-bc48-1def6c1bc266-diff.temp
index 272a8aa..1ca1f9d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1a383e94-7130-4a59-bc48-1def6c1bc266-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/780fa328-4845-4ce9-9d26-61f12d1315ae-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,247F1E93020
-       mov       r9,1F7FF2A1028
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,247F1E93020
-       mov       r9,1F7FF2A1028
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D9E8
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A6120]
+       vdivsd    xmm0,xmm0,[7FFB478A6118]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,247F1E9D280
-       mov       rcx,1F7FF2AB288
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,247F1E9D278
-       mov       rdx,1F7FF2AB280
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,247F1E9D280
-       mov       rcx,1F7FF2AB288
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/23d48123-ae0e-49f7-8435-a08ba9b8fd01-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3f8b6344-593b-4ef3-ad3d-ac1b97b57d31-diff.temp
index 272a8aa..14a93cd 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3f8b6344-593b-4ef3-ad3d-ac1b97b57d31-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/23d48123-ae0e-49f7-8435-a08ba9b8fd01-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1D420B83020
-       mov       r9,1F7FF2A1028
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1D420B83020
-       mov       r9,1F7FF2A1028
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D9E8
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A6120]
+       vdivsd    xmm0,xmm0,[7FFB478A6118]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1D440B88E78
-       mov       rcx,1F7FF2AB288
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1D440B88E70
-       mov       rdx,1F7FF2AB280
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1D440B88E78
-       mov       rcx,1F7FF2AB288
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c030a9c7-a76c-4a9d-b849-dc6013882ebb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f7a01e0c-a92d-40a2-b6b4-7f138efd3629-diff.temp
index 272a8aa..dd02ed5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f7a01e0c-a92d-40a2-b6b4-7f138efd3629-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c030a9c7-a76c-4a9d-b849-dc6013882ebb-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,1F7FF2A1028
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DA10
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,1F7FF2A1028
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794D898
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B9960]
+       vdivsd    xmm0,xmm0,[7FFB478B9958]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E5CEBAD280
-       mov       rcx,1F7FF2AB288
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E5CEBAD278
-       mov       rdx,1F7FF2AB280
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E5CEBAD280
-       mov       rcx,1F7FF2AB288
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/97053cd2-9585-4063-b574-36f541f2b5a7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/eb4b8b16-867b-4de0-b6e7-95c44438250d-diff.temp
index 272a8aa..fe4c4a7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/eb4b8b16-867b-4de0-b6e7-95c44438250d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/97053cd2-9585-4063-b574-36f541f2b5a7-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,1F7FF2A1028
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DA28
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,1F7FF2A1028
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D8B0
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47899A60]
+       vdivsd    xmm0,xmm0,[7FFB47899A58]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2198608B288
-       mov       rcx,1F7FF2AB288
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,2198608B280
-       mov       rdx,1F7FF2AB280
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2198608B288
-       mov       rcx,1F7FF2AB288
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0891c34c-9753-4017-8224-7cbae22a44c8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/885ca51d-6e6f-495b-ad1f-6e08755a55ce-diff.temp
index 272a8aa..ace3f95 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/885ca51d-6e6f-495b-ad1f-6e08755a55ce-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0891c34c-9753-4017-8224-7cbae22a44c8-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1A9F0C33020
-       mov       r9,2A0F75B3020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1A9F0C33020
-       mov       r9,2A0F75B3020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D9E8
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A6120]
+       vdivsd    xmm0,xmm0,[7FFB478A6118]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1A9F0C3D280
-       mov       rcx,2A0F75BD280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1A9F0C3D278
-       mov       rdx,2A0F75BD278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1A9F0C3D280
-       mov       rcx,2A0F75BD280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/669c9672-defa-49e4-aa8a-8bee903d3edb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dc75083b-99f6-42ff-98ae-9a543d23c12e-diff.temp
index 0aea5dc..1ca1f9d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dc75083b-99f6-42ff-98ae-9a543d23c12e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/669c9672-defa-49e4-aa8a-8bee903d3edb-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,247F1E93020
-       mov       r9,2A0F75B3020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,247F1E93020
-       mov       r9,2A0F75B3020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D9E8
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A6120]
+       vdivsd    xmm0,xmm0,[7FFB478A6118]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,247F1E9D280
-       mov       rcx,2A0F75BD280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,247F1E9D278
-       mov       rdx,2A0F75BD278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,247F1E9D280
-       mov       rcx,2A0F75BD280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1cb31829-ab99-4efa-b79d-40ae4e8e2319-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8539a70b-c377-4921-a609-7fee0c7c31b3-diff.temp
index 0aea5dc..14a93cd 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8539a70b-c377-4921-a609-7fee0c7c31b3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1cb31829-ab99-4efa-b79d-40ae4e8e2319-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1D420B83020
-       mov       r9,2A0F75B3020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1D420B83020
-       mov       r9,2A0F75B3020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D9E8
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A6120]
+       vdivsd    xmm0,xmm0,[7FFB478A6118]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1D440B88E78
-       mov       rcx,2A0F75BD280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1D440B88E70
-       mov       rdx,2A0F75BD278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1D440B88E78
-       mov       rcx,2A0F75BD280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6e41aa9a-a60f-484c-9ead-81f5e6f298ce-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/300545e8-2578-400f-a605-56fe62ef7b12-diff.temp
index 0aea5dc..dd02ed5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/300545e8-2578-400f-a605-56fe62ef7b12-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6e41aa9a-a60f-484c-9ead-81f5e6f298ce-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,2A0F75B3020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DA10
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,2A0F75B3020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794D898
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B9960]
+       vdivsd    xmm0,xmm0,[7FFB478B9958]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E5CEBAD280
-       mov       rcx,2A0F75BD280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E5CEBAD278
-       mov       rdx,2A0F75BD278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E5CEBAD280
-       mov       rcx,2A0F75BD280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e246e303-7bc0-4020-bf73-a0f2236ce737-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/43561795-00e4-4718-9454-5f0e08fd0277-diff.temp
index 0aea5dc..fe4c4a7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/43561795-00e4-4718-9454-5f0e08fd0277-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e246e303-7bc0-4020-bf73-a0f2236ce737-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,2A0F75B3020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DA28
-       mov       rdx,7FFB4794DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,2A0F75B3020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D8B0
-       mov       rdx,7FFB4794D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47899A60]
+       vdivsd    xmm0,xmm0,[7FFB47899A58]
-       vucomisd  xmm0,qword ptr [7FFB478C6120]
-       vdivsd    xmm0,xmm0,[7FFB478C6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2198608B288
-       mov       rcx,2A0F75BD280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,2198608B280
-       mov       rdx,2A0F75BD278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2198608B288
-       mov       rcx,2A0F75BD280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6ecb19c7-6b21-4cdd-a004-4c2a0f477dfa-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e7046215-6a4a-4700-ba98-47805fef1737-diff.temp
index 0aea5dc..ace3f95 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e7046215-6a4a-4700-ba98-47805fef1737-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6ecb19c7-6b21-4cdd-a004-4c2a0f477dfa-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,247F1E93020
-       mov       r9,1A9F0C33020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFB4792D9E8
        mov       rcx,rsi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,247F1E9D280
-       mov       rcx,1A9F0C3D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,247F1E9D278
-       mov       rdx,1A9F0C3D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,247F1E9D280
-       mov       rcx,1A9F0C3D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/19e764d8-c7a4-4d2e-9ad7-f8f5b40d467f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6a9296a8-d2b7-4d14-8edf-b341aa4e6269-diff.temp
index 1ca1f9d..14a93cd 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6a9296a8-d2b7-4d14-8edf-b341aa4e6269-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/19e764d8-c7a4-4d2e-9ad7-f8f5b40d467f-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1D420B83020
-       mov       r9,1A9F0C33020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFB4792D9E8
        mov       rcx,rsi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1D440B88E78
-       mov       rcx,1A9F0C3D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1D440B88E70
-       mov       rdx,1A9F0C3D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1D440B88E78
-       mov       rcx,1A9F0C3D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c1803578-b3f3-4e22-8f2d-b3fcce7b18dc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/edde489e-bbb3-4d3e-9a23-2246c66683f0-diff.temp
index 1ca1f9d..dd02ed5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/edde489e-bbb3-4d3e-9a23-2246c66683f0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c1803578-b3f3-4e22-8f2d-b3fcce7b18dc-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,1A9F0C33020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DA10
-       mov       rdx,7FFB4792DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,1A9F0C33020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794D898
-       mov       rdx,7FFB4792D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B9960]
+       vdivsd    xmm0,xmm0,[7FFB478B9958]
-       vucomisd  xmm0,qword ptr [7FFB478A6120]
-       vdivsd    xmm0,xmm0,[7FFB478A6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E5CEBAD280
-       mov       rcx,1A9F0C3D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E5CEBAD278
-       mov       rdx,1A9F0C3D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E5CEBAD280
-       mov       rcx,1A9F0C3D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/09e78180-4783-4b41-b898-2b0be3c88c33-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6ba1ea04-7d3a-40b5-80b1-8f481571b615-diff.temp
index 1ca1f9d..fe4c4a7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6ba1ea04-7d3a-40b5-80b1-8f481571b615-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/09e78180-4783-4b41-b898-2b0be3c88c33-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,1A9F0C33020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DA28
-       mov       rdx,7FFB4792DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,1A9F0C33020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D8B0
-       mov       rdx,7FFB4792D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47899A60]
+       vdivsd    xmm0,xmm0,[7FFB47899A58]
-       vucomisd  xmm0,qword ptr [7FFB478A6120]
-       vdivsd    xmm0,xmm0,[7FFB478A6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2198608B288
-       mov       rcx,1A9F0C3D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,2198608B280
-       mov       rdx,1A9F0C3D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2198608B288
-       mov       rcx,1A9F0C3D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a8bbecae-7d40-41ee-87b0-277cdcc76d25-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dac47ad5-1cf5-4145-875a-1843e30f9445-diff.temp
index 1ca1f9d..ace3f95 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dac47ad5-1cf5-4145-875a-1843e30f9445-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a8bbecae-7d40-41ee-87b0-277cdcc76d25-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1D420B83020
-       mov       r9,247F1E93020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFB4792D9E8
        mov       rcx,rsi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1D440B88E78
-       mov       rcx,247F1E9D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1D440B88E70
-       mov       rdx,247F1E9D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1D440B88E78
-       mov       rcx,247F1E9D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6db3071f-4cad-4cdc-87d9-a2de22cbb360-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/176b9fb4-e0bd-4e49-96cd-cdf70261d19e-diff.temp
index 14a93cd..dd02ed5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/176b9fb4-e0bd-4e49-96cd-cdf70261d19e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6db3071f-4cad-4cdc-87d9-a2de22cbb360-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,247F1E93020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DA10
-       mov       rdx,7FFB4792DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,247F1E93020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794D898
-       mov       rdx,7FFB4792D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B9960]
+       vdivsd    xmm0,xmm0,[7FFB478B9958]
-       vucomisd  xmm0,qword ptr [7FFB478A6120]
-       vdivsd    xmm0,xmm0,[7FFB478A6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E5CEBAD280
-       mov       rcx,247F1E9D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E5CEBAD278
-       mov       rdx,247F1E9D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E5CEBAD280
-       mov       rcx,247F1E9D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ffdf6b98-cc78-4e72-a36c-12d29b67ed0a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2a65dd65-06f0-4f51-91dd-2242e51e4915-diff.temp
index 14a93cd..fe4c4a7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2a65dd65-06f0-4f51-91dd-2242e51e4915-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ffdf6b98-cc78-4e72-a36c-12d29b67ed0a-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,247F1E93020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DA28
-       mov       rdx,7FFB4792DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,247F1E93020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D8B0
-       mov       rdx,7FFB4792D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47899A60]
+       vdivsd    xmm0,xmm0,[7FFB47899A58]
-       vucomisd  xmm0,qword ptr [7FFB478A6120]
-       vdivsd    xmm0,xmm0,[7FFB478A6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2198608B288
-       mov       rcx,247F1E9D280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,2198608B280
-       mov       rdx,247F1E9D278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2198608B288
-       mov       rcx,247F1E9D280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ea7c8874-c4e1-4933-a0bb-4dc14e121e46-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5039b674-c113-41ff-b78d-fa1808a685ad-diff.temp
index 14a93cd..ace3f95 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5039b674-c113-41ff-b78d-fa1808a685ad-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ea7c8874-c4e1-4933-a0bb-4dc14e121e46-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,1D420B83020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DA10
-       mov       rdx,7FFB4792DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1E5CEBA3020
-       mov       r9,1D420B83020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794D898
-       mov       rdx,7FFB4792D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B9960]
+       vdivsd    xmm0,xmm0,[7FFB478B9958]
-       vucomisd  xmm0,qword ptr [7FFB478A6120]
-       vdivsd    xmm0,xmm0,[7FFB478A6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1E5CEBAD280
-       mov       rcx,1D440B88E78
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1E5CEBAD278
-       mov       rdx,1D440B88E70
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1E5CEBAD280
-       mov       rcx,1D440B88E78
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6a89163f-39ce-4ab2-9b8b-d82440bd8a04-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ac3952eb-c13f-436e-80f3-cfdf92904a0c-diff.temp
index dd02ed5..fe4c4a7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ac3952eb-c13f-436e-80f3-cfdf92904a0c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6a89163f-39ce-4ab2-9b8b-d82440bd8a04-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,1D420B83020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DA28
-       mov       rdx,7FFB4792DB60
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,1D420B83020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D8B0
-       mov       rdx,7FFB4792D9E8
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47899A60]
+       vdivsd    xmm0,xmm0,[7FFB47899A58]
-       vucomisd  xmm0,qword ptr [7FFB478A6120]
-       vdivsd    xmm0,xmm0,[7FFB478A6118]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2198608B288
-       mov       rcx,1D440B88E78
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,2198608B280
-       mov       rdx,1D440B88E70
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2198608B288
-       mov       rcx,1D440B88E78
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e3ba9561-667c-4b72-b9cb-7a4de20ffa60-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dc321255-78a2-4102-a3b3-474f9fdc104f-diff.temp
index dd02ed5..ace3f95 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dc321255-78a2-4102-a3b3-474f9fdc104f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e3ba9561-667c-4b72-b9cb-7a4de20ffa60-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jne       short M02_L05
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,1E5CEBA3020
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DA28
-       mov       rdx,7FFB4794DA10
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbp+18]
        je        short M02_L04
        test      eax,eax
        call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
        xor       r8d,r8d
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,21986081028
-       mov       r9,1E5CEBA3020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792D8B0
-       mov       rdx,7FFB4794D898
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbp+10]
        mov       rbp,[rsi+10]
        mov       rbx,r8
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
 ; Total bytes of code 189
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB47899A60]
+       vdivsd    xmm0,xmm0,[7FFB47899A58]
-       vucomisd  xmm0,qword ptr [7FFB478B9960]
-       vdivsd    xmm0,xmm0,[7FFB478B9958]
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
 ; 			                                                  ^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
        mov       rdx,rdi
 M00_L00:
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,2198608B288
-       mov       rcx,1E5CEBAD280
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,2198608B280
-       mov       rdx,1E5CEBAD278
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,2198608B288
-       mov       rcx,1E5CEBAD280
        mov       rdi,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f094b76f-84c9-440c-857f-14b4086e7c8d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6d3210c1-391a-4ac0-8f51-053f65b7ac86-diff.temp
index fe4c4a7..ace3f95 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6d3210c1-391a-4ac0-8f51-053f65b7ac86-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f094b76f-84c9-440c-857f-14b4086e7c8d-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DCA0
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1D487AA3E60
-       mov       r9,15B1B3623B8
        mov       r8,[r8]
+       mov       r8,1D487A93020
-       mov       r8,15B3B363020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA88
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D800
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E948
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1D487AA3958
-       mov       r9,15B1B361EB0
        mov       r8,[r8]
+       mov       r8,1D487A93020
-       mov       r8,15B3B363020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E478
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6c8e43b9-2f66-4eaf-b4d3-1c3f7e99a4f3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/81fa26f3-da57-4549-861c-1e5d58b120bb-diff.temp
index aca5372..cd35653 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/81fa26f3-da57-4549-861c-1e5d58b120bb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6c8e43b9-2f66-4eaf-b4d3-1c3f7e99a4f3-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,14932635188
-       mov       r9,15B1B361EB0
        mov       r8,[r8]
+       mov       r8,14932623020
-       mov       r8,15B3B363020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFB4789E478
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/db2ffb0b-352b-4e21-8bf6-b6f09035197c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/79611aef-1469-4615-aa1b-60bbfa61ba69-diff.temp
index aca5372..7372240 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/79611aef-1469-4615-aa1b-60bbfa61ba69-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/db2ffb0b-352b-4e21-8bf6-b6f09035197c-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DCA0
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,28F51652BB8
-       mov       r9,15B1B3623B8
        mov       r8,[r8]
+       mov       r8,28F41653020
-       mov       r8,15B3B363020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DA88
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791D800
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4786E948
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,28F516526B0
-       mov       r9,15B1B361EB0
        mov       r8,[r8]
+       mov       r8,28F41653020
-       mov       r8,15B3B363020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4786E478
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477433C0
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cfcc64dc-f093-4adf-bb52-d7acc24d5667-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b4b905ca-30b8-47dd-923d-e8c7450f4b9c-diff.temp
index aca5372..aecb593 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b4b905ca-30b8-47dd-923d-e8c7450f4b9c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cfcc64dc-f093-4adf-bb52-d7acc24d5667-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DCA0
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1ED92D91BA0
-       mov       r9,15B1B3623B8
        mov       r8,[r8]
+       mov       r8,1ED82D91028
-       mov       r8,15B3B363020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA88
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D800
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E948
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1ED92D91698
-       mov       r9,15B1B361EB0
        mov       r8,[r8]
+       mov       r8,1ED82D91028
-       mov       r8,15B3B363020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E478
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f3b583c1-29c7-469e-a0cd-4829f87b9f9d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c1e3f94c-7dd6-4a4f-a5e4-50786c0f0d62-diff.temp
index aca5372..f85423c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c1e3f94c-7dd6-4a4f-a5e4-50786c0f0d62-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f3b583c1-29c7-469e-a0cd-4829f87b9f9d-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DCA0
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,28F746D1BA0
-       mov       r9,15B1B3623B8
        mov       r8,[r8]
+       mov       r8,28F946D3020
-       mov       r8,15B3B363020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA88
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D800
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E948
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,28F746D1698
-       mov       r9,15B1B361EB0
        mov       r8,[r8]
+       mov       r8,28F946D3020
-       mov       r8,15B3B363020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E478
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5c81b5d7-5cec-4339-9348-fadbe681a992-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5014dc26-faf3-48be-816b-93b29a62c4e0-diff.temp
index aca5372..f9b4698 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5014dc26-faf3-48be-816b-93b29a62c4e0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5c81b5d7-5cec-4339-9348-fadbe681a992-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB50
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA10
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,20713FD2BB8
-       mov       r9,15B1B3623B8
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,15B3B363020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D938
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D6B0
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E848
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,20713FD26B0
-       mov       r9,15B1B361EB0
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,15B3B363020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E378
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4775AF70
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5a2205c2-26ad-412e-ab49-d2e8ca763529-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b0fa3277-8a82-4c55-ac81-a94f7c51df9f-diff.temp
index aca5372..f0656df 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b0fa3277-8a82-4c55-ac81-a94f7c51df9f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5a2205c2-26ad-412e-ab49-d2e8ca763529-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DA28
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,2B8005E1BA0
-       mov       r9,15B1B3623B8
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,15B3B363020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D950
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D6C8
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E890
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2B8005E1698
-       mov       r9,15B1B361EB0
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,15B3B363020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E3C0
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4777AF70
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5acf2200-4924-4fe8-a1bf-8181884881db-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/109f1114-875a-4532-a64c-dbdde585a476-diff.temp
index aca5372..625cf50 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/109f1114-875a-4532-a64c-dbdde585a476-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5acf2200-4924-4fe8-a1bf-8181884881db-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DCA0
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DB60
-       mov       rdx,7FFB4793DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,14932635690
-       mov       r9,1D487AA3E60
        mov       r8,[r8]
+       mov       r8,14932623020
-       mov       r8,1D487A93020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DA88
-       mov       rdx,7FFB4793DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794D800
-       mov       rdx,7FFB4793D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4789E948
-       mov       rdx,7FFB4788E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,14932635188
-       mov       r9,1D487AA3958
        mov       r8,[r8]
+       mov       r8,14932623020
-       mov       r8,1D487A93020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4789E478
-       mov       rdx,7FFB4788E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477733C0
-       mov       rdx,7FFB477633C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c1731bff-bbc8-49e8-9d7d-f3243df72018-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1dc36c81-cf79-476b-b250-2cbc884f6eb1-diff.temp
index cd35653..7372240 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1dc36c81-cf79-476b-b250-2cbc884f6eb1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c1731bff-bbc8-49e8-9d7d-f3243df72018-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DCA0
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DB60
-       mov       rdx,7FFB4793DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,28F51652BB8
-       mov       r9,1D487AA3E60
        mov       r8,[r8]
+       mov       r8,28F41653020
-       mov       r8,1D487A93020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DA88
-       mov       rdx,7FFB4793DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791D800
-       mov       rdx,7FFB4793D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4786E948
-       mov       rdx,7FFB4788E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,28F516526B0
-       mov       r9,1D487AA3958
        mov       r8,[r8]
+       mov       r8,28F41653020
-       mov       r8,1D487A93020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4786E478
-       mov       rdx,7FFB4788E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477433C0
-       mov       rdx,7FFB477633C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/345f7817-c754-4a99-86f1-79f64c2bc99a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c0c438cc-a81f-4df0-aa4f-4a2a4e3c531e-diff.temp
index cd35653..aecb593 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c0c438cc-a81f-4df0-aa4f-4a2a4e3c531e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/345f7817-c754-4a99-86f1-79f64c2bc99a-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1ED92D91698
-       mov       r9,1D487AA3958
        mov       r8,[r8]
+       mov       r8,1ED82D91028
-       mov       r8,1D487A93020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFB4788E478
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/00fc6998-2a3a-4a13-b34e-c5e8de193ea6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/493b85a1-ab06-407a-8a21-6f90415c9489-diff.temp
index cd35653..f85423c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/493b85a1-ab06-407a-8a21-6f90415c9489-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/00fc6998-2a3a-4a13-b34e-c5e8de193ea6-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,28F746D1698
-       mov       r9,1D487AA3958
        mov       r8,[r8]
+       mov       r8,28F946D3020
-       mov       r8,1D487A93020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFB4788E478
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8db4e369-7c39-4152-a81d-e2f09b73c867-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bbe520fe-ba5c-4af7-a106-9fe98e591f0b-diff.temp
index cd35653..f9b4698 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bbe520fe-ba5c-4af7-a106-9fe98e591f0b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8db4e369-7c39-4152-a81d-e2f09b73c867-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB50
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA10
-       mov       rdx,7FFB4793DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,20713FD2BB8
-       mov       r9,1D487AA3E60
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,1D487A93020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D938
-       mov       rdx,7FFB4793DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D6B0
-       mov       rdx,7FFB4793D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E848
-       mov       rdx,7FFB4788E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,20713FD26B0
-       mov       r9,1D487AA3958
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,1D487A93020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E378
-       mov       rdx,7FFB4788E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4775AF70
-       mov       rdx,7FFB477633C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/defd0329-4b35-426b-b1c8-f4e01d809c17-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cf629af6-2d82-453b-8c27-ad1b51da7473-diff.temp
index cd35653..f0656df 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cf629af6-2d82-453b-8c27-ad1b51da7473-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/defd0329-4b35-426b-b1c8-f4e01d809c17-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DB68
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DA28
-       mov       rdx,7FFB4793DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,2B8005E1BA0
-       mov       r9,1D487AA3E60
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,1D487A93020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D950
-       mov       rdx,7FFB4793DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D6C8
-       mov       rdx,7FFB4793D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E890
-       mov       rdx,7FFB4788E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2B8005E1698
-       mov       r9,1D487AA3958
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,1D487A93020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E3C0
-       mov       rdx,7FFB4788E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4777AF70
-       mov       rdx,7FFB477633C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/426d233b-1b15-46f4-8f70-5e6cdb4c999a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/423679a5-ab92-4ae2-8d72-0965d651b1a7-diff.temp
index cd35653..625cf50 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/423679a5-ab92-4ae2-8d72-0965d651b1a7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/426d233b-1b15-46f4-8f70-5e6cdb4c999a-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DCA0
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,28F51652BB8
-       mov       r9,14932635690
        mov       r8,[r8]
+       mov       r8,28F41653020
-       mov       r8,14932623020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DA88
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791D800
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4786E948
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,28F516526B0
-       mov       r9,14932635188
        mov       r8,[r8]
+       mov       r8,28F41653020
-       mov       r8,14932623020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4786E478
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477433C0
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1fa56a6e-e9b8-4bf9-bfbc-845d6f7799a6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fcd0a78e-9b13-416f-a272-6e0bd4ca3f4d-diff.temp
index 7372240..aecb593 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fcd0a78e-9b13-416f-a272-6e0bd4ca3f4d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1fa56a6e-e9b8-4bf9-bfbc-845d6f7799a6-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DCA0
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1ED92D91BA0
-       mov       r9,14932635690
        mov       r8,[r8]
+       mov       r8,1ED82D91028
-       mov       r8,14932623020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA88
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D800
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E948
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1ED92D91698
-       mov       r9,14932635188
        mov       r8,[r8]
+       mov       r8,1ED82D91028
-       mov       r8,14932623020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E478
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8f482a84-d704-46de-ac78-81c3816fa264-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5a49c10e-23fb-4d4d-81ce-3dbbdae7f697-diff.temp
index 7372240..f85423c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5a49c10e-23fb-4d4d-81ce-3dbbdae7f697-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8f482a84-d704-46de-ac78-81c3816fa264-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DCA0
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB60
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,28F746D1BA0
-       mov       r9,14932635690
        mov       r8,[r8]
+       mov       r8,28F946D3020
-       mov       r8,14932623020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA88
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D800
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E948
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,28F746D1698
-       mov       r9,14932635188
        mov       r8,[r8]
+       mov       r8,28F946D3020
-       mov       r8,14932623020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E478
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2ec0378d-114b-4cf4-923c-91e5845fb2d7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f6569569-12b8-4adf-97d4-bee836010d22-diff.temp
index 7372240..f9b4698 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f6569569-12b8-4adf-97d4-bee836010d22-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2ec0378d-114b-4cf4-923c-91e5845fb2d7-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB50
-       mov       rdx,7FFB4794DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA10
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,20713FD2BB8
-       mov       r9,14932635690
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,14932623020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D938
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D6B0
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E848
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,20713FD26B0
-       mov       r9,14932635188
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,14932623020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E378
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4775AF70
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5e1ecbfb-f4be-4fcf-b6a6-46549f8cefc1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7c31ec78-d9a1-4260-9399-cea0bd4bf1a6-diff.temp
index 7372240..f0656df 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7c31ec78-d9a1-4260-9399-cea0bd4bf1a6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5e1ecbfb-f4be-4fcf-b6a6-46549f8cefc1-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DA28
-       mov       rdx,7FFB4794DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,2B8005E1BA0
-       mov       r9,14932635690
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,14932623020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D950
-       mov       rdx,7FFB4794DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D6C8
-       mov       rdx,7FFB4794D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E890
-       mov       rdx,7FFB4789E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2B8005E1698
-       mov       r9,14932635188
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,14932623020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E3C0
-       mov       rdx,7FFB4789E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB47706F48
        mov       ecx,4D
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4777AF70
-       mov       rdx,7FFB477733C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ec7f11df-0f16-4349-a4f5-fb2df664c001-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2b3a5930-d957-4ee7-b236-3547928cbc2e-diff.temp
index 7372240..625cf50 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2b3a5930-d957-4ee7-b236-3547928cbc2e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ec7f11df-0f16-4349-a4f5-fb2df664c001-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DCA0
-       mov       rdx,7FFB4791DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB60
-       mov       rdx,7FFB4791DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,1ED92D91BA0
-       mov       r9,28F51652BB8
        mov       r8,[r8]
+       mov       r8,1ED82D91028
-       mov       r8,28F41653020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA88
-       mov       rdx,7FFB4791DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D800
-       mov       rdx,7FFB4791D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E948
-       mov       rdx,7FFB4786E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1ED92D91698
-       mov       r9,28F516526B0
        mov       r8,[r8]
+       mov       r8,1ED82D91028
-       mov       r8,28F41653020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E478
-       mov       rdx,7FFB4786E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477433C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f600fe5f-9732-4d35-bf2c-0fdd1f92059e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/996d5d79-986f-4751-914b-3d31f5bc1b42-diff.temp
index aecb593..f85423c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/996d5d79-986f-4751-914b-3d31f5bc1b42-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f600fe5f-9732-4d35-bf2c-0fdd1f92059e-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DCA0
-       mov       rdx,7FFB4791DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB60
-       mov       rdx,7FFB4791DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,28F746D1BA0
-       mov       r9,28F51652BB8
        mov       r8,[r8]
+       mov       r8,28F946D3020
-       mov       r8,28F41653020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA88
-       mov       rdx,7FFB4791DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D800
-       mov       rdx,7FFB4791D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E948
-       mov       rdx,7FFB4786E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,28F746D1698
-       mov       r9,28F516526B0
        mov       r8,[r8]
+       mov       r8,28F946D3020
-       mov       r8,28F41653020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4788E478
-       mov       rdx,7FFB4786E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477433C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a7c705eb-844d-4e66-8210-c09ca584e877-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5755220e-66ae-4c80-a5a8-ab6c1b07214b-diff.temp
index aecb593..f9b4698 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5755220e-66ae-4c80-a5a8-ab6c1b07214b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a7c705eb-844d-4e66-8210-c09ca584e877-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB50
-       mov       rdx,7FFB4791DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA10
-       mov       rdx,7FFB4791DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,20713FD2BB8
-       mov       r9,28F51652BB8
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,28F41653020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D938
-       mov       rdx,7FFB4791DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D6B0
-       mov       rdx,7FFB4791D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E848
-       mov       rdx,7FFB4786E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,20713FD26B0
-       mov       r9,28F516526B0
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,28F41653020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E378
-       mov       rdx,7FFB4786E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4775AF70
-       mov       rdx,7FFB477433C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/07e18408-377e-4f17-8c0d-b5e07677d9ab-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/386eaec7-d144-4928-855a-adde778cba75-diff.temp
index aecb593..f0656df 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/386eaec7-d144-4928-855a-adde778cba75-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/07e18408-377e-4f17-8c0d-b5e07677d9ab-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DB68
-       mov       rdx,7FFB4791DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DA28
-       mov       rdx,7FFB4791DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,2B8005E1BA0
-       mov       r9,28F51652BB8
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,28F41653020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D950
-       mov       rdx,7FFB4791DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D6C8
-       mov       rdx,7FFB4791D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E890
-       mov       rdx,7FFB4786E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2B8005E1698
-       mov       r9,28F516526B0
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,28F41653020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E3C0
-       mov       rdx,7FFB4786E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4777AF70
-       mov       rdx,7FFB477433C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fd556522-cf96-4516-9eb6-f5514b1bda16-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1c981485-170f-4376-b2dd-9c70aaba4d89-diff.temp
index aecb593..625cf50 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1c981485-170f-4376-b2dd-9c70aaba4d89-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fd556522-cf96-4516-9eb6-f5514b1bda16-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,28F746D1698
-       mov       r9,1ED92D91698
        mov       r8,[r8]
+       mov       r8,28F946D3020
-       mov       r8,1ED82D91028
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFB4788E478
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/30c6436a-aa0e-4b01-ba3e-a08d5734d3ab-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c029a237-c63e-41c3-b34a-07134ba5d9d4-diff.temp
index f85423c..f9b4698 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c029a237-c63e-41c3-b34a-07134ba5d9d4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/30c6436a-aa0e-4b01-ba3e-a08d5734d3ab-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB50
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA10
-       mov       rdx,7FFB4793DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,20713FD2BB8
-       mov       r9,1ED92D91BA0
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,1ED82D91028
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D938
-       mov       rdx,7FFB4793DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D6B0
-       mov       rdx,7FFB4793D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E848
-       mov       rdx,7FFB4788E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,20713FD26B0
-       mov       r9,1ED92D91698
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,1ED82D91028
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E378
-       mov       rdx,7FFB4788E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4775AF70
-       mov       rdx,7FFB477633C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e171ce78-7ac8-4f5e-9f52-463a425ace42-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c239f051-83cf-47cb-bcec-891d00f6622f-diff.temp
index f85423c..f0656df 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c239f051-83cf-47cb-bcec-891d00f6622f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e171ce78-7ac8-4f5e-9f52-463a425ace42-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DB68
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DA28
-       mov       rdx,7FFB4793DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,2B8005E1BA0
-       mov       r9,1ED92D91BA0
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,1ED82D91028
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D950
-       mov       rdx,7FFB4793DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D6C8
-       mov       rdx,7FFB4793D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E890
-       mov       rdx,7FFB4788E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2B8005E1698
-       mov       r9,1ED92D91698
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,1ED82D91028
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E3C0
-       mov       rdx,7FFB4788E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4777AF70
-       mov       rdx,7FFB477633C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/86811af3-8902-47cf-9da7-6c0edb0c3cd2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/36d48d40-711a-4463-abb0-943b80c378f5-diff.temp
index f85423c..625cf50 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/36d48d40-711a-4463-abb0-943b80c378f5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/86811af3-8902-47cf-9da7-6c0edb0c3cd2-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DB50
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DA10
-       mov       rdx,7FFB4793DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,20713FD2BB8
-       mov       r9,28F746D1BA0
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,28F946D3020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D938
-       mov       rdx,7FFB4793DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793D6B0
-       mov       rdx,7FFB4793D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E848
-       mov       rdx,7FFB4788E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,20713FD26B0
-       mov       r9,28F746D1698
        mov       r8,[r8]
+       mov       r8,20723FD3020
-       mov       r8,28F946D3020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E378
-       mov       rdx,7FFB4788E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4775AF70
-       mov       rdx,7FFB477633C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9898f120-29bc-45dc-978f-72c98eb6cd84-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3b8b3188-c30c-4b55-aed9-8e4b20a9e551-diff.temp
index f9b4698..f0656df 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3b8b3188-c30c-4b55-aed9-8e4b20a9e551-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9898f120-29bc-45dc-978f-72c98eb6cd84-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DB68
-       mov       rdx,7FFB4793DCA0
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DA28
-       mov       rdx,7FFB4793DB60
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,2B8005E1BA0
-       mov       r9,28F746D1BA0
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,28F946D3020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D950
-       mov       rdx,7FFB4793DA88
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D6C8
-       mov       rdx,7FFB4793D800
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E890
-       mov       rdx,7FFB4788E948
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2B8005E1698
-       mov       r9,28F746D1698
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,28F946D3020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E3C0
-       mov       rdx,7FFB4788E478
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4777AF70
-       mov       rdx,7FFB477633C0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/135e4f41-21f5-431d-97fe-495368534640-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/422718cf-b954-45d1-8483-d5ef3e507727-diff.temp
index f9b4698..625cf50 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/422718cf-b954-45d1-8483-d5ef3e507727-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/135e4f41-21f5-431d-97fe-495368534640-diff.temp
```
**Diff for AddRange01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M03_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DB68
-       mov       rdx,7FFB4793DB50
        mov       rcx,rdi
 M03_L06:
        jmp       short M03_L07
        je        short M03_L06
        test      rcx,rcx
        mov       rcx,[rbx+38]
        jle       short M03_L06
        cmp       qword ptr [rbx+8],38
        mov       rsi,rax
        call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rsi
 M03_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795DA28
-       mov       rdx,7FFB4793DA10
        mov       rcx,rdi
 M03_L04:
        jmp       short M03_L05
        je        short M03_L04
        test      rcx,rcx
        mov       rcx,[rcx+30]
        jle       short M03_L04
        cmp       qword ptr [rcx+8],30
        mov       rcx,rbx
        mov       rbx,[rdi+10]
        je        near ptr M03_L08
        test      ecx,ecx
        movzx     ecx,cl
        setg      cl
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rsi
        mov       byte ptr [r15+14],0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[r15+8]
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       rdx,rbx
        mov       r9,[r9]
+       mov       r9,2B8005E1BA0
-       mov       r9,20713FD2BB8
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,20723FD3020
 M03_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D950
-       mov       rdx,7FFB4793D938
        mov       rcx,rdi
 M03_L02:
        jmp       short M03_L03
        mov       rcx,[r14+28]
        je        short M03_L02
        cmp       qword ptr [r14+28],0
        je        near ptr M03_L10
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rbx,rbx
        mov       rbx,[r15+8]
        je        near ptr M03_L09
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[r15+8]
        mov       [r15+10],ebp
        mov       r15,rax
        call      CORINFO_HELP_NEWSFAST
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4795D6C8
-       mov       rdx,7FFB4793D6B0
        mov       rcx,rdi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rdi+10]
        mov       ebp,r9d
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 138
        jmp       near ptr DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rdx,rdi
 M02_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E890
-       mov       rdx,7FFB4790E848
        mov       rcx,rsi
 M02_L02:
        jmp       short M02_L03
        je        short M02_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2B8005E1698
-       mov       r9,20713FD26B0
        mov       r8,[r8]
+       mov       r8,2B7F05E3020
-       mov       r8,20723FD3020
 M02_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E3C0
-       mov       rdx,7FFB4790E378
        mov       rcx,rsi
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rcx,rcx
        mov       rcx,[rbx+10]
        mov       rbx,[rsi+10]
        mov       rdi,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 162
        int       3
        call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       rdi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M01_L02:
        jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rdx,rdi
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4777AF70
-       mov       rdx,7FFB4775AF70
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rcx+10]
        mov       rcx,[rsi+10]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       rcx,rdx
        je        short M01_L02
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rdx,rdx
        mov       rsi,rcx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
 ; Total bytes of code 109
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,[rsi+2B8]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+268]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			_ = people.AddRange(this._peopleToAdd, Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = GetPersonProperRefArray().ToCollection();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f9f54a91-a9d8-4407-94bd-f71c5ec79d14-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9a3a8e20-4865-4725-895f-ecab5e7e1bfd-diff.temp
index f0656df..625cf50 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9a3a8e20-4865-4725-895f-ecab5e7e1bfd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f9f54a91-a9d8-4407-94bd-f71c5ec79d14-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0810]
+       mov       r11,7FFB47260810
-       call      qword ptr [7FFB47890810]
-       mov       r11,7FFB47230810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E998
-       mov       rdx,7FFB4790E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ad2f5134-4ba2-4b22-86f6-889a6c5cc1bd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/02662182-16fc-4fcf-abcd-ce7c5c9553eb-diff.temp
index db2cdd9..9bc7b7e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/02662182-16fc-4fcf-abcd-ce7c5c9553eb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ad2f5134-4ba2-4b22-86f6-889a6c5cc1bd-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB47890810]
-       mov       r11,7FFB47230810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E998
-       mov       rdx,7FFB4790E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/19415416-a49f-4862-815e-306ebe8c4925-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bd864280-b01b-499d-99f3-63b63e224032-diff.temp
index db2cdd9..ce95b9e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bd864280-b01b-499d-99f3-63b63e224032-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/19415416-a49f-4862-815e-306ebe8c4925-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0810]
+       mov       r11,7FFB47270810
-       call      qword ptr [7FFB47890810]
-       mov       r11,7FFB47230810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E998
-       mov       rdx,7FFB4790E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/44c0338b-77fb-4003-a1fa-9b46c9d4f995-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1b9e6b0f-1c0c-48b0-9f65-4ca3bf75ca9a-diff.temp
index db2cdd9..4202bee 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1b9e6b0f-1c0c-48b0-9f65-4ca3bf75ca9a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/44c0338b-77fb-4003-a1fa-9b46c9d4f995-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6b1849bb-58eb-420a-b380-19d7defe8da3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c7d64115-4e06-4a03-84fe-b0c2b2e3adec-diff.temp
index db2cdd9..5ba4a2b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c7d64115-4e06-4a03-84fe-b0c2b2e3adec-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6b1849bb-58eb-420a-b380-19d7defe8da3-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB47890810]
-       mov       r11,7FFB47230810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E898
-       mov       rdx,7FFB4790E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/eadeddc6-8658-45a6-a672-984f1fe77dce-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9f1c74b2-1a91-4f9a-bb68-385f8c432ba7-diff.temp
index db2cdd9..f8fe277 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9f1c74b2-1a91-4f9a-bb68-385f8c432ba7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/eadeddc6-8658-45a6-a672-984f1fe77dce-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB47890810]
-       mov       r11,7FFB47230810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479799A0
-       mov       rdx,7FFB4790E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b2fa0b89-9b8a-4045-bec2-85e709db305a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e8d089be-5880-4052-b13a-5679d9d8a9c9-diff.temp
index db2cdd9..4e2d648 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e8d089be-5880-4052-b13a-5679d9d8a9c9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b2fa0b89-9b8a-4045-bec2-85e709db305a-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0910]
+       mov       r11,7FFB47270910
-       call      qword ptr [7FFB47890810]
-       mov       r11,7FFB47230810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479899A8
-       mov       rdx,7FFB4790E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/109f1769-d554-4368-9d0a-a65b45345c06-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/80c526a8-02df-4af9-af0a-8f3c725e5073-diff.temp
index db2cdd9..11cf4ea 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/80c526a8-02df-4af9-af0a-8f3c725e5073-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/109f1769-d554-4368-9d0a-a65b45345c06-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E998
-       mov       rdx,7FFB4793E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/166d4ad7-fc43-45e5-8b83-bb2a5351baff-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/67635612-fdd7-493f-90da-b8089d6d4b29-diff.temp
index 9bc7b7e..ce95b9e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/67635612-fdd7-493f-90da-b8089d6d4b29-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/166d4ad7-fc43-45e5-8b83-bb2a5351baff-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0810]
+       mov       r11,7FFB47270810
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E998
-       mov       rdx,7FFB4793E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/829b72e7-49c3-4e0c-bc74-516cb8b30791-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/05974c11-023d-49e2-a103-e55bd848ee08-diff.temp
index 9bc7b7e..4202bee 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/05974c11-023d-49e2-a103-e55bd848ee08-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/829b72e7-49c3-4e0c-bc74-516cb8b30791-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB47890810]
+       mov       r11,7FFB47230810
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E898
-       mov       rdx,7FFB4793E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1d1e2985-7f43-45f3-83f7-c6e04f72b8db-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8c29925a-1f40-46a0-96fd-36bd1dc449f8-diff.temp
index 9bc7b7e..5ba4a2b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8c29925a-1f40-46a0-96fd-36bd1dc449f8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1d1e2985-7f43-45f3-83f7-c6e04f72b8db-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E898
-       mov       rdx,7FFB4793E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7c65e2c0-749c-4d9e-82f8-8b2d041b458f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cba55888-6dd2-4967-b03d-68c584352b89-diff.temp
index 9bc7b7e..f8fe277 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cba55888-6dd2-4967-b03d-68c584352b89-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7c65e2c0-749c-4d9e-82f8-8b2d041b458f-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479799A0
-       mov       rdx,7FFB4793E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1866dad8-2a9f-4662-bb9c-fd024b79aa3b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9debc830-d4d7-428c-a9b1-e9dd17654b4d-diff.temp
index 9bc7b7e..4e2d648 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9debc830-d4d7-428c-a9b1-e9dd17654b4d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1866dad8-2a9f-4662-bb9c-fd024b79aa3b-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0910]
+       mov       r11,7FFB47270910
-       call      qword ptr [7FFB478C0810]
-       mov       r11,7FFB47260810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479899A8
-       mov       rdx,7FFB4793E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8406e90d-0d9f-41fb-83fe-269f97aef836-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e290066a-19ce-4fae-9766-565483090540-diff.temp
index 9bc7b7e..11cf4ea 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e290066a-19ce-4fae-9766-565483090540-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8406e90d-0d9f-41fb-83fe-269f97aef836-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0810]
+       mov       r11,7FFB47270810
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E998
-       mov       rdx,7FFB4792E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fb31ab98-d571-4fb6-95d3-a121b481f961-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/437d4813-3b06-4df3-bafd-13fcf0affdb5-diff.temp
index ce95b9e..4202bee 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/437d4813-3b06-4df3-bafd-13fcf0affdb5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fb31ab98-d571-4fb6-95d3-a121b481f961-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB47890810]
+       mov       r11,7FFB47230810
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E898
-       mov       rdx,7FFB4792E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e6863297-a853-4bb9-b294-122b456da0b1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/08c17c5f-f5fc-47dd-9c95-d81feb5ed5da-diff.temp
index ce95b9e..5ba4a2b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/08c17c5f-f5fc-47dd-9c95-d81feb5ed5da-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e6863297-a853-4bb9-b294-122b456da0b1-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7ad8894f-2655-4250-91de-c39d54bff263-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/01650bd2-beb8-4751-b4a1-0a79d85e7c83-diff.temp
index ce95b9e..f8fe277 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/01650bd2-beb8-4751-b4a1-0a79d85e7c83-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7ad8894f-2655-4250-91de-c39d54bff263-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479799A0
-       mov       rdx,7FFB4792E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b2e88f19-bf96-45bb-ac07-d30b0c6c053e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/df31f84c-7f3d-40c1-98a7-37157448131f-diff.temp
index ce95b9e..4e2d648 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/df31f84c-7f3d-40c1-98a7-37157448131f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b2e88f19-bf96-45bb-ac07-d30b0c6c053e-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0910]
+       mov       r11,7FFB47270910
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479899A8
-       mov       rdx,7FFB4792E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6a7bf49f-fdf5-4575-a9e6-a7f0500f54b2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2b039428-6ed0-4ed9-9142-d365d555ad68-diff.temp
index ce95b9e..11cf4ea 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2b039428-6ed0-4ed9-9142-d365d555ad68-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6a7bf49f-fdf5-4575-a9e6-a7f0500f54b2-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB47890810]
+       mov       r11,7FFB47230810
-       call      qword ptr [7FFB478D0810]
-       mov       r11,7FFB47270810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E898
-       mov       rdx,7FFB4794E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/099ae245-35d3-4733-bdbb-b4471572059a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ac9cbaef-eec8-4632-a7d2-f0edd69831b0-diff.temp
index 4202bee..5ba4a2b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ac9cbaef-eec8-4632-a7d2-f0edd69831b0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/099ae245-35d3-4733-bdbb-b4471572059a-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB478D0810]
-       mov       r11,7FFB47270810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E898
-       mov       rdx,7FFB4794E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d84fab5a-bbb1-40e2-b941-73109ac0f22e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2040dde8-3be8-464c-9bb7-105b372527c2-diff.temp
index 4202bee..f8fe277 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2040dde8-3be8-464c-9bb7-105b372527c2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d84fab5a-bbb1-40e2-b941-73109ac0f22e-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB478D0810]
-       mov       r11,7FFB47270810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479799A0
-       mov       rdx,7FFB4794E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/475c5c17-a6dc-4ae6-afd5-bba7772cb27d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63290257-312c-4efa-be85-cb781a2241a5-diff.temp
index 4202bee..4e2d648 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63290257-312c-4efa-be85-cb781a2241a5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/475c5c17-a6dc-4ae6-afd5-bba7772cb27d-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0910]
+       mov       r11,7FFB47270910
-       call      qword ptr [7FFB478D0810]
-       mov       r11,7FFB47270810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479899A8
-       mov       rdx,7FFB4794E998
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98d86e1a-b297-4a8d-a213-e2329a9ab5fc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a6023ad2-b3de-4745-b647-6bbb610f39a8-diff.temp
index 4202bee..11cf4ea 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a6023ad2-b3de-4745-b647-6bbb610f39a8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98d86e1a-b297-4a8d-a213-e2329a9ab5fc-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478B0810]
+       mov       r11,7FFB47250810
-       call      qword ptr [7FFB47890810]
-       mov       r11,7FFB47230810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E898
-       mov       rdx,7FFB4790E898
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4ebce6c7-bd5e-40e1-a845-b343c4624ee4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/05e320b4-1209-4192-93f9-a0b30024d98c-diff.temp
index 5ba4a2b..f8fe277 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/05e320b4-1209-4192-93f9-a0b30024d98c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4ebce6c7-bd5e-40e1-a845-b343c4624ee4-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB47890810]
-       mov       r11,7FFB47230810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479799A0
-       mov       rdx,7FFB4790E898
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/03465660-7948-4f75-9386-bef6432d7f82-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4cd2ca7a-5e74-44dc-87ca-1a1e7bb5fe2a-diff.temp
index 5ba4a2b..4e2d648 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4cd2ca7a-5e74-44dc-87ca-1a1e7bb5fe2a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/03465660-7948-4f75-9386-bef6432d7f82-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0910]
+       mov       r11,7FFB47270910
-       call      qword ptr [7FFB47890810]
-       mov       r11,7FFB47230810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479899A8
-       mov       rdx,7FFB4790E898
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/128bcda9-4fe3-4b1a-ac80-f5ec35ea65a2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/77678b77-21cf-433b-bed3-7e29e1e2d891-diff.temp
index 5ba4a2b..11cf4ea 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/77678b77-21cf-433b-bed3-7e29e1e2d891-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/128bcda9-4fe3-4b1a-ac80-f5ec35ea65a2-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478C0910]
+       mov       r11,7FFB47260910
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479799A0
-       mov       rdx,7FFB4792E898
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9dc4bb63-8d7c-4197-b140-62e74dbb7649-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/38ea7350-5e58-4335-a4aa-3940b3f08562-diff.temp
index f8fe277..4e2d648 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/38ea7350-5e58-4335-a4aa-3940b3f08562-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9dc4bb63-8d7c-4197-b140-62e74dbb7649-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0910]
+       mov       r11,7FFB47270910
-       call      qword ptr [7FFB478B0810]
-       mov       r11,7FFB47250810
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479899A8
-       mov       rdx,7FFB4792E898
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/59b20a29-c537-4c0c-95dd-22f1a4ec68f5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/43f6ba52-a32e-4604-adb4-effea7c60dd2-diff.temp
index f8fe277..11cf4ea 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/43f6ba52-a32e-4604-adb4-effea7c60dd2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/59b20a29-c537-4c0c-95dd-22f1a4ec68f5-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L02
        jo        short M01_L03
        add       rdi,1
        je        short M01_L04
        test      eax,eax
+       call      qword ptr [7FFB478D0910]
+       mov       r11,7FFB47270910
-       call      qword ptr [7FFB478C0910]
-       mov       r11,7FFB47260910
        mov       rcx,rsi
 M01_L02:
        mov       [rbp+0FFE0],rsi
        mov       rsi,rax
        call      qword ptr [r11]
        mov       rcx,rsi
 M01_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479899A8
-       mov       rdx,7FFB479799A0
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      r11,r11
        mov       r11,[rdx+18]
        mov       rdx,[rcx+10]
        xor       edi,edi
        je        short M01_L05
        test      rsi,rsi
        mov       rsi,rdx
        mov       [rbp+0FFE8],rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,40
        push      rsi
        push      rdi
        push      rbp
 ; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 66
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+18]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/47c42390-d8c8-4659-8069-f268da640be4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d6b4057d-b429-4462-a949-e839e7c7d859-diff.temp
index 4e2d648..11cf4ea 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d6b4057d-b429-4462-a949-e839e7c7d859-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/47c42390-d8c8-4659-8069-f268da640be4-diff.temp
```
