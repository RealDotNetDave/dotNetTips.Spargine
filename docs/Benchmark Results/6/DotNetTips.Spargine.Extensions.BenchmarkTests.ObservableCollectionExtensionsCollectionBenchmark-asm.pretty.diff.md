## DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark-20220427-211421
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660760]
+       mov       r11,7FFE3C0B0760
-       call      qword ptr [7FFE3C670760]
-       mov       r11,7FFE3C0C0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/3ff8c34b-236c-4903-8ec3-de525e826e5f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/744004fe-9f40-448d-9d40-ce70b75cd3e3-diff.temp
index b9705d9..326790d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/744004fe-9f40-448d-9d40-ce70b75cd3e3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/3ff8c34b-236c-4903-8ec3-de525e826e5f-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C680790]
+       mov       r11,7FFE3C0C0790
-       call      qword ptr [7FFE3C670760]
-       mov       r11,7FFE3C0C0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/687fe9cd-dc94-4e0f-a37f-72b9b35662c6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/67d1ec08-792a-4bf4-9dfe-3b5a083ede2a-diff.temp
index b9705d9..3d2b935 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/67d1ec08-792a-4bf4-9dfe-3b5a083ede2a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/687fe9cd-dc94-4e0f-a37f-72b9b35662c6-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C680760]
+       mov       r11,7FFE3C0D0760
-       call      qword ptr [7FFE3C670760]
-       mov       r11,7FFE3C0C0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/304fd791-77e5-4c40-8dc8-91c8ceaa7d37-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/fd73111c-756c-48a8-9360-8cc866a8e563-diff.temp
index b9705d9..26a71a5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/fd73111c-756c-48a8-9360-8cc866a8e563-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/304fd791-77e5-4c40-8dc8-91c8ceaa7d37-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C6A0790]
+       mov       r11,7FFE3C0E0790
-       call      qword ptr [7FFE3C670760]
-       mov       r11,7FFE3C0C0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/78b4267a-8170-4471-9cd8-614e9956f38b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/445fb3c2-07a4-4ffd-bbc6-f117aaa86827-diff.temp
index b9705d9..c54904a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/445fb3c2-07a4-4ffd-bbc6-f117aaa86827-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/78b4267a-8170-4471-9cd8-614e9956f38b-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660760]
+       mov       r11,7FFE3C0B0760
-       call      qword ptr [7FFE3C670760]
-       mov       r11,7FFE3C0C0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/e40704cf-4fb1-4e13-bfd3-10d186814bf5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/51b69329-60d9-4126-8924-5f0d4bd99178-diff.temp
index b9705d9..24c3a41 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/51b69329-60d9-4126-8924-5f0d4bd99178-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/e40704cf-4fb1-4e13-bfd3-10d186814bf5-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C670760]
-       mov       r11,7FFE3C0C0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/6fae355e-a597-4bca-b2d2-af3eeef8c2ef-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/07cb4004-c6d2-4f5b-9cfd-bdb19402360e-diff.temp
index b9705d9..f64724b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/07cb4004-c6d2-4f5b-9cfd-bdb19402360e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/6fae355e-a597-4bca-b2d2-af3eeef8c2ef-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C670760]
-       mov       r11,7FFE3C0C0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/0a979a03-67f8-4be4-abbf-36ef322cb24e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/ca3f52e4-8788-41f5-8db5-7c11db417b21-diff.temp
index b9705d9..6897397 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/ca3f52e4-8788-41f5-8db5-7c11db417b21-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/0a979a03-67f8-4be4-abbf-36ef322cb24e-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C680790]
+       mov       r11,7FFE3C0C0790
-       call      qword ptr [7FFE3C660760]
-       mov       r11,7FFE3C0B0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/0af8ef86-b2f5-4c88-be4b-1941a51b66c6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/58255b73-9624-49d6-a591-55d5bbc10ab7-diff.temp
index 326790d..3d2b935 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/58255b73-9624-49d6-a591-55d5bbc10ab7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/0af8ef86-b2f5-4c88-be4b-1941a51b66c6-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C680760]
+       mov       r11,7FFE3C0D0760
-       call      qword ptr [7FFE3C660760]
-       mov       r11,7FFE3C0B0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/320c3b9c-ef36-46d1-af2f-6f711235155d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/8703c01d-4c9c-44a3-88f6-58db7a986ee4-diff.temp
index 326790d..26a71a5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/8703c01d-4c9c-44a3-88f6-58db7a986ee4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/320c3b9c-ef36-46d1-af2f-6f711235155d-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C6A0790]
+       mov       r11,7FFE3C0E0790
-       call      qword ptr [7FFE3C660760]
-       mov       r11,7FFE3C0B0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/240c4a95-7752-4cf7-bbd2-02d8680d86ef-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/133755f8-8c4b-48ad-8107-01b4adb0cc2d-diff.temp
index 326790d..c54904a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/133755f8-8c4b-48ad-8107-01b4adb0cc2d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/240c4a95-7752-4cf7-bbd2-02d8680d86ef-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/ee6da322-d46b-49aa-9622-f63887bd4ec5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/c04f731e-a9af-4256-8c19-338c36bcc328-diff.temp
index 326790d..24c3a41 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/c04f731e-a9af-4256-8c19-338c36bcc328-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/ee6da322-d46b-49aa-9622-f63887bd4ec5-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C660760]
-       mov       r11,7FFE3C0B0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/cf823655-7e68-4ff8-8695-c0ce2171fc9b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a58642c4-0660-4cb6-b0f9-34acaa8cce4f-diff.temp
index 326790d..f64724b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a58642c4-0660-4cb6-b0f9-34acaa8cce4f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/cf823655-7e68-4ff8-8695-c0ce2171fc9b-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C660760]
-       mov       r11,7FFE3C0B0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b5217a69-fa79-46f8-865e-834fd25e0eb7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a64e841e-eb7a-4582-aa55-81e822c7c984-diff.temp
index 326790d..6897397 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a64e841e-eb7a-4582-aa55-81e822c7c984-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b5217a69-fa79-46f8-865e-834fd25e0eb7-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C680760]
+       mov       r11,7FFE3C0D0760
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/2117d54a-48ab-4e11-b6c8-cdc265c01f3e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/93e3fbe0-8ce9-4f69-95c6-f14b47f8ec34-diff.temp
index 3d2b935..26a71a5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/93e3fbe0-8ce9-4f69-95c6-f14b47f8ec34-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/2117d54a-48ab-4e11-b6c8-cdc265c01f3e-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C6A0790]
+       mov       r11,7FFE3C0E0790
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/bddee722-53bd-46ec-9dca-f6f6e58d7d49-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/8137bab7-46fa-46aa-a2fc-68fd41a85510-diff.temp
index 3d2b935..c54904a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/8137bab7-46fa-46aa-a2fc-68fd41a85510-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/bddee722-53bd-46ec-9dca-f6f6e58d7d49-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660760]
+       mov       r11,7FFE3C0B0760
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d7f12e1c-ea61-4880-9f82-24edd5d6375f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/5d5088f4-2068-4140-bc48-31bbe3a852ef-diff.temp
index 3d2b935..24c3a41 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/5d5088f4-2068-4140-bc48-31bbe3a852ef-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d7f12e1c-ea61-4880-9f82-24edd5d6375f-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/085e9218-724a-4ed0-80d8-59e81703f3f4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b222f642-faa6-4467-8fa7-138ae6257b28-diff.temp
index 3d2b935..f64724b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b222f642-faa6-4467-8fa7-138ae6257b28-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/085e9218-724a-4ed0-80d8-59e81703f3f4-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/ba87ff72-f9a6-4923-ac73-3ab7ab11addc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/f667d6ae-d032-43d7-8d5c-91de2be0129c-diff.temp
index 3d2b935..6897397 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/f667d6ae-d032-43d7-8d5c-91de2be0129c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/ba87ff72-f9a6-4923-ac73-3ab7ab11addc-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C6A0790]
+       mov       r11,7FFE3C0E0790
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/483e3e0f-e5a5-4f98-8da0-faf4b02b7e53-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/3684603f-f232-46bc-8e4f-e97cfc3fff45-diff.temp
index 26a71a5..c54904a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/3684603f-f232-46bc-8e4f-e97cfc3fff45-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/483e3e0f-e5a5-4f98-8da0-faf4b02b7e53-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660760]
+       mov       r11,7FFE3C0B0760
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/5c7c3433-1d8c-4293-a813-1d928262b36f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/fbc61a06-f1d5-4881-b7ed-dc3d7faf1af4-diff.temp
index 26a71a5..24c3a41 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/fbc61a06-f1d5-4881-b7ed-dc3d7faf1af4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/5c7c3433-1d8c-4293-a813-1d928262b36f-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a7272630-dbf2-4d20-b86c-63a740b18d93-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/1a6464a2-4e92-4172-a0d9-a028a2a28752-diff.temp
index 26a71a5..f64724b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/1a6464a2-4e92-4172-a0d9-a028a2a28752-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a7272630-dbf2-4d20-b86c-63a740b18d93-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/94b7d758-923e-4855-a0a8-2d709d39bea1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/9440b3a9-2e1a-47cb-a9e0-39aab3bb0ff1-diff.temp
index 26a71a5..6897397 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/9440b3a9-2e1a-47cb-a9e0-39aab3bb0ff1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/94b7d758-923e-4855-a0a8-2d709d39bea1-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660760]
+       mov       r11,7FFE3C0B0760
-       call      qword ptr [7FFE3C6A0790]
-       mov       r11,7FFE3C0E0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d3c3ffab-bd8a-444e-9f3c-508b7d0a141e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/7d5dbe32-0012-49d0-8b3e-eec64d9e1d01-diff.temp
index c54904a..24c3a41 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/7d5dbe32-0012-49d0-8b3e-eec64d9e1d01-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d3c3ffab-bd8a-444e-9f3c-508b7d0a141e-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C6A0790]
-       mov       r11,7FFE3C0E0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/30345739-fb73-4c33-9b5b-bb28c259cc0e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/12fc4229-7a6e-4bd8-a55b-fe1a70eeab9d-diff.temp
index c54904a..f64724b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/12fc4229-7a6e-4bd8-a55b-fe1a70eeab9d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/30345739-fb73-4c33-9b5b-bb28c259cc0e-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C6A0790]
-       mov       r11,7FFE3C0E0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/93d6958e-0978-4a17-9368-52bd9ae8a881-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/06e5aa86-7351-49b2-af56-cd89e040dceb-diff.temp
index c54904a..6897397 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/06e5aa86-7351-49b2-af56-cd89e040dceb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/93d6958e-0978-4a17-9368-52bd9ae8a881-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C660760]
-       mov       r11,7FFE3C0B0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/cc0f7eff-bafc-437f-8221-e534277b4ca9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d843fdd7-7fc5-40a4-a060-c62f054b976f-diff.temp
index 24c3a41..f64724b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d843fdd7-7fc5-40a4-a060-c62f054b976f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/cc0f7eff-bafc-437f-8221-e534277b4ca9-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C660760]
-       mov       r11,7FFE3C0B0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/87aa718e-1dd6-41d8-b611-7de337ff9ee0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/70cac83f-18bc-469a-86ef-bf0c6599bb9e-diff.temp
index 24c3a41..6897397 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/70cac83f-18bc-469a-86ef-bf0c6599bb9e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/87aa718e-1dd6-41d8-b611-7de337ff9ee0-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        sete      dil
        cmp       eax,5
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C670790]
-       mov       r11,7FFE3C0B0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a579550b-f2b8-404f-8069-11b906be640f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/0a50114d-9a6d-4609-940d-7baa5568f382-diff.temp
index f64724b..6897397 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/0a50114d-9a6d-4609-940d-7baa5568f382-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a579550b-f2b8-404f-8069-11b906be640f-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C680790]
+       mov       r11,7FFE3C0C0790
-       call      qword ptr [7FFE3C6607B8]
-       mov       r11,7FFE3C0A07B8
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/dc7380c9-e31d-4c71-8f13-4511199e9170-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b60ce631-6b67-4448-8f84-48a77e8f9d05-diff.temp
index 05c55db..8ef48f5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b60ce631-6b67-4448-8f84-48a77e8f9d05-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/dc7380c9-e31d-4c71-8f13-4511199e9170-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C680760]
+       mov       r11,7FFE3C0D0760
-       call      qword ptr [7FFE3C6607B8]
-       mov       r11,7FFE3C0A07B8
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d4596339-0851-46f4-8b06-85c0c3da1cab-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/f0afca5b-a32b-4041-ab9d-ffd5fca44553-diff.temp
index 05c55db..d4e663a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/f0afca5b-a32b-4041-ab9d-ffd5fca44553-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d4596339-0851-46f4-8b06-85c0c3da1cab-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C680760]
+       mov       r11,7FFE3C0D0760
-       call      qword ptr [7FFE3C6607B8]
-       mov       r11,7FFE3C0A07B8
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/28f3085b-a716-42da-bd55-6f5bae6c6034-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/6c9a2437-3342-4ada-8789-a362afd7380b-diff.temp
index 05c55db..c1dcf47 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/6c9a2437-3342-4ada-8789-a362afd7380b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/28f3085b-a716-42da-bd55-6f5bae6c6034-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C690760]
+       mov       r11,7FFE3C0E0760
-       call      qword ptr [7FFE3C6607B8]
-       mov       r11,7FFE3C0A07B8
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/955dbf96-4734-4fc1-921e-05089fb6d5b2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/028b8f37-e451-4ee2-a640-04956c227807-diff.temp
index 05c55db..4cb33ce 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/028b8f37-e451-4ee2-a640-04956c227807-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/955dbf96-4734-4fc1-921e-05089fb6d5b2-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C6607B8]
-       mov       r11,7FFE3C0A07B8
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/9d069887-38a2-4bc2-858a-e9ec04ca9fad-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/ec7acdcd-464d-4639-a38d-ec16c2ba1bb8-diff.temp
index 05c55db..8ada863 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/ec7acdcd-464d-4639-a38d-ec16c2ba1bb8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/9d069887-38a2-4bc2-858a-e9ec04ca9fad-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C6607B8]
-       mov       r11,7FFE3C0A07B8
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/be11d023-215b-452a-b489-08fb0508987a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/4c272908-0b0f-4ed1-8c7c-552762b2dad2-diff.temp
index 05c55db..2fc7ca6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/4c272908-0b0f-4ed1-8c7c-552762b2dad2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/be11d023-215b-452a-b489-08fb0508987a-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C6607B8]
-       mov       r11,7FFE3C0A07B8
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/822906f6-9887-45c3-9855-60a139115a8a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/998bda04-635d-4d05-b4f4-6827bf14815e-diff.temp
index 05c55db..9891ae3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/998bda04-635d-4d05-b4f4-6827bf14815e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/822906f6-9887-45c3-9855-60a139115a8a-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C680760]
+       mov       r11,7FFE3C0D0760
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/3aeebfc2-2aa5-461e-9e40-27ecd4fb7223-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/91728196-9e29-4f4b-8373-003a19a78e33-diff.temp
index 8ef48f5..d4e663a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/91728196-9e29-4f4b-8373-003a19a78e33-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/3aeebfc2-2aa5-461e-9e40-27ecd4fb7223-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C680760]
+       mov       r11,7FFE3C0D0760
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/f4abe577-74e7-4065-ae2d-acc77bbbae49-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/939f7d3f-745e-4b84-9659-21b070747de8-diff.temp
index 8ef48f5..c1dcf47 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/939f7d3f-745e-4b84-9659-21b070747de8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/f4abe577-74e7-4065-ae2d-acc77bbbae49-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C690760]
+       mov       r11,7FFE3C0E0760
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/c39c4e92-f72c-413b-ad9f-91ebf68ecc13-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/987fbe70-84d6-4f69-813f-a827b9e2476f-diff.temp
index 8ef48f5..4cb33ce 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/987fbe70-84d6-4f69-813f-a827b9e2476f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/c39c4e92-f72c-413b-ad9f-91ebf68ecc13-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/147666e4-a00b-4a79-87cb-15dee4d5af1a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/99aa2cc8-bc16-44bc-8352-8de2795763f1-diff.temp
index 8ef48f5..8ada863 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/99aa2cc8-bc16-44bc-8352-8de2795763f1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/147666e4-a00b-4a79-87cb-15dee4d5af1a-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/0e451168-8a64-491d-960b-8b74dba6b441-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/5ede855d-abf5-47c8-a508-32478539cb2a-diff.temp
index 8ef48f5..2fc7ca6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/5ede855d-abf5-47c8-a508-32478539cb2a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/0e451168-8a64-491d-960b-8b74dba6b441-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C680790]
-       mov       r11,7FFE3C0C0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/6e3cfe3f-d472-4411-8161-b3596e23cdd9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/51cb082f-358e-4fc6-8632-9324b0614440-diff.temp
index 8ef48f5..9891ae3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/51cb082f-358e-4fc6-8632-9324b0614440-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/6e3cfe3f-d472-4411-8161-b3596e23cdd9-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/1cd0f591-f5cd-4563-aabf-a0d49c32d092-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/8a73008b-2294-444e-ac65-37eb11ff7871-diff.temp
index d4e663a..c1dcf47 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/8a73008b-2294-444e-ac65-37eb11ff7871-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/1cd0f591-f5cd-4563-aabf-a0d49c32d092-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C690760]
+       mov       r11,7FFE3C0E0760
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/2a207fcf-4405-4c10-9e5c-91acf8b726cc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/3a151fd9-802e-43cc-ba3b-9bc7dae104a6-diff.temp
index d4e663a..4cb33ce 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/3a151fd9-802e-43cc-ba3b-9bc7dae104a6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/2a207fcf-4405-4c10-9e5c-91acf8b726cc-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/c8045a8a-857a-44c4-af53-385ccdec3aef-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/75dd9c6c-a8b2-46fb-bcc6-1bbac9c3e11e-diff.temp
index d4e663a..8ada863 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/75dd9c6c-a8b2-46fb-bcc6-1bbac9c3e11e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/c8045a8a-857a-44c4-af53-385ccdec3aef-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/51419c69-64d5-4050-84d9-3f50aaa2809e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/7c675b7b-aecd-464d-91ef-c25aa2e30ee1-diff.temp
index d4e663a..2fc7ca6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/7c675b7b-aecd-464d-91ef-c25aa2e30ee1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/51419c69-64d5-4050-84d9-3f50aaa2809e-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/7a2d0701-dc4c-4217-a39d-517ee4e5dd57-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/4c024134-6bbe-41fa-940a-6df2f5947872-diff.temp
index d4e663a..9891ae3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/4c024134-6bbe-41fa-940a-6df2f5947872-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/7a2d0701-dc4c-4217-a39d-517ee4e5dd57-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C690760]
+       mov       r11,7FFE3C0E0760
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/e40feaad-d390-4fa4-b194-758654f1950f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/1770614c-599b-440c-b120-f78beaa38128-diff.temp
index c1dcf47..4cb33ce 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/1770614c-599b-440c-b120-f78beaa38128-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/e40feaad-d390-4fa4-b194-758654f1950f-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a0dc8ba6-d6ca-465f-82d7-aea14afcc21f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b1506235-d378-49f9-b405-310c3d31e397-diff.temp
index c1dcf47..8ada863 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b1506235-d378-49f9-b405-310c3d31e397-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a0dc8ba6-d6ca-465f-82d7-aea14afcc21f-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/0dceb0e4-7139-498d-9ac7-7e2d5db5d8c8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/4b20df6f-a008-464e-958b-236524116439-diff.temp
index c1dcf47..2fc7ca6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/4b20df6f-a008-464e-958b-236524116439-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/0dceb0e4-7139-498d-9ac7-7e2d5db5d8c8-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C680760]
-       mov       r11,7FFE3C0D0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/ba14ee71-6cac-4688-ad9d-a8f203ab7cc4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/298a6520-90cb-4b6d-a573-d8d31c6841ee-diff.temp
index c1dcf47..9891ae3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/298a6520-90cb-4b6d-a573-d8d31c6841ee-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/ba14ee71-6cac-4688-ad9d-a8f203ab7cc4-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C670790]
+       mov       r11,7FFE3C0B0790
-       call      qword ptr [7FFE3C690760]
-       mov       r11,7FFE3C0E0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a6b9e501-b3a8-42eb-bc16-a258f633572a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/2206e322-a5e1-42b1-8d0b-1c1d482b580e-diff.temp
index 4cb33ce..8ada863 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/2206e322-a5e1-42b1-8d0b-1c1d482b580e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/a6b9e501-b3a8-42eb-bc16-a258f633572a-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C690760]
-       mov       r11,7FFE3C0E0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/f904f5ae-3944-4a13-9f8f-72701864b5a1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/cb8e6070-7c29-46de-84c8-a0530257bf6e-diff.temp
index 4cb33ce..2fc7ca6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/cb8e6070-7c29-46de-84c8-a0530257bf6e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/f904f5ae-3944-4a13-9f8f-72701864b5a1-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C690760]
-       mov       r11,7FFE3C0E0760
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/da03879a-ea1b-4c18-9929-ffb763c444d4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b5a1d815-d3fe-46b7-b861-fd69355abff6-diff.temp
index 4cb33ce..9891ae3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b5a1d815-d3fe-46b7-b861-fd69355abff6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/da03879a-ea1b-4c18-9929-ffb763c444d4-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C670790]
-       mov       r11,7FFE3C0B0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d7f6a4dd-82f8-4c8d-a336-5db3fdd7eb6e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/03224345-d641-4131-8564-b8cd2afb1d09-diff.temp
index 8ada863..2fc7ca6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/03224345-d641-4131-8564-b8cd2afb1d09-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d7f6a4dd-82f8-4c8d-a336-5db3fdd7eb6e-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
movzx     edi,dil
        setg      dil
        test      eax,eax
+       call      qword ptr [7FFE3C660790]
+       mov       r11,7FFE3C0A0790
-       call      qword ptr [7FFE3C670790]
-       mov       r11,7FFE3C0B0790
        mov       rcx,[rax+8]
 M00_L00:
        jmp       short M00_L01
        xor       edi,edi
        jne       short M00_L00
        test      rax,rax
        call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
        mov       rdx,[rsi+100]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b8e6dea1-0569-4b59-85c3-168e0f23f8ab-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d0327ace-7f28-42a5-98d7-ad67f76140cd-diff.temp
index 8ada863..9891ae3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/d0327ace-7f28-42a5-98d7-ad67f76140cd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/b8e6dea1-0569-4b59-85c3-168e0f23f8ab-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
.NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/09c69a54-71ec-43a1-8509-6414df727ea3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/8d8f9f6d-c2c8-4733-bb8a-b7e39e83b270-diff.temp
index 2fc7ca6..9891ae3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/8d8f9f6d-c2c8-4733-bb8a-b7e39e83b270-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/Benchmarking/OutputBin/net6.0/BenchmarkDotNet.Artifacts/results/09c69a54-71ec-43a1-8509-6414df727ea3-diff.temp
```
