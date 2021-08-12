## dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark-20210811-213719
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CEAE023020
-       mov       rax,1E6940B3020
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
 ; Total bytes of code 217
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
+       mov       rax,1CEAE031DE0
-       mov       rax,1E6840B1250
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1CEAE021508
-       mov       rax,1E6940B1508
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
+       mov       rdx,1CEAE031DD8
-       mov       rdx,1E6840B1248
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1CEAE0233B8
-       mov       rdx,1E6940B33B8
        mov       r8,[r8]
+       mov       r8,1CEAE023020
-       mov       r8,1E6940B3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1CEAE031DD0
-       mov       rdx,1E6840B1240
        mov       r8,[r8]
+       mov       r8,1CEAE023020
-       mov       r8,1E6940B3020
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f070e9de-e1d5-4f15-9246-f5f6f5d99d16-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2eae4db4-2f2a-42bd-a287-cfec66355169-diff.temp
index 54aed0a..58a8e1c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2eae4db4-2f2a-42bd-a287-cfec66355169-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f070e9de-e1d5-4f15-9246-f5f6f5d99d16-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1C10C821028
-       mov       rax,1E6940B3020
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
 ; Total bytes of code 217
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
+       mov       rax,1C0FC821250
-       mov       rax,1E6840B1250
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1C0EC821508
-       mov       rax,1E6940B1508
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
+       mov       rdx,1C0FC821248
-       mov       rdx,1E6840B1248
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1C10C8213C0
-       mov       rdx,1E6940B33B8
        mov       r8,[r8]
+       mov       r8,1C10C821028
-       mov       r8,1E6940B3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1C0FC821240
-       mov       rdx,1E6840B1240
        mov       r8,[r8]
+       mov       r8,1C10C821028
-       mov       r8,1E6940B3020
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/04076435-53f3-4a9a-8cc9-510fe5501a6a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dd647410-3431-4c38-8fdf-cfbf3c4721fa-diff.temp
index 54aed0a..e41b54c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dd647410-3431-4c38-8fdf-cfbf3c4721fa-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/04076435-53f3-4a9a-8cc9-510fe5501a6a-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,24F73953020
-       mov       rax,1E6940B3020
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
 ; Total bytes of code 217
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
+       mov       rax,24F73953660
-       mov       rax,1E6840B1250
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24F73951508
-       mov       rax,1E6940B1508
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
+       mov       rdx,24F73953658
-       mov       rdx,1E6840B1248
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,24F739533B8
-       mov       rdx,1E6940B33B8
        mov       r8,[r8]
+       mov       r8,24F73953020
-       mov       r8,1E6940B3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,24F73953650
-       mov       rdx,1E6840B1240
        mov       r8,[r8]
+       mov       r8,24F73953020
-       mov       r8,1E6940B3020
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/354b2677-247c-4237-a6c5-2b84229bcbb3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bc75fe0f-981b-44a3-a68a-ff2eb41432ea-diff.temp
index 54aed0a..d9f67fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bc75fe0f-981b-44a3-a68a-ff2eb41432ea-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/354b2677-247c-4237-a6c5-2b84229bcbb3-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23B30733020
-       mov       rax,1E6940B3020
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
 ; Total bytes of code 217
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
+       mov       rax,23B30733660
-       mov       rax,1E6840B1250
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23B30731508
-       mov       rax,1E6940B1508
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
+       mov       rdx,23B30733658
-       mov       rdx,1E6840B1248
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23B307333B8
-       mov       rdx,1E6940B33B8
        mov       r8,[r8]
+       mov       r8,23B30733020
-       mov       r8,1E6940B3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23B30733650
-       mov       rdx,1E6840B1240
        mov       r8,[r8]
+       mov       r8,23B30733020
-       mov       r8,1E6940B3020
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2b1f3749-4eb9-4f1a-b40b-cd066d81ac1b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f3b4ff9f-6c34-4809-9afe-ec8487dd5f6f-diff.temp
index 54aed0a..8bcaa9a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f3b4ff9f-6c34-4809-9afe-ec8487dd5f6f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2b1f3749-4eb9-4f1a-b40b-cd066d81ac1b-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,22A255C3020
-       mov       rax,1E6940B3020
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
 ; Total bytes of code 217
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
+       mov       rax,22A255D1DE0
-       mov       rax,1E6840B1250
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22A255C1508
-       mov       rax,1E6940B1508
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
+       mov       rdx,22A255D1DD8
-       mov       rdx,1E6840B1248
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22A255C33B8
-       mov       rdx,1E6940B33B8
        mov       r8,[r8]
+       mov       r8,22A255C3020
-       mov       r8,1E6940B3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22A255D1DD0
-       mov       rdx,1E6840B1240
        mov       r8,[r8]
+       mov       r8,22A255C3020
-       mov       r8,1E6940B3020
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d4f63a7d-d19a-4ab6-970e-4ddb7c2b80d2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9df40494-7f64-4691-9c57-0a7606d2a78f-diff.temp
index 54aed0a..0aed2f9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9df40494-7f64-4691-9c57-0a7606d2a78f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d4f63a7d-d19a-4ab6-970e-4ddb7c2b80d2-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2130D173020
-       mov       rax,1E6940B3020
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
 ; Total bytes of code 217
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
+       mov       rax,2130D181DE0
-       mov       rax,1E6840B1250
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,2130D171508
-       mov       rax,1E6940B1508
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
+       mov       rdx,2130D181DD8
-       mov       rdx,1E6840B1248
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2130D1733B8
-       mov       rdx,1E6940B33B8
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,1E6940B3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2130D181DD0
-       mov       rdx,1E6840B1240
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,1E6940B3020
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0d3d17fb-c92a-4ba1-ad84-d5bf999c8214-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6eabad53-d274-469d-a7e8-6a14d8c67490-diff.temp
index 54aed0a..e31c842 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6eabad53-d274-469d-a7e8-6a14d8c67490-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0d3d17fb-c92a-4ba1-ad84-d5bf999c8214-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1C10C821028
-       mov       rax,1CEAE023020
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
 ; Total bytes of code 217
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
+       mov       rax,1C0FC821250
-       mov       rax,1CEAE031DE0
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1C0EC821508
-       mov       rax,1CEAE021508
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
+       mov       rdx,1C0FC821248
-       mov       rdx,1CEAE031DD8
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1C10C8213C0
-       mov       rdx,1CEAE0233B8
        mov       r8,[r8]
+       mov       r8,1C10C821028
-       mov       r8,1CEAE023020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1C0FC821240
-       mov       rdx,1CEAE031DD0
        mov       r8,[r8]
+       mov       r8,1C10C821028
-       mov       r8,1CEAE023020
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2784e13b-5ec3-4f1f-921f-83b3ae8c0819-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/964d8d04-2524-4d90-9fd4-bcf777edde6c-diff.temp
index 58a8e1c..e41b54c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/964d8d04-2524-4d90-9fd4-bcf777edde6c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2784e13b-5ec3-4f1f-921f-83b3ae8c0819-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,24F73953020
-       mov       rax,1CEAE023020
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
 ; Total bytes of code 217
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
+       mov       rax,24F73953660
-       mov       rax,1CEAE031DE0
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24F73951508
-       mov       rax,1CEAE021508
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
+       mov       rdx,24F73953658
-       mov       rdx,1CEAE031DD8
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,24F739533B8
-       mov       rdx,1CEAE0233B8
        mov       r8,[r8]
+       mov       r8,24F73953020
-       mov       r8,1CEAE023020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,24F73953650
-       mov       rdx,1CEAE031DD0
        mov       r8,[r8]
+       mov       r8,24F73953020
-       mov       r8,1CEAE023020
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4b764e4d-e856-42ce-90da-37283fd0eeeb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d503678b-51a5-47dc-ad77-7f489fd7b6d7-diff.temp
index 58a8e1c..d9f67fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d503678b-51a5-47dc-ad77-7f489fd7b6d7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4b764e4d-e856-42ce-90da-37283fd0eeeb-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,23B30733660
-       mov       rax,1CEAE031DE0
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23B30731508
-       mov       rax,1CEAE021508
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
+       mov       rdx,23B30733658
-       mov       rdx,1CEAE031DD8
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23B307333B8
-       mov       rdx,1CEAE0233B8
        mov       r8,[r8]
+       mov       r8,23B30733020
-       mov       r8,1CEAE023020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23B30733650
-       mov       rdx,1CEAE031DD0
        mov       r8,[r8]
+       mov       r8,23B30733020
-       mov       r8,1CEAE023020
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
        call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/31f1f906-ddc2-42a6-bdea-fa87bf9bac36-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/df932e0a-c509-413f-b57b-4ade4cb42234-diff.temp
