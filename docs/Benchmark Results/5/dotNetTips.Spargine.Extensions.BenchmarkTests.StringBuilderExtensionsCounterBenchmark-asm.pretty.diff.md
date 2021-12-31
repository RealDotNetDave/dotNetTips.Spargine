## dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark-20211222-210910
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,20C564B3020
-       mov       rax,2B964273020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,20C564C2058
-       mov       rax,2B944272210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,20C564B1508
-       mov       rax,2B964271508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,20C564C2050
-       mov       rdx,2B944272208
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/651055c6-5b9e-4288-bce8-71232c7f85b9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/73194def-451c-4c63-95fb-66f6bb850b85-diff.temp
index 3e72290..0c8c688 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/73194def-451c-4c63-95fb-66f6bb850b85-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/651055c6-5b9e-4288-bce8-71232c7f85b9-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,20C04CF3020
-       mov       rax,2B964273020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,20C04D03850
-       mov       rax,2B944272210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,20C04CF1508
-       mov       rax,2B964271508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,20C04D03848
-       mov       rdx,2B944272208
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ad46d29-58ff-4d80-bf3d-3964a869ce4f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/172c3654-f120-4f40-9290-7e3248a7a2c0-diff.temp
index 3e72290..fa7ed49 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/172c3654-f120-4f40-9290-7e3248a7a2c0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ad46d29-58ff-4d80-bf3d-3964a869ce4f-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,171151A3020
-       mov       rax,2B964273020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,171151A4620
-       mov       rax,2B944272210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,171151A1508
-       mov       rax,2B964271508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,171151A4618
-       mov       rdx,2B944272208
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/46b9da3f-cc42-4b9f-a3e6-dfe0e3a55b95-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/818c6286-75c8-4ecc-958d-65ddec522234-diff.temp
index 3e72290..b050570 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/818c6286-75c8-4ecc-958d-65ddec522234-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/46b9da3f-cc42-4b9f-a3e6-dfe0e3a55b95-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,270A9693020
-       mov       rax,2B964273020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,270B9696C98
-       mov       rax,2B944272210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,270A9691508
-       mov       rax,2B964271508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,270B9696C90
-       mov       rdx,2B944272208
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e9b1cd25-6bf9-427e-be02-b51d60438d16-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4d3ebb85-20be-4036-8add-4b483024f0fe-diff.temp
index 3e72290..46e53a4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4d3ebb85-20be-4036-8add-4b483024f0fe-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e9b1cd25-6bf9-427e-be02-b51d60438d16-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,24EEBB63020
-       mov       rax,2B964273020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,24EFBB611F8
-       mov       rax,2B944272210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24EEBB61508
-       mov       rax,2B964271508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,24EFBB611F0
-       mov       rdx,2B944272208
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/62b1f42f-d54c-4f9c-9595-1bf494bbef27-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da4bc716-3023-430d-b24a-7ee2c4ae1e3c-diff.temp
index 3e72290..06d25ec 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da4bc716-3023-430d-b24a-7ee2c4ae1e3c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/62b1f42f-d54c-4f9c-9595-1bf494bbef27-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,22B4BD53020
-       mov       rax,2B964273020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,22B3BD511F8
-       mov       rax,2B944272210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22B4BD51508
-       mov       rax,2B964271508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22B3BD511F0
-       mov       rdx,2B944272208
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/82160520-98bc-4602-a0dd-0945a45184e8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/13000280-e24a-4ef0-8183-71496b1ceede-diff.temp
index 3e72290..2feb619 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/13000280-e24a-4ef0-8183-71496b1ceede-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/82160520-98bc-4602-a0dd-0945a45184e8-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CBBC8F3020
-       mov       rax,2B964273020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1CB9C8F2210
-       mov       rax,2B944272210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1CBBC8F1508
-       mov       rax,2B964271508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1CB9C8F2208
-       mov       rdx,2B944272208
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a3d78b57-9bca-47f8-aca9-1d04201d4616-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6418258-04b7-49cf-bfe8-c5ce7b685abc-diff.temp
index 3e72290..c09ae21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6418258-04b7-49cf-bfe8-c5ce7b685abc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a3d78b57-9bca-47f8-aca9-1d04201d4616-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,20C04D03850
-       mov       rax,20C564C2058
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,20C04CF1508
-       mov       rax,20C564B1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,20C04D03848
-       mov       rdx,20C564C2050
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
        call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4201ad08-071c-427a-bf65-38070c2a7d4d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e7a69c0-77f8-4f16-9dd4-d9ad345de86f-diff.temp
index 0c8c688..fa7ed49 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e7a69c0-77f8-4f16-9dd4-d9ad345de86f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4201ad08-071c-427a-bf65-38070c2a7d4d-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,171151A3020
-       mov       rax,20C564B3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,171151A4620
-       mov       rax,20C564C2058
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,171151A1508
-       mov       rax,20C564B1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,171151A4618
-       mov       rdx,20C564C2050
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/50c549a5-979e-43bc-8b36-fc12d5e6ed33-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d90cd736-5b3d-4ad7-8c2f-d178cfbe3e91-diff.temp
index 0c8c688..b050570 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d90cd736-5b3d-4ad7-8c2f-d178cfbe3e91-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/50c549a5-979e-43bc-8b36-fc12d5e6ed33-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,270A9693020
-       mov       rax,20C564B3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,270B9696C98
-       mov       rax,20C564C2058
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,270A9691508
-       mov       rax,20C564B1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,270B9696C90
-       mov       rdx,20C564C2050
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dde5b813-20c8-4fc7-bf8f-3f66e23278e2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d7709171-1d00-4657-8058-aef3b1b43dbe-diff.temp
index 0c8c688..46e53a4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d7709171-1d00-4657-8058-aef3b1b43dbe-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dde5b813-20c8-4fc7-bf8f-3f66e23278e2-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,24EEBB63020
-       mov       rax,20C564B3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,24EFBB611F8
-       mov       rax,20C564C2058
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24EEBB61508
-       mov       rax,20C564B1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,24EFBB611F0
-       mov       rdx,20C564C2050
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a4641479-6e14-4b31-b5da-26ff2f7135f4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dbddbda2-de6a-4257-9056-40a8be8a173d-diff.temp
index 0c8c688..06d25ec 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dbddbda2-de6a-4257-9056-40a8be8a173d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a4641479-6e14-4b31-b5da-26ff2f7135f4-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,22B3BD511F8
-       mov       rax,20C564C2058
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22B4BD51508
-       mov       rax,20C564B1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22B3BD511F0
-       mov       rdx,20C564C2050
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
        call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc0330d4-bd93-4d23-8c5f-a4b7be919f70-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/509d58a3-ed00-48b9-97d8-7f32cfba32f6-diff.temp
