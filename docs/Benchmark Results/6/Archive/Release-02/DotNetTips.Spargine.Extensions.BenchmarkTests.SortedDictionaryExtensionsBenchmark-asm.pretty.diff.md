## DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark-20220802-042729
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E0A0
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
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
+       mov       rdx,7FFB477433C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/43c28dcc-2ca4-4def-8ce1-121b634df825-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2c890f9d-1dab-4e5f-aa58-207434042a62-diff.temp
index 0fa20b2..99560a5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2c890f9d-1dab-4e5f-aa58-207434042a62-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/43c28dcc-2ca4-4def-8ce1-121b634df825-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E0A0
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
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
+       mov       rdx,7FFB477433C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/607cee00-7815-445c-8d4e-4d1b68515393-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/44175f08-c042-4c1c-8ad5-7ee646a7f27d-diff.temp
index 0fa20b2..99560a5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/44175f08-c042-4c1c-8ad5-7ee646a7f27d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/607cee00-7815-445c-8d4e-4d1b68515393-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E0A0
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
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
+       mov       rdx,7FFB477433C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9468ec01-15b0-4ff1-9d03-a6619e861003-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7d9eaf0c-0dd3-484c-b9aa-1c6939b8348d-diff.temp
index 0fa20b2..99560a5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7d9eaf0c-0dd3-484c-b9aa-1c6939b8348d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9468ec01-15b0-4ff1-9d03-a6619e861003-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E0A0
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
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
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/366ee39d-a47a-4104-8a95-607ca33d4bdc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cc61ddbb-8205-4464-86db-c704c80d6ba0-diff.temp
index 0fa20b2..9ea08f2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cc61ddbb-8205-4464-86db-c704c80d6ba0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/366ee39d-a47a-4104-8a95-607ca33d4bdc-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE28
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
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
+       mov       rdx,7FFB4776AF70
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4a76e6d5-f696-4658-9896-075c3547b4ee-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d103bf4a-5ed7-4d11-a546-88ed8315776a-diff.temp
index 0fa20b2..b214aaf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d103bf4a-5ed7-4d11-a546-88ed8315776a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4a76e6d5-f696-4658-9896-075c3547b4ee-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE28
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
        mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4775AF70
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1c5f0af4-8cad-48ee-9061-45cc0d2c15ac-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/532c2b16-8e90-423c-8bc8-aa4f2fb43a33-diff.temp
index 0fa20b2..b12a16b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/532c2b16-8e90-423c-8bc8-aa4f2fb43a33-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1c5f0af4-8cad-48ee-9061-45cc0d2c15ac-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E0A0
-       mov       rdx,7FFB4791E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/daf180e7-21bb-4b8b-9ff7-9661b5059148-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f6b3f546-0471-445e-b3af-57e5a76795a3-diff.temp
index 99560a5..0fa20b2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f6b3f546-0471-445e-b3af-57e5a76795a3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/daf180e7-21bb-4b8b-9ff7-9661b5059148-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E0A0
-       mov       rdx,7FFB4791E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/141af63f-10dc-45bf-b726-8625b285e567-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dbca70fd-7fe9-4735-b2a0-1b12c327758f-diff.temp
index 99560a5..9ea08f2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dbca70fd-7fe9-4735-b2a0-1b12c327758f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/141af63f-10dc-45bf-b726-8625b285e567-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE28
-       mov       rdx,7FFB4791E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB4776AF70
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4229bacb-57ff-441c-9dbd-b417937bddfa-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a102d3ed-088a-4ba8-a704-4a532e62e8c6-diff.temp
index 99560a5..b214aaf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a102d3ed-088a-4ba8-a704-4a532e62e8c6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4229bacb-57ff-441c-9dbd-b417937bddfa-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE28
-       mov       rdx,7FFB4791E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f920d50-bd7f-400a-af78-27df4ddf7fb5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f3b64786-9a10-4be6-a551-e2e35b1303f1-diff.temp
index 99560a5..b12a16b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f3b64786-9a10-4be6-a551-e2e35b1303f1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f920d50-bd7f-400a-af78-27df4ddf7fb5-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E0A0
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
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
+       mov       rdx,7FFB477433C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bf6ff654-16ce-4b6a-9e16-f84b4337d049-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ba2813a6-e26b-47e3-b352-e8d6de97738c-diff.temp
index 0fa20b2..99560a5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ba2813a6-e26b-47e3-b352-e8d6de97738c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bf6ff654-16ce-4b6a-9e16-f84b4337d049-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E0A0
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
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
+       mov       rdx,7FFB477433C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0adc967f-b806-425a-b6a8-e14753ed0a99-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f60134c-9e05-4419-8a94-319c8b4cb595-diff.temp
index 0fa20b2..99560a5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f60134c-9e05-4419-8a94-319c8b4cb595-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0adc967f-b806-425a-b6a8-e14753ed0a99-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E0A0
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
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
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/26963af8-e5d9-4400-a1de-a530ed5a7488-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6f1e1047-958a-416f-9abe-e344214e68d4-diff.temp
index 0fa20b2..9ea08f2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6f1e1047-958a-416f-9abe-e344214e68d4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/26963af8-e5d9-4400-a1de-a530ed5a7488-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE28
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
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
+       mov       rdx,7FFB4776AF70
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c0b61cae-3e6c-4f31-9cb0-c5f484ba6e00-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e5310fb4-e4ca-4cb6-a14b-7349d3381dd2-diff.temp
index 0fa20b2..b214aaf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e5310fb4-e4ca-4cb6-a14b-7349d3381dd2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c0b61cae-3e6c-4f31-9cb0-c5f484ba6e00-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE28
-       mov       rdx,7FFB4792E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
        mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4775AF70
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4a4a8751-cc1b-4e65-a674-5bbde67089f8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3c7a5a53-1cd4-4b58-8c2b-f554a4ceb5d7-diff.temp
index 0fa20b2..b12a16b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3c7a5a53-1cd4-4b58-8c2b-f554a4ceb5d7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4a4a8751-cc1b-4e65-a674-5bbde67089f8-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E0A0
-       mov       rdx,7FFB4791E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b37fac17-1ad5-4d08-868b-8bb0c5603723-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/24354265-51f6-453a-8f2a-a07fef402841-diff.temp
index 99560a5..9ea08f2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/24354265-51f6-453a-8f2a-a07fef402841-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b37fac17-1ad5-4d08-868b-8bb0c5603723-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE28
-       mov       rdx,7FFB4791E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB4776AF70
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/062cc23e-cefa-434f-b4ec-8a383eba3eaf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8c12a6af-c28d-417a-8ab9-6b9d0b1d74b9-diff.temp
index 99560a5..b214aaf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8c12a6af-c28d-417a-8ab9-6b9d0b1d74b9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/062cc23e-cefa-434f-b4ec-8a383eba3eaf-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE28
-       mov       rdx,7FFB4791E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/82f54012-0fe7-430a-81ab-eb6f104f023d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/03f84e97-6522-43c7-b599-d6b4073852ab-diff.temp
index 99560a5..b12a16b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/03f84e97-6522-43c7-b599-d6b4073852ab-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/82f54012-0fe7-430a-81ab-eb6f104f023d-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E0A0
-       mov       rdx,7FFB4791E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0da8e657-ec9f-4bde-b60d-f47d8603d2ce-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/607ce2bc-254b-403b-b56d-9c3f22c92a01-diff.temp
index 99560a5..9ea08f2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/607ce2bc-254b-403b-b56d-9c3f22c92a01-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0da8e657-ec9f-4bde-b60d-f47d8603d2ce-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE28
-       mov       rdx,7FFB4791E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB4776AF70
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c802e4b-16d1-40d2-877f-f3143acfdb9c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cf09bb77-328d-49ee-a29c-608eac23d1b7-diff.temp
index 99560a5..b214aaf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cf09bb77-328d-49ee-a29c-608eac23d1b7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c802e4b-16d1-40d2-877f-f3143acfdb9c-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE28
-       mov       rdx,7FFB4791E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/21ebc22d-dc22-47cf-bab4-05dd140e3259-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fbfa40f6-2067-4f0f-a97e-d655f61476cc-diff.temp
index 99560a5..b12a16b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fbfa40f6-2067-4f0f-a97e-d655f61476cc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/21ebc22d-dc22-47cf-bab4-05dd140e3259-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE28
-       mov       rdx,7FFB4793E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
        mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476F6F48
        mov       ecx,4D
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4776AF70
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9907dea4-1f0c-4021-98ea-cfa50ae72610-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/935a0490-dfb9-4d99-a94a-cb5a88c59628-diff.temp
index 9ea08f2..b214aaf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/935a0490-dfb9-4d99-a94a-cb5a88c59628-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9907dea4-1f0c-4021-98ea-cfa50ae72610-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE28
-       mov       rdx,7FFB4793E0A0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f066d5a3-2be5-4e9a-b046-a3a639978924-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a5bce3e9-f4bb-4f27-99ff-ce92e9642e87-diff.temp
index 9ea08f2..b12a16b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a5bce3e9-f4bb-4f27-99ff-ce92e9642e87-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f066d5a3-2be5-4e9a-b046-a3a639978924-diff.temp
```
**Diff for HaveItemsWithCount method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE28
-       mov       rdx,7FFB4794DE28
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB4776AF70
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
 ; Total bytes of code 96
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rdi+54],bl
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aee0dd55-b03e-452c-a980-c5aceb9585ba-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/999b6456-8e50-4576-a6cc-a0db666e67e2-diff.temp
index b214aaf..b12a16b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/999b6456-8e50-4576-a6cc-a0db666e67e2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aee0dd55-b03e-452c-a980-c5aceb9585ba-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A07F8]
+       mov       r11,7FFB472407F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A07F0]
+       mov       r11,7FFB472407F0
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930B28
-       mov       rdx,7FFB47920B40
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A07F0]
+       mov       r11,7FFB472407F0
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930A50
-       mov       rdx,7FFB47920A68
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478AEF90]
+       vdivsd    xmm0,xmm0,[7FFB478AEF88]
-       vucomisd  xmm0,qword ptr [7FFB4789EF70]
-       vdivsd    xmm0,xmm0,[7FFB4789EF68]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB476C6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E288
-       mov       rdx,7FFB4790E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB476C6F48
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
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,290F4EED2F0
-       mov       rcx,2891996D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,290F4EED2E8
-       mov       rdx,2891996D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,290F4EED2F0
-       mov       rcx,2891996D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/922b264f-e96f-43c3-97a8-48b485627b5c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/87f1674d-9fad-4fa7-8f64-a69350239a3c-diff.temp
index 6279093..2e87ad7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/87f1674d-9fad-4fa7-8f64-a69350239a3c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/922b264f-e96f-43c3-97a8-48b485627b5c-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478B07F8]
+       mov       r11,7FFB472507F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478B07F0]
+       mov       r11,7FFB472507F0
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47940B98
-       mov       rdx,7FFB47920B40
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478B07F0]
+       mov       r11,7FFB472507F0
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47940AC0
-       mov       rdx,7FFB47920A68
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478BF690]
+       vdivsd    xmm0,xmm0,[7FFB478BF688]
-       vucomisd  xmm0,qword ptr [7FFB4789EF70]
-       vdivsd    xmm0,xmm0,[7FFB4789EF68]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476C6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E288
-       mov       rdx,7FFB4790E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB477533C0
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1B35657D2F0
-       mov       rcx,2891996D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1B35657D2E8
-       mov       rdx,2891996D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1B35657D2F0
-       mov       rcx,2891996D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fa1e4b4f-d583-4989-b426-5fb7ef3167ad-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e405bb10-0996-4cc7-9a91-7675c0053c1f-diff.temp
index 6279093..3971cfb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e405bb10-0996-4cc7-9a91-7675c0053c1f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fa1e4b4f-d583-4989-b426-5fb7ef3167ad-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A07F8]
+       mov       r11,7FFB472407F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A07F0]
+       mov       r11,7FFB472407F0
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930B98
-       mov       rdx,7FFB47920B40
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A07F0]
+       mov       r11,7FFB472407F0
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930AC0
-       mov       rdx,7FFB47920A68
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B2740]
+       vdivsd    xmm0,xmm0,[7FFB478B2738]
-       vucomisd  xmm0,qword ptr [7FFB4789EF70]
-       vdivsd    xmm0,xmm0,[7FFB4789EF68]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB476C6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E288
-       mov       rdx,7FFB4790E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB476C6F48
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
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1C2A4DB2FC8
-       mov       rcx,2891996D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1C2A4DB2FC0
-       mov       rdx,2891996D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1C2A4DB2FC8
-       mov       rcx,2891996D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e7a4396b-8925-4068-aa2c-864fd64066c2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4f1e920c-9335-458b-9d70-e40101f86771-diff.temp
index 6279093..a89ffa2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4f1e920c-9335-458b-9d70-e40101f86771-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e7a4396b-8925-4068-aa2c-864fd64066c2-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A07F8]
+       mov       r11,7FFB472407F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A07F0]
+       mov       r11,7FFB472407F0
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930B98
-       mov       rdx,7FFB47920B40
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A07F0]
+       mov       r11,7FFB472407F0
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930AC0
-       mov       rdx,7FFB47920A68
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B2740]
+       vdivsd    xmm0,xmm0,[7FFB478B2738]
-       vucomisd  xmm0,qword ptr [7FFB4789EF70]
-       vdivsd    xmm0,xmm0,[7FFB4789EF68]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB476C6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E288
-       mov       rdx,7FFB4790E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB476C6F48
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
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1AFF335D2F0
-       mov       rcx,2891996D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1AFF335D2E8
-       mov       rdx,2891996D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1AFF335D2F0
-       mov       rcx,2891996D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/109cf669-9b59-4218-8294-61223e982abd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f200fffe-8254-4c0f-8f01-80c25cd89279-diff.temp
index 6279093..bf8798a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f200fffe-8254-4c0f-8f01-80c25cd89279-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/109cf669-9b59-4218-8294-61223e982abd-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F0]
+       mov       r11,7FFB472707F0
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47960B98
-       mov       rdx,7FFB47920B40
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F0]
+       mov       r11,7FFB472707F0
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47960AC0
-       mov       rdx,7FFB47920A68
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478E2760]
+       vdivsd    xmm0,xmm0,[7FFB478E2758]
-       vucomisd  xmm0,qword ptr [7FFB4789EF70]
-       vdivsd    xmm0,xmm0,[7FFB4789EF68]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476C6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E288
-       mov       rdx,7FFB4790E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476C6F48
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
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,24A9D59D2F0
-       mov       rcx,2891996D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,24A9D59D2E8
-       mov       rdx,2891996D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,24A9D59D2F0
-       mov       rcx,2891996D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74ca48f8-d2a8-402b-b3d0-dfdf1934c0e5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/45e35429-d789-4f51-bfdd-1ed6da0f1e51-diff.temp
index 6279093..d0e22e2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/45e35429-d789-4f51-bfdd-1ed6da0f1e51-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74ca48f8-d2a8-402b-b3d0-dfdf1934c0e5-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A0808]
+       mov       r11,7FFB47250808
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479508E8
-       mov       rdx,7FFB47920B40
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47950810
-       mov       rdx,7FFB47920A68
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C1930]
+       vdivsd    xmm0,xmm0,[7FFB478C1928]
-       vucomisd  xmm0,qword ptr [7FFB4789EF70]
-       vdivsd    xmm0,xmm0,[7FFB4789EF68]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476C6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E010
-       mov       rdx,7FFB4790E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476C6F48
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
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,15202022FC8
-       mov       rcx,2891996D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,15202022FC0
-       mov       rdx,2891996D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,15202022FC8
-       mov       rcx,2891996D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/715e1e75-dc0f-4b19-9d4e-c2db84417d76-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f5be3f7f-ee47-417c-92a6-af190caeaf3a-diff.temp
index 6279093..35cae84 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f5be3f7f-ee47-417c-92a6-af190caeaf3a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/715e1e75-dc0f-4b19-9d4e-c2db84417d76-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB47880808]
+       mov       r11,7FFB47230808
-       call      qword ptr [7FFB478907F8]
-       mov       r11,7FFB472307F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930920
-       mov       rdx,7FFB47920B40
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478907F0]
-       mov       r11,7FFB472307F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930848
-       mov       rdx,7FFB47920A68
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A3150]
+       vdivsd    xmm0,xmm0,[7FFB478A3148]
-       vucomisd  xmm0,qword ptr [7FFB4789EF70]
-       vdivsd    xmm0,xmm0,[7FFB4789EF68]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       rdx,7FFB476C6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476C6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E040
-       mov       rdx,7FFB4790E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
        mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476C6F48
        mov       ecx,4D
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4773AF50
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,193651ED2F0
-       mov       rcx,2891996D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,193651ED2E8
-       mov       rdx,2891996D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,193651ED2F0
-       mov       rcx,2891996D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/932be03f-ae05-45bb-9996-ab0991afa3ee-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9ffdbe18-e211-4770-a5bf-9503b17b32d8-diff.temp
index 6279093..2411203 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9ffdbe18-e211-4770-a5bf-9503b17b32d8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/932be03f-ae05-45bb-9996-ab0991afa3ee-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478B07F8]
+       mov       r11,7FFB472507F8
-       call      qword ptr [7FFB478A07F8]
-       mov       r11,7FFB472407F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478B07F0]
+       mov       r11,7FFB472507F0
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47940B98
-       mov       rdx,7FFB47930B28
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478B07F0]
+       mov       r11,7FFB472507F0
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47940AC0
-       mov       rdx,7FFB47930A50
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478BF690]
+       vdivsd    xmm0,xmm0,[7FFB478BF688]
-       vucomisd  xmm0,qword ptr [7FFB478AEF90]
-       vdivsd    xmm0,xmm0,[7FFB478AEF88]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E288
-       mov       rdx,7FFB4791E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1B35657D2F0
-       mov       rcx,290F4EED2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1B35657D2E8
-       mov       rdx,290F4EED2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1B35657D2F0
-       mov       rcx,290F4EED2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/32fe54be-30c6-4066-ba1b-69959e3e05a4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/229494d3-b1b1-44c1-969e-dd56abe2b5da-diff.temp
index 2e87ad7..3971cfb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/229494d3-b1b1-44c1-969e-dd56abe2b5da-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/32fe54be-30c6-4066-ba1b-69959e3e05a4-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930AC0
-       mov       rdx,7FFB47930A50
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B2740]
+       vdivsd    xmm0,xmm0,[7FFB478B2738]
-       vucomisd  xmm0,qword ptr [7FFB478AEF90]
-       vdivsd    xmm0,xmm0,[7FFB478AEF88]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       rdx,7FFB476D6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1C2A4DB2FC8
-       mov       rcx,290F4EED2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1C2A4DB2FC0
-       mov       rdx,290F4EED2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1C2A4DB2FC8
-       mov       rcx,290F4EED2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9be8df6e-9234-4715-98b9-3e4120bcb8a1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c47d8d6c-acf2-43cd-b113-1f06529a58b3-diff.temp
index 2e87ad7..a89ffa2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c47d8d6c-acf2-43cd-b113-1f06529a58b3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9be8df6e-9234-4715-98b9-3e4120bcb8a1-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930AC0
-       mov       rdx,7FFB47930A50
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B2740]
+       vdivsd    xmm0,xmm0,[7FFB478B2738]
-       vucomisd  xmm0,qword ptr [7FFB478AEF90]
-       vdivsd    xmm0,xmm0,[7FFB478AEF88]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       rdx,7FFB476D6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1AFF335D2F0
-       mov       rcx,290F4EED2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1AFF335D2E8
-       mov       rdx,290F4EED2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1AFF335D2F0
-       mov       rcx,290F4EED2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3ecb9313-cce9-4e3f-8e27-b00d9933f967-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/80ba4e1a-9d43-4fbd-8a80-96e73f8f13cd-diff.temp
index 2e87ad7..bf8798a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/80ba4e1a-9d43-4fbd-8a80-96e73f8f13cd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3ecb9313-cce9-4e3f-8e27-b00d9933f967-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478A07F8]
-       mov       r11,7FFB472407F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F0]
+       mov       r11,7FFB472707F0
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47960B98
-       mov       rdx,7FFB47930B28
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F0]
+       mov       r11,7FFB472707F0
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47960AC0
-       mov       rdx,7FFB47930A50
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478E2760]
+       vdivsd    xmm0,xmm0,[7FFB478E2758]
-       vucomisd  xmm0,qword ptr [7FFB478AEF90]
-       vdivsd    xmm0,xmm0,[7FFB478AEF88]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E288
-       mov       rdx,7FFB4791E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477733C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,24A9D59D2F0
-       mov       rcx,290F4EED2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,24A9D59D2E8
-       mov       rdx,290F4EED2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,24A9D59D2F0
-       mov       rcx,290F4EED2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1973ccb1-103e-49e8-add8-d37757bdc475-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7eeb0192-c255-4abe-9f17-d46392243ba1-diff.temp
index 2e87ad7..d0e22e2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7eeb0192-c255-4abe-9f17-d46392243ba1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1973ccb1-103e-49e8-add8-d37757bdc475-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A0808]
+       mov       r11,7FFB47250808
-       call      qword ptr [7FFB478A07F8]
-       mov       r11,7FFB472407F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479508E8
-       mov       rdx,7FFB47930B28
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47950810
-       mov       rdx,7FFB47930A50
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C1930]
+       vdivsd    xmm0,xmm0,[7FFB478C1928]
-       vucomisd  xmm0,qword ptr [7FFB478AEF90]
-       vdivsd    xmm0,xmm0,[7FFB478AEF88]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E010
-       mov       rdx,7FFB4791E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,15202022FC8
-       mov       rcx,290F4EED2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,15202022FC0
-       mov       rdx,290F4EED2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,15202022FC8
-       mov       rcx,290F4EED2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74d5f6e1-b4b2-4828-8e81-2f72eaddba36-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0d333cdd-ace9-45a9-b2b7-e23db7284a0c-diff.temp
index 2e87ad7..35cae84 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0d333cdd-ace9-45a9-b2b7-e23db7284a0c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74d5f6e1-b4b2-4828-8e81-2f72eaddba36-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB47880808]
+       mov       r11,7FFB47230808
-       call      qword ptr [7FFB478A07F8]
-       mov       r11,7FFB472407F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930920
-       mov       rdx,7FFB47930B28
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930848
-       mov       rdx,7FFB47930A50
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A3150]
+       vdivsd    xmm0,xmm0,[7FFB478A3148]
-       vucomisd  xmm0,qword ptr [7FFB478AEF90]
-       vdivsd    xmm0,xmm0,[7FFB478AEF88]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E040
-       mov       rdx,7FFB4791E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF50
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,193651ED2F0
-       mov       rcx,290F4EED2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,193651ED2E8
-       mov       rdx,290F4EED2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,193651ED2F0
-       mov       rcx,290F4EED2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/092c0e76-1d45-4d5b-805d-a870932c5f42-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/419e07ce-4b86-4cc7-a648-e1d9cfddf94c-diff.temp
index 2e87ad7..2411203 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/419e07ce-4b86-4cc7-a648-e1d9cfddf94c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/092c0e76-1d45-4d5b-805d-a870932c5f42-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A07F8]
+       mov       r11,7FFB472407F8
-       call      qword ptr [7FFB478B07F8]
-       mov       r11,7FFB472507F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A07F0]
+       mov       r11,7FFB472407F0
-       call      qword ptr [7FFB478B07F0]
-       mov       r11,7FFB472507F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930B98
-       mov       rdx,7FFB47940B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A07F0]
+       mov       r11,7FFB472407F0
-       call      qword ptr [7FFB478B07F0]
-       mov       r11,7FFB472507F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930AC0
-       mov       rdx,7FFB47940AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B2740]
+       vdivsd    xmm0,xmm0,[7FFB478B2738]
-       vucomisd  xmm0,qword ptr [7FFB478BF690]
-       vdivsd    xmm0,xmm0,[7FFB478BF688]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E288
-       mov       rdx,7FFB4792E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
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
+       mov       rdx,7FFB477433C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1C2A4DB2FC8
-       mov       rcx,1B35657D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1C2A4DB2FC0
-       mov       rdx,1B35657D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1C2A4DB2FC8
-       mov       rcx,1B35657D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d12967f4-f35c-4e01-961a-3aa11cdc30a8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0d7101b1-518e-48c0-82f0-b612c4f52021-diff.temp
index 3971cfb..a89ffa2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0d7101b1-518e-48c0-82f0-b612c4f52021-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d12967f4-f35c-4e01-961a-3aa11cdc30a8-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A07F8]
+       mov       r11,7FFB472407F8
-       call      qword ptr [7FFB478B07F8]
-       mov       r11,7FFB472507F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A07F0]
+       mov       r11,7FFB472407F0
-       call      qword ptr [7FFB478B07F0]
-       mov       r11,7FFB472507F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930B98
-       mov       rdx,7FFB47940B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A07F0]
+       mov       r11,7FFB472407F0
-       call      qword ptr [7FFB478B07F0]
-       mov       r11,7FFB472507F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930AC0
-       mov       rdx,7FFB47940AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478B2740]
+       vdivsd    xmm0,xmm0,[7FFB478B2738]
-       vucomisd  xmm0,qword ptr [7FFB478BF690]
-       vdivsd    xmm0,xmm0,[7FFB478BF688]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E288
-       mov       rdx,7FFB4792E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
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
+       mov       rdx,7FFB477433C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1AFF335D2F0
-       mov       rcx,1B35657D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1AFF335D2E8
-       mov       rdx,1B35657D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1AFF335D2F0
-       mov       rcx,1B35657D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c7fb2e3a-835f-4ced-80a3-f0ace5903775-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c8e6b77a-9975-4ef0-beae-d847b5377997-diff.temp
index 3971cfb..bf8798a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c8e6b77a-9975-4ef0-beae-d847b5377997-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c7fb2e3a-835f-4ced-80a3-f0ace5903775-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478B07F8]
-       mov       r11,7FFB472507F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F0]
+       mov       r11,7FFB472707F0
-       call      qword ptr [7FFB478B07F0]
-       mov       r11,7FFB472507F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47960B98
-       mov       rdx,7FFB47940B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F0]
+       mov       r11,7FFB472707F0
-       call      qword ptr [7FFB478B07F0]
-       mov       r11,7FFB472507F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47960AC0
-       mov       rdx,7FFB47940AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478E2760]
+       vdivsd    xmm0,xmm0,[7FFB478E2758]
-       vucomisd  xmm0,qword ptr [7FFB478BF690]
-       vdivsd    xmm0,xmm0,[7FFB478BF688]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E288
-       mov       rdx,7FFB4792E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477733C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,24A9D59D2F0
-       mov       rcx,1B35657D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,24A9D59D2E8
-       mov       rdx,1B35657D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,24A9D59D2F0
-       mov       rcx,1B35657D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a7bf917f-6611-46a5-8ef1-b5f8fbf99f33-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/79a35abd-1123-4386-97cc-38ee5af1b9b3-diff.temp
index 3971cfb..d0e22e2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/79a35abd-1123-4386-97cc-38ee5af1b9b3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a7bf917f-6611-46a5-8ef1-b5f8fbf99f33-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A0808]
+       mov       r11,7FFB47250808
-       call      qword ptr [7FFB478B07F8]
-       mov       r11,7FFB472507F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478B07F0]
-       mov       r11,7FFB472507F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479508E8
-       mov       rdx,7FFB47940B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478B07F0]
-       mov       r11,7FFB472507F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47950810
-       mov       rdx,7FFB47940AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C1930]
+       vdivsd    xmm0,xmm0,[7FFB478C1928]
-       vucomisd  xmm0,qword ptr [7FFB478BF690]
-       vdivsd    xmm0,xmm0,[7FFB478BF688]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       rdx,7FFB476E6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E010
-       mov       rdx,7FFB4792E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
        mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4775AF70
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,15202022FC8
-       mov       rcx,1B35657D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,15202022FC0
-       mov       rdx,1B35657D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,15202022FC8
-       mov       rcx,1B35657D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e4675c5f-a7ba-4021-bc54-22c5f2ea785e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/55bd223a-a8e6-41d7-bca1-deb8c00be0c8-diff.temp
index 3971cfb..35cae84 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/55bd223a-a8e6-41d7-bca1-deb8c00be0c8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e4675c5f-a7ba-4021-bc54-22c5f2ea785e-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB47880808]
+       mov       r11,7FFB47230808
-       call      qword ptr [7FFB478B07F8]
-       mov       r11,7FFB472507F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478B07F0]
-       mov       r11,7FFB472507F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930920
-       mov       rdx,7FFB47940B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478B07F0]
-       mov       r11,7FFB472507F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930848
-       mov       rdx,7FFB47940AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A3150]
+       vdivsd    xmm0,xmm0,[7FFB478A3148]
-       vucomisd  xmm0,qword ptr [7FFB478BF690]
-       vdivsd    xmm0,xmm0,[7FFB478BF688]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E040
-       mov       rdx,7FFB4792E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF50
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,193651ED2F0
-       mov       rcx,1B35657D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,193651ED2E8
-       mov       rdx,1B35657D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,193651ED2F0
-       mov       rcx,1B35657D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/94f030b8-b243-4bcc-a901-0f0aea6b4be4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bfa7a5ec-c9e7-4f95-a0ae-8f6d71aa4397-diff.temp
index 3971cfb..2411203 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bfa7a5ec-c9e7-4f95-a0ae-8f6d71aa4397-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/94f030b8-b243-4bcc-a901-0f0aea6b4be4-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a02d8570-6229-4ded-9357-abd464d9825a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0db3b3a8-434d-4f21-a3cd-3c4b73fffdd9-diff.temp
index a89ffa2..bf8798a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0db3b3a8-434d-4f21-a3cd-3c4b73fffdd9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a02d8570-6229-4ded-9357-abd464d9825a-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478A07F8]
-       mov       r11,7FFB472407F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F0]
+       mov       r11,7FFB472707F0
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47960B98
-       mov       rdx,7FFB47930B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F0]
+       mov       r11,7FFB472707F0
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47960AC0
-       mov       rdx,7FFB47930AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478E2760]
+       vdivsd    xmm0,xmm0,[7FFB478E2758]
-       vucomisd  xmm0,qword ptr [7FFB478B2740]
-       vdivsd    xmm0,xmm0,[7FFB478B2738]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E288
-       mov       rdx,7FFB4791E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477733C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,24A9D59D2F0
-       mov       rcx,1C2A4DB2FC8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,24A9D59D2E8
-       mov       rdx,1C2A4DB2FC0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,24A9D59D2F0
-       mov       rcx,1C2A4DB2FC8
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a504557b-ac5c-4723-969e-dcad1106292f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/afa46cb5-26eb-49cf-91da-009036e5bf28-diff.temp
index a89ffa2..d0e22e2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/afa46cb5-26eb-49cf-91da-009036e5bf28-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a504557b-ac5c-4723-969e-dcad1106292f-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A0808]
+       mov       r11,7FFB47250808
-       call      qword ptr [7FFB478A07F8]
-       mov       r11,7FFB472407F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479508E8
-       mov       rdx,7FFB47930B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47950810
-       mov       rdx,7FFB47930AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C1930]
+       vdivsd    xmm0,xmm0,[7FFB478C1928]
-       vucomisd  xmm0,qword ptr [7FFB478B2740]
-       vdivsd    xmm0,xmm0,[7FFB478B2738]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E010
-       mov       rdx,7FFB4791E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,15202022FC8
-       mov       rcx,1C2A4DB2FC8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,15202022FC0
-       mov       rdx,1C2A4DB2FC0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,15202022FC8
-       mov       rcx,1C2A4DB2FC8
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/48b30cca-fdd4-44f7-896d-0857c7b4f9b2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5e4d0104-1ff2-4876-9c23-177f0d5fa927-diff.temp
index a89ffa2..35cae84 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5e4d0104-1ff2-4876-9c23-177f0d5fa927-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/48b30cca-fdd4-44f7-896d-0857c7b4f9b2-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB47880808]
+       mov       r11,7FFB47230808
-       call      qword ptr [7FFB478A07F8]
-       mov       r11,7FFB472407F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930920
-       mov       rdx,7FFB47930B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930848
-       mov       rdx,7FFB47930AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A3150]
+       vdivsd    xmm0,xmm0,[7FFB478A3148]
-       vucomisd  xmm0,qword ptr [7FFB478B2740]
-       vdivsd    xmm0,xmm0,[7FFB478B2738]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E040
-       mov       rdx,7FFB4791E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF50
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,193651ED2F0
-       mov       rcx,1C2A4DB2FC8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,193651ED2E8
-       mov       rdx,1C2A4DB2FC0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,193651ED2F0
-       mov       rcx,1C2A4DB2FC8
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/715100b8-b370-4da7-80d5-c370e70ad7ad-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e14c6966-2c86-4db9-a2f0-a5f8985a6940-diff.temp
index a89ffa2..2411203 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e14c6966-2c86-4db9-a2f0-a5f8985a6940-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/715100b8-b370-4da7-80d5-c370e70ad7ad-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478D07F8]
+       mov       r11,7FFB472707F8
-       call      qword ptr [7FFB478A07F8]
-       mov       r11,7FFB472407F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478D07F0]
+       mov       r11,7FFB472707F0
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47960B98
-       mov       rdx,7FFB47930B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478D07F0]
+       mov       r11,7FFB472707F0
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47960AC0
-       mov       rdx,7FFB47930AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478E2760]
+       vdivsd    xmm0,xmm0,[7FFB478E2758]
-       vucomisd  xmm0,qword ptr [7FFB478B2740]
-       vdivsd    xmm0,xmm0,[7FFB478B2738]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E288
-       mov       rdx,7FFB4791E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477733C0
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,24A9D59D2F0
-       mov       rcx,1AFF335D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,24A9D59D2E8
-       mov       rdx,1AFF335D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,24A9D59D2F0
-       mov       rcx,1AFF335D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/02ebda4f-d17e-4d7c-9fb5-819ffeef81e6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0627ebc1-b789-4266-a9e8-43d0de223f4b-diff.temp
index bf8798a..d0e22e2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0627ebc1-b789-4266-a9e8-43d0de223f4b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/02ebda4f-d17e-4d7c-9fb5-819ffeef81e6-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A0808]
+       mov       r11,7FFB47250808
-       call      qword ptr [7FFB478A07F8]
-       mov       r11,7FFB472407F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479508E8
-       mov       rdx,7FFB47930B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47950810
-       mov       rdx,7FFB47930AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C1930]
+       vdivsd    xmm0,xmm0,[7FFB478C1928]
-       vucomisd  xmm0,qword ptr [7FFB478B2740]
-       vdivsd    xmm0,xmm0,[7FFB478B2738]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E010
-       mov       rdx,7FFB4791E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,15202022FC8
-       mov       rcx,1AFF335D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,15202022FC0
-       mov       rdx,1AFF335D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,15202022FC8
-       mov       rcx,1AFF335D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/46aece25-9514-4118-a065-a421add2f1a8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d77c3f7f-4edb-4909-9674-60e181b873f6-diff.temp
index bf8798a..35cae84 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d77c3f7f-4edb-4909-9674-60e181b873f6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/46aece25-9514-4118-a065-a421add2f1a8-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB47880808]
+       mov       r11,7FFB47230808
-       call      qword ptr [7FFB478A07F8]
-       mov       r11,7FFB472407F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930920
-       mov       rdx,7FFB47930B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478A07F0]
-       mov       r11,7FFB472407F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930848
-       mov       rdx,7FFB47930AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A3150]
+       vdivsd    xmm0,xmm0,[7FFB478A3148]
-       vucomisd  xmm0,qword ptr [7FFB478B2740]
-       vdivsd    xmm0,xmm0,[7FFB478B2738]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E040
-       mov       rdx,7FFB4791E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF50
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,193651ED2F0
-       mov       rcx,1AFF335D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,193651ED2E8
-       mov       rdx,1AFF335D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,193651ED2F0
-       mov       rcx,1AFF335D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63b56d8b-3f91-45d0-a073-dab202a22b51-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/be6e840d-bd95-4e8f-a745-da338e55c09e-diff.temp
index bf8798a..2411203 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/be6e840d-bd95-4e8f-a745-da338e55c09e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63b56d8b-3f91-45d0-a073-dab202a22b51-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB478A0808]
+       mov       r11,7FFB47250808
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478D07F0]
-       mov       r11,7FFB472707F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB479508E8
-       mov       rdx,7FFB47960B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB478A0800]
+       mov       r11,7FFB47250800
-       call      qword ptr [7FFB478D07F0]
-       mov       r11,7FFB472707F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47950810
-       mov       rdx,7FFB47960AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478C1930]
+       vdivsd    xmm0,xmm0,[7FFB478C1928]
-       vucomisd  xmm0,qword ptr [7FFB478E2760]
-       vdivsd    xmm0,xmm0,[7FFB478E2758]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E010
-       mov       rdx,7FFB4794E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,15202022FC8
-       mov       rcx,24A9D59D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,15202022FC0
-       mov       rdx,24A9D59D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,15202022FC8
-       mov       rcx,24A9D59D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ff064845-b3b5-4e29-bdb6-1686256c52ef-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/38182cac-7dbe-4462-8796-74cf65cacc95-diff.temp
index d0e22e2..35cae84 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/38182cac-7dbe-4462-8796-74cf65cacc95-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ff064845-b3b5-4e29-bdb6-1686256c52ef-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB47880808]
+       mov       r11,7FFB47230808
-       call      qword ptr [7FFB478D07F8]
-       mov       r11,7FFB472707F8
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478D07F0]
-       mov       r11,7FFB472707F0
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930920
-       mov       rdx,7FFB47960B98
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478D07F0]
-       mov       r11,7FFB472707F0
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930848
-       mov       rdx,7FFB47960AC0
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A3150]
+       vdivsd    xmm0,xmm0,[7FFB478A3148]
-       vucomisd  xmm0,qword ptr [7FFB478E2760]
-       vdivsd    xmm0,xmm0,[7FFB478E2758]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E040
-       mov       rdx,7FFB4794E288
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF50
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,193651ED2F0
-       mov       rcx,24A9D59D2F0
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,193651ED2E8
-       mov       rdx,24A9D59D2E8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,193651ED2F0
-       mov       rcx,24A9D59D2F0
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ec9cc4a3-156c-4eba-841e-4de9d46596fa-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fdda6fea-8786-487a-a056-00ddbceace5b-diff.temp
index d0e22e2..2411203 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fdda6fea-8786-487a-a056-00ddbceace5b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ec9cc4a3-156c-4eba-841e-4de9d46596fa-diff.temp
```
**Diff for HaveItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       rcx,rsp
 M04_L07:
        jmp       short M04_L08