index 58a8e1c..8bcaa9a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/df932e0a-c509-413f-b57b-4ade4cb42234-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/31f1f906-ddc2-42a6-bdea-fa87bf9bac36-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,22A255D1DE0
-       mov       rax,1CEAE031DE0
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22A255C1508
-       mov       rax,1CEAE021508
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
+       mov       rdx,22A255D1DD8
-       mov       rdx,1CEAE031DD8
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22A255C33B8
-       mov       rdx,1CEAE0233B8
        mov       r8,[r8]
+       mov       r8,22A255C3020
-       mov       r8,1CEAE023020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22A255D1DD0
-       mov       rdx,1CEAE031DD0
        mov       r8,[r8]
+       mov       r8,22A255C3020
-       mov       r8,1CEAE023020
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
        call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/17135930-601c-4290-bb16-76d3f95cdd2a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7605e85b-6a0e-4789-ab98-15559c5706a9-diff.temp
index 58a8e1c..0aed2f9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7605e85b-6a0e-4789-ab98-15559c5706a9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/17135930-601c-4290-bb16-76d3f95cdd2a-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,2130D181DE0
-       mov       rax,1CEAE031DE0
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,2130D171508
-       mov       rax,1CEAE021508
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
+       mov       rdx,2130D181DD8
-       mov       rdx,1CEAE031DD8
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2130D1733B8
-       mov       rdx,1CEAE0233B8
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,1CEAE023020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2130D181DD0
-       mov       rdx,1CEAE031DD0
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,1CEAE023020
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
        call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8459b684-0f9d-4255-9483-ab548284e56a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/58883e73-8967-48c1-b988-c1b6b2772f01-diff.temp
index 58a8e1c..e31c842 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/58883e73-8967-48c1-b988-c1b6b2772f01-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8459b684-0f9d-4255-9483-ab548284e56a-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,24F73953660
-       mov       rax,1C0FC821250
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24F73951508
-       mov       rax,1C0EC821508
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
+       mov       rdx,24F73953658
-       mov       rdx,1C0FC821248
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,24F739533B8
-       mov       rdx,1C10C8213C0
        mov       r8,[r8]
+       mov       r8,24F73953020
-       mov       r8,1C10C821028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,24F73953650
-       mov       rdx,1C0FC821240
        mov       r8,[r8]
