## DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark-20220802-070933
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,20092231098
-       mov       rdx,10E8ACF3090
        mov       rcx,[rcx]
+       mov       rcx,200922311E0
-       mov       rcx,10E8ACF31D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E32180]
-       mov       rax,[7FFB52E22180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,20072233B88
-       mov       rdx,10E8ACFB7A0
        mov       r14,[rdx]
+       mov       rdx,20072231568
-       mov       rdx,10E8ACF1568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,20072233B80
-       mov       rdx,10E8ACFB798
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/60afbb09-5f8f-4944-a12c-cebfcb1683a4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/638a7082-483c-4dc4-9be2-67f51f5bf18a-diff.temp
index 1a346f7..7fca36d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/638a7082-483c-4dc4-9be2-67f51f5bf18a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/60afbb09-5f8f-4944-a12c-cebfcb1683a4-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,1A305653090
-       mov       rdx,10E8ACF3090
        mov       rcx,[rcx]
+       mov       rcx,1A3056531D8
-       mov       rcx,10E8ACF31D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E02180]
-       mov       rax,[7FFB52E22180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1A30565AF88
-       mov       rdx,10E8ACFB7A0
        mov       r14,[rdx]
+       mov       rdx,1A305651568
-       mov       rdx,10E8ACF1568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1A30565AF80
-       mov       rdx,10E8ACFB798
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/49a1b5ef-5953-4b69-ad1e-dfa3a221dd40-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f40eb997-07b0-4dda-95ea-461fffa5c0da-diff.temp
index 1a346f7..ce9ebb8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f40eb997-07b0-4dda-95ea-461fffa5c0da-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/49a1b5ef-5953-4b69-ad1e-dfa3a221dd40-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,2646E123090
-       mov       rdx,10E8ACF3090
        mov       rcx,[rcx]
+       mov       rcx,2646E1231D8
-       mov       rcx,10E8ACF31D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E22180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,2648E121B90
-       mov       rdx,10E8ACFB7A0
        mov       r14,[rdx]
+       mov       rdx,2646E121568
-       mov       rdx,10E8ACF1568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2648E121B88
-       mov       rdx,10E8ACFB798
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63c767fd-7dee-4b3c-a85a-2229efe8adda-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/73548bdf-6735-4a9d-b610-10bc49c4100a-diff.temp
index 1a346f7..511ac34 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/73548bdf-6735-4a9d-b610-10bc49c4100a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63c767fd-7dee-4b3c-a85a-2229efe8adda-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,1F25B411098
-       mov       rdx,10E8ACF3090
        mov       rcx,[rcx]
+       mov       rcx,1F25B4111E0
-       mov       rcx,10E8ACF31D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E22180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1F26B412BA8
-       mov       rdx,10E8ACFB7A0
        mov       r14,[rdx]
+       mov       rdx,1F24B411568
-       mov       rdx,10E8ACF1568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F26B412BA0
-       mov       rdx,10E8ACFB798
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ff0c79c1-164a-4eaa-89f8-2154f6861ef0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b5c27080-72db-4d4c-b30e-027287b6ba9a-diff.temp
index 1a346f7..a41cd71 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b5c27080-72db-4d4c-b30e-027287b6ba9a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ff0c79c1-164a-4eaa-89f8-2154f6861ef0-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,180C1843090
-       mov       rdx,10E8ACF3090
        mov       rcx,[rcx]
+       mov       rcx,180C18431D8
-       mov       rcx,10E8ACF31D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E22180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,180D18423A8
-       mov       rdx,10E8ACFB7A0
        mov       r14,[rdx]
+       mov       rdx,180C1841568
-       mov       rdx,10E8ACF1568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,180D18423A0
-       mov       rdx,10E8ACFB798
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f5840d9b-504c-4d5e-8e9b-dca7d20227e4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74ff5119-204e-43fd-b92c-62d7ac2d56cc-diff.temp
index 1a346f7..5bd888d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74ff5119-204e-43fd-b92c-62d7ac2d56cc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f5840d9b-504c-4d5e-8e9b-dca7d20227e4-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,1E0E6333090
-       mov       rdx,10E8ACF3090
        mov       rcx,[rcx]
+       mov       rcx,1E0E63331D8
-       mov       rcx,10E8ACF31D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E22180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1E0F63333C0
-       mov       rdx,10E8ACFB7A0
        mov       r14,[rdx]
+       mov       rdx,1E0E6331568
-       mov       rdx,10E8ACF1568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E0F63333B8
-       mov       rdx,10E8ACFB798
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/317f5dc6-c0d1-4051-bb5d-c5162fb2d04b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/68ec57bb-a7a1-4545-a581-d3e32c2920b2-diff.temp
index 1a346f7..f69b6cf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/68ec57bb-a7a1-4545-a581-d3e32c2920b2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/317f5dc6-c0d1-4051-bb5d-c5162fb2d04b-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,245E7D03090
-       mov       rdx,10E8ACF3090
        mov       rcx,[rcx]
+       mov       rcx,245E7D031D8
-       mov       rcx,10E8ACF31D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E22180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,24607D02BA8
-       mov       rdx,10E8ACFB7A0
        mov       r14,[rdx]
+       mov       rdx,245E7D01568
-       mov       rdx,10E8ACF1568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,24607D02BA0
-       mov       rdx,10E8ACFB798
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/523bf3b9-b2ea-4b33-aa27-4f838c4dc9bd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/059b8eda-67ef-4fca-b596-e83a557ceab1-diff.temp
index 1a346f7..aca9c94 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/059b8eda-67ef-4fca-b596-e83a557ceab1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/523bf3b9-b2ea-4b33-aa27-4f838c4dc9bd-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,22C3ECE3090
-       mov       rdx,10E8ACF3090
        mov       rcx,[rcx]
+       mov       rcx,22C3ECE31D8
-       mov       rcx,10E8ACF31D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E22180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,22C3ECEAF88
-       mov       rdx,10E8ACFB7A0
        mov       r14,[rdx]
+       mov       rdx,22C3ECE1568
-       mov       rdx,10E8ACF1568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22C3ECEAF80
-       mov       rdx,10E8ACFB798
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/382d5e24-269c-48f0-a23d-420120f6cca0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ad21ba2c-90a8-48d1-ab7d-7108f63fb398-diff.temp
index 1a346f7..c9ac4f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ad21ba2c-90a8-48d1-ab7d-7108f63fb398-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/382d5e24-269c-48f0-a23d-420120f6cca0-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,1A305653090
-       mov       rdx,20092231098
        mov       rcx,[rcx]
+       mov       rcx,1A3056531D8
-       mov       rcx,200922311E0
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E02180]
-       mov       rax,[7FFB52E32180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1A30565AF88
-       mov       rdx,20072233B88
        mov       r14,[rdx]
+       mov       rdx,1A305651568
-       mov       rdx,20072231568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1A30565AF80
-       mov       rdx,20072233B80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98b36efc-e0e9-44c6-888f-c5e0f8c7e960-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3f3ad8d7-3c71-4d03-b70a-5e86682edb76-diff.temp
index 7fca36d..ce9ebb8 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3f3ad8d7-3c71-4d03-b70a-5e86682edb76-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98b36efc-e0e9-44c6-888f-c5e0f8c7e960-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,2646E123090
-       mov       rdx,20092231098
        mov       rcx,[rcx]
+       mov       rcx,2646E1231D8
-       mov       rcx,200922311E0
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E32180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,2648E121B90
-       mov       rdx,20072233B88
        mov       r14,[rdx]
+       mov       rdx,2646E121568
-       mov       rdx,20072231568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2648E121B88
-       mov       rdx,20072233B80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/08585df0-7078-4aff-8c4d-45e4377fcbe9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/17491dd8-2a03-48b6-8809-c37ffaf55461-diff.temp
index 7fca36d..511ac34 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/17491dd8-2a03-48b6-8809-c37ffaf55461-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/08585df0-7078-4aff-8c4d-45e4377fcbe9-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,1F25B411098
-       mov       rdx,20092231098
        mov       rcx,[rcx]
+       mov       rcx,1F25B4111E0
-       mov       rcx,200922311E0
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E32180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1F26B412BA8
-       mov       rdx,20072233B88
        mov       r14,[rdx]
+       mov       rdx,1F24B411568
-       mov       rdx,20072231568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F26B412BA0
-       mov       rdx,20072233B80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/87d3a0f6-c160-4815-b63c-727764fd4fee-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a706521b-4725-40e6-b522-4e07d5772da6-diff.temp
index 7fca36d..a41cd71 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a706521b-4725-40e6-b522-4e07d5772da6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/87d3a0f6-c160-4815-b63c-727764fd4fee-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,180C1843090
-       mov       rdx,20092231098
        mov       rcx,[rcx]
+       mov       rcx,180C18431D8
-       mov       rcx,200922311E0
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E32180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,180D18423A8
-       mov       rdx,20072233B88
        mov       r14,[rdx]
+       mov       rdx,180C1841568
-       mov       rdx,20072231568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,180D18423A0
-       mov       rdx,20072233B80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/441b1098-62b4-43ed-8281-2aad24818b5d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f668dd14-d268-48de-8582-1b2c6d7166c8-diff.temp
index 7fca36d..5bd888d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f668dd14-d268-48de-8582-1b2c6d7166c8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/441b1098-62b4-43ed-8281-2aad24818b5d-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,1E0E6333090
-       mov       rdx,20092231098
        mov       rcx,[rcx]
+       mov       rcx,1E0E63331D8
-       mov       rcx,200922311E0
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E32180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1E0F63333C0
-       mov       rdx,20072233B88
        mov       r14,[rdx]
+       mov       rdx,1E0E6331568
-       mov       rdx,20072231568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E0F63333B8
-       mov       rdx,20072233B80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/37888dd6-41d4-4c14-b2fc-c3bafae3e374-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61a66901-c49a-4723-9d01-2af92a1b560b-diff.temp
index 7fca36d..f69b6cf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61a66901-c49a-4723-9d01-2af92a1b560b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/37888dd6-41d4-4c14-b2fc-c3bafae3e374-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,245E7D03090
-       mov       rdx,20092231098
        mov       rcx,[rcx]
+       mov       rcx,245E7D031D8
-       mov       rcx,200922311E0
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E32180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,24607D02BA8
-       mov       rdx,20072233B88
        mov       r14,[rdx]
+       mov       rdx,245E7D01568
-       mov       rdx,20072231568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,24607D02BA0
-       mov       rdx,20072233B80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c36c5ad4-5595-4642-8d3b-61e56c07d8bc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/169a416b-2b7a-491a-8063-95de24e466dc-diff.temp
index 7fca36d..aca9c94 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/169a416b-2b7a-491a-8063-95de24e466dc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c36c5ad4-5595-4642-8d3b-61e56c07d8bc-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,22C3ECE3090
-       mov       rdx,20092231098
        mov       rcx,[rcx]
+       mov       rcx,22C3ECE31D8
-       mov       rcx,200922311E0
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E32180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,22C3ECEAF88
-       mov       rdx,20072233B88
        mov       r14,[rdx]
+       mov       rdx,22C3ECE1568
-       mov       rdx,20072231568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22C3ECEAF80
-       mov       rdx,20072233B80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1ad8a4ba-337e-4f32-9206-2619ca2cd32d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4a6d3595-c067-449e-a99a-0f8d12d7e5a3-diff.temp
index 7fca36d..c9ac4f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4a6d3595-c067-449e-a99a-0f8d12d7e5a3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1ad8a4ba-337e-4f32-9206-2619ca2cd32d-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,2646E123090
-       mov       rdx,1A305653090
        mov       rcx,[rcx]
+       mov       rcx,2646E1231D8
-       mov       rcx,1A3056531D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E02180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,2648E121B90
-       mov       rdx,1A30565AF88
        mov       r14,[rdx]
+       mov       rdx,2646E121568
-       mov       rdx,1A305651568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,2648E121B88
-       mov       rdx,1A30565AF80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b8a4e26b-4ca4-4a70-9683-502c1aea6cfc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7be53a5d-d134-4724-8728-b80d0cca5a5b-diff.temp
index ce9ebb8..511ac34 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7be53a5d-d134-4724-8728-b80d0cca5a5b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b8a4e26b-4ca4-4a70-9683-502c1aea6cfc-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,1F25B411098
-       mov       rdx,1A305653090
        mov       rcx,[rcx]
+       mov       rcx,1F25B4111E0
-       mov       rcx,1A3056531D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E02180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1F26B412BA8
-       mov       rdx,1A30565AF88
        mov       r14,[rdx]
+       mov       rdx,1F24B411568
-       mov       rdx,1A305651568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F26B412BA0
-       mov       rdx,1A30565AF80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/47a7bb6c-c3f9-4f03-9d4e-6f7384c3c900-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/687993e8-4edc-43dc-90c2-c002582eb987-diff.temp
index ce9ebb8..a41cd71 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/687993e8-4edc-43dc-90c2-c002582eb987-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/47a7bb6c-c3f9-4f03-9d4e-6f7384c3c900-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,180C1843090
-       mov       rdx,1A305653090
        mov       rcx,[rcx]
+       mov       rcx,180C18431D8
-       mov       rcx,1A3056531D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E02180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,180D18423A8
-       mov       rdx,1A30565AF88
        mov       r14,[rdx]
+       mov       rdx,180C1841568
-       mov       rdx,1A305651568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,180D18423A0
-       mov       rdx,1A30565AF80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9af76b17-602f-4cee-b7be-eec46a6d9d2b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ab4fcf4a-f30c-4e00-b55b-4408050f6549-diff.temp
index ce9ebb8..5bd888d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ab4fcf4a-f30c-4e00-b55b-4408050f6549-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9af76b17-602f-4cee-b7be-eec46a6d9d2b-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,1E0E6333090
-       mov       rdx,1A305653090
        mov       rcx,[rcx]
+       mov       rcx,1E0E63331D8
-       mov       rcx,1A3056531D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E02180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1E0F63333C0
-       mov       rdx,1A30565AF88
        mov       r14,[rdx]
+       mov       rdx,1E0E6331568
-       mov       rdx,1A305651568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E0F63333B8
-       mov       rdx,1A30565AF80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1723f983-ad16-4c0c-b64d-14e09843a7b7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fa2f401d-87f5-4dc3-ade7-49a2fe2d2b88-diff.temp
index ce9ebb8..f69b6cf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fa2f401d-87f5-4dc3-ade7-49a2fe2d2b88-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1723f983-ad16-4c0c-b64d-14e09843a7b7-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,245E7D03090
-       mov       rdx,1A305653090
        mov       rcx,[rcx]
+       mov       rcx,245E7D031D8
-       mov       rcx,1A3056531D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E02180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,24607D02BA8
-       mov       rdx,1A30565AF88
        mov       r14,[rdx]
+       mov       rdx,245E7D01568
-       mov       rdx,1A305651568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,24607D02BA0
-       mov       rdx,1A30565AF80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/598d8744-435b-4fea-bb1d-7b1f35454818-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5b78083e-0d9f-407c-9c1d-e544e2af2adb-diff.temp
index ce9ebb8..aca9c94 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5b78083e-0d9f-407c-9c1d-e544e2af2adb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/598d8744-435b-4fea-bb1d-7b1f35454818-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,22C3ECE3090
-       mov       rdx,1A305653090
        mov       rcx,[rcx]
+       mov       rcx,22C3ECE31D8
-       mov       rcx,1A3056531D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E02180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,22C3ECEAF88
-       mov       rdx,1A30565AF88
        mov       r14,[rdx]
+       mov       rdx,22C3ECE1568
-       mov       rdx,1A305651568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22C3ECEAF80
-       mov       rdx,1A30565AF80
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aa7539e0-b917-4be2-9e01-4fe423109b17-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/837a1d31-b2ed-4caf-8bd5-2c436889182f-diff.temp
index ce9ebb8..c9ac4f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/837a1d31-b2ed-4caf-8bd5-2c436889182f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aa7539e0-b917-4be2-9e01-4fe423109b17-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1F26B412BA8
-       mov       rdx,2648E121B90
        mov       r14,[rdx]
+       mov       rdx,1F24B411568
-       mov       rdx,2646E121568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1F26B412BA0
-       mov       rdx,2648E121B88
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/56fffa09-a259-47c4-bdb4-3a73d7132908-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/29f99f21-6f25-4c6a-a252-6743515bf44f-diff.temp
index 511ac34..a41cd71 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/29f99f21-6f25-4c6a-a252-6743515bf44f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/56fffa09-a259-47c4-bdb4-3a73d7132908-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,180C1843090
-       mov       rdx,2646E123090
        mov       rcx,[rcx]
+       mov       rcx,180C18431D8
-       mov       rcx,2646E1231D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E42180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,180D18423A8
-       mov       rdx,2648E121B90
        mov       r14,[rdx]
+       mov       rdx,180C1841568
-       mov       rdx,2646E121568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,180D18423A0
-       mov       rdx,2648E121B88
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4329062b-d10e-4204-8b84-d8c99cc94954-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c87cce8d-3791-4fb3-ad68-895701495dda-diff.temp
index 511ac34..5bd888d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c87cce8d-3791-4fb3-ad68-895701495dda-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4329062b-d10e-4204-8b84-d8c99cc94954-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1E0F63333C0
-       mov       rdx,2648E121B90
        mov       r14,[rdx]
+       mov       rdx,1E0E6331568
-       mov       rdx,2646E121568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E0F63333B8
-       mov       rdx,2648E121B88
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4cf2eeac-500f-40de-83eb-4875838b6f4e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e2cd2618-9b0b-4117-9e41-83321c539d47-diff.temp
index 511ac34..f69b6cf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e2cd2618-9b0b-4117-9e41-83321c539d47-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4cf2eeac-500f-40de-83eb-4875838b6f4e-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,245E7D03090
-       mov       rdx,2646E123090
        mov       rcx,[rcx]
+       mov       rcx,245E7D031D8
-       mov       rcx,2646E1231D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E42180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,24607D02BA8
-       mov       rdx,2648E121B90
        mov       r14,[rdx]
+       mov       rdx,245E7D01568
-       mov       rdx,2646E121568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,24607D02BA0
-       mov       rdx,2648E121B88
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f587f046-4e39-4045-9288-adf40593fdd9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9df73918-6d73-4973-ae38-8dea4de046ff-diff.temp
index 511ac34..aca9c94 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9df73918-6d73-4973-ae38-8dea4de046ff-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f587f046-4e39-4045-9288-adf40593fdd9-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,22C3ECEAF88
-       mov       rdx,2648E121B90
        mov       r14,[rdx]
+       mov       rdx,22C3ECE1568
-       mov       rdx,2646E121568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22C3ECEAF80
-       mov       rdx,2648E121B88
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1334c670-3a5a-4484-839c-1e3723254104-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b3c32378-041b-463e-ba6c-b490cf44364f-diff.temp
index 511ac34..c9ac4f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b3c32378-041b-463e-ba6c-b490cf44364f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1334c670-3a5a-4484-839c-1e3723254104-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,180C1843090
-       mov       rdx,1F25B411098
        mov       rcx,[rcx]
+       mov       rcx,180C18431D8
-       mov       rcx,1F25B4111E0
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E42180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,180D18423A8
-       mov       rdx,1F26B412BA8
        mov       r14,[rdx]
+       mov       rdx,180C1841568
-       mov       rdx,1F24B411568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,180D18423A0
-       mov       rdx,1F26B412BA0
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74adfae8-d6f7-47e9-bc51-3e64783ff7c6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f4af83a9-e2a6-4473-ac65-79a898c4b86b-diff.temp
index a41cd71..5bd888d 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f4af83a9-e2a6-4473-ac65-79a898c4b86b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74adfae8-d6f7-47e9-bc51-3e64783ff7c6-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1E0F63333C0
-       mov       rdx,1F26B412BA8
        mov       r14,[rdx]
+       mov       rdx,1E0E6331568
-       mov       rdx,1F24B411568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E0F63333B8
-       mov       rdx,1F26B412BA0
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7bc54d79-89ec-4935-b8a8-aaaab5c8dcae-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7ba31332-971d-43fe-854d-904961538067-diff.temp
index a41cd71..f69b6cf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7ba31332-971d-43fe-854d-904961538067-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7bc54d79-89ec-4935-b8a8-aaaab5c8dcae-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,245E7D03090
-       mov       rdx,1F25B411098
        mov       rcx,[rcx]
+       mov       rcx,245E7D031D8
-       mov       rcx,1F25B4111E0
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E42180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,24607D02BA8
-       mov       rdx,1F26B412BA8
        mov       r14,[rdx]
+       mov       rdx,245E7D01568
-       mov       rdx,1F24B411568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,24607D02BA0
-       mov       rdx,1F26B412BA0
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3d6387ee-a317-4e16-b193-f0202197f87e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dc5b7d3f-715a-4eca-ae75-416be8be214b-diff.temp
index a41cd71..aca9c94 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dc5b7d3f-715a-4eca-ae75-416be8be214b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3d6387ee-a317-4e16-b193-f0202197f87e-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,22C3ECEAF88
-       mov       rdx,1F26B412BA8
        mov       r14,[rdx]
+       mov       rdx,22C3ECE1568
-       mov       rdx,1F24B411568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22C3ECEAF80
-       mov       rdx,1F26B412BA0
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8f3224d6-04f6-49db-a9ec-1c5c18ef6223-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e4873630-5062-4842-8def-c4e2fb0e9ebc-diff.temp
index a41cd71..c9ac4f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e4873630-5062-4842-8def-c4e2fb0e9ebc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8f3224d6-04f6-49db-a9ec-1c5c18ef6223-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,1E0E6333090
-       mov       rdx,180C1843090
        mov       rcx,[rcx]
+       mov       rcx,1E0E63331D8
-       mov       rcx,180C18431D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E12180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,1E0F63333C0
-       mov       rdx,180D18423A8
        mov       r14,[rdx]
+       mov       rdx,1E0E6331568
-       mov       rdx,180C1841568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,1E0F63333B8
-       mov       rdx,180D18423A0
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9baf9f24-5205-47be-a81a-544dbadf9fd9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0704ff98-6adc-4a19-9aec-ef8e9c61b3e8-diff.temp
index 5bd888d..f69b6cf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0704ff98-6adc-4a19-9aec-ef8e9c61b3e8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9baf9f24-5205-47be-a81a-544dbadf9fd9-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,24607D02BA8
-       mov       rdx,180D18423A8
        mov       r14,[rdx]
+       mov       rdx,245E7D01568
-       mov       rdx,180C1841568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,24607D02BA0
-       mov       rdx,180D18423A0
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/03a9de29-5655-4ae5-93c7-45d6f92c0496-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a89abfae-fc48-4f5a-a241-9ccff05b8ab0-diff.temp
index 5bd888d..aca9c94 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a89abfae-fc48-4f5a-a241-9ccff05b8ab0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/03a9de29-5655-4ae5-93c7-45d6f92c0496-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,22C3ECE3090
-       mov       rdx,180C1843090
        mov       rcx,[rcx]
+       mov       rcx,22C3ECE31D8
-       mov       rcx,180C18431D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E12180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,22C3ECEAF88
-       mov       rdx,180D18423A8
        mov       r14,[rdx]
+       mov       rdx,22C3ECE1568
-       mov       rdx,180C1841568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22C3ECEAF80
-       mov       rdx,180D18423A0
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e9a5c27c-ee59-46c4-8cc2-53549be0809f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c0a6faa2-41f4-4d60-868a-ce5c44ad4645-diff.temp
index 5bd888d..c9ac4f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c0a6faa2-41f4-4d60-868a-ce5c44ad4645-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e9a5c27c-ee59-46c4-8cc2-53549be0809f-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,245E7D03090
-       mov       rdx,1E0E6333090
        mov       rcx,[rcx]
+       mov       rcx,245E7D031D8
-       mov       rcx,1E0E63331D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E12180]
-       mov       rax,[7FFB52E42180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,24607D02BA8
-       mov       rdx,1E0F63333C0
        mov       r14,[rdx]
+       mov       rdx,245E7D01568
-       mov       rdx,1E0E6331568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,24607D02BA0
-       mov       rdx,1E0F63333B8
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/caf466a7-9b83-4887-b540-8505d1d1b61a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/34df6307-f97b-4003-8341-fdda211f8eef-diff.temp
index f69b6cf..aca9c94 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/34df6307-f97b-4003-8341-fdda211f8eef-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/caf466a7-9b83-4887-b540-8505d1d1b61a-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,22C3ECEAF88
-       mov       rdx,1E0F63333C0
        mov       r14,[rdx]
+       mov       rdx,22C3ECE1568
-       mov       rdx,1E0E6331568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22C3ECEAF80
-       mov       rdx,1E0F63333B8
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5ee75aef-49df-4007-a0c4-66a64dba80c3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/59d0d2dd-3873-490b-a0f7-0a90dc569c28-diff.temp
index f69b6cf..c9ac4f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/59d0d2dd-3873-490b-a0f7-0a90dc569c28-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5ee75aef-49df-4007-a0c4-66a64dba80c3-diff.temp
```
**Diff for BytesToString method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
jmp       short M01_L07
        xor       eax,eax
        je        short M01_L06
        cmp       dword ptr [rcx+8],0
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,rsi
        mov       rcx,rax
        call      System.String.Concat(System.String, System.String)
        mov       rdx,[rdx]
+       mov       rdx,22C3ECE3090
-       mov       rdx,245E7D03090
        mov       rcx,[rcx]
+       mov       rcx,22C3ECE31D8
-       mov       rcx,245E7D031D8
        mov       rsi,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
 M01_L05:
        call      CORINFO_HELP_OVERFLOW
        jmp       rax
        pop       r15
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,28
+       mov       rax,[7FFB52E42180]
-       mov       rax,[7FFB52E12180]
        mov       rcx,rdi
 M01_L03:
        call      System.Text.StringBuilder.Append(Char, Int32)
        mov       r8d,1
        mov       edx,27
        mov       rcx,rdi
        movsxd    rdx,ebx
 M01_L00:
        mov       r15,[rdx]
+       mov       rdx,22C3ECEAF88
-       mov       rdx,24607D02BA8
        mov       r14,[rdx]
+       mov       rdx,22C3ECE1568
-       mov       rdx,245E7D01568
        jle       short M01_L01
        test      ebp,ebp
        mov       ebp,[rsi+8]
        xor       ebx,ebx
        call      System.Text.StringBuilder.Append(System.String)
        mov       rcx,rdi
        mov       rdx,[rdx]
+       mov       rdx,22C3ECEAF80
-       mov       rdx,24607D02BA0
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
        je        near ptr M01_L05
        test      ecx,ecx
        movzx     ecx,cl
        setne     cl
        test      rsi,rsi
        mov       rsi,rcx
        sub       rsp,28
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
        push      r15
 ; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
 ; Total bytes of code 45
        ret
        pop       rsi
        add       rsp,20
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rax
        add       rcx,8
        cmp       [rcx],ecx
        mov       rcx,[rsi+18]
        call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
        mov       rcx,[rsi+2B0]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
 ; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61f90f7d-cab5-4316-8dec-e5887f6b0932-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/67ef2f0f-5029-47c7-8c2a-9315f9ab3f0e-diff.temp
index aca9c94..c9ac4f7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/67ef2f0f-5029-47c7-8c2a-9315f9ab3f0e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61f90f7d-cab5-4316-8dec-e5887f6b0932-diff.temp
```
