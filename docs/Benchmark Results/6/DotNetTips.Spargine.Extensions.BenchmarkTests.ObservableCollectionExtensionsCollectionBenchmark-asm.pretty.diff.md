## DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark-20220530-175658
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,19BDD6C6D78
-       mov       rax,1A4E60E2970
        mov       rbp,[rax]
+       mov       rax,19BDD6C3020
-       mov       rax,1A5060E3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457F20
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,19BDD6C6D78
-       mov       r9,1A4E60E2970
        mov       r8,[r8]
+       mov       r8,19BDD6C3020
-       mov       r8,1A5060E3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457A50
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8b7bcae6-9c59-4b78-86a6-91bfc7ebd676-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/81ad11c4-a93b-4b2d-9713-d3255bf4f436-diff.temp
index 27d41f5..2a12770 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/81ad11c4-a93b-4b2d-9713-d3255bf4f436-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8b7bcae6-9c59-4b78-86a6-91bfc7ebd676-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,15D218F2170
-       mov       rax,1A4E60E2970
        mov       rbp,[rax]
+       mov       rax,15D018F3020
-       mov       rax,1A5060E3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447F20
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,15D218F2170
-       mov       r9,1A4E60E2970
        mov       r8,[r8]
+       mov       r8,15D018F3020
-       mov       r8,1A5060E3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A50
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/03051f23-9b98-4b0a-a32d-f70adb0ef6b0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/79b9583b-9169-4de3-bf24-fb78b72834ae-diff.temp
index 27d41f5..0abcb00 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/79b9583b-9169-4de3-bf24-fb78b72834ae-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/03051f23-9b98-4b0a-a32d-f70adb0ef6b0-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,2D795672190
-       mov       rax,1A4E60E2970
        mov       rbp,[rax]
+       mov       rax,2D795663020
-       mov       rax,1A5060E3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457F20
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2D795672190
-       mov       r9,1A4E60E2970
        mov       r8,[r8]
+       mov       r8,2D795663020
-       mov       r8,1A5060E3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457A50
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/68f8908a-e60f-4682-ac6d-aa32fddadd17-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8f015981-6696-49e4-8f58-0686926fdf2b-diff.temp
index 27d41f5..95b195a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8f015981-6696-49e4-8f58-0686926fdf2b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/68f8908a-e60f-4682-ac6d-aa32fddadd17-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1F2A8B03188
-       mov       rax,1A4E60E2970
        mov       rbp,[rax]
+       mov       rax,1F288B01028
-       mov       rax,1A5060E3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457F20
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1F2A8B03188
-       mov       r9,1A4E60E2970
        mov       r8,[r8]
+       mov       r8,1F288B01028
-       mov       r8,1A5060E3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457A50
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/30967b35-5520-4030-b433-d34435abf097-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/588ba4cd-7098-4faa-aab2-bf33e5e0b458-diff.temp
index 27d41f5..f9a0a51 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/588ba4cd-7098-4faa-aab2-bf33e5e0b458-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/30967b35-5520-4030-b433-d34435abf097-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1CC5FAC6D78
-       mov       rax,1A4E60E2970
        mov       rbp,[rax]
+       mov       rax,1CC5FAC3020
-       mov       rax,1A5060E3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF427ED8
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1CC5FAC6D78
-       mov       r9,1A4E60E2970
        mov       r8,[r8]
+       mov       r8,1CC5FAC3020
-       mov       r8,1A5060E3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF427A08
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/24ede635-3079-4cf2-a3a8-f5d58118fc3f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/111fd955-8323-48e4-95d9-03f3f646e01b-diff.temp
index 27d41f5..911e84b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/111fd955-8323-48e4-95d9-03f3f646e01b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/24ede635-3079-4cf2-a3a8-f5d58118fc3f-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,179D8E04168
-       mov       rax,1A4E60E2970
        mov       rbp,[rax]
+       mov       rax,179C8E01028
-       mov       rax,1A5060E3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,179D8E04168
-       mov       r9,1A4E60E2970
        mov       r8,[r8]
+       mov       r8,179C8E01028
-       mov       r8,1A5060E3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/545b1960-cb57-4446-b481-7b72bc210227-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0cdb411a-d9b8-481d-a81a-3f966db0f57a-diff.temp
index 27d41f5..5c626c6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0cdb411a-d9b8-481d-a81a-3f966db0f57a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/545b1960-cb57-4446-b481-7b72bc210227-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,27FA5D34968
-       mov       rax,1A4E60E2970
        mov       rbp,[rax]
+       mov       rax,27FC5D31028
-       mov       rax,1A5060E3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,27FA5D34968
-       mov       r9,1A4E60E2970
        mov       r8,[r8]