index 0c8c688..2feb619 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/509d58a3-ed00-48b9-97d8-7f32cfba32f6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc0330d4-bd93-4d23-8c5f-a4b7be919f70-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CBBC8F3020
-       mov       rax,20C564B3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1CB9C8F2210
-       mov       rax,20C564C2058
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1CBBC8F1508
-       mov       rax,20C564B1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1CB9C8F2208
-       mov       rdx,20C564C2050
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d2c2d6ba-de56-4b75-a094-b0e79aa44de2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/024175ba-10aa-46e6-bb2a-ea033485c76d-diff.temp
index 0c8c688..c09ae21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/024175ba-10aa-46e6-bb2a-ea033485c76d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d2c2d6ba-de56-4b75-a094-b0e79aa44de2-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,171151A3020
-       mov       rax,20C04CF3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,171151A4620
-       mov       rax,20C04D03850
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,171151A1508
-       mov       rax,20C04CF1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,171151A4618
-       mov       rdx,20C04D03848
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3792bbe0-71ac-4687-86cf-d4c0902d0d9b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5a359c9c-2792-4848-b6c6-86535ad191a5-diff.temp
index fa7ed49..b050570 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5a359c9c-2792-4848-b6c6-86535ad191a5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3792bbe0-71ac-4687-86cf-d4c0902d0d9b-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,270A9693020
-       mov       rax,20C04CF3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,270B9696C98
-       mov       rax,20C04D03850
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,270A9691508
-       mov       rax,20C04CF1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,270B9696C90
-       mov       rdx,20C04D03848
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/94ce776c-59eb-460e-90ac-9a735726fd36-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b82ed119-1b81-4954-8e23-4c41323737d5-diff.temp
index fa7ed49..46e53a4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b82ed119-1b81-4954-8e23-4c41323737d5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/94ce776c-59eb-460e-90ac-9a735726fd36-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,24EEBB63020
-       mov       rax,20C04CF3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,24EFBB611F8
-       mov       rax,20C04D03850
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24EEBB61508
-       mov       rax,20C04CF1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,24EFBB611F0
-       mov       rdx,20C04D03848
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9ba9db13-2fb1-49b9-858c-41206e0faf0a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b9c557d4-eae5-45e0-bcf2-163c9867186a-diff.temp
index fa7ed49..06d25ec 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b9c557d4-eae5-45e0-bcf2-163c9867186a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9ba9db13-2fb1-49b9-858c-41206e0faf0a-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,22B3BD511F8
-       mov       rax,20C04D03850
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22B4BD51508
-       mov       rax,20C04CF1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22B3BD511F0
-       mov       rdx,20C04D03848
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
        call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4da6f687-eede-4b78-8e72-8383f6a74b3b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c62ec4db-a943-49f1-8033-7c54f417064d-diff.temp
index fa7ed49..2feb619 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c62ec4db-a943-49f1-8033-7c54f417064d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4da6f687-eede-4b78-8e72-8383f6a74b3b-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CBBC8F3020
-       mov       rax,20C04CF3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1CB9C8F2210
-       mov       rax,20C04D03850
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1CBBC8F1508
-       mov       rax,20C04CF1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1CB9C8F2208
-       mov       rdx,20C04D03848
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c2c34045-7145-482a-b257-d2cb8dfcdb3d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0ba125a4-0a9d-4e12-a5f8-2f21f03c061d-diff.temp
index fa7ed49..c09ae21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0ba125a4-0a9d-4e12-a5f8-2f21f03c061d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c2c34045-7145-482a-b257-d2cb8dfcdb3d-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,270A9693020
-       mov       rax,171151A3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,270B9696C98
-       mov       rax,171151A4620
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,270A9691508
-       mov       rax,171151A1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,270B9696C90
-       mov       rdx,171151A4618
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6DBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5b9a820f-dfb9-49f6-8fca-95c1037dd47e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c331ded7-26e8-4e60-beb8-df1c9d7a28ba-diff.temp
index b050570..46e53a4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c331ded7-26e8-4e60-beb8-df1c9d7a28ba-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5b9a820f-dfb9-49f6-8fca-95c1037dd47e-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,24EEBB63020
-       mov       rax,171151A3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,24EFBB611F8
-       mov       rax,171151A4620
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24EEBB61508
-       mov       rax,171151A1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,24EFBB611F0
-       mov       rdx,171151A4618
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6DBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4bb421dd-e186-4a2e-b18b-cffb14d5080b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b30f43c0-5cab-4dd0-a1c7-2de6de7b1783-diff.temp
index b050570..06d25ec 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b30f43c0-5cab-4dd0-a1c7-2de6de7b1783-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4bb421dd-e186-4a2e-b18b-cffb14d5080b-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,22B4BD53020
-       mov       rax,171151A3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,22B3BD511F8
-       mov       rax,171151A4620
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22B4BD51508
-       mov       rax,171151A1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22B3BD511F0
-       mov       rdx,171151A4618
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6DBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e9a3d0d1-1bad-45c9-8f8a-1a6ee2e18bf2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b91d4335-5398-4374-972a-d5ff139c17bf-diff.temp
index b050570..2feb619 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b91d4335-5398-4374-972a-d5ff139c17bf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e9a3d0d1-1bad-45c9-8f8a-1a6ee2e18bf2-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CBBC8F3020
-       mov       rax,171151A3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1CB9C8F2210
-       mov       rax,171151A4620
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1CBBC8F1508
-       mov       rax,171151A1508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1CB9C8F2208
-       mov       rdx,171151A4618
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6DBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f409d8bd-0dd7-4caa-b15f-65b17b4ccf34-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fe45749d-5226-49eb-9e6e-ce12f0ffeb59-diff.temp
index b050570..c09ae21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fe45749d-5226-49eb-9e6e-ce12f0ffeb59-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f409d8bd-0dd7-4caa-b15f-65b17b4ccf34-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,24EFBB611F8
-       mov       rax,270B9696C98
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24EEBB61508
-       mov       rax,270A9691508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,24EFBB611F0
-       mov       rdx,270B9696C90
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
        call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/afa40547-d0e6-496a-9642-d3a75612d419-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5b67f80c-a70f-40f7-a57d-a9f441039859-diff.temp
index 46e53a4..06d25ec 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5b67f80c-a70f-40f7-a57d-a9f441039859-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/afa40547-d0e6-496a-9642-d3a75612d419-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,22B4BD53020
-       mov       rax,270A9693020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,22B3BD511F8
-       mov       rax,270B9696C98
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22B4BD51508
-       mov       rax,270A9691508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22B3BD511F0
-       mov       rdx,270B9696C90
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1a59653a-1f90-49c1-833e-70e6f1b187c5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c83c8246-f38e-4f90-8cdd-13d9e749b195-diff.temp
index 46e53a4..2feb619 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c83c8246-f38e-4f90-8cdd-13d9e749b195-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1a59653a-1f90-49c1-833e-70e6f1b187c5-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CBBC8F3020
-       mov       rax,270A9693020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1CB9C8F2210
-       mov       rax,270B9696C98
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1CBBC8F1508
-       mov       rax,270A9691508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1CB9C8F2208
-       mov       rdx,270B9696C90
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e50fc494-b67f-4ec5-9f56-33c41f1fd659-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/efe7d8a0-fde3-49db-beb0-356763d52555-diff.temp
index 46e53a4..c09ae21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/efe7d8a0-fde3-49db-beb0-356763d52555-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e50fc494-b67f-4ec5-9f56-33c41f1fd659-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,22B4BD53020
-       mov       rax,24EEBB63020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,22B3BD511F8
-       mov       rax,24EFBB611F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22B4BD51508
-       mov       rax,24EEBB61508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22B3BD511F0
-       mov       rdx,24EFBB611F0
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/381583b2-7600-4966-99d5-1b6395ed4f3a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a96b9570-557c-4cb1-9b21-6e3ca73c3551-diff.temp
index 06d25ec..2feb619 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a96b9570-557c-4cb1-9b21-6e3ca73c3551-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/381583b2-7600-4966-99d5-1b6395ed4f3a-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CBBC8F3020
-       mov       rax,24EEBB63020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1CB9C8F2210
-       mov       rax,24EFBB611F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1CBBC8F1508
-       mov       rax,24EEBB61508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1CB9C8F2208
-       mov       rdx,24EFBB611F0
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2fd4a9f2-9418-4849-a5b5-76fb592884b5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cebbd3c6-34b1-499c-8e91-b4fcf38c006b-diff.temp
index 06d25ec..c09ae21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cebbd3c6-34b1-499c-8e91-b4fcf38c006b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2fd4a9f2-9418-4849-a5b5-76fb592884b5-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CBBC8F3020
-       mov       rax,22B4BD53020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 149
        int       3
        call      CORINFO_HELP_OVERFLOW
 M01_L04:
        ret
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
        nop
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,27
        mov       rcx,rsi
        jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1CB9C8F2210