+       call      qword ptr [7FFB47880808]
+       mov       r11,7FFB47230808
-       call      qword ptr [7FFB478A0808]
-       mov       r11,7FFB47250808
        mov       rcx,rbx
 M04_L06:
        jmp       short M04_L07
        mov       dword ptr [rbp+0FFC4],1
        jmp       short M04_L06
        jne       short M04_L02
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478A0800]
-       mov       r11,7FFB47250800
        mov       rcx,rbx
        jne       short M04_L05
        test      eax,eax
        call      qword ptr [rax+18]
        lea       rdx,[rbp+0FFB0]
        mov       rcx,[rax+8]
        mov       rax,rsi
        mov       [rbp+0FFB8],rcx
        mov       rcx,[rbp+0FFD0]
        mov       [rbp+0FFB0],rcx
        mov       rcx,[rbp+0FFC8]
        call      qword ptr [r11]
        mov       rcx,rbx
        lea       rdx,[rbp+0FFC8]
 M04_L04:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930920
-       mov       rdx,7FFB479508E8
        mov       rcx,rdi
 M04_L03:
        jmp       short M04_L04
        je        short M04_L03
        test      r11,r11
        mov       r11,[r14+18]
 M04_L02:
        je        short M04_L06
        test      eax,eax
+       call      qword ptr [7FFB47880800]
+       mov       r11,7FFB47230800
-       call      qword ptr [7FFB478A0800]
-       mov       r11,7FFB47250800
        mov       rcx,rbx
        mov       [rbp+0FFA8],rbx
        mov       rbx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M04_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47930848