+       mov       r8,27FC5D31028
-       mov       r8,1A5060E3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d89ad6c1-026b-49a2-8772-e3f3e153594c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cc33d3d2-3e10-45ae-9cc1-c21061082662-diff.temp
index 27d41f5..80bd4d5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cc33d3d2-3e10-45ae-9cc1-c21061082662-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d89ad6c1-026b-49a2-8772-e3f3e153594c-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,15D218F2170
-       mov       rax,19BDD6C6D78
        mov       rbp,[rax]
+       mov       rax,15D018F3020
-       mov       rax,19BDD6C3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447F20
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,15D218F2170
-       mov       r9,19BDD6C6D78
        mov       r8,[r8]
+       mov       r8,15D018F3020
-       mov       r8,19BDD6C3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A50
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d05b9de9-6b08-44e5-a86f-18784a0e9446-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6ed69e44-c9fb-4ce4-9dd6-c8a878d2c9ce-diff.temp
index 2a12770..0abcb00 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6ed69e44-c9fb-4ce4-9dd6-c8a878d2c9ce-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d05b9de9-6b08-44e5-a86f-18784a0e9446-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2D795672190
-       mov       r9,19BDD6C6D78
        mov       r8,[r8]
+       mov       r8,2D795663020
-       mov       r8,19BDD6C3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFAAF457A50
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f4714550-24a1-45e8-b8b0-bf9ecf105eb4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61846fe8-0461-41ae-8f72-bb4f64ad0406-diff.temp
index 2a12770..95b195a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61846fe8-0461-41ae-8f72-bb4f64ad0406-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f4714550-24a1-45e8-b8b0-bf9ecf105eb4-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1F2A8B03188
-       mov       r9,19BDD6C6D78
        mov       r8,[r8]
+       mov       r8,1F288B01028
-       mov       r8,19BDD6C3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFAAF457A50
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fe473731-06a9-4002-9aeb-d5a04a065aea-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1303e829-3780-4301-b608-04223ac834e5-diff.temp
index 2a12770..f9a0a51 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1303e829-3780-4301-b608-04223ac834e5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fe473731-06a9-4002-9aeb-d5a04a065aea-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1CC5FAC6D78
-       mov       rax,19BDD6C6D78
        mov       rbp,[rax]
+       mov       rax,1CC5FAC3020
-       mov       rax,19BDD6C3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF427ED8
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1CC5FAC6D78
-       mov       r9,19BDD6C6D78
        mov       r8,[r8]
+       mov       r8,1CC5FAC3020
-       mov       r8,19BDD6C3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF427A08
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/85f1219e-03af-4157-8fd0-fb6d9a817c00-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/543de895-745d-4cf6-95b7-8962caad2c33-diff.temp
index 2a12770..911e84b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/543de895-745d-4cf6-95b7-8962caad2c33-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/85f1219e-03af-4157-8fd0-fb6d9a817c00-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,179D8E04168
-       mov       rax,19BDD6C6D78
        mov       rbp,[rax]
+       mov       rax,179C8E01028
-       mov       rax,19BDD6C3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,179D8E04168
-       mov       r9,19BDD6C6D78
        mov       r8,[r8]
+       mov       r8,179C8E01028
-       mov       r8,19BDD6C3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/350b27ef-90f6-4867-9087-524af0361c18-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/52ba161b-7130-43c4-9acb-a805d99c6e9e-diff.temp
index 2a12770..5c626c6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/52ba161b-7130-43c4-9acb-a805d99c6e9e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/350b27ef-90f6-4867-9087-524af0361c18-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,27FA5D34968
-       mov       rax,19BDD6C6D78
        mov       rbp,[rax]
+       mov       rax,27FC5D31028
-       mov       rax,19BDD6C3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,27FA5D34968
-       mov       r9,19BDD6C6D78
        mov       r8,[r8]
+       mov       r8,27FC5D31028
-       mov       r8,19BDD6C3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5b6aaa64-e71d-4b5a-a20f-43a31dbbba9c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ab2e0eda-3974-4ade-a182-ba63c5ce896b-diff.temp
index 2a12770..80bd4d5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ab2e0eda-3974-4ade-a182-ba63c5ce896b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5b6aaa64-e71d-4b5a-a20f-43a31dbbba9c-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,2D795672190
-       mov       rax,15D218F2170
        mov       rbp,[rax]
+       mov       rax,2D795663020
-       mov       rax,15D018F3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457F20
-       mov       rdx,7FFAAF447F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,2D795672190
-       mov       r9,15D218F2170
        mov       r8,[r8]
+       mov       r8,2D795663020
-       mov       r8,15D018F3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457A50
-       mov       rdx,7FFAAF447A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c2841e2e-aee6-449f-8c32-b4d3b38a354d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/40f4246a-0c0b-48b5-b68d-2efb429ef536-diff.temp
index 0abcb00..95b195a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/40f4246a-0c0b-48b5-b68d-2efb429ef536-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c2841e2e-aee6-449f-8c32-b4d3b38a354d-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1F2A8B03188
-       mov       rax,15D218F2170
        mov       rbp,[rax]
