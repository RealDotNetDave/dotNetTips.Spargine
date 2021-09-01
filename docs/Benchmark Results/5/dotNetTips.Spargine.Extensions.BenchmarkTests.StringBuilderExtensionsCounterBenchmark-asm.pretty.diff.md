## dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark-20210828-172531
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
+       mov       rax,23C132F3020
-       mov       rax,2057D0F3020
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
+       mov       rax,23C13302070
-       mov       rax,2055D0F11E8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,23C132F1508
-       mov       rax,2057D0F1508
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
+       mov       rdx,23C13302068
-       mov       rdx,2055D0F11E0
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/efca1024-d177-4a3b-b3fc-9dc6e44f8108-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9622a13b-983b-4c9e-b836-87335dba11b3-diff.temp
index e0fe1f7..162e146 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9622a13b-983b-4c9e-b836-87335dba11b3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/efca1024-d177-4a3b-b3fc-9dc6e44f8108-diff.temp
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
+       mov       rax,1B2D1C03020
-       mov       rax,2057D0F3020
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
+       mov       rax,1B2F1C10460
-       mov       rax,2055D0F11E8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1B2D1C01508
-       mov       rax,2057D0F1508
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
+       mov       rdx,1B2F1C10458
-       mov       rdx,2055D0F11E0
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
+       call      qword ptr [7FF7AD2888E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3abe7f3c-a3bd-42f6-8444-3ac56d9c3c9a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/34da6b15-d0d4-4e67-a17d-d652c136650e-diff.temp
index e0fe1f7..8c072f8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/34da6b15-d0d4-4e67-a17d-d652c136650e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3abe7f3c-a3bd-42f6-8444-3ac56d9c3c9a-diff.temp
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
+       mov       rax,17E30513020
-       mov       rax,2057D0F3020
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
+       mov       rax,17E505111E8
-       mov       rax,2055D0F11E8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,17E30511508
-       mov       rax,2057D0F1508
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
+       mov       rdx,17E505111E0
-       mov       rdx,2055D0F11E0
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
+       call      qword ptr [7FF7AD2888E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dfe60dbb-2963-4f0e-889f-e9730e51c8ad-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/752adb2c-6898-4762-8550-f081c1b3aff4-diff.temp
index e0fe1f7..31d12bf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/752adb2c-6898-4762-8550-f081c1b3aff4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/dfe60dbb-2963-4f0e-889f-e9730e51c8ad-diff.temp
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
+       mov       rax,29352083020
-       mov       rax,2057D0F3020
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
+       mov       rax,29332082A18
-       mov       rax,2055D0F11E8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,29352081508
-       mov       rax,2057D0F1508
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
+       mov       rdx,29332082A10
-       mov       rdx,2055D0F11E0
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
+       call      qword ptr [7FF7AD2A88E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c4e30959-2986-4b58-9d21-29e05109416f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/79fba899-3297-4670-a9d7-02026a2bf0f6-diff.temp
index e0fe1f7..e21684f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/79fba899-3297-4670-a9d7-02026a2bf0f6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c4e30959-2986-4b58-9d21-29e05109416f-diff.temp
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
+       mov       rax,1A836902200
-       mov       rax,2055D0F11E8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1A846901508
-       mov       rax,2057D0F1508
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
+       mov       rdx,1A8369021F8
-       mov       rdx,2055D0F11E0
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
        call      qword ptr [7FF7AD2B88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ffa26e08-44c4-46c2-a9b6-2a39ba2d366e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d8b1fa09-cf09-45d8-80ab-220755f07f70-diff.temp
index e0fe1f7..c204068 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d8b1fa09-cf09-45d8-80ab-220755f07f70-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ffa26e08-44c4-46c2-a9b6-2a39ba2d366e-diff.temp
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
+       mov       rax,216347A3020
-       mov       rax,2057D0F3020
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
+       mov       rax,216347A35F8
-       mov       rax,2055D0F11E8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,216347A1508
-       mov       rax,2057D0F1508
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
+       mov       rdx,216347A35F0
-       mov       rdx,2055D0F11E0
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/26a0c0f4-a9a7-49c4-a809-20ccff2e7b7c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/97b705fc-cea1-49d9-92bc-4dd7e7aed708-diff.temp
index e0fe1f7..9076255 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/97b705fc-cea1-49d9-92bc-4dd7e7aed708-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/26a0c0f4-a9a7-49c4-a809-20ccff2e7b7c-diff.temp
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
+       mov       rax,1B2D1C03020
-       mov       rax,23C132F3020
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
+       mov       rax,1B2F1C10460
-       mov       rax,23C13302070
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1B2D1C01508
-       mov       rax,23C132F1508
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
+       mov       rdx,1B2F1C10458
-       mov       rdx,23C13302068
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
+       call      qword ptr [7FF7AD2888E8]
-       call      qword ptr [7FF7AD2988E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3cd05625-b69c-444e-9da7-42d7d3326049-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/97475d2c-39c1-4997-999a-4b7813fe08e9-diff.temp
index 162e146..8c072f8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/97475d2c-39c1-4997-999a-4b7813fe08e9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3cd05625-b69c-444e-9da7-42d7d3326049-diff.temp
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
+       mov       rax,17E30513020
-       mov       rax,23C132F3020
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
+       mov       rax,17E505111E8
-       mov       rax,23C13302070
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,17E30511508
-       mov       rax,23C132F1508
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
+       mov       rdx,17E505111E0
-       mov       rdx,23C13302068
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
+       call      qword ptr [7FF7AD2888E8]
-       call      qword ptr [7FF7AD2988E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5fa0204c-f637-4d21-8c18-55dcdcdb90d5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f6df6e26-b1cd-47ed-baf7-683d01910c0a-diff.temp
index 162e146..31d12bf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f6df6e26-b1cd-47ed-baf7-683d01910c0a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5fa0204c-f637-4d21-8c18-55dcdcdb90d5-diff.temp
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
+       mov       rax,29352083020
-       mov       rax,23C132F3020
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
+       mov       rax,29332082A18
-       mov       rax,23C13302070
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,29352081508
-       mov       rax,23C132F1508
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
+       mov       rdx,29332082A10
-       mov       rdx,23C13302068
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
+       call      qword ptr [7FF7AD2A88E8]
-       call      qword ptr [7FF7AD2988E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a99021b-6d93-47f8-9de7-f97e9e15275a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/049ee0bd-bab6-443c-8b7c-d2ab8c2338ea-diff.temp
index 162e146..e21684f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/049ee0bd-bab6-443c-8b7c-d2ab8c2338ea-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a99021b-6d93-47f8-9de7-f97e9e15275a-diff.temp
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
+       mov       rax,1A856901028
-       mov       rax,23C132F3020
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
+       mov       rax,1A836902200
-       mov       rax,23C13302070
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1A846901508
-       mov       rax,23C132F1508
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
+       mov       rdx,1A8369021F8
-       mov       rdx,23C13302068
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
+       call      qword ptr [7FF7AD2B88E8]
-       call      qword ptr [7FF7AD2988E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9d9c9ec5-5ac0-462a-8249-f4881d363b7f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1c0b960-e986-466f-8336-7bad9639d716-diff.temp
index 162e146..c204068 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1c0b960-e986-466f-8336-7bad9639d716-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9d9c9ec5-5ac0-462a-8249-f4881d363b7f-diff.temp
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
+       mov       rax,216347A35F8
-       mov       rax,23C13302070
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,216347A1508
-       mov       rax,23C132F1508
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
+       mov       rdx,216347A35F0
-       mov       rdx,23C13302068
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
        call      qword ptr [7FF7AD2988E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ca88cb7e-f614-4fc8-a366-e02e1d5d40d5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a0919475-ed08-4ab0-93f9-bd22ad7f04d5-diff.temp
index 162e146..9076255 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a0919475-ed08-4ab0-93f9-bd22ad7f04d5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ca88cb7e-f614-4fc8-a366-e02e1d5d40d5-diff.temp
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
+       mov       rax,17E505111E8
-       mov       rax,1B2F1C10460
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,17E30511508
-       mov       rax,1B2D1C01508
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
+       mov       rdx,17E505111E0
-       mov       rdx,1B2F1C10458
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
        call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/84082ded-1971-4fc3-b74c-abd9c4df8b4a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b7459b74-c39c-429d-9201-23c7e0d7c994-diff.temp
index 8c072f8..31d12bf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b7459b74-c39c-429d-9201-23c7e0d7c994-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/84082ded-1971-4fc3-b74c-abd9c4df8b4a-diff.temp
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
+       mov       rax,29352083020
-       mov       rax,1B2D1C03020
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
+       mov       rax,29332082A18
-       mov       rax,1B2F1C10460
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,29352081508
-       mov       rax,1B2D1C01508
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
+       mov       rdx,29332082A10
-       mov       rdx,1B2F1C10458
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
+       call      qword ptr [7FF7AD2A88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/01c7f467-9d88-4cda-a10f-d7ed9cbb29f8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4c8790cb-0559-4685-afc2-ac677e6b6ca6-diff.temp
index 8c072f8..e21684f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4c8790cb-0559-4685-afc2-ac677e6b6ca6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/01c7f467-9d88-4cda-a10f-d7ed9cbb29f8-diff.temp
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
+       mov       rax,1A856901028
-       mov       rax,1B2D1C03020
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
+       mov       rax,1A836902200
-       mov       rax,1B2F1C10460
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1A846901508
-       mov       rax,1B2D1C01508
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
+       mov       rdx,1A8369021F8
-       mov       rdx,1B2F1C10458
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
+       call      qword ptr [7FF7AD2B88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f42c2e2c-c4aa-4f61-b041-f01ba6727fa8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2f2e86ae-b579-46d0-86e6-d3bbb0e3fff3-diff.temp
index 8c072f8..c204068 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2f2e86ae-b579-46d0-86e6-d3bbb0e3fff3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f42c2e2c-c4aa-4f61-b041-f01ba6727fa8-diff.temp
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
+       mov       rax,216347A3020
-       mov       rax,1B2D1C03020
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
+       mov       rax,216347A35F8
-       mov       rax,1B2F1C10460
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,216347A1508
-       mov       rax,1B2D1C01508
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
+       mov       rdx,216347A35F0
-       mov       rdx,1B2F1C10458
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/78902f9d-fbb1-47ef-84db-bdc5751e6b27-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/595a2688-c0b5-4d43-9a83-98c1f8a3e121-diff.temp
index 8c072f8..9076255 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/595a2688-c0b5-4d43-9a83-98c1f8a3e121-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/78902f9d-fbb1-47ef-84db-bdc5751e6b27-diff.temp
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
+       mov       rax,29352083020
-       mov       rax,17E30513020
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
+       mov       rax,29332082A18
-       mov       rax,17E505111E8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,29352081508
-       mov       rax,17E30511508
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
+       mov       rdx,29332082A10
-       mov       rdx,17E505111E0
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
+       call      qword ptr [7FF7AD2A88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7aecfd4c-8c71-48ce-a844-04093ace28dc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/40d6693c-83e3-4765-b827-29cb2165d617-diff.temp
index 31d12bf..e21684f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/40d6693c-83e3-4765-b827-29cb2165d617-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7aecfd4c-8c71-48ce-a844-04093ace28dc-diff.temp
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
+       mov       rax,1A856901028
-       mov       rax,17E30513020
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
+       mov       rax,1A836902200
-       mov       rax,17E505111E8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1A846901508
-       mov       rax,17E30511508
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
+       mov       rdx,1A8369021F8
-       mov       rdx,17E505111E0
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
+       call      qword ptr [7FF7AD2B88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8b889c7-349c-44ae-8b43-8bf0a9d12a9d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/802176e7-0fb4-4ae2-9af8-f11f85ddb369-diff.temp
index 31d12bf..c204068 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/802176e7-0fb4-4ae2-9af8-f11f85ddb369-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8b889c7-349c-44ae-8b43-8bf0a9d12a9d-diff.temp
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
+       mov       rax,216347A3020
-       mov       rax,17E30513020
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
+       mov       rax,216347A35F8
-       mov       rax,17E505111E8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,216347A1508
-       mov       rax,17E30511508
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
+       mov       rdx,216347A35F0
-       mov       rdx,17E505111E0
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/49b41978-eda9-4cf8-b592-6d23a3206704-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9c8fc925-622f-4a10-948c-3f78d59fd717-diff.temp
index 31d12bf..9076255 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9c8fc925-622f-4a10-948c-3f78d59fd717-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/49b41978-eda9-4cf8-b592-6d23a3206704-diff.temp
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
+       mov       rax,1A856901028
-       mov       rax,29352083020
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
+       mov       rax,1A836902200
-       mov       rax,29332082A18
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1A846901508
-       mov       rax,29352081508
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
+       mov       rdx,1A8369021F8
-       mov       rdx,29332082A10
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
+       call      qword ptr [7FF7AD2B88E8]
-       call      qword ptr [7FF7AD2A88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a81c8611-7f14-4631-ac0d-2363aeb75d0b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/19fc840a-4927-4d2a-b5d1-59c836696ff0-diff.temp
index e21684f..c204068 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/19fc840a-4927-4d2a-b5d1-59c836696ff0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a81c8611-7f14-4631-ac0d-2363aeb75d0b-diff.temp
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
+       mov       rax,216347A3020
-       mov       rax,29352083020
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
+       mov       rax,216347A35F8
-       mov       rax,29332082A18
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,216347A1508
-       mov       rax,29352081508
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
+       mov       rdx,216347A35F0
-       mov       rdx,29332082A10
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2A88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/166efb48-eb0c-4599-9ba1-8d08e8acc98d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fb6ef7a8-f7de-4ea6-967c-59099a8b2c0d-diff.temp
index e21684f..9076255 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fb6ef7a8-f7de-4ea6-967c-59099a8b2c0d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/166efb48-eb0c-4599-9ba1-8d08e8acc98d-diff.temp
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
+       mov       rax,216347A3020
-       mov       rax,1A856901028
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
+       mov       rax,216347A35F8
-       mov       rax,1A836902200
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,216347A1508
-       mov       rax,1A846901508
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
+       mov       rdx,216347A35F0
-       mov       rdx,1A8369021F8
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/42e52560-ca7b-4de1-80e1-5a09cb67b01c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d95c360e-3193-4017-86b1-da9f5de069e3-diff.temp
index c204068..9076255 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d95c360e-3193-4017-86b1-da9f5de069e3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/42e52560-ca7b-4de1-80e1-5a09cb67b01c-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,2596BDDF4A8
-       mov       rdx,1AF206F1248
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
+       mov       r9,2596BDD9AD0
-       mov       r9,1AF306F7AD8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF7AD2E0720
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/809a9923-0e3c-447e-bdb5-de2f596041fb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f01c1dc-fd11-4380-a5e1-957f1239a23d-diff.temp
index 0ddb33c..b5e9864 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f01c1dc-fd11-4380-a5e1-957f1239a23d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/809a9923-0e3c-447e-bdb5-de2f596041fb-diff.temp
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
+       mov       rax,14257E11028
-       mov       rax,1AF406F3020
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
+       mov       rdx,14247E13240
-       mov       rdx,1AF206F1248
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
+       mov       r9,14257E19EE8
-       mov       r9,1AF306F7AD8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD300720
-       mov       rcx,7FF7AD2E0720
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
+       call      qword ptr [7FF7AD2A88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fffe3fc4-9924-4b98-91cf-d5b0e16032bb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/94b86182-e335-4a51-8004-a08abd6cfce7-diff.temp
index 0ddb33c..f8add74 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/94b86182-e335-4a51-8004-a08abd6cfce7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fffe3fc4-9924-4b98-91cf-d5b0e16032bb-diff.temp
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
+       mov       rax,273EA8D1028
-       mov       rax,1AF406F3020
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
+       mov       rdx,273EA8DF8C0
-       mov       rdx,1AF206F1248
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
+       mov       r9,273EA8D9EE8
-       mov       r9,1AF306F7AD8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD310720
-       mov       rcx,7FF7AD2E0720
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
+       call      qword ptr [7FF7AD2B88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8522c64a-6003-40f5-9c7d-227b5d1e9d6f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/edeb0af6-54cd-4f1c-856b-3ef19098caad-diff.temp
index 0ddb33c..ad06f97 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/edeb0af6-54cd-4f1c-856b-3ef19098caad-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8522c64a-6003-40f5-9c7d-227b5d1e9d6f-diff.temp
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
+       mov       rax,1E623993020
-       mov       rax,1AF406F3020
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
+       mov       rdx,1E64399F4A8
-       mov       rdx,1AF206F1248
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
+       mov       r9,1E643999AD0
-       mov       r9,1AF306F7AD8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD300720
-       mov       rcx,7FF7AD2E0720
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
+       call      qword ptr [7FF7AD2A88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3de08268-39ce-4264-999b-cf1947c5b135-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/866907f2-3395-4316-a51a-a133a56e791f-diff.temp
index 0ddb33c..cf8f9eb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/866907f2-3395-4316-a51a-a133a56e791f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3de08268-39ce-4264-999b-cf1947c5b135-diff.temp
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
+       mov       rax,1CA399D1028
-       mov       rax,1AF406F3020
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
+       mov       rdx,1CA199D3240
-       mov       rdx,1AF206F1248
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
+       mov       r9,1CA299D7AD8
-       mov       r9,1AF306F7AD8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD2F0720
-       mov       rcx,7FF7AD2E0720
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9e3ba7d2-019d-442c-a0fb-474635cbb858-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aca16a50-4578-460f-a785-0444ba6aa7a1-diff.temp
index 0ddb33c..75ad31e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aca16a50-4578-460f-a785-0444ba6aa7a1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9e3ba7d2-019d-442c-a0fb-474635cbb858-diff.temp
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
+       mov       rax,18164313020
-       mov       rax,1AF406F3020
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
+       mov       rdx,18164319920
-       mov       rdx,1AF206F1248
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
+       mov       r9,18144313808
-       mov       r9,1AF306F7AD8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD2F0720
-       mov       rcx,7FF7AD2E0720
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3cd0a651-cc90-4a42-80f6-e6eb3e3b4406-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b935d1e2-8db4-4f94-a917-04b1d25c1162-diff.temp
index 0ddb33c..94cbfc6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b935d1e2-8db4-4f94-a917-04b1d25c1162-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3cd0a651-cc90-4a42-80f6-e6eb3e3b4406-diff.temp
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
+       mov       rax,14257E11028
-       mov       rax,2595BDD3020
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
+       mov       rdx,14247E13240
-       mov       rdx,2596BDDF4A8
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
+       mov       r9,14257E19EE8
-       mov       r9,2596BDD9AD0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD300720
-       mov       rcx,7FF7AD2E0720
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
+       call      qword ptr [7FF7AD2A88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/90aaf5df-4281-4689-aae8-0308c8c44174-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/93bc5dd9-8b4d-4193-a4b9-69076b04c7c6-diff.temp
index b5e9864..f8add74 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/93bc5dd9-8b4d-4193-a4b9-69076b04c7c6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/90aaf5df-4281-4689-aae8-0308c8c44174-diff.temp
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
+       mov       rax,273EA8D1028
-       mov       rax,2595BDD3020
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
+       mov       rdx,273EA8DF8C0
-       mov       rdx,2596BDDF4A8
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
+       mov       r9,273EA8D9EE8
-       mov       r9,2596BDD9AD0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD310720
-       mov       rcx,7FF7AD2E0720
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
+       call      qword ptr [7FF7AD2B88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/383d5831-fea4-46aa-908f-a51ea0e4280c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/47516134-3567-4639-af05-979da369a1b9-diff.temp
index b5e9864..ad06f97 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/47516134-3567-4639-af05-979da369a1b9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/383d5831-fea4-46aa-908f-a51ea0e4280c-diff.temp
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
+       mov       rax,1E623993020
-       mov       rax,2595BDD3020
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
+       mov       rdx,1E64399F4A8
-       mov       rdx,2596BDDF4A8
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
+       mov       r9,1E643999AD0
-       mov       r9,2596BDD9AD0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD300720
-       mov       rcx,7FF7AD2E0720
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
+       call      qword ptr [7FF7AD2A88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5f38241e-d4df-4c37-9bcd-355627b3065a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d39baaa1-c9b9-49c8-b957-74bc4a01a7ea-diff.temp
index b5e9864..cf8f9eb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d39baaa1-c9b9-49c8-b957-74bc4a01a7ea-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5f38241e-d4df-4c37-9bcd-355627b3065a-diff.temp
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
+       mov       rax,1CA399D1028
-       mov       rax,2595BDD3020
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
+       mov       rdx,1CA199D3240
-       mov       rdx,2596BDDF4A8
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
+       mov       r9,1CA299D7AD8
-       mov       r9,2596BDD9AD0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD2F0720
-       mov       rcx,7FF7AD2E0720
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/92e7e84c-081d-450a-8b4b-6b771e6130ef-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9ad3142b-6d66-495d-a58e-25f92bf0816f-diff.temp
index b5e9864..75ad31e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9ad3142b-6d66-495d-a58e-25f92bf0816f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/92e7e84c-081d-450a-8b4b-6b771e6130ef-diff.temp
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
+       mov       rax,18164313020
-       mov       rax,2595BDD3020
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
+       mov       rdx,18164319920
-       mov       rdx,2596BDDF4A8
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
+       mov       r9,18144313808
-       mov       r9,2596BDD9AD0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD2F0720
-       mov       rcx,7FF7AD2E0720
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2888E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c41dfb11-5a9b-4a20-a035-9738250138a6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/36d620bf-5377-4014-b1a8-7536cbcb1ecc-diff.temp
index b5e9864..94cbfc6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/36d620bf-5377-4014-b1a8-7536cbcb1ecc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c41dfb11-5a9b-4a20-a035-9738250138a6-diff.temp
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
+       mov       rax,273EA8D1028
-       mov       rax,14257E11028
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
+       mov       rdx,273EA8DF8C0
-       mov       rdx,14247E13240
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
+       mov       r9,273EA8D9EE8
-       mov       r9,14257E19EE8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD310720
-       mov       rcx,7FF7AD300720
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
+       call      qword ptr [7FF7AD2B88E8]
-       call      qword ptr [7FF7AD2A88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2354757c-cd6d-47f3-864d-ec168dfcc15c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/94e14844-bdbb-4895-a91b-5a61bd2774b3-diff.temp
index f8add74..ad06f97 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/94e14844-bdbb-4895-a91b-5a61bd2774b3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2354757c-cd6d-47f3-864d-ec168dfcc15c-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,1E64399F4A8
-       mov       rdx,14247E13240
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
+       mov       r9,1E643999AD0
-       mov       r9,14257E19EE8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF7AD300720
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9b2dba2e-44d3-4f55-a1b6-52397df0262e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96813782-787d-43a9-a58b-4955817e2cd1-diff.temp
index f8add74..cf8f9eb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96813782-787d-43a9-a58b-4955817e2cd1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9b2dba2e-44d3-4f55-a1b6-52397df0262e-diff.temp
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
+       mov       rax,1CA399D1028
-       mov       rax,14257E11028
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
+       mov       rdx,1CA199D3240
-       mov       rdx,14247E13240
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
+       mov       r9,1CA299D7AD8
-       mov       r9,14257E19EE8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD2F0720
-       mov       rcx,7FF7AD300720
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2A88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/41fd6d44-1f08-4b27-bc06-46b4d4746564-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/de3b0910-e06b-4853-ba7e-aa0e4bb05e4e-diff.temp
index f8add74..75ad31e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/de3b0910-e06b-4853-ba7e-aa0e4bb05e4e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/41fd6d44-1f08-4b27-bc06-46b4d4746564-diff.temp
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
+       mov       rax,18164313020
-       mov       rax,14257E11028
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
+       mov       rdx,18164319920
-       mov       rdx,14247E13240
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
+       mov       r9,18144313808
-       mov       r9,14257E19EE8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD2F0720
-       mov       rcx,7FF7AD300720
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2A88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1650f5f6-d2a9-4bb4-84d4-87b62b80147c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c4d89861-650a-41d3-8e29-587989651809-diff.temp
index f8add74..94cbfc6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c4d89861-650a-41d3-8e29-587989651809-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1650f5f6-d2a9-4bb4-84d4-87b62b80147c-diff.temp
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
+       mov       rax,1E623993020
-       mov       rax,273EA8D1028
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
+       mov       rdx,1E64399F4A8
-       mov       rdx,273EA8DF8C0
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
+       mov       r9,1E643999AD0
-       mov       r9,273EA8D9EE8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD300720
-       mov       rcx,7FF7AD310720
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
+       call      qword ptr [7FF7AD2A88E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8b3c1e1b-7a9f-493f-a4f8-7855d6174afe-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da76cb7f-507f-4d14-809f-f6d7e5863a65-diff.temp
index ad06f97..cf8f9eb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da76cb7f-507f-4d14-809f-f6d7e5863a65-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8b3c1e1b-7a9f-493f-a4f8-7855d6174afe-diff.temp
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
+       mov       rax,1CA399D1028
-       mov       rax,273EA8D1028
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
+       mov       rdx,1CA199D3240
-       mov       rdx,273EA8DF8C0
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
+       mov       r9,1CA299D7AD8
-       mov       r9,273EA8D9EE8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD2F0720
-       mov       rcx,7FF7AD310720
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d2b3bf3b-9dc6-4bf9-bb53-20ce20bb33ba-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b0e17f3f-010d-491c-bc33-c0e94284ba1e-diff.temp
index ad06f97..75ad31e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b0e17f3f-010d-491c-bc33-c0e94284ba1e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d2b3bf3b-9dc6-4bf9-bb53-20ce20bb33ba-diff.temp
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
+       mov       rax,18164313020
-       mov       rax,273EA8D1028
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
+       mov       rdx,18164319920
-       mov       rdx,273EA8DF8C0
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
+       mov       r9,18144313808
-       mov       r9,273EA8D9EE8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD2F0720
-       mov       rcx,7FF7AD310720
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5ee3aff9-8a13-4089-9dca-8597da256470-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f96e19f4-8087-40a7-86ea-cf66a2ae339c-diff.temp
index ad06f97..94cbfc6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f96e19f4-8087-40a7-86ea-cf66a2ae339c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5ee3aff9-8a13-4089-9dca-8597da256470-diff.temp
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
+       mov       rax,1CA399D1028
-       mov       rax,1E623993020
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
+       mov       rdx,1CA199D3240
-       mov       rdx,1E64399F4A8
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
+       mov       r9,1CA299D7AD8
-       mov       r9,1E643999AD0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD2F0720
-       mov       rcx,7FF7AD300720
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2A88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f6d37055-da89-4090-890b-9ccc44342947-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c305713e-0583-4500-b296-1d26951dd1a7-diff.temp
index cf8f9eb..75ad31e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c305713e-0583-4500-b296-1d26951dd1a7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f6d37055-da89-4090-890b-9ccc44342947-diff.temp
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
+       mov       rax,18164313020
-       mov       rax,1E623993020
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
+       mov       rdx,18164319920
-       mov       rdx,1E64399F4A8
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
+       mov       r9,18144313808
-       mov       r9,1E643999AD0
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
+       mov       rcx,7FF7AD2F0720
-       mov       rcx,7FF7AD300720
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2A88E8]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d30a3ba8-99e7-4e96-b79f-c05f702539ba-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/154ae80b-0cee-4b54-b961-69c3d6b8e989-diff.temp
index cf8f9eb..94cbfc6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/154ae80b-0cee-4b54-b961-69c3d6b8e989-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d30a3ba8-99e7-4e96-b79f-c05f702539ba-diff.temp
```
**Diff for AppendKeyValue0 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rsi
        mov       rdx,[rdx]
+       mov       rdx,18164319920
-       mov       rdx,1CA199D3240
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
+       mov       r9,18144313808
-       mov       r9,1CA299D7AD8
 M01_L01:
        mov       r14d,[rdi+8]
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
        mov       edx,29
        mov       rcx,7FF7AD2F0720
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(Char)
        mov       edx,22
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/38603c1a-af8d-4286-a454-ed64b2015cbd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a810ea85-3be2-4f2b-becb-78da81b145cf-diff.temp
index 75ad31e..94cbfc6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a810ea85-3be2-4f2b-becb-78da81b145cf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/38603c1a-af8d-4286-a454-ed64b2015cbd-diff.temp
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
+       mov       rax,17A46111028
-       mov       rax,2B7B9991028
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
+       mov       rdx,17A361111E0
-       mov       rdx,2B7C99911E0
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
+       mov       rcx,17A46111028
-       mov       rcx,2B7B9991028
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+       mov       rcx,17A4611F8C0
-       mov       rcx,2B799991248
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a1b317e1-c4bd-4b67-8892-e541f33e1b09-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4554f43d-c3a3-46de-9c69-03f10a5ce3f1-diff.temp
index 761e460..73cb26a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4554f43d-c3a3-46de-9c69-03f10a5ce3f1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a1b317e1-c4bd-4b67-8892-e541f33e1b09-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/71629f7a-f009-46eb-839c-56d0016e0c70-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/15be82a3-13d4-49d8-a93f-e182102917e3-diff.temp
index 761e460..12da5f9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/15be82a3-13d4-49d8-a93f-e182102917e3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/71629f7a-f009-46eb-839c-56d0016e0c70-diff.temp
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
+       mov       rax,1D2988C3020
-       mov       rax,2B7B9991028
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
+       mov       rdx,1D2988D2068
-       mov       rdx,2B7C99911E0
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
+       mov       rcx,1D2988C3020
-       mov       rcx,2B7B9991028
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
+       call      qword ptr [7FF7AD2888E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+       mov       rcx,1D2988D18B8
-       mov       rcx,2B799991248
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/327460b0-2e43-4b49-8c31-e86ce5112ffc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/292c8bcc-1a56-451d-8c5c-e45f1cb422db-diff.temp
index 761e460..9fd9fc0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/292c8bcc-1a56-451d-8c5c-e45f1cb422db-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/327460b0-2e43-4b49-8c31-e86ce5112ffc-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc386643-4bbd-45c0-9d69-c1eddfe55f45-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/73c7450d-8e68-425f-9f65-f03506482fbe-diff.temp
index 761e460..6cb7607 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/73c7450d-8e68-425f-9f65-f03506482fbe-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc386643-4bbd-45c0-9d69-c1eddfe55f45-diff.temp
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
+       mov       rax,193EF703020
-       mov       rax,2B7B9991028
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
+       mov       rdx,193EF712068
-       mov       rdx,2B7C99911E0
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
+       mov       rcx,193EF703020
-       mov       rcx,2B7B9991028
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+       mov       rcx,193EF7118B8
-       mov       rcx,2B799991248
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4713feaa-2abc-4ed6-b3a0-8ff56a3d2a9c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/abd34c6e-fd29-4765-b11e-b46b849e859a-diff.temp
index 761e460..b8992f8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/abd34c6e-fd29-4765-b11e-b46b849e859a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4713feaa-2abc-4ed6-b3a0-8ff56a3d2a9c-diff.temp
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
+       mov       rax,219A0A33020
-       mov       rax,2B7B9991028
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
+       mov       rdx,21980A311E0
-       mov       rdx,2B7C99911E0
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
+       mov       rcx,219A0A33020
-       mov       rcx,2B7B9991028
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+       mov       rcx,219A0A418B8
-       mov       rcx,2B799991248
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e99459d1-1364-4e79-b1bd-7647d0d2dc8a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/888fdfa3-109f-4336-9373-47a0a6890a27-diff.temp
index 761e460..2e970bc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/888fdfa3-109f-4336-9373-47a0a6890a27-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e99459d1-1364-4e79-b1bd-7647d0d2dc8a-diff.temp
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
+       mov       rax,2482AE73020
-       mov       rax,17A46111028
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
+       mov       rdx,2483AE711E0
-       mov       rdx,17A361111E0
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
+       mov       rcx,2482AE73020
-       mov       rcx,17A46111028
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
+       call      qword ptr [7FF7AD2B88E8]
-       call      qword ptr [7FF7AD2988E8]
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
+       mov       rcx,2482AE818B8
-       mov       rcx,17A4611F8C0
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/153b689c-2754-43e1-9939-bc3d57e77d48-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/529459a9-7015-406a-8215-9ea6012ecb0c-diff.temp
index 73cb26a..12da5f9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/529459a9-7015-406a-8215-9ea6012ecb0c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/153b689c-2754-43e1-9939-bc3d57e77d48-diff.temp
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
+       mov       rax,1D2988C3020
-       mov       rax,17A46111028
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
+       mov       rdx,1D2988D2068
-       mov       rdx,17A361111E0
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
+       mov       rcx,1D2988C3020
-       mov       rcx,17A46111028
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
+       call      qword ptr [7FF7AD2888E8]
-       call      qword ptr [7FF7AD2988E8]
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
+       mov       rcx,1D2988D18B8
-       mov       rcx,17A4611F8C0
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2177e972-46ed-435a-a04f-bf9fcb7134ee-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6aeeeb09-6c7d-450d-bd87-ce2199bfc493-diff.temp
index 73cb26a..9fd9fc0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6aeeeb09-6c7d-450d-bd87-ce2199bfc493-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2177e972-46ed-435a-a04f-bf9fcb7134ee-diff.temp
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
+       mov       rax,182C0D93020
-       mov       rax,17A46111028
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
+       mov       rdx,182A0D92A10
-       mov       rdx,17A361111E0
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
+       mov       rcx,182C0D93020
-       mov       rcx,17A46111028
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
+       call      qword ptr [7FF7AD2B88E8]
-       call      qword ptr [7FF7AD2988E8]
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
+       mov       rcx,182A0D91248
-       mov       rcx,17A4611F8C0
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1075c104-4047-45d4-ba96-3a43c2fc66ef-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3add3e07-a0a4-4ce7-aefb-158eb7976e5c-diff.temp
index 73cb26a..6cb7607 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3add3e07-a0a4-4ce7-aefb-158eb7976e5c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1075c104-4047-45d4-ba96-3a43c2fc66ef-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/00346c35-5e18-4a55-9865-0f850d4ca03a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/491d5d6d-14e4-4a25-bd67-9d9f8560f485-diff.temp
index 73cb26a..b8992f8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/491d5d6d-14e4-4a25-bd67-9d9f8560f485-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/00346c35-5e18-4a55-9865-0f850d4ca03a-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/171fb736-c4be-477b-a407-4f43ad3b51bb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/065618d8-9a49-4cd1-a845-c59076f17856-diff.temp
index 73cb26a..2e970bc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/065618d8-9a49-4cd1-a845-c59076f17856-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/171fb736-c4be-477b-a407-4f43ad3b51bb-diff.temp
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
+       mov       rax,1D2988C3020
-       mov       rax,2482AE73020
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
+       mov       rdx,1D2988D2068
-       mov       rdx,2483AE711E0
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
+       mov       rcx,1D2988C3020
-       mov       rcx,2482AE73020
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
+       call      qword ptr [7FF7AD2888E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+       mov       rcx,1D2988D18B8
-       mov       rcx,2482AE818B8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/448484fa-1588-4254-8c3b-2e6f34706ccf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20e01ddc-8666-4a9d-aa63-b52d1e51fd7d-diff.temp
index 12da5f9..9fd9fc0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20e01ddc-8666-4a9d-aa63-b52d1e51fd7d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/448484fa-1588-4254-8c3b-2e6f34706ccf-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b9e87bf4-0257-4078-9b32-e90c2d04f739-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e822165-7cd3-4c33-becb-71d6aadf68e8-diff.temp
index 12da5f9..6cb7607 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e822165-7cd3-4c33-becb-71d6aadf68e8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b9e87bf4-0257-4078-9b32-e90c2d04f739-diff.temp
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
+       mov       rax,193EF703020
-       mov       rax,2482AE73020
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
+       mov       rdx,193EF712068
-       mov       rdx,2483AE711E0
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
+       mov       rcx,193EF703020
-       mov       rcx,2482AE73020
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+       mov       rcx,193EF7118B8
-       mov       rcx,2482AE818B8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5d7341c1-0770-4c72-9762-d8e1dd97f240-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/401341bb-b7b9-4076-8caa-9ffb93c4c1e2-diff.temp
index 12da5f9..b8992f8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/401341bb-b7b9-4076-8caa-9ffb93c4c1e2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5d7341c1-0770-4c72-9762-d8e1dd97f240-diff.temp
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
+       mov       rax,219A0A33020
-       mov       rax,2482AE73020
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
+       mov       rdx,21980A311E0
-       mov       rdx,2483AE711E0
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
+       mov       rcx,219A0A33020
-       mov       rcx,2482AE73020
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+       mov       rcx,219A0A418B8
-       mov       rcx,2482AE818B8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3141f956-2798-41a3-a8ef-93581b5a7642-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f18980ce-8fc7-4383-b578-69ec5e9c9b69-diff.temp
index 12da5f9..2e970bc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f18980ce-8fc7-4383-b578-69ec5e9c9b69-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3141f956-2798-41a3-a8ef-93581b5a7642-diff.temp
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
+       mov       rax,182C0D93020
-       mov       rax,1D2988C3020
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
+       mov       rdx,182A0D92A10
-       mov       rdx,1D2988D2068
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
+       mov       rcx,182C0D93020
-       mov       rcx,1D2988C3020
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
+       call      qword ptr [7FF7AD2B88E8]
-       call      qword ptr [7FF7AD2888E8]
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
+       mov       rcx,182A0D91248
-       mov       rcx,1D2988D18B8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/120741e0-ab4a-41aa-8174-3b2f0fd6b76b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/91fb362a-d3af-4e27-8a97-1a9ac163d483-diff.temp
index 9fd9fc0..6cb7607 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/91fb362a-d3af-4e27-8a97-1a9ac163d483-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/120741e0-ab4a-41aa-8174-3b2f0fd6b76b-diff.temp
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
+       mov       rax,193EF703020
-       mov       rax,1D2988C3020
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
+       mov       rdx,193EF712068
-       mov       rdx,1D2988D2068
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
+       mov       rcx,193EF703020
-       mov       rcx,1D2988C3020
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2888E8]
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
+       mov       rcx,193EF7118B8
-       mov       rcx,1D2988D18B8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d8ae1a0f-4cc3-42a0-8005-ccd511df5484-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f1f042e1-ef46-44ff-ae31-75b582359fc7-diff.temp
index 9fd9fc0..b8992f8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f1f042e1-ef46-44ff-ae31-75b582359fc7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d8ae1a0f-4cc3-42a0-8005-ccd511df5484-diff.temp
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
+       mov       rax,219A0A33020
-       mov       rax,1D2988C3020
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
+       mov       rdx,21980A311E0
-       mov       rdx,1D2988D2068
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
+       mov       rcx,219A0A33020
-       mov       rcx,1D2988C3020
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2888E8]
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
+       mov       rcx,219A0A418B8
-       mov       rcx,1D2988D18B8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/925b2933-8d9f-4d09-b388-df482030cb3a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b74f5d23-eb1e-42b3-bc23-16f2ccc06d58-diff.temp
index 9fd9fc0..2e970bc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b74f5d23-eb1e-42b3-bc23-16f2ccc06d58-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/925b2933-8d9f-4d09-b388-df482030cb3a-diff.temp
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
+       mov       rax,193EF703020
-       mov       rax,182C0D93020
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
+       mov       rdx,193EF712068
-       mov       rdx,182A0D92A10
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
+       mov       rcx,193EF703020
-       mov       rcx,182C0D93020
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+       mov       rcx,193EF7118B8
-       mov       rcx,182A0D91248
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/57f4f057-0e5f-4080-b14d-5446c215d501-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eb2d57b1-09dc-48d4-8b27-5aa24739f1b4-diff.temp
index 6cb7607..b8992f8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eb2d57b1-09dc-48d4-8b27-5aa24739f1b4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/57f4f057-0e5f-4080-b14d-5446c215d501-diff.temp
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
+       mov       rax,219A0A33020
-       mov       rax,182C0D93020
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
+       mov       rdx,21980A311E0
-       mov       rdx,182A0D92A10
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
+       mov       rcx,219A0A33020
-       mov       rcx,182C0D93020
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
+       call      qword ptr [7FF7AD2988E8]
-       call      qword ptr [7FF7AD2B88E8]
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
+       mov       rcx,219A0A418B8
-       mov       rcx,182A0D91248
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20759598-88b6-4c23-8280-491c6add1885-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f3553d65-a39a-4862-bb2a-82f3e22b1874-diff.temp
index 6cb7607..2e970bc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f3553d65-a39a-4862-bb2a-82f3e22b1874-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20759598-88b6-4c23-8280-491c6add1885-diff.temp
```
**Diff for AppendValues01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/97d97f96-747c-41b0-94f2-b31c4599fbec-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8ef4d3ad-9019-44c0-a1f5-2d2711a990ef-diff.temp
index b8992f8..2e970bc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8ef4d3ad-9019-44c0-a1f5-2d2711a990ef-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/97d97f96-747c-41b0-94f2-b31c4599fbec-diff.temp
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
+       mov       rax,240115BE468
-       mov       rax,1F5CAD60878
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,240215B1508
-       mov       rax,1F5CAD51508
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
+       mov       rdx,240115BE460
-       mov       rdx,1F5CAD60870
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d107c846-3c01-4ef8-867e-15523aedce95-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a242ca9-6445-48b3-9403-cd10017998b4-diff.temp
index 1e3c218..0959832 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a242ca9-6445-48b3-9403-cd10017998b4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d107c846-3c01-4ef8-867e-15523aedce95-diff.temp
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
+       mov       rax,1E2C711FC60
-       mov       rax,1F5CAD60878
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E2B7111508
-       mov       rax,1F5CAD51508
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
+       mov       rdx,1E2C711FC58
-       mov       rdx,1F5CAD60870
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ff76dc37-0538-459c-acf5-fcf9365f7b5f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e4ba077f-f439-495e-88f2-9c5afc449f35-diff.temp
index 1e3c218..ac637b9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e4ba077f-f439-495e-88f2-9c5afc449f35-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ff76dc37-0538-459c-acf5-fcf9365f7b5f-diff.temp
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
+       mov       rax,20FBF7B41F8
-       mov       rax,1F5CAD60878
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,20FBF7B1508
-       mov       rax,1F5CAD51508
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
+       mov       rdx,20FBF7B41F0
-       mov       rdx,1F5CAD60870
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/63d7c0c5-32d9-431f-a5b6-2bdd0a65f7cf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/33e827ff-479b-4a97-8d5b-b5d8bbb30e64-diff.temp
index 1e3c218..557622f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/33e827ff-479b-4a97-8d5b-b5d8bbb30e64-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/63d7c0c5-32d9-431f-a5b6-2bdd0a65f7cf-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b211f396-62f3-49a7-a4ac-8cb3d627c6be-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/692250d2-17c8-4cbe-b202-cd03397729cd-diff.temp
index 1e3c218..c7aabed 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/692250d2-17c8-4cbe-b202-cd03397729cd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b211f396-62f3-49a7-a4ac-8cb3d627c6be-diff.temp
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
+       mov       rax,21A02362A18
-       mov       rax,1F5CAD60878
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,21A12361508
-       mov       rax,1F5CAD51508
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
+       mov       rdx,21A02362A10
-       mov       rdx,1F5CAD60870
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7a00d73e-500f-430b-8ba2-f3bb7d51c861-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b52fe05e-4487-4326-a2e6-006d3b48fac7-diff.temp
index 1e3c218..f719ea4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b52fe05e-4487-4326-a2e6-006d3b48fac7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7a00d73e-500f-430b-8ba2-f3bb7d51c861-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6422b2a4-54fe-40d2-9027-faa7646632fd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d79ec6f6-3bd3-43a0-87de-1609c492cc40-diff.temp
index 1e3c218..76fac21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d79ec6f6-3bd3-43a0-87de-1609c492cc40-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6422b2a4-54fe-40d2-9027-faa7646632fd-diff.temp
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
+       mov       rax,1E2C711FC60
-       mov       rax,240115BE468
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,1E2B7111508
-       mov       rax,240215B1508
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
+       mov       rdx,1E2C711FC58
-       mov       rdx,240115BE460
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/960745c8-32f9-4585-9bcc-04efb72b3fd2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2b8a2c7b-0471-4301-9dc1-ba4c6c26039e-diff.temp
index 0959832..ac637b9 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2b8a2c7b-0471-4301-9dc1-ba4c6c26039e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/960745c8-32f9-4585-9bcc-04efb72b3fd2-diff.temp
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
+       mov       rax,20FBF7B41F8
-       mov       rax,240115BE468
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,20FBF7B1508
-       mov       rax,240215B1508
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
+       mov       rdx,20FBF7B41F0
-       mov       rdx,240115BE460
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2ec092e2-f423-47fc-8530-7fa5cf3a3bc4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7a94e847-0194-483b-bab0-f49ad91c865e-diff.temp
index 0959832..557622f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7a94e847-0194-483b-bab0-f49ad91c865e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2ec092e2-f423-47fc-8530-7fa5cf3a3bc4-diff.temp
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
+       mov       rax,2AF998C31E0
-       mov       rax,240115BE468
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,2AF998C1508
-       mov       rax,240215B1508
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
+       mov       rdx,2AF998C31D8
-       mov       rdx,240115BE460
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/457dd6ce-2ec2-4a7c-b1f1-98df55d27136-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bee39a4e-f7de-48d1-9d6c-00527d790d41-diff.temp
index 0959832..c7aabed 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bee39a4e-f7de-48d1-9d6c-00527d790d41-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/457dd6ce-2ec2-4a7c-b1f1-98df55d27136-diff.temp
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
+       mov       rax,21A02362A18
-       mov       rax,240115BE468
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,21A12361508
-       mov       rax,240215B1508
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
+       mov       rdx,21A02362A10
-       mov       rdx,240115BE460
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/23fa5fd2-35dc-4356-b6be-475da00a3d53-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0030c5ef-a0d3-4c07-a167-eda693a414c9-diff.temp
index 0959832..f719ea4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0030c5ef-a0d3-4c07-a167-eda693a414c9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/23fa5fd2-35dc-4356-b6be-475da00a3d53-diff.temp
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
+       mov       rax,24FB13611E8
-       mov       rax,240115BE468
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24FA1361508
-       mov       rax,240215B1508
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
+       mov       rdx,24FB13611E0
-       mov       rdx,240115BE460
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d5785f07-653c-4f0d-95d6-b6823fb10583-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aafbe850-0621-40f3-825b-5a26ee3df61f-diff.temp
index 0959832..76fac21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aafbe850-0621-40f3-825b-5a26ee3df61f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d5785f07-653c-4f0d-95d6-b6823fb10583-diff.temp
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
+       mov       rax,20FBF7B41F8
-       mov       rax,1E2C711FC60
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,20FBF7B1508
-       mov       rax,1E2B7111508
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
+       mov       rdx,20FBF7B41F0
-       mov       rdx,1E2C711FC58
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/156e546d-714a-4792-833a-d6af47220e7c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f5768850-cb4c-491c-9331-167ba398cf67-diff.temp
index ac637b9..557622f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f5768850-cb4c-491c-9331-167ba398cf67-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/156e546d-714a-4792-833a-d6af47220e7c-diff.temp
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
+       mov       rax,2AF998C31E0
-       mov       rax,1E2C711FC60
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,2AF998C1508
-       mov       rax,1E2B7111508
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
+       mov       rdx,2AF998C31D8
-       mov       rdx,1E2C711FC58
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f61e6f16-713a-4391-aa5d-258a0a77586c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1c3b78ab-e093-4d65-b020-ad1b136e30c5-diff.temp
index ac637b9..c7aabed 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1c3b78ab-e093-4d65-b020-ad1b136e30c5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f61e6f16-713a-4391-aa5d-258a0a77586c-diff.temp
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
+       mov       rax,21A02362A18
-       mov       rax,1E2C711FC60
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,21A12361508
-       mov       rax,1E2B7111508
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
+       mov       rdx,21A02362A10
-       mov       rdx,1E2C711FC58
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b104e66c-f5ce-4b80-88f8-dd89325fea4b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/375d918a-27f5-48a4-8058-a4a6390ee467-diff.temp
index ac637b9..f719ea4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/375d918a-27f5-48a4-8058-a4a6390ee467-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b104e66c-f5ce-4b80-88f8-dd89325fea4b-diff.temp
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
+       mov       rax,24FB13611E8
-       mov       rax,1E2C711FC60
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24FA1361508
-       mov       rax,1E2B7111508
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
+       mov       rdx,24FB13611E0
-       mov       rdx,1E2C711FC58
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3cb8aee9-5799-43be-ab3e-7586b2158198-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/177fb388-e202-4539-8be5-5434cb0f09ba-diff.temp
index ac637b9..76fac21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/177fb388-e202-4539-8be5-5434cb0f09ba-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3cb8aee9-5799-43be-ab3e-7586b2158198-diff.temp
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
+       mov       rax,2AF998C31E0
-       mov       rax,20FBF7B41F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,2AF998C1508
-       mov       rax,20FBF7B1508
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
+       mov       rdx,2AF998C31D8
-       mov       rdx,20FBF7B41F0
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2651a5f1-f1c9-469e-b198-f8a9445df870-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39ce1321-52e7-47b2-a622-c1464985b626-diff.temp
index 557622f..c7aabed 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/39ce1321-52e7-47b2-a622-c1464985b626-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2651a5f1-f1c9-469e-b198-f8a9445df870-diff.temp
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
+       mov       rax,21A02362A18
-       mov       rax,20FBF7B41F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,21A12361508
-       mov       rax,20FBF7B1508
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
+       mov       rdx,21A02362A10
-       mov       rdx,20FBF7B41F0
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3a969e21-c938-42c5-8d6d-7f324e29b491-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/be1e40d1-f5ba-41a4-af77-a768dcc80d7c-diff.temp
index 557622f..f719ea4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/be1e40d1-f5ba-41a4-af77-a768dcc80d7c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3a969e21-c938-42c5-8d6d-7f324e29b491-diff.temp
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
+       mov       rax,24FB13611E8
-       mov       rax,20FBF7B41F8
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24FA1361508
-       mov       rax,20FBF7B1508
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
+       mov       rdx,24FB13611E0
-       mov       rdx,20FBF7B41F0
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b573d294-4034-4d7a-951a-9ee429c3da3c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/640b9ca4-75e9-4d6d-b546-018721776f6e-diff.temp
index 557622f..76fac21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/640b9ca4-75e9-4d6d-b546-018721776f6e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b573d294-4034-4d7a-951a-9ee429c3da3c-diff.temp
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
+       mov       rax,21A02362A18
-       mov       rax,2AF998C31E0
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,21A12361508
-       mov       rax,2AF998C1508
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
+       mov       rdx,21A02362A10
-       mov       rdx,2AF998C31D8
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9b7a6469-3af6-4ba4-b4df-b8bde347dad4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2ba16c23-9848-4541-84b5-7f5e34c3cec1-diff.temp
index c7aabed..f719ea4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2ba16c23-9848-4541-84b5-7f5e34c3cec1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9b7a6469-3af6-4ba4-b4df-b8bde347dad4-diff.temp
```
**Diff for AppendBytes03 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/640bb011-dd7a-4c64-a475-4b1fcaeea2a7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1c33711-1abc-4326-b8ed-ec8875108400-diff.temp
index c7aabed..76fac21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b1c33711-1abc-4326-b8ed-ec8875108400-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/640bb011-dd7a-4c64-a475-4b1fcaeea2a7-diff.temp
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
+       mov       rax,24FB13611E8
-       mov       rax,21A02362A18
        movzx     ecx,byte ptr [rcx]
        mov       r8,[rax]
+       mov       rax,24FA1361508
-       mov       rax,21A12361508
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
+       mov       rdx,24FB13611E0
-       mov       rdx,21A02362A10
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/878cf14b-a414-4ba4-9d44-d41639c4a050-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/91e6613e-f93a-4db6-827c-de772bec1a41-diff.temp
index f719ea4..76fac21 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/91e6613e-f93a-4db6-827c-de772bec1a41-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/878cf14b-a414-4ba4-9d44-d41639c4a050-diff.temp
```