-       mov       rdx,7FFB47950810
        mov       rcx,rdi
 M04_L00:
        jmp       short M04_L01
        je        short M04_L00
        test      r11,r11
        mov       r11,[r14+10]
        mov       r14,[rdi+10]
        je        near ptr M04_L10
        test      rsi,rsi
        je        near ptr M04_L09
        test      rbx,rbx
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rbp+0FFD8],rcx
        mov       [rbp+0FFA0],rsp
        mov       [rbp+0FFD0],rax
        xor       eax,eax
        vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
        vxorps    xmm4,xmm4,xmm4
        lea       rbp,[rsp+80]
        sub       rsp,60
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
 ; Total bytes of code 190
        ret
        pop       rsi
        add       rsp,60
        movzx     eax,al
        seta      al
+       vucomisd  xmm0,qword ptr [7FFB478A3150]
+       vdivsd    xmm0,xmm0,[7FFB478A3148]
-       vucomisd  xmm0,qword ptr [7FFB478C1930]
-       vdivsd    xmm0,xmm0,[7FFB478C1928]
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
        mov       rsi,[rdx+8]
        mov       [rsp+38],rax
        mov       [rsp+30],rax
        xor       eax,eax
        vzeroupper
        sub       rsp,60
        push      rsi
 ; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
 ; Total bytes of code 169
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,0A1
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M02_L02:
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       rax,rdi
        call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       rdx,rsi
        mov       rcx,rdi
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rdx
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791E040
-       mov       rdx,7FFB4793E010
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF50
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
 ; Total bytes of code 198
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,193651ED2F0
-       mov       rcx,15202022FC8
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,193651ED2E8
-       mov       rdx,15202022FC0
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,193651ED2F0
-       mov       rcx,15202022FC8
        mov       rsi,[rsi+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
        mov       rdx,rax
        call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
        mov       rdx,[rsi+258]
        mov       rsi,rcx
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/96044543-83ca-4553-9476-8cea2531df3e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/642becec-e3d8-42c6-ad39-554513ada32e-diff.temp
index 35cae84..2411203 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/642becec-e3d8-42c6-ad39-554513ada32e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/96044543-83ca-4553-9476-8cea2531df3e-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E088
-       mov       rdx,7FFB4791E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/222cd7c4-6617-4c72-a360-01ed8013ffeb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/71129c1c-06a5-4ca3-9c3b-4d5068213e7e-diff.temp
index 41b4287..0a8e9d2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/71129c1c-06a5-4ca3-9c3b-4d5068213e7e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/222cd7c4-6617-4c72-a360-01ed8013ffeb-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E088
-       mov       rdx,7FFB4791E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7b7a2082-5fe3-44cd-b21b-dcb3c0a50392-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/71bab994-c00c-4e9e-b6e2-f985c71cfcec-diff.temp
index 41b4287..0a8e9d2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/71bab994-c00c-4e9e-b6e2-f985c71cfcec-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7b7a2082-5fe3-44cd-b21b-dcb3c0a50392-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E088
-       mov       rdx,7FFB4791E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/53f5c8dc-6268-489d-9b36-af7df8f95b9d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e85b8b37-5d91-4246-9184-f256d6288511-diff.temp
index 41b4287..9d96930 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e85b8b37-5d91-4246-9184-f256d6288511-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/53f5c8dc-6268-489d-9b36-af7df8f95b9d-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E088
-       mov       rdx,7FFB4791E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/20276a13-6004-42ba-af75-52568b423ee8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ef5f266d-1c6a-408e-b54e-321e9635b22e-diff.temp
index 41b4287..0a8e9d2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ef5f266d-1c6a-408e-b54e-321e9635b22e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/20276a13-6004-42ba-af75-52568b423ee8-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E088
-       mov       rdx,7FFB4791E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9fd2a8e2-a3b5-40a1-acb8-760c40fb3637-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d9d6b558-318b-4387-bdd3-dfc1bb1cb9fe-diff.temp
index 41b4287..0a8e9d2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d9d6b558-318b-4387-bdd3-dfc1bb1cb9fe-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9fd2a8e2-a3b5-40a1-acb8-760c40fb3637-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DE10
-       mov       rdx,7FFB4791E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
        mov       rdx,7FFB476D6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476D6F48
        mov       ecx,4D
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4774AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cfb27134-c6ef-4d10-991f-a44743e766dd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e90cda9a-96fc-4035-a146-d67dfe13f430-diff.temp
index 41b4287..63da150 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e90cda9a-96fc-4035-a146-d67dfe13f430-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cfb27134-c6ef-4d10-991f-a44743e766dd-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DE10
-       mov       rdx,7FFB4791E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/34dfb764-a22c-4649-bbd3-0301be075d87-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ad31b7d8-236e-45a3-b635-927b2ec16c3e-diff.temp
index 41b4287..33deb4a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ad31b7d8-236e-45a3-b635-927b2ec16c3e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/34dfb764-a22c-4649-bbd3-0301be075d87-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E088
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/10439a53-740a-4606-b845-4ce1974bce5d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d3a490a3-91c4-45a9-b51e-52eb3660ebaf-diff.temp
index 0a8e9d2..9d96930 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d3a490a3-91c4-45a9-b51e-52eb3660ebaf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/10439a53-740a-4606-b845-4ce1974bce5d-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DE10
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB4774AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/908b237a-838c-4a92-8b99-732fc8feaf31-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0866db5a-924e-4549-84f9-101debf35be9-diff.temp
index 0a8e9d2..63da150 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0866db5a-924e-4549-84f9-101debf35be9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/908b237a-838c-4a92-8b99-732fc8feaf31-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DE10
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2538bb6f-8b53-425b-aff3-827adf2d35cd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8ace1b78-8531-475d-97a4-1094018cea55-diff.temp
index 0a8e9d2..33deb4a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8ace1b78-8531-475d-97a4-1094018cea55-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2538bb6f-8b53-425b-aff3-827adf2d35cd-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E088
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b776fc36-293a-42d9-ad4f-6b77967ba164-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9173bcbf-9eab-4e0a-84bf-2f1a767adcd0-diff.temp
index 0a8e9d2..9d96930 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9173bcbf-9eab-4e0a-84bf-2f1a767adcd0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b776fc36-293a-42d9-ad4f-6b77967ba164-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DE10
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB4774AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1ad92980-3ab8-4bc5-ace5-c6af2af3c1b2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b9893034-e44b-42ce-acf2-17fb000c968c-diff.temp
index 0a8e9d2..63da150 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b9893034-e44b-42ce-acf2-17fb000c968c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1ad92980-3ab8-4bc5-ace5-c6af2af3c1b2-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DE10
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/526ebff2-3e36-455b-bd87-78743a2527a0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e8e40731-3b58-4433-ac3c-343f81ff2e48-diff.temp
index 0a8e9d2..33deb4a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e8e40731-3b58-4433-ac3c-343f81ff2e48-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/526ebff2-3e36-455b-bd87-78743a2527a0-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E088
-       mov       rdx,7FFB4792E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
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
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/776abec4-2ae3-4ef1-b6df-d7c75b059cb6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7d3ef224-28c9-447e-9240-990d63f34da0-diff.temp
index 9d96930..0a8e9d2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7d3ef224-28c9-447e-9240-990d63f34da0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/776abec4-2ae3-4ef1-b6df-d7c75b059cb6-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E088
-       mov       rdx,7FFB4792E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
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
+       mov       rdx,7FFB477633C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b83c3805-023b-456b-a149-839f0ddea087-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f01131a-9bda-48c7-8621-921759b663c7-diff.temp
index 9d96930..0a8e9d2 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f01131a-9bda-48c7-8621-921759b663c7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b83c3805-023b-456b-a149-839f0ddea087-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DE10
-       mov       rdx,7FFB4792E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476D6F48
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
+       mov       rdx,7FFB4774AF70
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c4a1952e-eefd-4c17-8f27-d457bd2f5578-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8b96f37f-0a50-47c4-a33d-a5a275943f0f-diff.temp
index 9d96930..63da150 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8b96f37f-0a50-47c4-a33d-a5a275943f0f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c4a1952e-eefd-4c17-8f27-d457bd2f5578-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DE10
-       mov       rdx,7FFB4792E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF70
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5798238b-9bf8-452f-9442-35b21a3fb205-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c9835719-1e63-48f3-996a-b35d2c981645-diff.temp
index 9d96930..33deb4a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c9835719-1e63-48f3-996a-b35d2c981645-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5798238b-9bf8-452f-9442-35b21a3fb205-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DE10
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB4774AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63dec109-d9de-4529-9afd-8f5c652a432f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/37101f4a-86e5-4f79-8b89-892fb271751c-diff.temp
index 0a8e9d2..63da150 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/37101f4a-86e5-4f79-8b89-892fb271751c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63dec109-d9de-4529-9afd-8f5c652a432f-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DE10
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7b945fde-62f4-406e-834d-0566d618985f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a1af66d4-3477-449f-b065-4fcd0ffaea5f-diff.temp
index 0a8e9d2..33deb4a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a1af66d4-3477-449f-b065-4fcd0ffaea5f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7b945fde-62f4-406e-834d-0566d618985f-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792DE10
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB4774AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6bd2a4e2-9158-45b7-8fb5-934cb9466df9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bdfc194f-9100-4652-b683-1a3e33365cba-diff.temp
index 0a8e9d2..63da150 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bdfc194f-9100-4652-b683-1a3e33365cba-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6bd2a4e2-9158-45b7-8fb5-934cb9466df9-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DE10
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1038829b-3f39-42db-9bf9-c6c6732421bc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c0de53b-544b-4a3a-8508-74222323d0a5-diff.temp
index 0a8e9d2..33deb4a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c0de53b-544b-4a3a-8508-74222323d0a5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1038829b-3f39-42db-9bf9-c6c6732421bc-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4791DE10
-       mov       rdx,7FFB4792DE10
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476D6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4773AF70
-       mov       rdx,7FFB4774AF70
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
 ; Total bytes of code 94
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4fd31806-4266-4bc2-8a7f-07e11640c2d3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/35fc12c0-3eab-4034-a0c3-3a6e85c25756-diff.temp
index 63da150..33deb4a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/35fc12c0-3eab-4034-a0c3-3a6e85c25756-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4fd31806-4266-4bc2-8a7f-07e11640c2d3-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E088
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/99b5cfd0-bcfc-476e-a1c2-edc1f68eeec6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/057a4777-cee6-4aa0-b56b-d70d8f308f7e-diff.temp
index 77885ab..5f8b451 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/057a4777-cee6-4aa0-b56b-d70d8f308f7e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/99b5cfd0-bcfc-476e-a1c2-edc1f68eeec6-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E088
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d8ea4940-064f-400a-975e-a95a495db50e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3cfcc955-cc96-4eac-83a8-51bd050d27e2-diff.temp
index 77885ab..6a2d4f3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3cfcc955-cc96-4eac-83a8-51bd050d27e2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d8ea4940-064f-400a-975e-a95a495db50e-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E088
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0d9bcf50-0e97-4a22-ad9f-c5d6e621c394-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0daa7562-2aec-4209-8ee5-8a7331a92b60-diff.temp
index 77885ab..6a2d4f3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0daa7562-2aec-4209-8ee5-8a7331a92b60-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0d9bcf50-0e97-4a22-ad9f-c5d6e621c394-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E088
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/58ef804e-2a83-4d7e-a974-452ed5f7b134-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4c70591a-5329-45d8-b23e-fcd8e23095b7-diff.temp
index 77885ab..2e74a31 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4c70591a-5329-45d8-b23e-fcd8e23095b7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/58ef804e-2a83-4d7e-a974-452ed5f7b134-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E088
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/40f1e3d3-8760-41c4-9b08-3ce0492b5614-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b064f919-89f2-4357-86dd-e378b23fec5d-diff.temp
index 77885ab..5f8b451 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b064f919-89f2-4357-86dd-e378b23fec5d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/40f1e3d3-8760-41c4-9b08-3ce0492b5614-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE10
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c8c85a12-1220-48bf-a486-a92f326ec6f8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/11de9861-e832-4123-89a5-f183da1238db-diff.temp
index 77885ab..9f80e78 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/11de9861-e832-4123-89a5-f183da1238db-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c8c85a12-1220-48bf-a486-a92f326ec6f8-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE10
-       mov       rdx,7FFB4793E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
        mov       rdx,7FFB476F6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476F6F48
        mov       ecx,4D
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4776AF70
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9613152f-9892-4af8-825c-ac725716ba0d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/277b80fc-4ad9-4cad-b1e0-74de2c8873fe-diff.temp
index 77885ab..c628faf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/277b80fc-4ad9-4cad-b1e0-74de2c8873fe-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9613152f-9892-4af8-825c-ac725716ba0d-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E088
-       mov       rdx,7FFB4794E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8fd00051-0466-4254-a142-54528ec66c4f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8b59965b-ef1f-471e-b914-af2cac6a9ce7-diff.temp
index 5f8b451..6a2d4f3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8b59965b-ef1f-471e-b914-af2cac6a9ce7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8fd00051-0466-4254-a142-54528ec66c4f-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E088
-       mov       rdx,7FFB4794E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB476C6F48
-       mov       rdx,7FFB47706F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/97cdc591-8ab5-4888-bab3-1aff4d4a9e45-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/26bf5abe-f930-4e54-8d3d-13221555c78b-diff.temp
index 5f8b451..6a2d4f3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/26bf5abe-f930-4e54-8d3d-13221555c78b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/97cdc591-8ab5-4888-bab3-1aff4d4a9e45-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E088
-       mov       rdx,7FFB4794E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/444bae15-d8bb-4fca-b783-29ac60554ca3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bebe2e4d-8539-444b-8ffd-ab767919d763-diff.temp
index 5f8b451..2e74a31 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bebe2e4d-8539-444b-8ffd-ab767919d763-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/444bae15-d8bb-4fca-b783-29ac60554ca3-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE10
-       mov       rdx,7FFB4794E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7e8b3982-7791-4ae2-8e2d-ed17a69a0046-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ffc1ee6d-3add-423c-923d-6ba2436f8f6b-diff.temp
index 5f8b451..9f80e78 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ffc1ee6d-3add-423c-923d-6ba2436f8f6b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7e8b3982-7791-4ae2-8e2d-ed17a69a0046-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE10
-       mov       rdx,7FFB4794E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB4776AF70
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d1e157ff-56c3-4d3f-8c58-c8247e6a7c2f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0d43c4d8-aff3-4d4f-aaf7-e7fb51089de7-diff.temp
index 5f8b451..c628faf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0d43c4d8-aff3-4d4f-aaf7-e7fb51089de7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d1e157ff-56c3-4d3f-8c58-c8247e6a7c2f-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E088
-       mov       rdx,7FFB4790E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB477533C0
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/879baded-46cf-41f1-8fde-180d6b04d9c1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ab91bc34-4880-45ed-a6c2-5a25ca01df8e-diff.temp
index 6a2d4f3..2e74a31 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ab91bc34-4880-45ed-a6c2-5a25ca01df8e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/879baded-46cf-41f1-8fde-180d6b04d9c1-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E088
-       mov       rdx,7FFB4790E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476C6F48
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
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/17e90a12-bae8-4ee6-a032-1b5ca69fd954-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/409579a9-e28d-4bb0-9c34-bbdd834844c0-diff.temp
index 6a2d4f3..5f8b451 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/409579a9-e28d-4bb0-9c34-bbdd834844c0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/17e90a12-bae8-4ee6-a032-1b5ca69fd954-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE10
-       mov       rdx,7FFB4790E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476C6F48
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
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/96f3099d-fad5-4375-9a9e-0fde2ac8e4e8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5ebd110b-27a0-4cbe-8219-284d9637be74-diff.temp
index 6a2d4f3..9f80e78 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5ebd110b-27a0-4cbe-8219-284d9637be74-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/96f3099d-fad5-4375-9a9e-0fde2ac8e4e8-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE10
-       mov       rdx,7FFB4790E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4776AF70
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ac8da90b-a91f-4bc4-a329-36193f33304e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b411663a-4fbf-4065-b18d-336d2eec8840-diff.temp
index 6a2d4f3..c628faf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b411663a-4fbf-4065-b18d-336d2eec8840-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ac8da90b-a91f-4bc4-a329-36193f33304e-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E088
-       mov       rdx,7FFB4790E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB477533C0
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b8769034-df78-4413-be4a-6dba875c7dbb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ff6cbabb-d4e9-4d21-9441-5f09ecd391a9-diff.temp
index 6a2d4f3..2e74a31 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ff6cbabb-d4e9-4d21-9441-5f09ecd391a9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b8769034-df78-4413-be4a-6dba875c7dbb-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E088
-       mov       rdx,7FFB4790E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB47706F48
-       mov       rdx,7FFB476C6F48
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
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/13906fdd-7d39-41d2-804b-75241d14165c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b13b6de7-9f4d-440c-be51-f6a22a1c4220-diff.temp
index 6a2d4f3..5f8b451 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b13b6de7-9f4d-440c-be51-f6a22a1c4220-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/13906fdd-7d39-41d2-804b-75241d14165c-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE10
-       mov       rdx,7FFB4790E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476E6F48
-       mov       rdx,7FFB476C6F48
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
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4e404f3e-12d2-4122-96c0-4fa3372fed0d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f4b717c-4e2f-4d3e-904c-8a0f3829754d-diff.temp
index 6a2d4f3..9f80e78 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f4b717c-4e2f-4d3e-904c-8a0f3829754d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4e404f3e-12d2-4122-96c0-4fa3372fed0d-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE10
-       mov       rdx,7FFB4790E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476C6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
-       mov       rdx,7FFB476C6F48
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
+       mov       rdx,7FFB4776AF70
-       mov       rdx,7FFB477333C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74ca0a43-2ed6-410f-baf3-42d4d428ad0d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/92d9a4e8-2db8-4c07-bdd5-0932b20a64d0-diff.temp
index 6a2d4f3..c628faf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/92d9a4e8-2db8-4c07-bdd5-0932b20a64d0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/74ca0a43-2ed6-410f-baf3-42d4d428ad0d-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E088
-       mov       rdx,7FFB4792E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB477733C0
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cce8e3b1-a81c-47b5-a5fc-56c16d0e7e8d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1931f841-faf0-4034-aed8-588dbd21b3cb-diff.temp
index 2e74a31..5f8b451 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1931f841-faf0-4034-aed8-588dbd21b3cb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cce8e3b1-a81c-47b5-a5fc-56c16d0e7e8d-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE10
-       mov       rdx,7FFB4792E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
        mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
        mov       rdx,7FFB476E6F48
        mov       ecx,4D
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4775AF70
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d76b875e-a076-438e-b549-7bcea74f96f8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7885370a-14e4-407b-8c66-d151ff25a0d4-diff.temp
index 2e74a31..9f80e78 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7885370a-14e4-407b-8c66-d151ff25a0d4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d76b875e-a076-438e-b549-7bcea74f96f8-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE10
-       mov       rdx,7FFB4792E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
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
+       mov       rdx,7FFB4776AF70
-       mov       rdx,7FFB477533C0
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5e8c3a85-f56e-4f97-8141-fcebc4442e93-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c90accec-3be9-4ac8-94ec-403d4540dd60-diff.temp
index 2e74a31..c628faf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c90accec-3be9-4ac8-94ec-403d4540dd60-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5e8c3a85-f56e-4f97-8141-fcebc4442e93-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793DE10
-       mov       rdx,7FFB4794E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/18f668ec-53dc-4265-9c07-328138c61b8c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f49a3d37-1bee-452c-b2d1-3d0476edefa7-diff.temp
index 5f8b451..9f80e78 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f49a3d37-1bee-452c-b2d1-3d0476edefa7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/18f668ec-53dc-4265-9c07-328138c61b8c-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE10
-       mov       rdx,7FFB4794E088
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
+       mov       rdx,7FFB4776AF70
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/787f8351-76c3-49f1-bde2-f772371acdda-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/55b1038f-4c85-4407-8af2-1c1516d59047-diff.temp
index 5f8b451..c628faf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/55b1038f-4c85-4407-8af2-1c1516d59047-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/787f8351-76c3-49f1-bde2-f772371acdda-diff.temp
```
**Diff for HaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794DE10
-       mov       rdx,7FFB4793DE10
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rax+20]
        je        short M02_L02
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
 ; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
-       mov       rdx,7FFB476E6F48
        mov       ecx,77B
        mov       rsi,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB476F6F48
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
+       mov       rdx,7FFB4776AF70
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
 ; Total bytes of code 91
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],dil
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9a922577-7dbf-4fc0-9060-fc6d6e00d9e8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e3267b0f-6984-4ae0-a921-cc6f21783eac-diff.temp
index 9f80e78..c628faf 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e3267b0f-6984-4ae0-a921-cc6f21783eac-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9a922577-7dbf-4fc0-9060-fc6d6e00d9e8-diff.temp
```