+       mov       rax,1F288B01028
-       mov       rax,15D018F3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457F20
-       mov       rdx,7FFAAF447F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1F2A8B03188
-       mov       r9,15D218F2170
        mov       r8,[r8]
+       mov       r8,1F288B01028
-       mov       r8,15D018F3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457A50
-       mov       rdx,7FFAAF447A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7f1eae09-6e6c-41df-9baf-8f5dc373f93a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f1ee6a15-a942-4370-859c-ac5243d53b53-diff.temp
index 0abcb00..f9a0a51 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f1ee6a15-a942-4370-859c-ac5243d53b53-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7f1eae09-6e6c-41df-9baf-8f5dc373f93a-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1CC5FAC6D78
-       mov       rax,15D218F2170
        mov       rbp,[rax]
+       mov       rax,1CC5FAC3020
-       mov       rax,15D018F3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF427ED8
-       mov       rdx,7FFAAF447F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1CC5FAC6D78
-       mov       r9,15D218F2170
        mov       r8,[r8]
+       mov       r8,1CC5FAC3020
-       mov       r8,15D018F3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF427A08
-       mov       rdx,7FFAAF447A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4132e7d6-a70a-4e3e-b99a-f64fefa6738d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bb11495a-b62c-4481-8b68-1e9b460d7088-diff.temp
index 0abcb00..911e84b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bb11495a-b62c-4481-8b68-1e9b460d7088-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4132e7d6-a70a-4e3e-b99a-f64fefa6738d-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,179D8E04168
-       mov       rax,15D218F2170
        mov       rbp,[rax]
+       mov       rax,179C8E01028
-       mov       rax,15D018F3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF447F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,179D8E04168
-       mov       r9,15D218F2170
        mov       r8,[r8]
+       mov       r8,179C8E01028
-       mov       r8,15D018F3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF447A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aacefab4-019d-426f-b201-27bcc5cc3973-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6205147e-156b-4994-85f2-e86a95db7961-diff.temp
index 0abcb00..5c626c6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6205147e-156b-4994-85f2-e86a95db7961-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/aacefab4-019d-426f-b201-27bcc5cc3973-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,27FA5D34968
-       mov       rax,15D218F2170
        mov       rbp,[rax]
+       mov       rax,27FC5D31028
-       mov       rax,15D018F3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF447F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,27FA5D34968
-       mov       r9,15D218F2170
        mov       r8,[r8]
+       mov       r8,27FC5D31028
-       mov       r8,15D018F3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF447A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6bc1c79c-6714-4ba4-a62b-ad25cda73f6d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/018b3df9-e2c1-4b78-ad8f-45fb4dc47e71-diff.temp
index 0abcb00..80bd4d5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/018b3df9-e2c1-4b78-ad8f-45fb4dc47e71-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6bc1c79c-6714-4ba4-a62b-ad25cda73f6d-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1F2A8B03188
-       mov       r9,2D795672190
        mov       r8,[r8]
+       mov       r8,1F288B01028
-       mov       r8,2D795663020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFAAF457A50
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1a528088-5852-4535-bc6e-d9e79f15293b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ec675bc2-716d-4def-a6da-40657afd6ca9-diff.temp
index 95b195a..f9a0a51 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ec675bc2-716d-4def-a6da-40657afd6ca9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1a528088-5852-4535-bc6e-d9e79f15293b-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1CC5FAC6D78
-       mov       rax,2D795672190
        mov       rbp,[rax]
+       mov       rax,1CC5FAC3020
-       mov       rax,2D795663020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF427ED8
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1CC5FAC6D78
-       mov       r9,2D795672190
        mov       r8,[r8]
+       mov       r8,1CC5FAC3020
-       mov       r8,2D795663020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF427A08
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/18325760-0d28-437c-bdfa-dfed19bb48d1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6da89616-23e9-4978-910f-08d147d147df-diff.temp
index 95b195a..911e84b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6da89616-23e9-4978-910f-08d147d147df-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/18325760-0d28-437c-bdfa-dfed19bb48d1-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,179D8E04168
-       mov       rax,2D795672190
        mov       rbp,[rax]
+       mov       rax,179C8E01028
-       mov       rax,2D795663020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,179D8E04168
-       mov       r9,2D795672190
        mov       r8,[r8]
+       mov       r8,179C8E01028
-       mov       r8,2D795663020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fa9f668b-d830-40fa-9f1a-199b085de6d5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/24f2c91e-9dc8-4dda-8f48-4a8cbc0aaae9-diff.temp
index 95b195a..5c626c6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/24f2c91e-9dc8-4dda-8f48-4a8cbc0aaae9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fa9f668b-d830-40fa-9f1a-199b085de6d5-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,27FA5D34968
-       mov       rax,2D795672190
        mov       rbp,[rax]