-       mov       rax,22B3BD511F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1CBBC8F1508
-       mov       rax,22B4BD51508
        lea       rcx,[rdi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rdi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1CB9C8F2208
-       mov       rdx,22B3BD511F0
        mov       rdi,rdx
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
 ; Total bytes of code 125
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
        mov       rcx,rdi
        mov       rdx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendBytes(this.ByteArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a25a192a-035f-4ca2-8485-4eede7c15c53-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ad005b66-b7af-46ee-8312-35318199f239-diff.temp
index 2feb619..c09ae21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ad005b66-b7af-46ee-8312-35318199f239-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a25a192a-035f-4ca2-8485-4eede7c15c53-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,19C35C23020
-       mov       rax,2131EB01028
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,19C35C33088
-       mov       rdx,212FEB03240
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,19C35C2D6E8
-       mov       r9,2131EB0B6F0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F742A38
-       mov       rcx,7FF86F722A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dab303a7-b4c9-4536-9728-5689a82aaeec-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/146b51ed-cda2-458c-a312-45c59c96b998-diff.temp
index 81261a7..8c95f26 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/146b51ed-cda2-458c-a312-45c59c96b998-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dab303a7-b4c9-4536-9728-5689a82aaeec-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2B4AC8E3020
-       mov       rax,2131EB01028
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2B48C8E1248
-       mov       rdx,212FEB03240
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,2B49C8E92E0
-       mov       r9,2131EB0B6F0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F732A38
-       mov       rcx,7FF86F722A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7f8ab647-ad56-479a-8ef2-be27cc4a82d6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/78356262-b55c-4433-aa45-cde9d61aa53e-diff.temp
index 81261a7..5248a0b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/78356262-b55c-4433-aa45-cde9d61aa53e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7f8ab647-ad56-479a-8ef2-be27cc4a82d6-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,14CA54E3020
-       mov       rax,2131EB01028
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,14CA54F3088
-       mov       rdx,212FEB03240
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,14CA54ED6E8
-       mov       r9,2131EB0B6F0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F712A38
-       mov       rcx,7FF86F722A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2dd8a0f9-ae65-4cb5-8ddb-b4f106b50d58-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65924b6e-5235-4be9-b329-28921187b235-diff.temp
index 81261a7..3bd125c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65924b6e-5235-4be9-b329-28921187b235-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2dd8a0f9-ae65-4cb5-8ddb-b4f106b50d58-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23053F93020
-       mov       rax,2131EB01028
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23053FA3088
-       mov       rdx,212FEB03240
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,23053F9D6E8
-       mov       r9,2131EB0B6F0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F712A38
-       mov       rcx,7FF86F722A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da82fb30-1aef-46de-8c1b-3d1931c0358a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5bc0b124-a3f2-42ca-b42b-1b609d680684-diff.temp
index 81261a7..35f591c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5bc0b124-a3f2-42ca-b42b-1b609d680684-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da82fb30-1aef-46de-8c1b-3d1931c0358a-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,209A6D33020
-       mov       rax,2131EB01028
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,209A6D43088
-       mov       rdx,212FEB03240
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,209A6D3D6E8
-       mov       r9,2131EB0B6F0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F732A38
-       mov       rcx,7FF86F722A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b71b8c94-6903-4aba-b0d0-3584e4751a0d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cf26edc2-af1a-4d08-802c-f295b40e8eda-diff.temp
index 81261a7..731f17c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cf26edc2-af1a-4d08-802c-f295b40e8eda-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b71b8c94-6903-4aba-b0d0-3584e4751a0d-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,208A3B33020
-       mov       rax,2131EB01028
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,208A3B43088
-       mov       rdx,212FEB03240
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,208A3B3D6E8
-       mov       r9,2131EB0B6F0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F732A38
-       mov       rcx,7FF86F722A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2ec00a2d-1d20-4307-b85b-0999e305aa29-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/267ecbd5-31aa-41d5-afbb-99bfaf372768-diff.temp
index 81261a7..0f1b87a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/267ecbd5-31aa-41d5-afbb-99bfaf372768-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2ec00a2d-1d20-4307-b85b-0999e305aa29-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,26C75141248
-       mov       rdx,212FEB03240
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,26C6514D6E8
-       mov       r9,2131EB0B6F0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF86F722A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f3cecb09-a084-424c-8710-c0e748b9793c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8a0a35e1-cedd-43df-8c29-490e95bd8f25-diff.temp
index 81261a7..e1383e8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8a0a35e1-cedd-43df-8c29-490e95bd8f25-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f3cecb09-a084-424c-8710-c0e748b9793c-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2B4AC8E3020
-       mov       rax,19C35C23020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2B48C8E1248
-       mov       rdx,19C35C33088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,2B49C8E92E0
-       mov       r9,19C35C2D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F732A38
-       mov       rcx,7FF86F742A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6FBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/44b4819f-9daa-49ff-b64a-bae8e076c628-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/833bac6a-0ebd-4519-8e00-247cc4ef9068-diff.temp
index 8c95f26..5248a0b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/833bac6a-0ebd-4519-8e00-247cc4ef9068-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/44b4819f-9daa-49ff-b64a-bae8e076c628-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,14CA54E3020
-       mov       rax,19C35C23020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,14CA54F3088
-       mov       rdx,19C35C33088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,14CA54ED6E8
-       mov       r9,19C35C2D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F712A38
-       mov       rcx,7FF86F742A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6FBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1ab672db-cae4-4ea4-81d3-e75831f29ae2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/865b6050-fd06-40b3-9022-d171c468e43a-diff.temp
index 8c95f26..3bd125c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/865b6050-fd06-40b3-9022-d171c468e43a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1ab672db-cae4-4ea4-81d3-e75831f29ae2-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23053F93020
-       mov       rax,19C35C23020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23053FA3088
-       mov       rdx,19C35C33088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,23053F9D6E8
-       mov       r9,19C35C2D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F712A38
-       mov       rcx,7FF86F742A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6FBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08299a6e-a4b8-43fe-ba73-ddc816cea8d5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bc8b8c8e-17d6-4c0a-8171-c22b2a05ed37-diff.temp
index 8c95f26..35f591c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bc8b8c8e-17d6-4c0a-8171-c22b2a05ed37-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08299a6e-a4b8-43fe-ba73-ddc816cea8d5-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,209A6D33020
-       mov       rax,19C35C23020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,209A6D43088
-       mov       rdx,19C35C33088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,209A6D3D6E8
-       mov       r9,19C35C2D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F732A38
-       mov       rcx,7FF86F742A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6FBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6ee676d0-5126-4b35-bc94-1a737723d56f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0701a2fb-9a6a-4027-ae95-c469907e47b4-diff.temp
index 8c95f26..731f17c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0701a2fb-9a6a-4027-ae95-c469907e47b4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6ee676d0-5126-4b35-bc94-1a737723d56f-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,208A3B33020
-       mov       rax,19C35C23020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,208A3B43088
-       mov       rdx,19C35C33088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,208A3B3D6E8
-       mov       r9,19C35C2D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F732A38
-       mov       rcx,7FF86F742A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6FBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/55223268-93b3-473f-b4cd-1b2459a4e655-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/985c9d9d-3b5a-43e2-88e8-56cbb4822986-diff.temp
index 8c95f26..0f1b87a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/985c9d9d-3b5a-43e2-88e8-56cbb4822986-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/55223268-93b3-473f-b4cd-1b2459a4e655-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,26C65143020
-       mov       rax,19C35C23020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,26C75141248
-       mov       rdx,19C35C33088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,26C6514D6E8
-       mov       r9,19C35C2D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F722A38
-       mov       rcx,7FF86F742A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6FBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/50e1ec23-2514-460f-838b-dbe8574880ee-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f98ff09a-5a86-4b78-8a29-a6820674fda2-diff.temp
index 8c95f26..e1383e8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f98ff09a-5a86-4b78-8a29-a6820674fda2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/50e1ec23-2514-460f-838b-dbe8574880ee-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,14CA54E3020
-       mov       rax,2B4AC8E3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,14CA54F3088
-       mov       rdx,2B48C8E1248
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,14CA54ED6E8
-       mov       r9,2B49C8E92E0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F712A38
-       mov       rcx,7FF86F732A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5e34f16e-f727-4174-b321-20480318ee1c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/81c474b9-937d-4ce3-a74c-ec303dba846d-diff.temp
index 5248a0b..3bd125c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/81c474b9-937d-4ce3-a74c-ec303dba846d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5e34f16e-f727-4174-b321-20480318ee1c-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23053F93020
-       mov       rax,2B4AC8E3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23053FA3088
-       mov       rdx,2B48C8E1248
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,23053F9D6E8
-       mov       r9,2B49C8E92E0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F712A38
-       mov       rcx,7FF86F732A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/86cacea1-2976-4f68-b983-548fe141d5b6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0b5ea5f3-153b-4c55-8401-90eb794c7aa1-diff.temp
index 5248a0b..35f591c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0b5ea5f3-153b-4c55-8401-90eb794c7aa1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/86cacea1-2976-4f68-b983-548fe141d5b6-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,209A6D43088
-       mov       rdx,2B48C8E1248
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,209A6D3D6E8
-       mov       r9,2B49C8E92E0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF86F732A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bcd252ac-e697-44ce-aa0f-d99689d89a48-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5609d2cb-4af0-428d-a919-15d26a7f5324-diff.temp
index 5248a0b..731f17c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5609d2cb-4af0-428d-a919-15d26a7f5324-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bcd252ac-e697-44ce-aa0f-d99689d89a48-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,208A3B43088
-       mov       rdx,2B48C8E1248
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,208A3B3D6E8
-       mov       r9,2B49C8E92E0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF86F732A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a22bbdb3-6666-4f13-95e5-580597dc6719-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/19d3a9ce-b99c-4974-89a8-dbe8ebd2daa9-diff.temp
index 5248a0b..0f1b87a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/19d3a9ce-b99c-4974-89a8-dbe8ebd2daa9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a22bbdb3-6666-4f13-95e5-580597dc6719-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,26C65143020
-       mov       rax,2B4AC8E3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,26C75141248
-       mov       rdx,2B48C8E1248
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,26C6514D6E8
-       mov       r9,2B49C8E92E0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F722A38
-       mov       rcx,7FF86F732A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/335f3a98-f466-461a-bd42-411d26fdf327-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3dd66131-6552-4810-8d99-a3a16ee78600-diff.temp
index 5248a0b..e1383e8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3dd66131-6552-4810-8d99-a3a16ee78600-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/335f3a98-f466-461a-bd42-411d26fdf327-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23053FA3088
-       mov       rdx,14CA54F3088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,23053F9D6E8
-       mov       r9,14CA54ED6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF86F712A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e7df5d81-1954-442d-8e86-364cd6f7c272-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/81bd8fd3-4585-4d61-af52-577e7f968728-diff.temp
index 3bd125c..35f591c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/81bd8fd3-4585-4d61-af52-577e7f968728-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e7df5d81-1954-442d-8e86-364cd6f7c272-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,209A6D33020
-       mov       rax,14CA54E3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,209A6D43088
-       mov       rdx,14CA54F3088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,209A6D3D6E8
-       mov       r9,14CA54ED6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F732A38
-       mov       rcx,7FF86F712A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/698c8bc5-bc5f-4773-8713-3809b7bcfd27-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/69ccf2ad-0956-4984-a1b6-c105004b0262-diff.temp
index 3bd125c..731f17c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/69ccf2ad-0956-4984-a1b6-c105004b0262-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/698c8bc5-bc5f-4773-8713-3809b7bcfd27-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,208A3B33020
-       mov       rax,14CA54E3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,208A3B43088
-       mov       rdx,14CA54F3088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,208A3B3D6E8
-       mov       r9,14CA54ED6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F732A38
-       mov       rcx,7FF86F712A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/447ae1fb-ab5c-4dee-8061-ea6fa8efc343-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/28a4e336-a646-4fc2-b582-eb433b01c739-diff.temp
index 3bd125c..0f1b87a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/28a4e336-a646-4fc2-b582-eb433b01c739-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/447ae1fb-ab5c-4dee-8061-ea6fa8efc343-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,26C65143020
-       mov       rax,14CA54E3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,26C75141248
-       mov       rdx,14CA54F3088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,26C6514D6E8
-       mov       r9,14CA54ED6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F722A38
-       mov       rcx,7FF86F712A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9d40bb23-174f-469a-aa66-6ca68dd89953-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e3af80e-20ad-4b48-9491-eb56180cd438-diff.temp
index 3bd125c..e1383e8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e3af80e-20ad-4b48-9491-eb56180cd438-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9d40bb23-174f-469a-aa66-6ca68dd89953-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,209A6D33020
-       mov       rax,23053F93020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,209A6D43088
-       mov       rdx,23053FA3088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,209A6D3D6E8
-       mov       r9,23053F9D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F732A38
-       mov       rcx,7FF86F712A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5abc0ef4-5d81-404f-8eeb-6badbe2ffc31-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fffd8f35-281a-4d94-8cd0-dfd098733107-diff.temp
index 35f591c..731f17c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fffd8f35-281a-4d94-8cd0-dfd098733107-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5abc0ef4-5d81-404f-8eeb-6badbe2ffc31-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,208A3B33020
-       mov       rax,23053F93020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,208A3B43088
-       mov       rdx,23053FA3088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,208A3B3D6E8
-       mov       r9,23053F9D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F732A38
-       mov       rcx,7FF86F712A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/678dda9d-c341-43a4-8103-50c7142eedc9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e3b33ea7-9a5d-4078-8e29-0051c0399e5c-diff.temp
index 35f591c..0f1b87a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e3b33ea7-9a5d-4078-8e29-0051c0399e5c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/678dda9d-c341-43a4-8103-50c7142eedc9-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,26C65143020
-       mov       rax,23053F93020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,26C75141248
-       mov       rdx,23053FA3088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,26C6514D6E8
-       mov       r9,23053F9D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F722A38
-       mov       rcx,7FF86F712A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/34e512dc-3982-4e2a-9a58-f23f0711413f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8f3c665f-500e-42cf-8b0f-e9fb45a16b29-diff.temp
index 35f591c..e1383e8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8f3c665f-500e-42cf-8b0f-e9fb45a16b29-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/34e512dc-3982-4e2a-9a58-f23f0711413f-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,208A3B43088
-       mov       rdx,209A6D43088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,208A3B3D6E8
-       mov       r9,209A6D3D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF86F732A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/87ade880-d913-4cd7-8462-d00d2de6c379-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/93b7fcf3-0791-4697-9850-d64d79d5aed6-diff.temp
index 731f17c..0f1b87a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/93b7fcf3-0791-4697-9850-d64d79d5aed6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/87ade880-d913-4cd7-8462-d00d2de6c379-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,26C65143020
-       mov       rax,209A6D33020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,26C75141248
-       mov       rdx,209A6D43088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,26C6514D6E8
-       mov       r9,209A6D3D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F722A38
-       mov       rcx,7FF86F732A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9cc90ebd-01ff-4f2a-85fe-3b340ecaddc8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bced09f8-c09b-4a68-a59f-cf821f0249f5-diff.temp
index 731f17c..e1383e8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bced09f8-c09b-4a68-a59f-cf821f0249f5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9cc90ebd-01ff-4f2a-85fe-3b340ecaddc8-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,26C65143020
-       mov       rax,208A3B33020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 321
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,26C75141248
-       mov       rdx,208A3B43088
 M01_L05:
        jne       short M01_L06
        cmp       ebp,0FFFFFFFE
        je        short M01_L05
        cmp       ebp,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,r14d
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,5C
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
        mov       r8d,ebx
        mov       rdx,rdi
        mov       rcx,rsi
        jo        near ptr M01_L07
        sub       r9d,ebx
        mov       r9d,r15d
        jl        short M01_L02
        test      r15d,r15d
        mov       r15d,eax
        call      System.String.IndexOfAny(Char[], Int32, Int32)
        mov       r8d,ebx
        mov       rcx,rdi
        sub       r9d,ebx
        mov       r9d,r14d
        mov       rdx,[r9]
+       mov       r9,26C6514D6E8
-       mov       r9,208A3B3D6E8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF86F722A38
-       mov       rcx,7FF86F732A38
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebx,0FFFFFFFE
        je        short M01_L00
        cmp       ebx,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rcx,rsi
        mov       ebp,[rsp+80]
        mov       ebx,r9d
        mov       rdi,r8
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 201
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
 M00_L01:
        jg        short M00_L00
        cmp       [rax+8],ebx
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        inc       ebx
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rdx,r8
        mov       rcx,rdi
        mov       dword ptr [rsp+20],0FFFFFFFF
 ; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 				sb.AppendKeyValue(testString, testString);
        mov       r8,[rax+rcx*8+10]
        movsxd    rcx,ebx
        jae       short M00_L02
        cmp       ebx,[rax+8]
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/df5b5078-9967-4963-b6f7-de8fb8bf6b81-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/51707a01-3069-45f9-aae8-e0e35c49c4f3-diff.temp
index 0f1b87a..e1383e8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/51707a01-3069-45f9-aae8-e0e35c49c4f3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/df5b5078-9967-4963-b6f7-de8fb8bf6b81-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1ED45A43020
-       mov       rax,19BB7363020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1ED25A41A08
-       mov       rdx,19BB7374860
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,1ED45A43020
-       mov       rcx,19BB7363020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6BBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,1ED25A41248
-       mov       rcx,19BB7373088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83d798e4-964d-41bf-83d8-5520f0112e74-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/407414f4-a988-423b-8c44-98eefb0db179-diff.temp
index 97f819c..a02bb57 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/407414f4-a988-423b-8c44-98eefb0db179-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83d798e4-964d-41bf-83d8-5520f0112e74-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1B1EE6F3020
-       mov       rax,19BB7363020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1B1FE6F11F0
-       mov       rdx,19BB7374860
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,1B1EE6F3020
-       mov       rcx,19BB7363020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,1B1EE703088
-       mov       rcx,19BB7373088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/de7540d6-ae0d-4af5-9158-f148ab4bde78-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/094b7c34-46ba-46c6-b395-3591856eb475-diff.temp
index 97f819c..1a24350 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/094b7c34-46ba-46c6-b395-3591856eb475-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/de7540d6-ae0d-4af5-9158-f148ab4bde78-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,174FEF03020
-       mov       rax,19BB7363020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,174EEF011F0
-       mov       rdx,19BB7374860
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,174FEF03020
-       mov       rcx,19BB7363020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,174FEF13088
-       mov       rcx,19BB7373088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e205241-8389-429e-afe5-ab1c202b8984-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9bf39045-7752-478f-9a78-4ceb6e172532-diff.temp
index 97f819c..5260fa6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9bf39045-7752-478f-9a78-4ceb6e172532-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e205241-8389-429e-afe5-ab1c202b8984-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eed3b97d-29fa-4da0-b6ce-090ce8ed2377-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e4ece700-2dac-43fc-8fc1-8c0491fd2374-diff.temp
index 97f819c..56b1464 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e4ece700-2dac-43fc-8fc1-8c0491fd2374-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eed3b97d-29fa-4da0-b6ce-090ce8ed2377-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,28EA84F1028
-       mov       rax,19BB7363020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,28EB84F11F0
-       mov       rdx,19BB7374860
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,28EA84F1028
-       mov       rcx,19BB7363020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6BBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,28EA8501090
-       mov       rcx,19BB7373088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9fd9b45e-cb18-4f45-b151-0721f33e08a8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0de4a550-7604-4a70-ad95-4a5dd3168521-diff.temp
index 97f819c..2072178 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0de4a550-7604-4a70-ad95-4a5dd3168521-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9fd9b45e-cb18-4f45-b151-0721f33e08a8-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1FE14D63020
-       mov       rax,19BB7363020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1FE14D63600
-       mov       rdx,19BB7374860
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,1FE14D63020
-       mov       rcx,19BB7363020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,1FE34D70C78
-       mov       rcx,19BB7373088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6725b94-fb3e-4b05-9904-47b46fa020fe-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e7e086d8-4300-44d7-9b56-e0c2e94a4e07-diff.temp
index 97f819c..5de8935 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e7e086d8-4300-44d7-9b56-e0c2e94a4e07-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6725b94-fb3e-4b05-9904-47b46fa020fe-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0194eb03-a759-4e1f-b774-77c7f8adf3c9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b2812049-05bb-4e93-a8c4-a3dd9e71cc1b-diff.temp
index 97f819c..751f0fe 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b2812049-05bb-4e93-a8c4-a3dd9e71cc1b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0194eb03-a759-4e1f-b774-77c7f8adf3c9-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1B1EE6F3020
-       mov       rax,1ED45A43020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1B1FE6F11F0
-       mov       rdx,1ED25A41A08
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,1B1EE6F3020
-       mov       rcx,1ED45A43020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6EBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,1B1EE703088
-       mov       rcx,1ED25A41248
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4caaadae-5ee5-4ab2-893c-1c7767461c58-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/899d93d1-e489-411a-971f-c0b6e1cd30c2-diff.temp
index a02bb57..1a24350 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/899d93d1-e489-411a-971f-c0b6e1cd30c2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4caaadae-5ee5-4ab2-893c-1c7767461c58-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,174FEF03020
-       mov       rax,1ED45A43020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,174EEF011F0
-       mov       rdx,1ED25A41A08
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,174FEF03020
-       mov       rcx,1ED45A43020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,174FEF13088
-       mov       rcx,1ED25A41248
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9ea153e6-ab4a-42af-9dba-9b09923c31d6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/40cebde3-6baf-4c06-a3f3-4abfd6cefd46-diff.temp
index a02bb57..5260fa6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/40cebde3-6baf-4c06-a3f3-4abfd6cefd46-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9ea153e6-ab4a-42af-9dba-9b09923c31d6-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,28FA9673020
-       mov       rax,1ED45A43020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,28F89672208
-       mov       rdx,1ED25A41A08
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,28FA9673020
-       mov       rcx,1ED45A43020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,28FA9683088
-       mov       rcx,1ED25A41248
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/80908f22-3799-4906-8c57-f7cf3b7c5630-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/262535a8-5dba-49d1-83fd-319dbdb42c30-diff.temp
index a02bb57..56b1464 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/262535a8-5dba-49d1-83fd-319dbdb42c30-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/80908f22-3799-4906-8c57-f7cf3b7c5630-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0b82982d-cb92-4db4-9220-1cd550946e6e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9ab08eca-dcf6-49ee-8383-036980aab816-diff.temp
index a02bb57..2072178 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9ab08eca-dcf6-49ee-8383-036980aab816-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0b82982d-cb92-4db4-9220-1cd550946e6e-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1FE14D63020
-       mov       rax,1ED45A43020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1FE14D63600
-       mov       rdx,1ED25A41A08
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,1FE14D63020
-       mov       rcx,1ED45A43020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,1FE34D70C78
-       mov       rcx,1ED25A41248
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e892fab7-97ab-4e3e-9227-96687b6ead64-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bd69ab2a-af94-492d-9649-e96a21e35b84-diff.temp
index a02bb57..5de8935 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bd69ab2a-af94-492d-9649-e96a21e35b84-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e892fab7-97ab-4e3e-9227-96687b6ead64-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2333EA13020
-       mov       rax,1ED45A43020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2335EA21438
-       mov       rdx,1ED25A41A08
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,2333EA13020
-       mov       rcx,1ED45A43020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,2335EA20C78
-       mov       rcx,1ED25A41248
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a97d585f-bfe4-42e1-9f23-6c2a3592cdea-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/673e5013-62eb-4aed-8599-ad9d6db989c0-diff.temp
index a02bb57..751f0fe 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/673e5013-62eb-4aed-8599-ad9d6db989c0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a97d585f-bfe4-42e1-9f23-6c2a3592cdea-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,174FEF03020
-       mov       rax,1B1EE6F3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,174EEF011F0
-       mov       rdx,1B1FE6F11F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,174FEF03020
-       mov       rcx,1B1EE6F3020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6FBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,174FEF13088
-       mov       rcx,1B1EE703088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a549a46c-0600-494d-abb9-d3a8a56cb610-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1b04bc4-1cab-473b-9984-c65950cbb4a6-diff.temp
index 1a24350..5260fa6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1b04bc4-1cab-473b-9984-c65950cbb4a6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a549a46c-0600-494d-abb9-d3a8a56cb610-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,28FA9673020
-       mov       rax,1B1EE6F3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,28F89672208
-       mov       rdx,1B1FE6F11F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,28FA9673020
-       mov       rcx,1B1EE6F3020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,28FA9683088
-       mov       rcx,1B1EE703088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/403808e5-96e4-4a03-8bfa-7a561968f801-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/03818692-6d72-407a-a29a-f100b829b388-diff.temp
index 1a24350..56b1464 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/03818692-6d72-407a-a29a-f100b829b388-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/403808e5-96e4-4a03-8bfa-7a561968f801-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,28EA84F1028
-       mov       rax,1B1EE6F3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,28EB84F11F0
-       mov       rdx,1B1FE6F11F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,28EA84F1028
-       mov       rcx,1B1EE6F3020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6BBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,28EA8501090
-       mov       rcx,1B1EE703088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1aeae8a7-8e2d-4dba-880a-57b94e990d8e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d3bd5179-5b7b-4b5f-afa2-18858607a8ab-diff.temp
index 1a24350..2072178 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d3bd5179-5b7b-4b5f-afa2-18858607a8ab-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1aeae8a7-8e2d-4dba-880a-57b94e990d8e-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1FE14D63020
-       mov       rax,1B1EE6F3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1FE14D63600
-       mov       rdx,1B1FE6F11F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,1FE14D63020
-       mov       rcx,1B1EE6F3020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,1FE34D70C78
-       mov       rcx,1B1EE703088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ff19a624-c2cf-438f-9978-a48d8f1d2261-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d68040aa-8362-43f7-9f07-570053c30213-diff.temp
index 1a24350..5de8935 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d68040aa-8362-43f7-9f07-570053c30213-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ff19a624-c2cf-438f-9978-a48d8f1d2261-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2333EA13020
-       mov       rax,1B1EE6F3020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2335EA21438
-       mov       rdx,1B1FE6F11F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,2333EA13020
-       mov       rcx,1B1EE6F3020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6EBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,2335EA20C78
-       mov       rcx,1B1EE703088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1b19d56-4c20-4759-b0ac-5a70b287b067-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/07bfcdb9-7d4a-434e-8eb1-0966d5fcb161-diff.temp
index 1a24350..751f0fe 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/07bfcdb9-7d4a-434e-8eb1-0966d5fcb161-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1b19d56-4c20-4759-b0ac-5a70b287b067-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,28FA9673020
-       mov       rax,174FEF03020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,28F89672208
-       mov       rdx,174EEF011F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,28FA9673020
-       mov       rcx,174FEF03020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6FBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,28FA9683088
-       mov       rcx,174FEF13088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6f5a7346-0079-404a-b907-3d79bf6870ef-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8fcd0e58-ffbe-4a2e-bd31-0a5c9cf3e752-diff.temp
index 5260fa6..56b1464 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8fcd0e58-ffbe-4a2e-bd31-0a5c9cf3e752-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6f5a7346-0079-404a-b907-3d79bf6870ef-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,28EA84F1028
-       mov       rax,174FEF03020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,28EB84F11F0
-       mov       rdx,174EEF011F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,28EA84F1028
-       mov       rcx,174FEF03020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6BBD30]
-       call      qword ptr [7FF86F6FBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,28EA8501090
-       mov       rcx,174FEF13088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83ee6e6f-e891-4ba8-8349-012cc3adc1bc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/57c34a3b-6e4a-481a-bfa7-3af1933ccb07-diff.temp
index 5260fa6..2072178 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/57c34a3b-6e4a-481a-bfa7-3af1933ccb07-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83ee6e6f-e891-4ba8-8349-012cc3adc1bc-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1FE14D63020
-       mov       rax,174FEF03020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1FE14D63600
-       mov       rdx,174EEF011F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,1FE14D63020
-       mov       rcx,174FEF03020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6FBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,1FE34D70C78
-       mov       rcx,174FEF13088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/db3bd542-1101-44ec-ac21-bf7fc1abc2d6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e742678-9355-490c-a304-5b8d51a02c6d-diff.temp
index 5260fa6..5de8935 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e742678-9355-490c-a304-5b8d51a02c6d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/db3bd542-1101-44ec-ac21-bf7fc1abc2d6-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2333EA13020
-       mov       rax,174FEF03020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2335EA21438
-       mov       rdx,174EEF011F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,2333EA13020
-       mov       rcx,174FEF03020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6FBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,2335EA20C78
-       mov       rcx,174FEF13088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/32242447-6765-4386-b7f9-d99784fcbb3b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ef4b0ee9-9145-4307-be9a-473d74238015-diff.temp
index 5260fa6..751f0fe 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ef4b0ee9-9145-4307-be9a-473d74238015-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/32242447-6765-4386-b7f9-d99784fcbb3b-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,28EA84F1028
-       mov       rax,28FA9673020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,28EB84F11F0
-       mov       rdx,28F89672208
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,28EA84F1028
-       mov       rcx,28FA9673020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6BBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,28EA8501090
-       mov       rcx,28FA9683088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67648573-3736-4beb-b057-0e0d2f8f0dd3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f5ed32d8-e226-4995-a53b-237b6e062f4b-diff.temp
index 56b1464..2072178 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f5ed32d8-e226-4995-a53b-237b6e062f4b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67648573-3736-4beb-b057-0e0d2f8f0dd3-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1FE14D63020
-       mov       rax,28FA9673020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1FE14D63600
-       mov       rdx,28F89672208
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,1FE14D63020
-       mov       rcx,28FA9673020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6CBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,1FE34D70C78
-       mov       rcx,28FA9683088
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d3eb0a8-1b8a-4381-aced-8e6f7f0d3e9f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b4f278ef-2ccb-461f-871a-b0087ab47ec8-diff.temp
index 56b1464..5de8935 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b4f278ef-2ccb-461f-871a-b0087ab47ec8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d3eb0a8-1b8a-4381-aced-8e6f7f0d3e9f-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f4b9e752-0aa4-4397-89d2-ca08ce097813-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c7e414e3-6c9b-4af0-bbf6-d609c4362777-diff.temp
index 56b1464..751f0fe 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c7e414e3-6c9b-4af0-bbf6-d609c4362777-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f4b9e752-0aa4-4397-89d2-ca08ce097813-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1FE14D63020
-       mov       rax,28EA84F1028
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1FE14D63600
-       mov       rdx,28EB84F11F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,1FE14D63020
-       mov       rcx,28EA84F1028
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6DBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,1FE34D70C78
-       mov       rcx,28EA8501090
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/148dd2e8-c39e-4992-a12e-853739b71399-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e6b2934b-08dd-4fab-aa80-6a4853cf143b-diff.temp
index 2072178..5de8935 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e6b2934b-08dd-4fab-aa80-6a4853cf143b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/148dd2e8-c39e-4992-a12e-853739b71399-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2333EA13020
-       mov       rax,28EA84F1028
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2335EA21438
-       mov       rdx,28EB84F11F0
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,2333EA13020
-       mov       rcx,28EA84F1028
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6BBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,2335EA20C78
-       mov       rcx,28EA8501090
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67980b12-898c-485b-968d-c0f9ccc49e66-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0bbeb042-33b4-4845-aa6e-d823aad62150-diff.temp
index 2072178..751f0fe 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0bbeb042-33b4-4845-aa6e-d823aad62150-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67980b12-898c-485b-968d-c0f9ccc49e66-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2333EA13020
-       mov       rax,1FE14D63020
        jne       short M02_L00
        add       ecx,[rsi+18]
        mov       ecx,[rsi+1C]
        mov       rsi,rcx
        mov       [rsp+20],rax
        mov       [rsp+28],rax
        xor       eax,eax
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
 ; System.Text.StringBuilder.ToString()
 ; Total bytes of code 219
        ret
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,30
        nop
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
        mov       r9,rdi
        mov       r8,rsi
        mov       rdx,r14
        mov       [rsp+20],rbx
        mov       [rbx+18],rdx
        mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbp
        lea       rcx,[rbx+8]
        mov       r14,[rbp+8]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
        mov       rsi,rax
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
        mov       rcx,rsi
 M01_L02:
        call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2335EA21438
-       mov       rdx,1FE14D63600
 M01_L01:
        mov       rbx,rcx
 M01_L00:
        jmp       short M01_L01
        jbe       short M01_L00
        cmp       dword ptr [rbx+8],0
        je        short M01_L00
        test      rbx,rbx
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Properties.Resources.get_CollectionIsNullOrHasNoItems()
        jne       short M01_L02
        test      eax,eax
        call      dotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       rbx,[rcx]
+       mov       rcx,2333EA13020
-       mov       rcx,1FE14D63020
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rbx
        lea       rcx,[rbp+8]
        mov       rbp,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
        mov       rdi,r8
        mov       rsi,rdx
        mov       rbx,rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
 ; Total bytes of code 143
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rsi+8]
        cmp       [rsi],esi
+       call      qword ptr [7FF86F6CBD30]
-       call      qword ptr [7FF86F6DBD30]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
        call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
        mov       rcx,rdi
        mov       rdx,rbx
        mov       r8,rax
        call      qword ptr [rax+18]
        mov       rax,[rax+48]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rbx,[rcx]
+       mov       rcx,2335EA20C78
-       mov       rcx,1FE34D70C78
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(sb.ToString());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var sb = new StringBuilder();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f42406ce-cec0-4d6f-a7c7-c6a35fcbd0d0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6814a0ae-4861-45da-b2f4-82296ad47440-diff.temp
index 5de8935..751f0fe 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6814a0ae-4861-45da-b2f4-82296ad47440-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f42406ce-cec0-4d6f-a7c7-c6a35fcbd0d0-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,17F78AB2210
-       mov       rax,1E3A2814868
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,17F98AB1508
-       mov       rax,1E3A2801508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,17F78AB2208
-       mov       rdx,1E3A2814860
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ba29313c-9780-4dba-aeb6-5fe07919e886-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a80b5310-e9cd-4b4c-a26d-9f912c20d585-diff.temp
index 1bc273a..b4e0a17 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a80b5310-e9cd-4b4c-a26d-9f912c20d585-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ba29313c-9780-4dba-aeb6-5fe07919e886-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1BE9B6111F8
-       mov       rax,1E3A2814868
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1BEBB611508
-       mov       rax,1E3A2801508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1BE9B6111F0
-       mov       rdx,1E3A2814860
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9180f0bf-bd0e-42b1-be6f-5350ac63af0e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9806de0b-1121-4566-b66f-b0570741e834-diff.temp
index 1bc273a..81ff5bf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9806de0b-1121-4566-b66f-b0570741e834-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9180f0bf-bd0e-42b1-be6f-5350ac63af0e-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1A49CA7F860
-       mov       rax,1E3A2814868
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1A47CA71508
-       mov       rax,1E3A2801508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1A49CA7F858
-       mov       rdx,1E3A2814860
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/24daa0b2-2c55-443f-8136-d9f3dc63432b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/32a5609b-ed7d-4233-9ee0-8a40a047e754-diff.temp
index 1bc273a..06ec5fe 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/32a5609b-ed7d-4233-9ee0-8a40a047e754-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/24daa0b2-2c55-443f-8136-d9f3dc63432b-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,184928C6E30
-       mov       rax,1E3A2814868
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,184928C1508
-       mov       rax,1E3A2801508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,184928C6E28
-       mov       rdx,1E3A2814860
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2f0c0dea-b51f-4840-be7a-e18ffcaaf449-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ae813418-d217-4ee0-9480-268c05bd1938-diff.temp
index 1bc273a..2a1cda0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ae813418-d217-4ee0-9480-268c05bd1938-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2f0c0dea-b51f-4840-be7a-e18ffcaaf449-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,23BA2E511F8
-       mov       rax,1E3A2814868
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23BC2E51508
-       mov       rax,1E3A2801508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23BA2E511F0
-       mov       rdx,1E3A2814860
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/297793ef-0084-4d48-a8ff-b22c3d7fd4b2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dfc2443f-32b5-42bb-85ea-17933476562f-diff.temp
index 1bc273a..d16015a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dfc2443f-32b5-42bb-85ea-17933476562f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/297793ef-0084-4d48-a8ff-b22c3d7fd4b2-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,235CCE62210
-       mov       rax,1E3A2814868
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,235ECE61508
-       mov       rax,1E3A2801508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,235CCE62208
-       mov       rdx,1E3A2814860
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a8d6f007-31c4-4a11-87fd-22f343ccf6eb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9288f694-6273-40f2-8dbe-7c6c5f4cd100-diff.temp
index 1bc273a..8edd22a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9288f694-6273-40f2-8dbe-7c6c5f4cd100-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a8d6f007-31c4-4a11-87fd-22f343ccf6eb-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1E3E8755E18
-       mov       rax,1E3A2814868
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E3E8751508
-       mov       rax,1E3A2801508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E3E8755E10
-       mov       rdx,1E3A2814860
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e9ccebf-8f86-42c2-a859-437eea9c0903-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9448e8f9-9170-4108-9ea1-1fcfd148eba6-diff.temp
index 1bc273a..d392d48 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9448e8f9-9170-4108-9ea1-1fcfd148eba6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e9ccebf-8f86-42c2-a859-437eea9c0903-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2f4be732-7d71-4417-88d4-e33d2e896160-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed97e3e6-5d93-4b2e-80fe-52f38c10cf1b-diff.temp
index b4e0a17..81ff5bf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed97e3e6-5d93-4b2e-80fe-52f38c10cf1b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2f4be732-7d71-4417-88d4-e33d2e896160-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1A49CA7F860
-       mov       rax,17F78AB2210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1A47CA71508
-       mov       rax,17F98AB1508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1A49CA7F858
-       mov       rdx,17F78AB2208
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a67ef09a-d196-400a-b98c-96486e1b2b50-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3d56f965-1a5d-4caa-b827-f8702b124772-diff.temp
index b4e0a17..06ec5fe 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3d56f965-1a5d-4caa-b827-f8702b124772-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a67ef09a-d196-400a-b98c-96486e1b2b50-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f4b342d5-855d-4e52-89c3-5971989075db-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9e98f962-c51a-4cd4-9735-6b1ca3c0da75-diff.temp
index b4e0a17..2a1cda0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9e98f962-c51a-4cd4-9735-6b1ca3c0da75-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f4b342d5-855d-4e52-89c3-5971989075db-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,23BA2E511F8
-       mov       rax,17F78AB2210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23BC2E51508
-       mov       rax,17F98AB1508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23BA2E511F0
-       mov       rdx,17F78AB2208
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d48f0733-25d1-4237-8f1d-54acec977717-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/03fe9d82-fb18-4a0e-8202-81e9ce925e57-diff.temp
index b4e0a17..d16015a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/03fe9d82-fb18-4a0e-8202-81e9ce925e57-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d48f0733-25d1-4237-8f1d-54acec977717-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,235CCE62210
-       mov       rax,17F78AB2210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,235ECE61508
-       mov       rax,17F98AB1508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,235CCE62208
-       mov       rdx,17F78AB2208
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a47ad6ed-f453-4d56-adc7-d26d931808b6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e3f8a5d-384c-4b18-b05d-c08212ae473b-diff.temp
index b4e0a17..8edd22a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e3f8a5d-384c-4b18-b05d-c08212ae473b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a47ad6ed-f453-4d56-adc7-d26d931808b6-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1E3E8755E18
-       mov       rax,17F78AB2210
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E3E8751508
-       mov       rax,17F98AB1508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E3E8755E10
-       mov       rdx,17F78AB2208
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed468b7a-9f74-4352-bfb7-fad6782aa106-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8010a477-bbe2-4a30-88e0-9203e19d4d87-diff.temp
index b4e0a17..d392d48 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8010a477-bbe2-4a30-88e0-9203e19d4d87-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ed468b7a-9f74-4352-bfb7-fad6782aa106-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1A49CA7F860
-       mov       rax,1BE9B6111F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1A47CA71508
-       mov       rax,1BEBB611508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1A49CA7F858
-       mov       rdx,1BE9B6111F0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/928f7d72-bb5a-4f85-97c1-c19f0fa25b5c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ee39ab0-33cd-46b5-b97c-de5242e22fd2-diff.temp
index 81ff5bf..06ec5fe 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ee39ab0-33cd-46b5-b97c-de5242e22fd2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/928f7d72-bb5a-4f85-97c1-c19f0fa25b5c-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/06c4ce78-e0ab-4021-a719-f18d91efd3e4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39a85822-b757-49a0-af59-85557fb7bf10-diff.temp
index 81ff5bf..2a1cda0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39a85822-b757-49a0-af59-85557fb7bf10-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/06c4ce78-e0ab-4021-a719-f18d91efd3e4-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,23BA2E511F8
-       mov       rax,1BE9B6111F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23BC2E51508
-       mov       rax,1BEBB611508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23BA2E511F0
-       mov       rdx,1BE9B6111F0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/53417631-5da8-4d38-a945-dafbc553d3b1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7b03a6e7-5f22-43c8-b340-27706195d86c-diff.temp
index 81ff5bf..d16015a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7b03a6e7-5f22-43c8-b340-27706195d86c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/53417631-5da8-4d38-a945-dafbc553d3b1-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,235CCE62210
-       mov       rax,1BE9B6111F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,235ECE61508
-       mov       rax,1BEBB611508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,235CCE62208
-       mov       rdx,1BE9B6111F0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b2f0d08b-5d4d-4350-9ad5-6302a051238a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bab3ad5d-4afe-4077-a550-3baf76cc3c52-diff.temp
index 81ff5bf..8edd22a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bab3ad5d-4afe-4077-a550-3baf76cc3c52-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b2f0d08b-5d4d-4350-9ad5-6302a051238a-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1E3E8755E18
-       mov       rax,1BE9B6111F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E3E8751508
-       mov       rax,1BEBB611508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E3E8755E10
-       mov       rdx,1BE9B6111F0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/366f9136-91a7-4cfc-bce0-ccbe6b00c6de-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/14cc5457-c894-4a86-a1f0-95021dec896a-diff.temp
index 81ff5bf..d392d48 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/14cc5457-c894-4a86-a1f0-95021dec896a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/366f9136-91a7-4cfc-bce0-ccbe6b00c6de-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,184928C6E30
-       mov       rax,1A49CA7F860
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,184928C1508
-       mov       rax,1A47CA71508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,184928C6E28
-       mov       rdx,1A49CA7F858
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08876c35-7a1b-496f-ada4-dc4fd5d10fc2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/151864e9-2c39-4f46-b3a5-d692eb612beb-diff.temp
index 06ec5fe..2a1cda0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/151864e9-2c39-4f46-b3a5-d692eb612beb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08876c35-7a1b-496f-ada4-dc4fd5d10fc2-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,23BA2E511F8
-       mov       rax,1A49CA7F860
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23BC2E51508
-       mov       rax,1A47CA71508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23BA2E511F0
-       mov       rdx,1A49CA7F858
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dc3d9db1-bd7b-4bfa-ae10-26d18b236cc0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/367f939c-a68b-4a25-8303-4c170c242b0b-diff.temp
index 06ec5fe..d16015a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/367f939c-a68b-4a25-8303-4c170c242b0b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dc3d9db1-bd7b-4bfa-ae10-26d18b236cc0-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,235CCE62210
-       mov       rax,1A49CA7F860
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,235ECE61508
-       mov       rax,1A47CA71508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,235CCE62208
-       mov       rdx,1A49CA7F858
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/18770cab-24c2-410a-9f3b-5e27f8d214cb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/61f157bc-9a08-4087-a022-21f3da9ed62c-diff.temp
index 06ec5fe..8edd22a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/61f157bc-9a08-4087-a022-21f3da9ed62c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/18770cab-24c2-410a-9f3b-5e27f8d214cb-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1E3E8755E18
-       mov       rax,1A49CA7F860
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E3E8751508
-       mov       rax,1A47CA71508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E3E8755E10
-       mov       rdx,1A49CA7F858
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4fbe37a0-3da9-4921-a511-bd4ab7f938f4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c1db9182-8c7a-43f6-9c03-e151309b23ce-diff.temp
index 06ec5fe..d392d48 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c1db9182-8c7a-43f6-9c03-e151309b23ce-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4fbe37a0-3da9-4921-a511-bd4ab7f938f4-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,23BA2E511F8
-       mov       rax,184928C6E30
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23BC2E51508
-       mov       rax,184928C1508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23BA2E511F0
-       mov       rdx,184928C6E28
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96043902-7b74-44cb-a174-a3f507c03f9f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6cc41854-6f25-46e6-9298-cb82cec3fd68-diff.temp
index 2a1cda0..d16015a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6cc41854-6f25-46e6-9298-cb82cec3fd68-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96043902-7b74-44cb-a174-a3f507c03f9f-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,235CCE62210
-       mov       rax,184928C6E30
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,235ECE61508
-       mov       rax,184928C1508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,235CCE62208
-       mov       rdx,184928C6E28
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bd4c76e9-f6d5-4b05-a81b-8171564538ea-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b9eb4f95-5b0c-4079-a7c2-236dc7eca176-diff.temp
index 2a1cda0..8edd22a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b9eb4f95-5b0c-4079-a7c2-236dc7eca176-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bd4c76e9-f6d5-4b05-a81b-8171564538ea-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1E3E8755E18
-       mov       rax,184928C6E30
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E3E8751508
-       mov       rax,184928C1508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E3E8755E10
-       mov       rdx,184928C6E28
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/044c61bb-cdf4-443b-bcc2-189af5a607b8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0a3efb75-a5e1-4540-a403-e0afcb64018e-diff.temp
index 2a1cda0..d392d48 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0a3efb75-a5e1-4540-a403-e0afcb64018e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/044c61bb-cdf4-443b-bcc2-189af5a607b8-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,235CCE62210
-       mov       rax,23BA2E511F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,235ECE61508
-       mov       rax,23BC2E51508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,235CCE62208
-       mov       rdx,23BA2E511F0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/541f33d1-91f6-4455-a090-63b4fb28402e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/16988056-bb6e-46ca-a441-2de3195b427d-diff.temp
index d16015a..8edd22a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/16988056-bb6e-46ca-a441-2de3195b427d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/541f33d1-91f6-4455-a090-63b4fb28402e-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1E3E8755E18
-       mov       rax,23BA2E511F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E3E8751508
-       mov       rax,23BC2E51508
        lea       rcx,[rsi+rcx+10]
        movsxd    rcx,ebx
 M01_L00:
        jle       short M01_L03
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E3E8755E10
-       mov       rdx,23BA2E511F0
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rax
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_NEWARR_1_VC
        mov       edx,10
        mov       rcx,offset MT_System.Char[]
        mov       dword ptr [rdi+20],7FFFFFFF
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Text.StringBuilder
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
 ; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 54
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,rax
        call      qword ptr [rax+38]
        mov       rax,[rax+40]
        mov       rax,[rsi]
        mov       rcx,rsi
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f1120eea-22c9-4e88-8571-a59d23e99453-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0b1e9f1b-500b-41ad-9473-a78b6d7783be-diff.temp
index d16015a..d392d48 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0b1e9f1b-500b-41ad-9473-a78b6d7783be-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f1120eea-22c9-4e88-8571-a59d23e99453-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/40658fbf-c3e0-49ef-a389-df02f3c1c8e3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e351ff3c-2d7e-4aaf-93c4-7233cc6a292f-diff.temp
index 8edd22a..d392d48 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e351ff3c-2d7e-4aaf-93c4-7233cc6a292f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/40658fbf-c3e0-49ef-a389-df02f3c1c8e3-diff.temp
```