+       mov       r8,24F73953020
-       mov       r8,1C10C821028
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
        call      qword ptr [7FF9EA0F7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4b69c36d-4c1c-43a2-9fca-2e809ddf4fd4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e77a486-0679-403c-a318-39fdb7b06944-diff.temp
index e41b54c..d9f67fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1e77a486-0679-403c-a318-39fdb7b06944-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4b69c36d-4c1c-43a2-9fca-2e809ddf4fd4-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23B30733020
-       mov       rax,1C10C821028
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
 ; Total bytes of code 217
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
+       mov       rax,23B30733660
-       mov       rax,1C0FC821250
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23B30731508
-       mov       rax,1C0EC821508
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
+       mov       rdx,23B30733658
-       mov       rdx,1C0FC821248
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23B307333B8
-       mov       rdx,1C10C8213C0
        mov       r8,[r8]
+       mov       r8,23B30733020
-       mov       r8,1C10C821028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23B30733650
-       mov       rdx,1C0FC821240
        mov       r8,[r8]
+       mov       r8,23B30733020
-       mov       r8,1C10C821028
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/989ad76b-c4b6-470e-801f-7fe1c12e55e6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b068e2b8-2663-45b3-a3ad-2cae25356e03-diff.temp
index e41b54c..8bcaa9a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b068e2b8-2663-45b3-a3ad-2cae25356e03-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/989ad76b-c4b6-470e-801f-7fe1c12e55e6-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,22A255C3020
-       mov       rax,1C10C821028
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
 ; Total bytes of code 217
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
+       mov       rax,22A255D1DE0
-       mov       rax,1C0FC821250
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22A255C1508
-       mov       rax,1C0EC821508
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
+       mov       rdx,22A255D1DD8
-       mov       rdx,1C0FC821248
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22A255C33B8
-       mov       rdx,1C10C8213C0
        mov       r8,[r8]
+       mov       r8,22A255C3020
-       mov       r8,1C10C821028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22A255D1DD0
-       mov       rdx,1C0FC821240
        mov       r8,[r8]
+       mov       r8,22A255C3020
-       mov       r8,1C10C821028
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83e3af8a-2dd7-4be5-aec8-5aa00d3e7b1b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0d823a21-6075-4bc3-af07-e015e1acf9d5-diff.temp
index e41b54c..0aed2f9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0d823a21-6075-4bc3-af07-e015e1acf9d5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83e3af8a-2dd7-4be5-aec8-5aa00d3e7b1b-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2130D173020
-       mov       rax,1C10C821028
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
 ; Total bytes of code 217
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
+       mov       rax,2130D181DE0
-       mov       rax,1C0FC821250
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,2130D171508
-       mov       rax,1C0EC821508
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
+       mov       rdx,2130D181DD8
-       mov       rdx,1C0FC821248
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2130D1733B8
-       mov       rdx,1C10C8213C0
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,1C10C821028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2130D181DD0
-       mov       rdx,1C0FC821240
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,1C10C821028
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a51cd4d-99f9-4c2f-b372-187c4ddb688b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/60b357c5-1bde-4992-b7e2-660489fa7b65-diff.temp
index e41b54c..e31c842 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/60b357c5-1bde-4992-b7e2-660489fa7b65-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a51cd4d-99f9-4c2f-b372-187c4ddb688b-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23B30733020
-       mov       rax,24F73953020
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
 ; Total bytes of code 217
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
+       mov       rax,23B30733660
-       mov       rax,24F73953660
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23B30731508
-       mov       rax,24F73951508
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
+       mov       rdx,23B30733658
-       mov       rdx,24F73953658
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23B307333B8
-       mov       rdx,24F739533B8
        mov       r8,[r8]
+       mov       r8,23B30733020
-       mov       r8,24F73953020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23B30733650
-       mov       rdx,24F73953650
        mov       r8,[r8]
+       mov       r8,23B30733020
-       mov       r8,24F73953020
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e5a4327d-ee83-41a0-a121-15828fc034cf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/23f0b579-a47a-4f9f-8854-58a15ce569ce-diff.temp
index d9f67fb..8bcaa9a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/23f0b579-a47a-4f9f-8854-58a15ce569ce-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e5a4327d-ee83-41a0-a121-15828fc034cf-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,22A255C3020
-       mov       rax,24F73953020
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
 ; Total bytes of code 217
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
+       mov       rax,22A255D1DE0
-       mov       rax,24F73953660
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22A255C1508
-       mov       rax,24F73951508
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
+       mov       rdx,22A255D1DD8
-       mov       rdx,24F73953658
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22A255C33B8
-       mov       rdx,24F739533B8
        mov       r8,[r8]
+       mov       r8,22A255C3020
-       mov       r8,24F73953020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22A255D1DD0
-       mov       rdx,24F73953650
        mov       r8,[r8]
+       mov       r8,22A255C3020
-       mov       r8,24F73953020
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b0b474af-ee5a-4ac3-841d-bfa709a7f74c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/03069b0d-8cbb-4d77-8f2a-a112461c2840-diff.temp
index d9f67fb..0aed2f9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/03069b0d-8cbb-4d77-8f2a-a112461c2840-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b0b474af-ee5a-4ac3-841d-bfa709a7f74c-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2130D173020
-       mov       rax,24F73953020
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
 ; Total bytes of code 217
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
+       mov       rax,2130D181DE0
-       mov       rax,24F73953660
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,2130D171508
-       mov       rax,24F73951508
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
+       mov       rdx,2130D181DD8
-       mov       rdx,24F73953658
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2130D1733B8
-       mov       rdx,24F739533B8
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,24F73953020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2130D181DD0
-       mov       rdx,24F73953650
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,24F73953020
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/98566fac-0589-4166-a4e9-c4d39300e538-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65249fea-11a1-449a-a92a-f7e1ced54299-diff.temp
index d9f67fb..e31c842 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65249fea-11a1-449a-a92a-f7e1ced54299-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/98566fac-0589-4166-a4e9-c4d39300e538-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,22A255D1DE0
-       mov       rax,23B30733660
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,22A255C1508
-       mov       rax,23B30731508
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
+       mov       rdx,22A255D1DD8
-       mov       rdx,23B30733658
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22A255C33B8
-       mov       rdx,23B307333B8
        mov       r8,[r8]
+       mov       r8,22A255C3020
-       mov       r8,23B30733020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,22A255D1DD0
-       mov       rdx,23B30733650
        mov       r8,[r8]
+       mov       r8,22A255C3020
-       mov       r8,23B30733020
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
        call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/af449e72-d854-40c5-9467-07e268697a9b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8acd4287-32b2-44c2-af10-c8c35083101b-diff.temp
index 8bcaa9a..0aed2f9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8acd4287-32b2-44c2-af10-c8c35083101b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/af449e72-d854-40c5-9467-07e268697a9b-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,2130D181DE0
-       mov       rax,23B30733660
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,2130D171508
-       mov       rax,23B30731508
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
+       mov       rdx,2130D181DD8
-       mov       rdx,23B30733658
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2130D1733B8
-       mov       rdx,23B307333B8
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,23B30733020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2130D181DD0
-       mov       rdx,23B30733650
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,23B30733020
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
        call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c19d029c-6ae8-4fd4-b710-a622bc396624-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/86b51cbd-44af-4d66-98d1-3163bf59e8fa-diff.temp
index 8bcaa9a..e31c842 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/86b51cbd-44af-4d66-98d1-3163bf59e8fa-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c19d029c-6ae8-4fd4-b710-a622bc396624-diff.temp
```
**Diff for AppendBytes01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,2130D181DE0
-       mov       rax,22A255D1DE0
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,2130D171508
-       mov       rax,22A255C1508
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
+       mov       rdx,2130D181DD8
-       mov       rdx,22A255D1DD8
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2130D1733B8
-       mov       rdx,22A255C33B8
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,22A255C3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2130D181DD0
-       mov       rdx,22A255D1DD0
        mov       r8,[r8]
+       mov       r8,2130D173020
-       mov       r8,22A255C3020
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
        call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7ad2c93e-f2f3-4811-992f-baf010b5f807-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/917b305d-ff73-443f-b042-07c48476121c-diff.temp
index 0aed2f9..e31c842 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/917b305d-ff73-443f-b042-07c48476121c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7ad2c93e-f2f3-4811-992f-baf010b5f807-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,193476B1028
-       mov       rax,2853E243020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,193476BF658
-       mov       rdx,2853E251650
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,193476B9BE8
-       mov       r9,2853E24BBE0
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA165B68
-       mov       rcx,7FF9EA175B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,193276B30D8
-       mov       rdx,2853E251C70
        mov       r8,[r8]
+       mov       r8,193476B1028
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,193476BF748
-       mov       rdx,2853E251740
        mov       r8,[r8]
+       mov       r8,193476B1028
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,193276B3238
-       mov       rdx,2853E251DD0
        mov       r8,[r8]
+       mov       r8,193476B1028
-       mov       r8,2853E243020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA127D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08b9967c-42cb-413e-b2c8-73a3adc38374-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3eaf2a1d-e318-4fc8-ac94-4cf95f0b52a7-diff.temp
index ea140d6..cc17745 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3eaf2a1d-e318-4fc8-ac94-4cf95f0b52a7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/08b9967c-42cb-413e-b2c8-73a3adc38374-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,2DA5FFE3020
-       mov       rax,2853E243020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2DA3FFE12D8
-       mov       rdx,2853E251650
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,2DA4FFE77D8
-       mov       r9,2853E24BBE0
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA165B68
-       mov       rcx,7FF9EA175B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2DA4FFED050
-       mov       rdx,2853E251C70
        mov       r8,[r8]
+       mov       r8,2DA5FFE3020
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2DA3FFE13C8
-       mov       rdx,2853E251740
        mov       r8,[r8]
+       mov       r8,2DA5FFE3020
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2DA4FFED1B0
-       mov       rdx,2853E251DD0
        mov       r8,[r8]
+       mov       r8,2DA5FFE3020
-       mov       r8,2853E243020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA127D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6ba7f7c7-87d8-45e5-8ef9-a4e6297be76e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2815cc58-ea6f-4a1d-a7e6-ae1fdd53eb4d-diff.temp
index ea140d6..59dcdb2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2815cc58-ea6f-4a1d-a7e6-ae1fdd53eb4d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6ba7f7c7-87d8-45e5-8ef9-a4e6297be76e-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1C169AFF658
-       mov       rdx,2853E251650
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,1C169AF9BE8
-       mov       r9,2853E24BBE0
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF9EA175B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1C169AFFC78
-       mov       rdx,2853E251C70
        mov       r8,[r8]
+       mov       r8,1C169AF1028
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1C169AFF748
-       mov       rdx,2853E251740
        mov       r8,[r8]
+       mov       r8,1C169AF1028
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1C169AFFDD8
-       mov       rdx,2853E251DD0
        mov       r8,[r8]
+       mov       r8,1C169AF1028
-       mov       r8,2853E243020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
        call      qword ptr [7FF9EA127D20]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a67bcb0c-6edc-43a6-85f8-0f59fdfdadab-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4edb4cc4-3dd0-4e02-9d6c-8322a45394a3-diff.temp
index ea140d6..d18ee0e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4edb4cc4-3dd0-4e02-9d6c-8322a45394a3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a67bcb0c-6edc-43a6-85f8-0f59fdfdadab-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23C22F63020
-       mov       rax,2853E243020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23C22F71650
-       mov       rdx,2853E251650
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,23C22F6BBE0
-       mov       r9,2853E24BBE0
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA135B68
-       mov       rcx,7FF9EA175B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23C02F610E0
-       mov       rdx,2853E251C70
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,23C22F71740
-       mov       rdx,2853E251740
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23C02F61240
-       mov       rdx,2853E251DD0
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,2853E243020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0E7D20]
-       call      qword ptr [7FF9EA127D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/74d8d094-6f3e-4f42-8d69-63fc243256c8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67403d75-fb87-4e52-a3f1-13cfd7693218-diff.temp
index ea140d6..6b8ed49 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67403d75-fb87-4e52-a3f1-13cfd7693218-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/74d8d094-6f3e-4f42-8d69-63fc243256c8-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,266CC173020
-       mov       rax,2853E243020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,266AC1712D8
-       mov       rdx,2853E251650
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,266BC1777D8
-       mov       r9,2853E24BBE0
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA145B68
-       mov       rcx,7FF9EA175B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,266BC17D050
-       mov       rdx,2853E251C70
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,266AC1713C8
-       mov       rdx,2853E251740
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,266BC17D1B0
-       mov       rdx,2853E251DD0
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,2853E243020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA127D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d6e43b69-8fcc-4bfd-9a87-963e651a7570-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cd5b327b-2e28-408a-bcba-ee831eeeb88b-diff.temp
index ea140d6..79cc586 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cd5b327b-2e28-408a-bcba-ee831eeeb88b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d6e43b69-8fcc-4bfd-9a87-963e651a7570-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1F57BD83020
-       mov       rax,2853E243020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91650
-       mov       rdx,2853E251650
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,1F57BD8BBE0
-       mov       r9,2853E24BBE0
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA145B68
-       mov       rcx,7FF9EA175B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD810E0
-       mov       rdx,2853E251C70
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91740
-       mov       rdx,2853E251740
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,2853E243020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD81240
-       mov       rdx,2853E251DD0
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,2853E243020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA127D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9d339183-4154-4fa2-b882-e80630b18e73-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aad1b3e0-93b1-4428-bb84-62bc8961a6d1-diff.temp
index ea140d6..3f65a76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aad1b3e0-93b1-4428-bb84-62bc8961a6d1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9d339183-4154-4fa2-b882-e80630b18e73-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2DA3FFE12D8
-       mov       rdx,193476BF658
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,2DA4FFE77D8
-       mov       r9,193476B9BE8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF9EA165B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2DA4FFED050
-       mov       rdx,193276B30D8
        mov       r8,[r8]
+       mov       r8,2DA5FFE3020
-       mov       r8,193476B1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,2DA3FFE13C8
-       mov       rdx,193476BF748
        mov       r8,[r8]
+       mov       r8,2DA5FFE3020
-       mov       r8,193476B1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2DA4FFED1B0
-       mov       rdx,193276B3238
        mov       r8,[r8]
+       mov       r8,2DA5FFE3020
-       mov       r8,193476B1028
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
        call      qword ptr [7FF9EA117D20]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/54163ec2-0fdb-479b-bb64-feff300df2b9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9af4a7bc-fb8b-4d50-b971-d4f9996e249b-diff.temp
index cc17745..59dcdb2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9af4a7bc-fb8b-4d50-b971-d4f9996e249b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/54163ec2-0fdb-479b-bb64-feff300df2b9-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1C169AF1028
-       mov       rax,193476B1028
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1C169AFF658
-       mov       rdx,193476BF658
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,1C169AF9BE8
-       mov       r9,193476B9BE8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA175B68
-       mov       rcx,7FF9EA165B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1C169AFFC78
-       mov       rdx,193276B30D8
        mov       r8,[r8]
+       mov       r8,1C169AF1028
-       mov       r8,193476B1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1C169AFF748
-       mov       rdx,193476BF748
        mov       r8,[r8]
+       mov       r8,1C169AF1028
-       mov       r8,193476B1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1C169AFFDD8
-       mov       rdx,193276B3238
        mov       r8,[r8]
+       mov       r8,1C169AF1028
-       mov       r8,193476B1028
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA127D20]
-       call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/326f6057-e2eb-47ef-89cf-65c679e61c13-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1a7a1676-c9cf-426e-83cc-b12ac7d2f54f-diff.temp
index cc17745..d18ee0e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1a7a1676-c9cf-426e-83cc-b12ac7d2f54f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/326f6057-e2eb-47ef-89cf-65c679e61c13-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23C22F63020
-       mov       rax,193476B1028
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23C22F71650
-       mov       rdx,193476BF658
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,23C22F6BBE0
-       mov       r9,193476B9BE8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA135B68
-       mov       rcx,7FF9EA165B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23C02F610E0
-       mov       rdx,193276B30D8
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,193476B1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,23C22F71740
-       mov       rdx,193476BF748
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,193476B1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23C02F61240
-       mov       rdx,193276B3238
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,193476B1028
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0E7D20]
-       call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fd526d57-0f71-46a4-8440-c285361ea987-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/adb2d1a8-a7d0-4b5d-b7cd-090b5cd8f8d6-diff.temp
index cc17745..6b8ed49 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/adb2d1a8-a7d0-4b5d-b7cd-090b5cd8f8d6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fd526d57-0f71-46a4-8440-c285361ea987-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,266CC173020
-       mov       rax,193476B1028
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,266AC1712D8
-       mov       rdx,193476BF658
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,266BC1777D8
-       mov       r9,193476B9BE8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA145B68
-       mov       rcx,7FF9EA165B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,266BC17D050
-       mov       rdx,193276B30D8
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,193476B1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,266AC1713C8
-       mov       rdx,193476BF748
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,193476B1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,266BC17D1B0
-       mov       rdx,193276B3238
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,193476B1028
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/46de4b8d-9bd5-4a43-9b49-a2977b23c380-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/81ec54f4-baae-421a-a0ed-04b8d5d962ef-diff.temp
index cc17745..79cc586 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/81ec54f4-baae-421a-a0ed-04b8d5d962ef-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/46de4b8d-9bd5-4a43-9b49-a2977b23c380-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1F57BD83020
-       mov       rax,193476B1028
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91650
-       mov       rdx,193476BF658
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,1F57BD8BBE0
-       mov       r9,193476B9BE8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA145B68
-       mov       rcx,7FF9EA165B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD810E0
-       mov       rdx,193276B30D8
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,193476B1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91740
-       mov       rdx,193476BF748
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,193476B1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD81240
-       mov       rdx,193276B3238
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,193476B1028
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5cb934f4-a86a-451c-ad21-4d28d4ba7f62-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/caa4832c-a001-4f95-94ae-2dbb4019da3a-diff.temp
index cc17745..3f65a76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/caa4832c-a001-4f95-94ae-2dbb4019da3a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5cb934f4-a86a-451c-ad21-4d28d4ba7f62-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1C169AF1028
-       mov       rax,2DA5FFE3020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1C169AFF658
-       mov       rdx,2DA3FFE12D8
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,1C169AF9BE8
-       mov       r9,2DA4FFE77D8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA175B68
-       mov       rcx,7FF9EA165B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1C169AFFC78
-       mov       rdx,2DA4FFED050
        mov       r8,[r8]
+       mov       r8,1C169AF1028
-       mov       r8,2DA5FFE3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1C169AFF748
-       mov       rdx,2DA3FFE13C8
        mov       r8,[r8]
+       mov       r8,1C169AF1028
-       mov       r8,2DA5FFE3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1C169AFFDD8
-       mov       rdx,2DA4FFED1B0
        mov       r8,[r8]
+       mov       r8,1C169AF1028
-       mov       r8,2DA5FFE3020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA127D20]
-       call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f4654e04-1afa-4d9e-8e7b-91c7f1c15d27-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/78100f25-7f0f-422d-b44e-17349180deae-diff.temp
index 59dcdb2..d18ee0e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/78100f25-7f0f-422d-b44e-17349180deae-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f4654e04-1afa-4d9e-8e7b-91c7f1c15d27-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23C22F63020
-       mov       rax,2DA5FFE3020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23C22F71650
-       mov       rdx,2DA3FFE12D8
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,23C22F6BBE0
-       mov       r9,2DA4FFE77D8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA135B68
-       mov       rcx,7FF9EA165B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23C02F610E0
-       mov       rdx,2DA4FFED050
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,2DA5FFE3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,23C22F71740
-       mov       rdx,2DA3FFE13C8
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,2DA5FFE3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23C02F61240
-       mov       rdx,2DA4FFED1B0
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,2DA5FFE3020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0E7D20]
-       call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/71414dd8-21bc-4946-beb0-05bca458e724-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bee835f1-f1ee-43f7-89b1-2247500ffbbc-diff.temp
index 59dcdb2..6b8ed49 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bee835f1-f1ee-43f7-89b1-2247500ffbbc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/71414dd8-21bc-4946-beb0-05bca458e724-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,266CC173020
-       mov       rax,2DA5FFE3020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,266AC1712D8
-       mov       rdx,2DA3FFE12D8
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,266BC1777D8
-       mov       r9,2DA4FFE77D8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA145B68
-       mov       rcx,7FF9EA165B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,266BC17D050
-       mov       rdx,2DA4FFED050
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,2DA5FFE3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,266AC1713C8
-       mov       rdx,2DA3FFE13C8
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,2DA5FFE3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,266BC17D1B0
-       mov       rdx,2DA4FFED1B0
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,2DA5FFE3020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5631ac23-553e-484e-bab8-69f32e0d8457-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7be5a920-eaff-4e37-895a-2ca17ca1875c-diff.temp
index 59dcdb2..79cc586 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7be5a920-eaff-4e37-895a-2ca17ca1875c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5631ac23-553e-484e-bab8-69f32e0d8457-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1F57BD83020
-       mov       rax,2DA5FFE3020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91650
-       mov       rdx,2DA3FFE12D8
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,1F57BD8BBE0
-       mov       r9,2DA4FFE77D8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA145B68
-       mov       rcx,7FF9EA165B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD810E0
-       mov       rdx,2DA4FFED050
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,2DA5FFE3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91740
-       mov       rdx,2DA3FFE13C8
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,2DA5FFE3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD81240
-       mov       rdx,2DA4FFED1B0
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,2DA5FFE3020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA117D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a8984932-63d7-41cd-9043-8487b282c291-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5711911d-438b-4351-83ce-eb7a174c5191-diff.temp
index 59dcdb2..3f65a76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5711911d-438b-4351-83ce-eb7a174c5191-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a8984932-63d7-41cd-9043-8487b282c291-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,23C22F63020
-       mov       rax,1C169AF1028
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23C22F71650
-       mov       rdx,1C169AFF658
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,23C22F6BBE0
-       mov       r9,1C169AF9BE8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA135B68
-       mov       rcx,7FF9EA175B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,23C02F610E0
-       mov       rdx,1C169AFFC78
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,1C169AF1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,23C22F71740
-       mov       rdx,1C169AFF748
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,1C169AF1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,23C02F61240
-       mov       rdx,1C169AFFDD8
        mov       r8,[r8]
+       mov       r8,23C22F63020
-       mov       r8,1C169AF1028
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0E7D20]
-       call      qword ptr [7FF9EA127D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/74127ce3-9656-4bfb-b7f0-87ce8bd7c541-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/099fe227-8eb5-4d74-81c9-7e9520bce212-diff.temp
index d18ee0e..6b8ed49 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/099fe227-8eb5-4d74-81c9-7e9520bce212-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/74127ce3-9656-4bfb-b7f0-87ce8bd7c541-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,266CC173020
-       mov       rax,1C169AF1028
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,266AC1712D8
-       mov       rdx,1C169AFF658
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,266BC1777D8
-       mov       r9,1C169AF9BE8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA145B68
-       mov       rcx,7FF9EA175B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,266BC17D050
-       mov       rdx,1C169AFFC78
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,1C169AF1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,266AC1713C8
-       mov       rdx,1C169AFF748
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,1C169AF1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,266BC17D1B0
-       mov       rdx,1C169AFFDD8
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,1C169AF1028
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA127D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d3bbae4d-66a6-4bda-a646-1c48ad591383-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d552ac5-ace5-42c7-8d64-96ceb19ac01a-diff.temp
index d18ee0e..79cc586 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8d552ac5-ace5-42c7-8d64-96ceb19ac01a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d3bbae4d-66a6-4bda-a646-1c48ad591383-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1F57BD83020
-       mov       rax,1C169AF1028
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91650
-       mov       rdx,1C169AFF658
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,1F57BD8BBE0
-       mov       r9,1C169AF9BE8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA145B68
-       mov       rcx,7FF9EA175B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD810E0
-       mov       rdx,1C169AFFC78
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,1C169AF1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91740
-       mov       rdx,1C169AFF748
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,1C169AF1028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD81240
-       mov       rdx,1C169AFFDD8
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,1C169AF1028
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA127D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1d0349dc-2e28-4c8d-bf20-9a6f281c3ea9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7fe64a0f-c8ab-41bd-9ea6-9fd1547bf824-diff.temp
index d18ee0e..3f65a76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7fe64a0f-c8ab-41bd-9ea6-9fd1547bf824-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1d0349dc-2e28-4c8d-bf20-9a6f281c3ea9-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,266CC173020
-       mov       rax,23C22F63020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,266AC1712D8
-       mov       rdx,23C22F71650
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,266BC1777D8
-       mov       r9,23C22F6BBE0
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA145B68
-       mov       rcx,7FF9EA135B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,266BC17D050
-       mov       rdx,23C02F610E0
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,23C22F63020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,266AC1713C8
-       mov       rdx,23C22F71740
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,23C22F63020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,266BC17D1B0
-       mov       rdx,23C02F61240
        mov       r8,[r8]
+       mov       r8,266CC173020
-       mov       r8,23C22F63020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5b5aff24-0a34-452a-8534-a18dbf6c9763-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8679bd48-0595-4798-9922-b7eb076cc0ee-diff.temp
index 6b8ed49..79cc586 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8679bd48-0595-4798-9922-b7eb076cc0ee-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5b5aff24-0a34-452a-8534-a18dbf6c9763-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1F57BD83020
-       mov       rax,23C22F63020
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
 ; Total bytes of code 431
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L08:
        int       3
        call      CORINFO_HELP_OVERFLOW
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91650
-       mov       rdx,23C22F71650
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,1F57BD8BBE0
-       mov       r9,23C22F6BBE0
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF9EA145B68
-       mov       rcx,7FF9EA135B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
 M01_L00:
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD810E0
-       mov       rdx,23C02F610E0
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,23C22F63020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91740
-       mov       rdx,23C22F71740
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,23C22F63020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD81240
-       mov       rdx,23C02F61240
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,23C22F63020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0e5216be-ffc8-41c8-8045-5bcaa9d7d602-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9e422220-a393-4bd7-9da4-02078fd0f513-diff.temp
index 6b8ed49..3f65a76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9e422220-a393-4bd7-9da4-02078fd0f513-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0e5216be-ffc8-41c8-8045-5bcaa9d7d602-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91650
-       mov       rdx,266AC1712D8
 M01_L05:
        jne       short M01_L06
        cmp       r14d,0FFFFFFFE
        je        short M01_L05
        cmp       r14d,0FFFFFFFF
        jmp       short M01_L01
        jo        short M01_L07
        add       ebx,1
        mov       ebx,r15d
        call      System.Text.StringBuilder.Append(Char)
        mov       rcx,rsi
        movzx     edx,word ptr [rdi+rdx*2+0C]
        movsxd    rdx,r15d
        jae       near ptr M01_L08
        cmp       r15d,ebp
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
        mov       r9d,ebp
        mov       rdx,[r9]
+       mov       r9,1F57BD8BBE0
-       mov       r9,266BC1777D8
 M01_L01:
        mov       ebp,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF9EA145B68
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
        jne       near ptr M01_L03
        cmp       ebp,0FFFFFFFE
        je        short M01_L00
        cmp       ebp,0FFFFFFFF
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,3D
        mov       rcx,rsi
        call      System.Text.StringBuilder.Append(System.String)
        cmp       [rcx],ecx
        mov       rdx,rbx
        mov       rcx,rsi
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD810E0
-       mov       rdx,266BC17D050
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,266CC173020
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
        mov       rcx,rbx
        mov       rdx,[rdx]
+       mov       rdx,1F57BD91740
-       mov       rdx,266AC1713C8
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,266CC173020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1F55BD81240
-       mov       rdx,266BC17D1B0
        mov       r8,[r8]
+       mov       r8,1F57BD83020
-       mov       r8,266CC173020
        mov       r14d,[rsp+80]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
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
 M00_L02:
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
        call      qword ptr [7FF9EA0F7D20]
        mov       rcx,rdi
        mov       rsi,[rsi+10]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/85c4aab8-dc1c-4bb3-985f-ee52fe438cfb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9b66997f-dd88-40ca-b276-a7105de7b980-diff.temp
index 79cc586..3f65a76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9b66997f-dd88-40ca-b276-a7105de7b980-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/85c4aab8-dc1c-4bb3-985f-ee52fe438cfb-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,11CD0363020
-       mov       rax,1EE08353020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,11CE0361248
-       mov       rdx,1EE083615C0
        mov       r8,[r8]
+       mov       r8,11CD0363020
-       mov       r8,1EE08353020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,11CD0363020
-       mov       r8,1EE08353020
        mov       rdx,[rdx]
+       mov       rdx,11CE0361240
-       mov       rdx,1EE083615B8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA0F7D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+       mov       rcx,11CD0371650
-       mov       rcx,1EDE83512D8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/88900864-6236-4dd6-8eef-759102de277d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6d2c92f0-980b-4147-9a87-051aab505707-diff.temp
index 7926be0..663581b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6d2c92f0-980b-4147-9a87-051aab505707-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/88900864-6236-4dd6-8eef-759102de277d-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,22766FF3020
-       mov       rax,1EE08353020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,227670015C0
-       mov       rdx,1EE083615C0
        mov       r8,[r8]
+       mov       r8,22766FF3020
-       mov       r8,1EE08353020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,22766FF3020
-       mov       r8,1EE08353020
        mov       rdx,[rdx]
+       mov       rdx,227670015B8
-       mov       rdx,1EE083615B8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA107D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+       mov       rcx,22746FF12D8
-       mov       rcx,1EDE83512D8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8ed99460-c5b2-4ad8-998b-f26df5ec4a4a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6d0dcd43-9b14-4735-bdd7-aadceeec9ece-diff.temp
index 7926be0..1cf3825 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6d0dcd43-9b14-4735-bdd7-aadceeec9ece-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8ed99460-c5b2-4ad8-998b-f26df5ec4a4a-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CDDF781028
-       mov       rax,1EE08353020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1CDBF783240
-       mov       rdx,1EE083615C0
        mov       r8,[r8]
+       mov       r8,1CDDF781028
-       mov       r8,1EE08353020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1CDDF781028
-       mov       r8,1EE08353020
        mov       rdx,[rdx]
+       mov       rdx,1CDBF783238
-       mov       rdx,1EE083615B8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA127D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+       mov       rcx,1CDDF7836E8
-       mov       rcx,1EDE83512D8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3b39fdc0-166a-469a-960a-cab3b9d4e23d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a9d80fc9-5d91-4b2d-8d6e-6c83157221ab-diff.temp
index 7926be0..e290917 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a9d80fc9-5d91-4b2d-8d6e-6c83157221ab-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3b39fdc0-166a-469a-960a-cab3b9d4e23d-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/872e1c48-dbbd-4437-935f-3a2d5c302964-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d8d718b4-a28a-4c0e-a44c-61e95e8d1dd1-diff.temp
index 7926be0..8d4319a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d8d718b4-a28a-4c0e-a44c-61e95e8d1dd1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/872e1c48-dbbd-4437-935f-3a2d5c302964-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,18247A13020
-       mov       rax,1EE08353020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,18247A21DD8
-       mov       rdx,1EE083615C0
        mov       r8,[r8]
+       mov       r8,18247A13020
-       mov       r8,1EE08353020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,18247A13020
-       mov       r8,1EE08353020
        mov       rdx,[rdx]
+       mov       rdx,18247A21DD0
-       mov       rdx,1EE083615B8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+       mov       rcx,18247A21650
-       mov       rcx,1EDE83512D8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1be1f9a6-6bfe-45f8-8999-4b7e05d38af7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4d33c3f7-55e6-4496-8aa9-5e37532a7aec-diff.temp
index 7926be0..fde81d6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4d33c3f7-55e6-4496-8aa9-5e37532a7aec-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1be1f9a6-6bfe-45f8-8999-4b7e05d38af7-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1F51E103020
-       mov       rax,1EE08353020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F53E101248
-       mov       rdx,1EE083615C0
        mov       r8,[r8]
+       mov       r8,1F51E103020
-       mov       r8,1EE08353020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1F51E103020
-       mov       r8,1EE08353020
        mov       rdx,[rdx]
+       mov       rdx,1F53E101240
-       mov       rdx,1EE083615B8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+       mov       rcx,1F52E10F240
-       mov       rcx,1EDE83512D8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3c75c8fc-1584-4278-b9e3-6622985578da-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4ec63adb-0496-41e0-baf8-5dc522eb2fff-diff.temp
index 7926be0..d6712be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4ec63adb-0496-41e0-baf8-5dc522eb2fff-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3c75c8fc-1584-4278-b9e3-6622985578da-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,22766FF3020
-       mov       rax,11CD0363020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,227670015C0
-       mov       rdx,11CE0361248
        mov       r8,[r8]
+       mov       r8,22766FF3020
-       mov       r8,11CD0363020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,22766FF3020
-       mov       r8,11CD0363020
        mov       rdx,[rdx]
+       mov       rdx,227670015B8
-       mov       rdx,11CE0361240
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA107D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+       mov       rcx,22746FF12D8
-       mov       rcx,11CD0371650
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f4b01f5e-ac77-4d9d-8afc-f244f81867a9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/afe742cf-8e87-4bdc-83c1-1dc483946bc7-diff.temp
index 663581b..1cf3825 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/afe742cf-8e87-4bdc-83c1-1dc483946bc7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f4b01f5e-ac77-4d9d-8afc-f244f81867a9-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CDDF781028
-       mov       rax,11CD0363020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1CDBF783240
-       mov       rdx,11CE0361248
        mov       r8,[r8]
+       mov       r8,1CDDF781028
-       mov       r8,11CD0363020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1CDDF781028
-       mov       r8,11CD0363020
        mov       rdx,[rdx]
+       mov       rdx,1CDBF783238
-       mov       rdx,11CE0361240
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA127D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+       mov       rcx,1CDDF7836E8
-       mov       rcx,11CD0371650
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/acc9c35c-169e-425f-bbba-72a2d081e583-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dad4fb98-69de-441e-8735-01505f10d8e1-diff.temp
index 663581b..e290917 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dad4fb98-69de-441e-8735-01505f10d8e1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/acc9c35c-169e-425f-bbba-72a2d081e583-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,207C7331028
-       mov       rax,11CD0363020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,207C733FDE0
-       mov       rdx,11CE0361248
        mov       r8,[r8]
+       mov       r8,207C7331028
-       mov       r8,11CD0363020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,207C7331028
-       mov       r8,11CD0363020
        mov       rdx,[rdx]
+       mov       rdx,207C733FDD8
-       mov       rdx,11CE0361240
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA0E7D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+       mov       rcx,207C733F658
-       mov       rcx,11CD0371650
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cc42a64a-426f-4bde-9c6e-85d0bf9906e3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/69922a42-ba8f-42ae-b279-993ff48285f7-diff.temp
index 663581b..8d4319a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/69922a42-ba8f-42ae-b279-993ff48285f7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cc42a64a-426f-4bde-9c6e-85d0bf9906e3-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,18247A13020
-       mov       rax,11CD0363020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,18247A21DD8
-       mov       rdx,11CE0361248
        mov       r8,[r8]
+       mov       r8,18247A13020
-       mov       r8,11CD0363020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,18247A13020
-       mov       r8,11CD0363020
        mov       rdx,[rdx]
+       mov       rdx,18247A21DD0
-       mov       rdx,11CE0361240
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+       mov       rcx,18247A21650
-       mov       rcx,11CD0371650
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fbbfcb4c-7923-4daa-89a1-e0ce1e83a7f7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1c0a584c-cca3-4d83-a273-c8113a1f6857-diff.temp
index 663581b..fde81d6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1c0a584c-cca3-4d83-a273-c8113a1f6857-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fbbfcb4c-7923-4daa-89a1-e0ce1e83a7f7-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1F51E103020
-       mov       rax,11CD0363020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F53E101248
-       mov       rdx,11CE0361248
        mov       r8,[r8]
+       mov       r8,1F51E103020
-       mov       r8,11CD0363020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1F51E103020
-       mov       r8,11CD0363020
        mov       rdx,[rdx]
+       mov       rdx,1F53E101240
-       mov       rdx,11CE0361240
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0F7D20]
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
+       mov       rcx,1F52E10F240
-       mov       rcx,11CD0371650
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fb6ff299-004c-497a-8bf3-603a2015ff79-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b7ab71ea-244d-4445-9a74-a7c7851bab8b-diff.temp
index 663581b..d6712be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b7ab71ea-244d-4445-9a74-a7c7851bab8b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fb6ff299-004c-497a-8bf3-603a2015ff79-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1CDDF781028
-       mov       rax,22766FF3020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1CDBF783240
-       mov       rdx,227670015C0
        mov       r8,[r8]
+       mov       r8,1CDDF781028
-       mov       r8,22766FF3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1CDDF781028
-       mov       r8,22766FF3020
        mov       rdx,[rdx]
+       mov       rdx,1CDBF783238
-       mov       rdx,227670015B8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA127D20]
-       call      qword ptr [7FF9EA107D20]
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
+       mov       rcx,1CDDF7836E8
-       mov       rcx,22746FF12D8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/22f7f08e-ccb2-4530-9fad-7ef0030c068a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f836d365-e123-483b-9453-8dbb2752683a-diff.temp
index 1cf3825..e290917 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f836d365-e123-483b-9453-8dbb2752683a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/22f7f08e-ccb2-4530-9fad-7ef0030c068a-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,207C7331028
-       mov       rax,22766FF3020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,207C733FDE0
-       mov       rdx,227670015C0
        mov       r8,[r8]
+       mov       r8,207C7331028
-       mov       r8,22766FF3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,207C7331028
-       mov       r8,22766FF3020
        mov       rdx,[rdx]
+       mov       rdx,207C733FDD8
-       mov       rdx,227670015B8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA0E7D20]
-       call      qword ptr [7FF9EA107D20]
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
+       mov       rcx,207C733F658
-       mov       rcx,22746FF12D8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d2ca6053-4d7e-4bea-91f3-dfd5433b03be-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/34985bb5-4731-4ace-ae40-748568c2fb8a-diff.temp
index 1cf3825..8d4319a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/34985bb5-4731-4ace-ae40-748568c2fb8a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d2ca6053-4d7e-4bea-91f3-dfd5433b03be-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,18247A13020
-       mov       rax,22766FF3020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,18247A21DD8
-       mov       rdx,227670015C0
        mov       r8,[r8]
+       mov       r8,18247A13020
-       mov       r8,22766FF3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,18247A13020
-       mov       r8,22766FF3020
        mov       rdx,[rdx]
+       mov       rdx,18247A21DD0
-       mov       rdx,227670015B8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA107D20]
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
+       mov       rcx,18247A21650
-       mov       rcx,22746FF12D8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6c62bd20-b468-4e94-a385-1a1f134193e9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d5688dcd-fd66-4e1c-9f9a-6a64f730da4b-diff.temp
index 1cf3825..fde81d6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d5688dcd-fd66-4e1c-9f9a-6a64f730da4b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6c62bd20-b468-4e94-a385-1a1f134193e9-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1F51E103020
-       mov       rax,22766FF3020
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F53E101248
-       mov       rdx,227670015C0
        mov       r8,[r8]
+       mov       r8,1F51E103020
-       mov       r8,22766FF3020
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1F51E103020
-       mov       r8,22766FF3020
        mov       rdx,[rdx]
+       mov       rdx,1F53E101240
-       mov       rdx,227670015B8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA107D20]
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
+       mov       rcx,1F52E10F240
-       mov       rcx,22746FF12D8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/85760755-dacd-4b63-a0c4-bdcb5abf9dca-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a31a0895-4516-4ff6-9ebd-0c4ff1bea22f-diff.temp
index 1cf3825..d6712be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a31a0895-4516-4ff6-9ebd-0c4ff1bea22f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/85760755-dacd-4b63-a0c4-bdcb5abf9dca-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,207C7331028
-       mov       rax,1CDDF781028
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,207C733FDE0
-       mov       rdx,1CDBF783240
        mov       r8,[r8]
+       mov       r8,207C7331028
-       mov       r8,1CDDF781028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,207C7331028
-       mov       r8,1CDDF781028
        mov       rdx,[rdx]
+       mov       rdx,207C733FDD8
-       mov       rdx,1CDBF783238
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA0E7D20]
-       call      qword ptr [7FF9EA127D20]
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
+       mov       rcx,207C733F658
-       mov       rcx,1CDDF7836E8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/21eb34d7-ff6c-449e-a4ec-614c1c999357-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d305b07f-f863-458a-8537-744bc7bf3fed-diff.temp
index e290917..8d4319a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d305b07f-f863-458a-8537-744bc7bf3fed-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/21eb34d7-ff6c-449e-a4ec-614c1c999357-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,18247A13020
-       mov       rax,1CDDF781028
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,18247A21DD8
-       mov       rdx,1CDBF783240
        mov       r8,[r8]
+       mov       r8,18247A13020
-       mov       r8,1CDDF781028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,18247A13020
-       mov       r8,1CDDF781028
        mov       rdx,[rdx]
+       mov       rdx,18247A21DD0
-       mov       rdx,1CDBF783238
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA127D20]
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
+       mov       rcx,18247A21650
-       mov       rcx,1CDDF7836E8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1f27785c-d0ee-4152-b7bb-3730c60d3301-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3524e7b4-ed63-4883-93d9-eb430bdb563b-diff.temp
index e290917..fde81d6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3524e7b4-ed63-4883-93d9-eb430bdb563b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1f27785c-d0ee-4152-b7bb-3730c60d3301-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1F51E103020
-       mov       rax,1CDDF781028
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F53E101248
-       mov       rdx,1CDBF783240
        mov       r8,[r8]
+       mov       r8,1F51E103020
-       mov       r8,1CDDF781028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1F51E103020
-       mov       r8,1CDDF781028
        mov       rdx,[rdx]
+       mov       rdx,1F53E101240
-       mov       rdx,1CDBF783238
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA127D20]
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
+       mov       rcx,1F52E10F240
-       mov       rcx,1CDDF7836E8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0ea4162d-927c-40f6-b527-66053ea50247-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/797c04b0-d7c8-49fd-8132-ec2c94dcaec4-diff.temp
index e290917..d6712be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/797c04b0-d7c8-49fd-8132-ec2c94dcaec4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0ea4162d-927c-40f6-b527-66053ea50247-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,18247A13020
-       mov       rax,207C7331028
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,18247A21DD8
-       mov       rdx,207C733FDE0
        mov       r8,[r8]
+       mov       r8,18247A13020
-       mov       r8,207C7331028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,18247A13020
-       mov       r8,207C7331028
        mov       rdx,[rdx]
+       mov       rdx,18247A21DD0
-       mov       rdx,207C733FDD8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+       mov       rcx,18247A21650
-       mov       rcx,207C733F658
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4eae64aa-ba8d-4f1d-81ef-c246becdd458-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cbd5edbb-fdee-413a-bd0c-dade5e9e394a-diff.temp
index 8d4319a..fde81d6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cbd5edbb-fdee-413a-bd0c-dade5e9e394a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4eae64aa-ba8d-4f1d-81ef-c246becdd458-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,[rax]
+       mov       rax,1F51E103020
-       mov       rax,207C7331028
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
 ; Total bytes of code 218
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F53E101248
-       mov       rdx,207C733FDE0
        mov       r8,[r8]
+       mov       r8,1F51E103020
-       mov       r8,207C7331028
        call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1F51E103020
-       mov       r8,207C7331028
        mov       rdx,[rdx]
+       mov       rdx,1F53E101240
-       mov       rdx,207C733FDD8
        mov       rcx,[rbp+8]
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
+       call      qword ptr [7FF9EA117D20]
-       call      qword ptr [7FF9EA0E7D20]
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
+       mov       rcx,1F52E10F240
-       mov       rcx,207C733F658
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5064ad8d-cacb-44e2-b76d-7607c25b8b52-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d4bcdf4a-6387-4688-95d6-e1e16d018fd3-diff.temp
index 8d4319a..d6712be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d4bcdf4a-6387-4688-95d6-e1e16d018fd3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5064ad8d-cacb-44e2-b76d-7607c25b8b52-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/894ee8e1-b05b-4278-9a5c-38d97baf789e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/158c6217-6770-4e78-a608-7371078fd8d7-diff.temp
index fde81d6..d6712be 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/158c6217-6770-4e78-a608-7371078fd8d7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/894ee8e1-b05b-4278-9a5c-38d97baf789e-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67a7f87d-37d9-413d-b93d-c7f985e731de-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/37ac31b9-3bf6-4eea-8bad-0c7567dff4fa-diff.temp
index 32dfb9f..b5166e0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/37ac31b9-3bf6-4eea-8bad-0c7567dff4fa-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67a7f87d-37d9-413d-b93d-c7f985e731de-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,211D5D81248
-       mov       rax,17C45AC3658
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,211E5D81508
-       mov       rax,17C45AC1508
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
+       mov       rdx,211D5D81240
-       mov       rdx,17C45AC3650
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,211E5D833B8
-       mov       rdx,17C45AC33B8
        mov       r8,[r8]
+       mov       r8,211E5D83020
-       mov       r8,17C45AC3020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6943aa26-1391-48e9-94d6-1f73f7ee5023-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2d0692bb-0774-47fe-b66f-660359f1de95-diff.temp
index 32dfb9f..b22afd9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2d0692bb-0774-47fe-b66f-660359f1de95-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6943aa26-1391-48e9-94d6-1f73f7ee5023-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,23013123240
-       mov       rax,17C45AC3658
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23013121508
-       mov       rax,17C45AC1508
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
+       mov       rdx,23013123238
-       mov       rdx,17C45AC3650
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,230331213C0
-       mov       rdx,17C45AC33B8
        mov       r8,[r8]
+       mov       r8,23033121028
-       mov       r8,17C45AC3020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/17995a58-4c18-495b-be1a-9620da3fe797-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f5261c57-d5a7-46f4-9392-db1ab9908354-diff.temp
index 32dfb9f..b13fa9c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f5261c57-d5a7-46f4-9392-db1ab9908354-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/17995a58-4c18-495b-be1a-9620da3fe797-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/88e6ac05-7ff5-4fd7-85d0-cf21ebb3418f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/205ee47d-bd1e-40ae-8d82-d7cdd2685afb-diff.temp
index 32dfb9f..6b369f3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/205ee47d-bd1e-40ae-8d82-d7cdd2685afb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/88e6ac05-7ff5-4fd7-85d0-cf21ebb3418f-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,27B42071248
-       mov       rax,17C45AC3658
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,27B62071508
-       mov       rax,17C45AC1508
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
+       mov       rdx,27B42071240
-       mov       rdx,17C45AC3650
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,27B620733B8
-       mov       rdx,17C45AC33B8
        mov       r8,[r8]
+       mov       r8,27B62073020
-       mov       r8,17C45AC3020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e95ce013-a962-4c97-8c61-c1f3da317cfd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ac9d030b-a5be-47df-bda1-1ceaba0201f1-diff.temp
index 32dfb9f..d99465a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ac9d030b-a5be-47df-bda1-1ceaba0201f1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e95ce013-a962-4c97-8c61-c1f3da317cfd-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1E88E47F1B0
-       mov       rax,17C45AC3658
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E87E471508
-       mov       rax,17C45AC1508
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
+       mov       rdx,1E88E47F1A8
-       mov       rdx,17C45AC3650
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1E87E4733B8
-       mov       rdx,17C45AC33B8
        mov       r8,[r8]
+       mov       r8,1E87E473020
-       mov       r8,17C45AC3020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ea47021-2bac-4b67-9ca7-a670418ca67f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b34775e2-34f9-4548-a7e3-f6c93c04b981-diff.temp
index 32dfb9f..42185e6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b34775e2-34f9-4548-a7e3-f6c93c04b981-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ea47021-2bac-4b67-9ca7-a670418ca67f-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,211D5D81248
-       mov       rax,18843783E70
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,211E5D81508
-       mov       rax,18843781508
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
+       mov       rdx,211D5D81240
-       mov       rdx,18843783E68
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,211E5D833B8
-       mov       rdx,188437833B8
        mov       r8,[r8]
+       mov       r8,211E5D83020
-       mov       r8,18843783020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/66227835-1a52-44fb-8cdb-afafbb1504c6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8c31f3bc-143b-432a-8842-6ac916f28105-diff.temp
index b5166e0..b22afd9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8c31f3bc-143b-432a-8842-6ac916f28105-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/66227835-1a52-44fb-8cdb-afafbb1504c6-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,23013123240
-       mov       rax,18843783E70
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23013121508
-       mov       rax,18843781508
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
+       mov       rdx,23013123238
-       mov       rdx,18843783E68
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,230331213C0
-       mov       rdx,188437833B8
        mov       r8,[r8]
+       mov       r8,23033121028
-       mov       r8,18843783020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1018b18a-6676-484e-b855-2d492a89b0fe-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65242d1f-1858-4461-8f7e-ae8b9b0be157-diff.temp
index b5166e0..b13fa9c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/65242d1f-1858-4461-8f7e-ae8b9b0be157-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1018b18a-6676-484e-b855-2d492a89b0fe-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c1b6572f-e973-4a24-b1fe-6ff4da13a545-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67a97307-6182-4bdc-a3f9-db29a927b02e-diff.temp
index b5166e0..6b369f3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/67a97307-6182-4bdc-a3f9-db29a927b02e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c1b6572f-e973-4a24-b1fe-6ff4da13a545-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,27B42071248
-       mov       rax,18843783E70
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,27B62071508
-       mov       rax,18843781508
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
+       mov       rdx,27B42071240
-       mov       rdx,18843783E68
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,27B620733B8
-       mov       rdx,188437833B8
        mov       r8,[r8]
+       mov       r8,27B62073020
-       mov       r8,18843783020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/36c9b29f-f0a3-4e4c-a848-eba3446d2537-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bf7b3d4e-b937-429a-9f4f-2a284fcc0848-diff.temp
index b5166e0..d99465a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bf7b3d4e-b937-429a-9f4f-2a284fcc0848-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/36c9b29f-f0a3-4e4c-a848-eba3446d2537-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1E88E47F1B0
-       mov       rax,18843783E70
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E87E471508
-       mov       rax,18843781508
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
+       mov       rdx,1E88E47F1A8
-       mov       rdx,18843783E68
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1E87E4733B8
-       mov       rdx,188437833B8
        mov       r8,[r8]
+       mov       r8,1E87E473020
-       mov       r8,18843783020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bac5c5c9-2b58-4445-bebd-ff764bda7b0d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e8da91d-96e6-4d90-ade6-4425b1f2cead-diff.temp
index b5166e0..42185e6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e8da91d-96e6-4d90-ade6-4425b1f2cead-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bac5c5c9-2b58-4445-bebd-ff764bda7b0d-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,23013123240
-       mov       rax,211D5D81248
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23013121508
-       mov       rax,211E5D81508
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
+       mov       rdx,23013123238
-       mov       rdx,211D5D81240
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,230331213C0
-       mov       rdx,211E5D833B8
        mov       r8,[r8]
+       mov       r8,23033121028
-       mov       r8,211E5D83020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc22fadf-f300-4cde-a139-15716e7bf439-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e365fc8-28c3-42d5-8804-69502bcfb634-diff.temp
index b22afd9..b13fa9c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e365fc8-28c3-42d5-8804-69502bcfb634-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc22fadf-f300-4cde-a139-15716e7bf439-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,27BB10B1248
-       mov       rax,211D5D81248
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,27B910B1508
-       mov       rax,211E5D81508
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
+       mov       rdx,27BB10B1240
-       mov       rdx,211D5D81240
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,27B910B33B8
-       mov       rdx,211E5D833B8
        mov       r8,[r8]
+       mov       r8,27B910B3020
-       mov       r8,211E5D83020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/365db78a-3142-4015-8d42-c5e6ef59f213-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d4e4a75d-a687-45e5-a053-08aeb2b9d5e6-diff.temp
index b22afd9..6b369f3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d4e4a75d-a687-45e5-a053-08aeb2b9d5e6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/365db78a-3142-4015-8d42-c5e6ef59f213-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,27B42071248
-       mov       rax,211D5D81248
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,27B62071508
-       mov       rax,211E5D81508
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
+       mov       rdx,27B42071240
-       mov       rdx,211D5D81240
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,27B620733B8
-       mov       rdx,211E5D833B8
        mov       r8,[r8]
+       mov       r8,27B62073020
-       mov       r8,211E5D83020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9084e5ad-7dde-4784-b37f-447db44245b2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0333e52e-4457-4a9d-84f1-0ce5e3a4daa9-diff.temp
index b22afd9..d99465a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0333e52e-4457-4a9d-84f1-0ce5e3a4daa9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9084e5ad-7dde-4784-b37f-447db44245b2-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1E88E47F1B0
-       mov       rax,211D5D81248
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E87E471508
-       mov       rax,211E5D81508
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
+       mov       rdx,1E88E47F1A8
-       mov       rdx,211D5D81240
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1E87E4733B8
-       mov       rdx,211E5D833B8
        mov       r8,[r8]
+       mov       r8,1E87E473020
-       mov       r8,211E5D83020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/391f2860-7ddf-41e5-b92d-7f4b75aadaa9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4a92f439-dca0-4419-a37e-e1af80424d16-diff.temp
index b22afd9..42185e6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4a92f439-dca0-4419-a37e-e1af80424d16-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/391f2860-7ddf-41e5-b92d-7f4b75aadaa9-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,27BB10B1248
-       mov       rax,23013123240
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,27B910B1508
-       mov       rax,23013121508
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
+       mov       rdx,27BB10B1240
-       mov       rdx,23013123238
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,27B910B33B8
-       mov       rdx,230331213C0
        mov       r8,[r8]
+       mov       r8,27B910B3020
-       mov       r8,23033121028
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dcec3368-2325-4616-9511-2c3ddc2a4a7a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/149a1e84-bf1f-4475-9617-f84b5b5dfb25-diff.temp
index b13fa9c..6b369f3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/149a1e84-bf1f-4475-9617-f84b5b5dfb25-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dcec3368-2325-4616-9511-2c3ddc2a4a7a-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9b976f9a-1eae-4283-a1c6-aaeb72413aae-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e138c904-9bf5-4433-9d1c-bdc5d5595e1e-diff.temp
index b13fa9c..d99465a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e138c904-9bf5-4433-9d1c-bdc5d5595e1e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9b976f9a-1eae-4283-a1c6-aaeb72413aae-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/43af2efa-5e24-41f6-a52d-e8ce3eb33d83-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/862f5bfa-2168-4b0f-8422-3c548fecc292-diff.temp
index b13fa9c..42185e6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/862f5bfa-2168-4b0f-8422-3c548fecc292-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/43af2efa-5e24-41f6-a52d-e8ce3eb33d83-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,27B42071248
-       mov       rax,27BB10B1248
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,27B62071508
-       mov       rax,27B910B1508
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
+       mov       rdx,27B42071240
-       mov       rdx,27BB10B1240
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,27B620733B8
-       mov       rdx,27B910B33B8
        mov       r8,[r8]
+       mov       r8,27B62073020
-       mov       r8,27B910B3020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6f61072-a5bd-4a70-840f-f5a8c7a37f32-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/57ffe94b-abc9-4ab5-a5c6-e14470954143-diff.temp
index 6b369f3..d99465a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/57ffe94b-abc9-4ab5-a5c6-e14470954143-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a6f61072-a5bd-4a70-840f-f5a8c7a37f32-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
jmp       short M01_L02
        call      System.Number.UInt32ToDecStr(UInt32)
        jne       short M01_L01
        test      rdx,rdx
        mov       rdx,[rax]
+       mov       rax,1E88E47F1B0
-       mov       rax,27BB10B1248
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E87E471508
-       mov       rax,27B910B1508
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
+       mov       rdx,1E88E47F1A8
-       mov       rdx,27BB10B1240
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
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1E87E4733B8
-       mov       rdx,27B910B33B8
        mov       r8,[r8]
+       mov       r8,1E87E473020
-       mov       r8,27B910B3020
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8705cc78-e6fc-4953-8b04-dad6c2ea1db2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7ce0310d-8894-496b-ba77-590e73c37446-diff.temp
index 6b369f3..42185e6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7ce0310d-8894-496b-ba77-590e73c37446-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8705cc78-e6fc-4953-8b04-dad6c2ea1db2-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d8dd3133-5e0f-48cf-a5c2-6110c543373f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8dba9f07-f6fd-4332-83de-029ece6141c0-diff.temp
index d99465a..42185e6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8dba9f07-f6fd-4332-83de-029ece6141c0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d8dd3133-5e0f-48cf-a5c2-6110c543373f-diff.temp
```