+       mov       rax,27FC5D31028
-       mov       rax,2D795663020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,27FA5D34968
-       mov       r9,2D795672190
        mov       r8,[r8]
+       mov       r8,27FC5D31028
-       mov       r8,2D795663020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4505ebea-52e3-405e-b9fc-23824971a92b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2e790534-2ac9-44f0-b361-3851264148f9-diff.temp
index 95b195a..80bd4d5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2e790534-2ac9-44f0-b361-3851264148f9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4505ebea-52e3-405e-b9fc-23824971a92b-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1CC5FAC6D78
-       mov       rax,1F2A8B03188
        mov       rbp,[rax]
+       mov       rax,1CC5FAC3020
-       mov       rax,1F288B01028
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF427ED8
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1CC5FAC6D78
-       mov       r9,1F2A8B03188
        mov       r8,[r8]
+       mov       r8,1CC5FAC3020
-       mov       r8,1F288B01028
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF427A08
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ac6c90e6-3be8-4c7f-b798-40ce3c721ab6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b83692b6-3f29-4a5a-854f-027625ecd02b-diff.temp
index f9a0a51..911e84b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b83692b6-3f29-4a5a-854f-027625ecd02b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ac6c90e6-3be8-4c7f-b798-40ce3c721ab6-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,179D8E04168
-       mov       rax,1F2A8B03188
        mov       rbp,[rax]
+       mov       rax,179C8E01028
-       mov       rax,1F288B01028
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,179D8E04168
-       mov       r9,1F2A8B03188
        mov       r8,[r8]
+       mov       r8,179C8E01028
-       mov       r8,1F288B01028
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5aa5540c-7387-42e5-ab0e-50276d82b76e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/652002bc-d307-4fa4-a347-a2c25e5415f6-diff.temp
index f9a0a51..5c626c6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/652002bc-d307-4fa4-a347-a2c25e5415f6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5aa5540c-7387-42e5-ab0e-50276d82b76e-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,27FA5D34968
-       mov       rax,1F2A8B03188
        mov       rbp,[rax]
+       mov       rax,27FC5D31028
-       mov       rax,1F288B01028
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,27FA5D34968
-       mov       r9,1F2A8B03188
        mov       r8,[r8]
+       mov       r8,27FC5D31028
-       mov       r8,1F288B01028
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/910b2706-98bd-48f0-8256-8618307574e8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f2048e14-c3d2-4f60-acee-cb586ec2b7ab-diff.temp
index f9a0a51..80bd4d5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f2048e14-c3d2-4f60-acee-cb586ec2b7ab-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/910b2706-98bd-48f0-8256-8618307574e8-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,179D8E04168
-       mov       rax,1CC5FAC6D78
        mov       rbp,[rax]
+       mov       rax,179C8E01028
-       mov       rax,1CC5FAC3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF427ED8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,179D8E04168
-       mov       r9,1CC5FAC6D78
        mov       r8,[r8]
+       mov       r8,179C8E01028
-       mov       r8,1CC5FAC3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF427A08
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ce4f208e-de91-4d32-9ee4-7e277f2f37a3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f85ab15-78ba-4011-9e9f-22cfbd1f1a05-diff.temp
index 911e84b..5c626c6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f85ab15-78ba-4011-9e9f-22cfbd1f1a05-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ce4f208e-de91-4d32-9ee4-7e277f2f37a3-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,27FA5D34968
-       mov       rax,1CC5FAC6D78
        mov       rbp,[rax]
+       mov       rax,27FC5D31028
-       mov       rax,1CC5FAC3020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF427ED8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,27FA5D34968
-       mov       r9,1CC5FAC6D78
        mov       r8,[r8]
+       mov       r8,27FC5D31028
-       mov       r8,1CC5FAC3020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF427A08
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61cda803-a57a-44bf-90db-886b236929ca-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fc6409d6-3a82-46c9-bfe6-5eb370e1452a-diff.temp
index 911e84b..80bd4d5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fc6409d6-3a82-46c9-bfe6-5eb370e1452a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61cda803-a57a-44bf-90db-886b236929ca-diff.temp
```
**Diff for HasItems02 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,27FA5D34968
-       mov       rax,179D8E04168
        mov       rbp,[rax]
+       mov       rax,27FC5D31028
-       mov       rax,179C8E01028
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF447ED8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,27FA5D34968
-       mov       r9,179D8E04168
        mov       r8,[r8]
+       mov       r8,27FC5D31028
-       mov       r8,179C8E01028
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF447A08
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/265a6040-0533-4c93-b10d-7b9dde00ca4e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5a88ba5a-69a4-4394-a9e7-d606596b74d0-diff.temp
index 5c626c6..80bd4d5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5a88ba5a-69a4-4394-a9e7-d606596b74d0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/265a6040-0533-4c93-b10d-7b9dde00ca4e-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,24876063D68
-       mov       rax,2095304E5A0
        mov       rbp,[rax]
+       mov       rax,24876061028
-       mov       rax,20933043020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF437F20
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,24876063D68
-       mov       r9,2095304E5A0
        mov       r8,[r8]
+       mov       r8,24876061028
-       mov       r8,20933043020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF437A50
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d3be9d88-af2a-46a5-a78a-614d84e06b06-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0e9948dc-906e-4f07-83d6-fc5c8aacc069-diff.temp
index ed011e4..e2d5e40 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0e9948dc-906e-4f07-83d6-fc5c8aacc069-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d3be9d88-af2a-46a5-a78a-614d84e06b06-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,267FD922970
-       mov       r9,2095304E5A0
        mov       r8,[r8]
+       mov       r8,2681D923020
-       mov       r8,20933043020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFAAF457A50
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e99720db-2d3d-441a-94a0-012266689467-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/365fe8ac-8853-4e24-9ce6-80aa5f7aa7b0-diff.temp
index ed011e4..56dc201 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/365fe8ac-8853-4e24-9ce6-80aa5f7aa7b0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e99720db-2d3d-441a-94a0-012266689467-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1D7BDF51958
-       mov       rax,2095304E5A0
        mov       rbp,[rax]
+       mov       rax,1D7ADF53020
-       mov       rax,20933043020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF437F20
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1D7BDF51958
-       mov       r9,2095304E5A0
        mov       r8,[r8]
+       mov       r8,1D7ADF53020
-       mov       r8,20933043020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF437A50
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/95b799ac-2557-47ab-8801-c6348117e64f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a473a646-d08e-425b-bbeb-2a6c0bc33ac5-diff.temp
index ed011e4..a886f23 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a473a646-d08e-425b-bbeb-2a6c0bc33ac5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/95b799ac-2557-47ab-8801-c6348117e64f-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1B5B3712970
-       mov       rax,2095304E5A0
        mov       rbp,[rax]
+       mov       rax,1B5D3713020
-       mov       rax,20933043020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF437F20
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B5B3712970
-       mov       r9,2095304E5A0
        mov       r8,[r8]
+       mov       r8,1B5D3713020
-       mov       r8,20933043020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF437A50
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b66a28ac-b780-45a9-bf3b-8ae09679553a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c03ddbb-822a-46c3-a44b-4c01724c76b9-diff.temp
index ed011e4..05a8d09 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c03ddbb-822a-46c3-a44b-4c01724c76b9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b66a28ac-b780-45a9-bf3b-8ae09679553a-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,219F1515D60
-       mov       rax,2095304E5A0
        mov       rbp,[rax]
+       mov       rax,219F1513020
-       mov       rax,20933043020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,219F1515D60
-       mov       r9,2095304E5A0
        mov       r8,[r8]
+       mov       r8,219F1513020
-       mov       r8,20933043020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/165d8a47-e0ea-45a2-aff0-93524e85e91f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/713906a7-c328-4874-ae7e-0eb50c83734a-diff.temp
index ed011e4..c478c4f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/713906a7-c328-4874-ae7e-0eb50c83734a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/165d8a47-e0ea-45a2-aff0-93524e85e91f-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,13C399139C0
-       mov       rax,2095304E5A0
        mov       rbp,[rax]
+       mov       rax,13C39903020
-       mov       rax,20933043020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467ED8
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,13C399139C0
-       mov       r9,2095304E5A0
        mov       r8,[r8]
+       mov       r8,13C39903020
-       mov       r8,20933043020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467A08
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cb581535-1574-413b-9108-595b887516f0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4df7d8f4-81d3-4a20-824c-303400c3a60b-diff.temp
index ed011e4..9fdb48f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4df7d8f4-81d3-4a20-824c-303400c3a60b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/cb581535-1574-413b-9108-595b887516f0-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1B956812190
-       mov       rax,2095304E5A0
        mov       rbp,[rax]
+       mov       rax,1B956803020
-       mov       rax,20933043020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B956812190
-       mov       r9,2095304E5A0
        mov       r8,[r8]
+       mov       r8,1B956803020
-       mov       r8,20933043020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0275de1f-2cc5-43b6-8a72-bd61abd9f6f4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/44c7cbb1-2728-43d2-83d7-10e75338eae1-diff.temp
index ed011e4..c437eb7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/44c7cbb1-2728-43d2-83d7-10e75338eae1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0275de1f-2cc5-43b6-8a72-bd61abd9f6f4-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,267FD922970
-       mov       rax,24876063D68
        mov       rbp,[rax]
+       mov       rax,2681D923020
-       mov       rax,24876061028
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457F20
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,267FD922970
-       mov       r9,24876063D68
        mov       r8,[r8]
+       mov       r8,2681D923020
-       mov       r8,24876061028
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF457A50
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8a2fc739-6b1c-4fe8-8b62-74c547653c58-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/56313c59-4d6e-44be-b87c-7105d16b1df8-diff.temp
index e2d5e40..56dc201 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/56313c59-4d6e-44be-b87c-7105d16b1df8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8a2fc739-6b1c-4fe8-8b62-74c547653c58-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1D7BDF51958
-       mov       r9,24876063D68
        mov       r8,[r8]
+       mov       r8,1D7ADF53020
-       mov       r8,24876061028
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFAAF437A50
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dd0d4954-c653-4b7e-a791-dec22de5924d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c79a47d-3fba-4f90-baf9-5877263ab6b6-diff.temp
index e2d5e40..a886f23 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c79a47d-3fba-4f90-baf9-5877263ab6b6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dd0d4954-c653-4b7e-a791-dec22de5924d-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B5B3712970
-       mov       r9,24876063D68
        mov       r8,[r8]
+       mov       r8,1B5D3713020
-       mov       r8,24876061028
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFAAF437A50
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/33f92d09-4656-441b-b331-8707448feafe-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98c17286-7cb6-490c-9dab-c13f6805a479-diff.temp
index e2d5e40..05a8d09 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98c17286-7cb6-490c-9dab-c13f6805a479-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/33f92d09-4656-441b-b331-8707448feafe-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,219F1515D60
-       mov       rax,24876063D68
        mov       rbp,[rax]
+       mov       rax,219F1513020
-       mov       rax,24876061028
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,219F1515D60
-       mov       r9,24876063D68
        mov       r8,[r8]
+       mov       r8,219F1513020
-       mov       r8,24876061028
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/82d8712a-36d9-494b-abdd-9bb042c85f52-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/10b75728-21df-4ed9-b07e-8851e18dd02d-diff.temp
index e2d5e40..c478c4f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/10b75728-21df-4ed9-b07e-8851e18dd02d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/82d8712a-36d9-494b-abdd-9bb042c85f52-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,13C399139C0
-       mov       rax,24876063D68
        mov       rbp,[rax]
+       mov       rax,13C39903020
-       mov       rax,24876061028
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467ED8
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,13C399139C0
-       mov       r9,24876063D68
        mov       r8,[r8]
+       mov       r8,13C39903020
-       mov       r8,24876061028
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467A08
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4207edb1-e623-4db6-84c7-3f30c461425d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1c118f7e-0ce4-495d-87ee-a7512f520cf2-diff.temp
index e2d5e40..9fdb48f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1c118f7e-0ce4-495d-87ee-a7512f520cf2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4207edb1-e623-4db6-84c7-3f30c461425d-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1B956812190
-       mov       rax,24876063D68
        mov       rbp,[rax]
+       mov       rax,1B956803020
-       mov       rax,24876061028
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B956812190
-       mov       r9,24876063D68
        mov       r8,[r8]
+       mov       r8,1B956803020
-       mov       r8,24876061028
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/df94f04d-988b-4f30-88d3-dee994ef00d5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d1d5a4d2-5796-4db3-a6ac-54eca1a0c9d2-diff.temp
index e2d5e40..c437eb7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d1d5a4d2-5796-4db3-a6ac-54eca1a0c9d2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/df94f04d-988b-4f30-88d3-dee994ef00d5-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1D7BDF51958
-       mov       rax,267FD922970
        mov       rbp,[rax]
+       mov       rax,1D7ADF53020
-       mov       rax,2681D923020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF437F20
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1D7BDF51958
-       mov       r9,267FD922970
        mov       r8,[r8]
+       mov       r8,1D7ADF53020
-       mov       r8,2681D923020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF437A50
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6905a4a1-8cbd-4cdc-9e9b-b1d1c46a3731-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1dbb9a91-a1e1-49d1-8fb3-4b756ca055bc-diff.temp
index 56dc201..a886f23 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1dbb9a91-a1e1-49d1-8fb3-4b756ca055bc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6905a4a1-8cbd-4cdc-9e9b-b1d1c46a3731-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1B5B3712970
-       mov       rax,267FD922970
        mov       rbp,[rax]
+       mov       rax,1B5D3713020
-       mov       rax,2681D923020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF437F20
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B5B3712970
-       mov       r9,267FD922970
        mov       r8,[r8]
+       mov       r8,1B5D3713020
-       mov       r8,2681D923020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF437A50
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5ffbc612-296e-4f56-ab17-80a38c01b08d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ce5f57d8-4859-4537-bd30-da53100f9279-diff.temp
index 56dc201..05a8d09 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ce5f57d8-4859-4537-bd30-da53100f9279-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5ffbc612-296e-4f56-ab17-80a38c01b08d-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,219F1515D60
-       mov       rax,267FD922970
        mov       rbp,[rax]
+       mov       rax,219F1513020
-       mov       rax,2681D923020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,219F1515D60
-       mov       r9,267FD922970
        mov       r8,[r8]
+       mov       r8,219F1513020
-       mov       r8,2681D923020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e64cd1fe-09fe-42b2-8c24-10b5536d1494-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/516e4a6b-a73c-43b1-993a-a725a0f289c6-diff.temp
index 56dc201..c478c4f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/516e4a6b-a73c-43b1-993a-a725a0f289c6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e64cd1fe-09fe-42b2-8c24-10b5536d1494-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,13C399139C0
-       mov       rax,267FD922970
        mov       rbp,[rax]
+       mov       rax,13C39903020
-       mov       rax,2681D923020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467ED8
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,13C399139C0
-       mov       r9,267FD922970
        mov       r8,[r8]
+       mov       r8,13C39903020
-       mov       r8,2681D923020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467A08
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9f57b0a1-0725-40e5-bef9-18d06f61b6fb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7e165c16-c554-4ccd-9966-fb670264b93b-diff.temp
index 56dc201..9fdb48f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7e165c16-c554-4ccd-9966-fb670264b93b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9f57b0a1-0725-40e5-bef9-18d06f61b6fb-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1B956812190
-       mov       rax,267FD922970
        mov       rbp,[rax]
+       mov       rax,1B956803020
-       mov       rax,2681D923020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF457F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B956812190
-       mov       r9,267FD922970
        mov       r8,[r8]
+       mov       r8,1B956803020
-       mov       r8,2681D923020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF457A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c987c65b-9344-4282-82a0-6d2ccde5894d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/240d8260-2fc9-4e08-9c61-e2d6b3da48fe-diff.temp
index 56dc201..c437eb7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/240d8260-2fc9-4e08-9c61-e2d6b3da48fe-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c987c65b-9344-4282-82a0-6d2ccde5894d-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B5B3712970
-       mov       r9,1D7BDF51958
        mov       r8,[r8]
+       mov       r8,1B5D3713020
-       mov       r8,1D7ADF53020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,7FFAAF437A50
        mov       rcx,rsi
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/88f7ebb4-60c4-476a-b706-4b6caa9d4ae8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b6f4d32d-39c0-41ff-b936-7b3b7db19c98-diff.temp
index a886f23..05a8d09 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b6f4d32d-39c0-41ff-b936-7b3b7db19c98-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/88f7ebb4-60c4-476a-b706-4b6caa9d4ae8-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,219F1515D60
-       mov       rax,1D7BDF51958
        mov       rbp,[rax]
+       mov       rax,219F1513020
-       mov       rax,1D7ADF53020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,219F1515D60
-       mov       r9,1D7BDF51958
        mov       r8,[r8]
+       mov       r8,219F1513020
-       mov       r8,1D7ADF53020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fa7deee9-9a6a-4977-8da1-ed6b2d939f42-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63ecb2c0-cf37-45a6-a77d-735f5ce136b0-diff.temp
index a886f23..c478c4f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63ecb2c0-cf37-45a6-a77d-735f5ce136b0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fa7deee9-9a6a-4977-8da1-ed6b2d939f42-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,13C399139C0
-       mov       rax,1D7BDF51958
        mov       rbp,[rax]
+       mov       rax,13C39903020
-       mov       rax,1D7ADF53020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467ED8
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,13C399139C0
-       mov       r9,1D7BDF51958
        mov       r8,[r8]
+       mov       r8,13C39903020
-       mov       r8,1D7ADF53020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467A08
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/648b66b9-a5a8-477b-a4c8-f583cb87728f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/30d98290-8d05-476c-8c15-3cd4abe6cc48-diff.temp
index a886f23..9fdb48f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/30d98290-8d05-476c-8c15-3cd4abe6cc48-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/648b66b9-a5a8-477b-a4c8-f583cb87728f-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1B956812190
-       mov       rax,1D7BDF51958
        mov       rbp,[rax]
+       mov       rax,1B956803020
-       mov       rax,1D7ADF53020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B956812190
-       mov       r9,1D7BDF51958
        mov       r8,[r8]
+       mov       r8,1B956803020
-       mov       r8,1D7ADF53020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/59775dad-e213-48c8-8781-513c3c0b57cb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f40124e4-fbeb-4ece-b85a-49b090782bfb-diff.temp
index a886f23..c437eb7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f40124e4-fbeb-4ece-b85a-49b090782bfb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/59775dad-e213-48c8-8781-513c3c0b57cb-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,219F1515D60
-       mov       rax,1B5B3712970
        mov       rbp,[rax]
+       mov       rax,219F1513020
-       mov       rax,1B5D3713020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447ED8
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,219F1515D60
-       mov       r9,1B5B3712970
        mov       r8,[r8]
+       mov       r8,219F1513020
-       mov       r8,1B5D3713020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF447A08
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9d4b812a-fa94-4282-95b1-0c22b79e3650-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f4dfc07f-834b-4a0a-b4af-04c05e496a27-diff.temp
index 05a8d09..c478c4f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f4dfc07f-834b-4a0a-b4af-04c05e496a27-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9d4b812a-fa94-4282-95b1-0c22b79e3650-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,13C399139C0
-       mov       rax,1B5B3712970
        mov       rbp,[rax]
+       mov       rax,13C39903020
-       mov       rax,1B5D3713020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467ED8
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,13C399139C0
-       mov       r9,1B5B3712970
        mov       r8,[r8]
+       mov       r8,13C39903020
-       mov       r8,1B5D3713020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467A08
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d397b38b-cd3a-49aa-b617-cf286e827a93-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6dc95541-4859-4afe-b546-2e8bb059bfdb-diff.temp
index 05a8d09..9fdb48f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6dc95541-4859-4afe-b546-2e8bb059bfdb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d397b38b-cd3a-49aa-b617-cf286e827a93-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1B956812190
-       mov       rax,1B5B3712970
        mov       rbp,[rax]
+       mov       rax,1B956803020
-       mov       rax,1B5D3713020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF437F20
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B956812190
-       mov       r9,1B5B3712970
        mov       r8,[r8]
+       mov       r8,1B956803020
-       mov       r8,1B5D3713020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF437A50
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9aeb4695-1dfa-4092-8738-a1366631d6f7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f3651b42-be0f-4825-8340-b0aeddc3b814-diff.temp
index 05a8d09..c437eb7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f3651b42-be0f-4825-8340-b0aeddc3b814-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9aeb4695-1dfa-4092-8738-a1366631d6f7-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,13C399139C0
-       mov       rax,219F1515D60
        mov       rbp,[rax]
+       mov       rax,13C39903020
-       mov       rax,219F1513020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467ED8
-       mov       rdx,7FFAAF447ED8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,13C399139C0
-       mov       r9,219F1515D60
        mov       r8,[r8]
+       mov       r8,13C39903020
-       mov       r8,219F1513020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF467A08
-       mov       rdx,7FFAAF447A08
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/17f8ea3b-cdaa-411e-9b42-2fb7d6f1efa6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/92c14d95-0d68-4b2c-9fa5-38c477961f35-diff.temp
index c478c4f..9fdb48f 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/92c14d95-0d68-4b2c-9fa5-38c477961f35-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/17f8ea3b-cdaa-411e-9b42-2fb7d6f1efa6-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1B956812190
-       mov       rax,219F1515D60
        mov       rbp,[rax]
+       mov       rax,1B956803020
-       mov       rax,219F1513020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF447ED8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B956812190
-       mov       r9,219F1515D60
        mov       r8,[r8]
+       mov       r8,1B956803020
-       mov       r8,219F1513020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF447A08
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b637c215-3e11-469c-b090-c0504533f3d0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0ebc34e0-cebf-48f1-94db-2746d9fddfc0-diff.temp
index c478c4f..c437eb7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0ebc34e0-cebf-48f1-94db-2746d9fddfc0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b637c215-3e11-469c-b090-c0504533f3d0-diff.temp
```
**Diff for HasItems01 method between:**
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
.NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```diff
call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
        mov       rcx,rax
        call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
        mov       rcx,rbp
        mov       rdx,r14
        mov       r8,rax
        call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
        mov       r14,[rax]
+       mov       rax,1B956812190
-       mov       rax,13C399139C0
        mov       rbp,[rax]
+       mov       rax,1B956803020
-       mov       rax,13C39903020
        jne       short M02_L00
        test      eax,eax
        movzx     eax,al
        setne     al
        test      rbx,rbx
        mov       rbx,rdx
        mov       rdi,[rsi+10]
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r14
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 ; Total bytes of code 153
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        mov       rax,rsi
        call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rdx,rdi
        mov       rcx,rsi
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47BA10
-       mov       rdx,7FFAAF467ED8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[rbx+18]
        mov       rdi,rax
        call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
        mov       rdx,rdi
        mov       r9,[r9]
+       mov       r9,1B956812190
-       mov       r9,13C399139C0
        mov       r8,[r8]
+       mov       r8,1B956803020
-       mov       r8,13C39903020
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFAAF47B540
-       mov       rdx,7FFAAF467A08
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
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
 ; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
 ; Total bytes of code 84
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rax+54],dil
        mov       rax,[rsi+20]
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e4477a00-05fc-499c-8955-20e7859cf9e4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a26d8210-62b3-4bb2-b655-556eac1c3aa8-diff.temp
index 9fdb48f..c437eb7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a26d8210-62b3-4bb2-b655-556eac1c3aa8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e4477a00-05fc-499c-8955-20e7859cf9e4-diff.temp
```
