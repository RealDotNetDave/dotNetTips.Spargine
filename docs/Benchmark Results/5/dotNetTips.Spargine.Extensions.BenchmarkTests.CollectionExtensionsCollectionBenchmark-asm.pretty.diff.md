## dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark-20210828-151927
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD290648]
+       mov       r11,7FF7ACE70648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD290648]
+       mov       r11,7FF7ACE70648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD290640]
+       mov       r11,7FF7ACE70640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A87B0
-       mov       rdx,7FF7AD3B87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A84F8
-       mov       rdx,7FF7AD3B84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD290640]
+       mov       r11,7FF7ACE70640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A84C8
-       mov       rdx,7FF7AD3B84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A84A8
-       mov       rdx,7FF7AD3B84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8468
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8708
-       mov       rdx,7FF7AD3B8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8468
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8468
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/221dc861-4379-4818-b74c-c765c4355f44-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/58030e81-9d2a-49e5-96e8-c5186119a31d-diff.temp
index c55b432..8976c46 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/58030e81-9d2a-49e5-96e8-c5186119a31d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/221dc861-4379-4818-b74c-c765c4355f44-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8C00
-       mov       rdx,7FF7AD3B87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8948
-       mov       rdx,7FF7AD3B84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8918
-       mov       rdx,7FF7AD3B84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88F8
-       mov       rdx,7FF7AD3B84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88B8
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8B58
-       mov       rdx,7FF7AD3B8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88B8
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88B8
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/502053dd-bcb5-4df0-bed0-e4de63a22ecb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/47037c67-ef8f-444e-ad7b-161d3600ef48-diff.temp
index c55b432..9d61c4a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/47037c67-ef8f-444e-ad7b-161d3600ef48-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/502053dd-bcb5-4df0-bed0-e4de63a22ecb-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8C18
-       mov       rdx,7FF7AD3B87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8960
-       mov       rdx,7FF7AD3B84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8930
-       mov       rdx,7FF7AD3B84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8910
-       mov       rdx,7FF7AD3B84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B70
-       mov       rdx,7FF7AD3B8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2a728cd4-dd4d-4db3-9105-dd3019243ff1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e8e2838a-4a72-4a04-96b4-2056c61508ca-diff.temp
index c55b432..f5f1f03 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e8e2838a-4a72-4a04-96b4-2056c61508ca-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2a728cd4-dd4d-4db3-9105-dd3019243ff1-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8C18
-       mov       rdx,7FF7AD3B87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8960
-       mov       rdx,7FF7AD3B84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8930
-       mov       rdx,7FF7AD3B84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8910
-       mov       rdx,7FF7AD3B84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B70
-       mov       rdx,7FF7AD3B8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/271a2b6e-dd70-4914-aa44-b99d3b16abbe-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/515603e8-fabf-4c0c-9197-3318e4d69209-diff.temp
index c55b432..f5f1f03 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/515603e8-fabf-4c0c-9197-3318e4d69209-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/271a2b6e-dd70-4914-aa44-b99d3b16abbe-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8C18
-       mov       rdx,7FF7AD3B87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8960
-       mov       rdx,7FF7AD3B84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8930
-       mov       rdx,7FF7AD3B84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8910
-       mov       rdx,7FF7AD3B84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8B70
-       mov       rdx,7FF7AD3B8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/736232b5-0e20-449d-8c99-aba0ab82aec4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3fb4249e-93a2-4ce9-83d2-b705c0989202-diff.temp
index c55b432..c64f91a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3fb4249e-93a2-4ce9-83d2-b705c0989202-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/736232b5-0e20-449d-8c99-aba0ab82aec4-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8BD8
-       mov       rdx,7FF7AD3B87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8920
-       mov       rdx,7FF7AD3B84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88F0
-       mov       rdx,7FF7AD3B84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3B84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B30
-       mov       rdx,7FF7AD3B8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3B8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bf38a5ff-f23d-4587-9fb7-d7c564472f08-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0f38819c-8bd0-4662-976c-42398da344f5-diff.temp
index c55b432..536a2a4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0f38819c-8bd0-4662-976c-42398da344f5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bf38a5ff-f23d-4587-9fb7-d7c564472f08-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8C00
-       mov       rdx,7FF7AD3A87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8948
-       mov       rdx,7FF7AD3A84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8918
-       mov       rdx,7FF7AD3A84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88F8
-       mov       rdx,7FF7AD3A84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88B8
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8B58
-       mov       rdx,7FF7AD3A8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88B8
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88B8
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/157e8117-f1c0-44e8-905c-54eac09228f8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ea34f190-d721-4d35-a19d-773154445046-diff.temp
index 8976c46..9d61c4a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ea34f190-d721-4d35-a19d-773154445046-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/157e8117-f1c0-44e8-905c-54eac09228f8-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8C18
-       mov       rdx,7FF7AD3A87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8960
-       mov       rdx,7FF7AD3A84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8930
-       mov       rdx,7FF7AD3A84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8910
-       mov       rdx,7FF7AD3A84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B70
-       mov       rdx,7FF7AD3A8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/56f11e54-d939-4a45-9fe6-995816f75bec-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b6d2c589-1326-4cf9-ba5a-7da7bc28618a-diff.temp
index 8976c46..f5f1f03 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b6d2c589-1326-4cf9-ba5a-7da7bc28618a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/56f11e54-d939-4a45-9fe6-995816f75bec-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8C18
-       mov       rdx,7FF7AD3A87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8960
-       mov       rdx,7FF7AD3A84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8930
-       mov       rdx,7FF7AD3A84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8910
-       mov       rdx,7FF7AD3A84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B70
-       mov       rdx,7FF7AD3A8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/660a5f16-90da-48f4-8d61-307c7abd1149-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/32bfe80d-5a42-4eec-96f7-44f5399a0f06-diff.temp
index 8976c46..f5f1f03 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/32bfe80d-5a42-4eec-96f7-44f5399a0f06-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/660a5f16-90da-48f4-8d61-307c7abd1149-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8C18
-       mov       rdx,7FF7AD3A87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8960
-       mov       rdx,7FF7AD3A84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8930
-       mov       rdx,7FF7AD3A84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8910
-       mov       rdx,7FF7AD3A84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8B70
-       mov       rdx,7FF7AD3A8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e824be3-c768-4d57-851b-5181ae7a501b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d27ac2ed-0598-44ee-80be-545fd14e660d-diff.temp
index 8976c46..c64f91a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d27ac2ed-0598-44ee-80be-545fd14e660d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e824be3-c768-4d57-851b-5181ae7a501b-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8BD8
-       mov       rdx,7FF7AD3A87B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8920
-       mov       rdx,7FF7AD3A84F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88F0
-       mov       rdx,7FF7AD3A84C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3A84A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B30
-       mov       rdx,7FF7AD3A8708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3A8468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f1ec833f-0f00-4fe1-b8ee-cae43a82dcac-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d1a66a75-8494-47a0-87f3-622c9bded2df-diff.temp
index 8976c46..536a2a4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d1a66a75-8494-47a0-87f3-622c9bded2df-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f1ec833f-0f00-4fe1-b8ee-cae43a82dcac-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2C0648]
-       mov       r11,7FF7ACEA0648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2C0648]
-       mov       r11,7FF7ACEA0648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2C0640]
-       mov       r11,7FF7ACEA0640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8C18
-       mov       rdx,7FF7AD3D8C00
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8960
-       mov       rdx,7FF7AD3D8948
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2C0640]
-       mov       r11,7FF7ACEA0640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8930
-       mov       rdx,7FF7AD3D8918
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8910
-       mov       rdx,7FF7AD3D88F8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B70
-       mov       rdx,7FF7AD3D8B58
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8a97ef9e-7796-430a-95fc-4b4c611ab5fc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4563078e-205f-4567-84c4-dacd61f6d51f-diff.temp
index 9d61c4a..f5f1f03 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4563078e-205f-4567-84c4-dacd61f6d51f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8a97ef9e-7796-430a-95fc-4b4c611ab5fc-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2C0648]
-       mov       r11,7FF7ACEA0648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2C0648]
-       mov       r11,7FF7ACEA0648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2C0640]
-       mov       r11,7FF7ACEA0640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8C18
-       mov       rdx,7FF7AD3D8C00
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8960
-       mov       rdx,7FF7AD3D8948
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2C0640]
-       mov       r11,7FF7ACEA0640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8930
-       mov       rdx,7FF7AD3D8918
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8910
-       mov       rdx,7FF7AD3D88F8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B70
-       mov       rdx,7FF7AD3D8B58
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/15d4121c-547c-4ddd-80d0-2cdfd852f73a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c7de3e66-802e-4e47-bd12-01d41fbb3ee3-diff.temp
index 9d61c4a..f5f1f03 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c7de3e66-802e-4e47-bd12-01d41fbb3ee3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/15d4121c-547c-4ddd-80d0-2cdfd852f73a-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8960
-       mov       rdx,7FF7AD3D8948
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8930
-       mov       rdx,7FF7AD3D8918
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8910
-       mov       rdx,7FF7AD3D88F8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8B70
-       mov       rdx,7FF7AD3D8B58
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/30db1c1f-beb6-4757-a659-9a9ea586c5c7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5020993a-30ae-4b32-8153-aa33fd9cd0e8-diff.temp
index 9d61c4a..c64f91a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5020993a-30ae-4b32-8153-aa33fd9cd0e8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/30db1c1f-beb6-4757-a659-9a9ea586c5c7-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2C0648]
-       mov       r11,7FF7ACEA0648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2C0648]
-       mov       r11,7FF7ACEA0648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2C0640]
-       mov       r11,7FF7ACEA0640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8BD8
-       mov       rdx,7FF7AD3D8C00
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8920
-       mov       rdx,7FF7AD3D8948
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2C0640]
-       mov       r11,7FF7ACEA0640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88F0
-       mov       rdx,7FF7AD3D8918
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3D88F8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B30
-       mov       rdx,7FF7AD3D8B58
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3D88B8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/03a6376f-bac5-4d8f-82d8-56f20c00db06-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4cf67b3f-78a1-4ed5-b244-db7c9400aec5-diff.temp
index 9d61c4a..536a2a4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4cf67b3f-78a1-4ed5-b244-db7c9400aec5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/03a6376f-bac5-4d8f-82d8-56f20c00db06-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff

```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8C18
-       mov       rdx,7FF7AD3C8C18
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8960
-       mov       rdx,7FF7AD3C8960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8930
-       mov       rdx,7FF7AD3C8930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8910
-       mov       rdx,7FF7AD3C8910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8B70
-       mov       rdx,7FF7AD3C8B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f5893882-c440-4985-8ea6-4d1020905144-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f313038-1b49-4a5f-abf3-a16a7c6df700-diff.temp
index f5f1f03..c64f91a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f313038-1b49-4a5f-abf3-a16a7c6df700-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f5893882-c440-4985-8ea6-4d1020905144-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8920
-       mov       rdx,7FF7AD3C8960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88F0
-       mov       rdx,7FF7AD3C8930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3C8910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B30
-       mov       rdx,7FF7AD3C8B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6e6cc332-7796-4062-8609-2a8f2be59422-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/492cbd50-2718-400e-a4a1-50f5392461af-diff.temp
index f5f1f03..536a2a4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/492cbd50-2718-400e-a4a1-50f5392461af-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6e6cc332-7796-4062-8609-2a8f2be59422-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2C0648]
+       mov       r11,7FF7ACEA0648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8C18
-       mov       rdx,7FF7AD3C8C18
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8960
-       mov       rdx,7FF7AD3C8960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2C0640]
+       mov       r11,7FF7ACEA0640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8930
-       mov       rdx,7FF7AD3C8930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8910
-       mov       rdx,7FF7AD3C8910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D8B70
-       mov       rdx,7FF7AD3C8B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3D88D0
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/44e86d4b-f3ce-49a4-9850-12abd777d838-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0a9e8942-93dd-428b-9ddd-707bbbf47313-diff.temp
index f5f1f03..c64f91a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0a9e8942-93dd-428b-9ddd-707bbbf47313-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/44e86d4b-f3ce-49a4-9850-12abd777d838-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8920
-       mov       rdx,7FF7AD3C8960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88F0
-       mov       rdx,7FF7AD3C8930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3C8910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B30
-       mov       rdx,7FF7AD3C8B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a5a0823-551a-474c-9cb6-d9883329f63e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a9e31b33-9f8a-4451-a093-6e64804a1c9d-diff.temp
index f5f1f03..536a2a4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a9e31b33-9f8a-4451-a093-6e64804a1c9d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a5a0823-551a-474c-9cb6-d9883329f63e-diff.temp
```
**Diff for HasItems02 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2C0648]
-       mov       r11,7FF7ACEA0648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2C0648]
-       mov       r11,7FF7ACEA0648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2C0640]
-       mov       r11,7FF7ACEA0640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8BD8
-       mov       rdx,7FF7AD3D8C18
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8920
-       mov       rdx,7FF7AD3D8960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2C0640]
-       mov       r11,7FF7ACEA0640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88F0
-       mov       rdx,7FF7AD3D8930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3D8910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3D88D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B30
-       mov       rdx,7FF7AD3D8B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3D88D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3D88D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 63
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        sete      al
        cmp       eax,5
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems(5);
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c9db71c9-5f2d-48f7-9b0b-8b3a45828389-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/026b715c-bf04-421d-a27b-39c52e6739c8-diff.temp
index c64f91a..536a2a4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/026b715c-bf04-421d-a27b-39c52e6739c8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c9db71c9-5f2d-48f7-9b0b-8b3a45828389-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3AD608
-       mov       rdx,7FF7AD3BD1A0
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,2C2D8D74768
-       mov       r8,1A8A9594368
        mov       r9,[r9]
+       mov       r9,2C2E8D71028
-       mov       r9,1A8A9593020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3AD3F8
-       mov       rdx,7FF7AD3BCF90
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3A9730
-       mov       rdx,7FF7AD3B92C8
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3A9690
-       mov       rdx,7FF7AD3B9228
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3D56F0
-       mov       rdx,7FF7AD3E5290
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3D5740
-       mov       rdx,7FF7AD3E52E0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD290648]
+       mov       r11,7FF7ACE70648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD290648]
+       mov       r11,7FF7ACE70648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD290640]
+       mov       r11,7FF7ACE70640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A9130
-       mov       rdx,7FF7AD3B8CC8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8E78
-       mov       rdx,7FF7AD3B8A10
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD290640]
+       mov       r11,7FF7ACE70640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8E48
-       mov       rdx,7FF7AD3B89E0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8E28
-       mov       rdx,7FF7AD3B89C0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8DE8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A9088
-       mov       rdx,7FF7AD3B8C20
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8DE8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8DE8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,2C2C8D72D30
-       mov       rdx,1A8A9592D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/05d8996e-dd50-4e8f-872a-36dc1e04c480-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b993d5af-0099-42a4-9625-cea055be8710-diff.temp
index cf82177..58349dc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b993d5af-0099-42a4-9625-cea055be8710-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/05d8996e-dd50-4e8f-872a-36dc1e04c480-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD5F0
-       mov       rdx,7FF7AD3BD1A0
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1D742516360
-       mov       r8,1A8A9594368
        mov       r9,[r9]
+       mov       r9,1D742513020
-       mov       r9,1A8A9593020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD3E0
-       mov       rdx,7FF7AD3BCF90
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9718
-       mov       rdx,7FF7AD3B92C8
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9678
-       mov       rdx,7FF7AD3B9228
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E56F0
-       mov       rdx,7FF7AD3E5290
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E5740
-       mov       rdx,7FF7AD3E52E0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9118
-       mov       rdx,7FF7AD3B8CC8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E60
-       mov       rdx,7FF7AD3B8A10
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E30
-       mov       rdx,7FF7AD3B89E0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E10
-       mov       rdx,7FF7AD3B89C0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DD0
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9070
-       mov       rdx,7FF7AD3B8C20
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DD0
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DD0
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,1D742512D30
-       mov       rdx,1A8A9592D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d7e87986-4235-43a7-a636-205a21905df3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c70db9b8-36d2-4315-b06e-e62c4d01d4df-diff.temp
index cf82177..3459ca5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c70db9b8-36d2-4315-b06e-e62c4d01d4df-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d7e87986-4235-43a7-a636-205a21905df3-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD5C8
-       mov       rdx,7FF7AD3BD1A0
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,27935E801B8
-       mov       r8,1A8A9594368
        mov       r9,[r9]
+       mov       r9,27925E73020
-       mov       r9,1A8A9593020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3B8
-       mov       rdx,7FF7AD3BCF90
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C96F0
-       mov       rdx,7FF7AD3B92C8
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9650
-       mov       rdx,7FF7AD3B9228
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F56F0
-       mov       rdx,7FF7AD3E5290
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5740
-       mov       rdx,7FF7AD3E52E0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C90F0
-       mov       rdx,7FF7AD3B8CC8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E38
-       mov       rdx,7FF7AD3B8A10
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E08
-       mov       rdx,7FF7AD3B89E0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3B89C0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9048
-       mov       rdx,7FF7AD3B8C20
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,27925E72D30
-       mov       rdx,1A8A9592D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2405441a-1e8e-4753-a9d6-a9359eb4b8a3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f0df785a-bc58-4150-b621-88babb1d938b-diff.temp
index cf82177..0fa6303 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f0df785a-bc58-4150-b621-88babb1d938b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2405441a-1e8e-4753-a9d6-a9359eb4b8a3-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD5C8
-       mov       rdx,7FF7AD3BD1A0
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,26B17591F58
-       mov       r8,1A8A9594368
        mov       r9,[r9]
+       mov       r9,26B27593020
-       mov       r9,1A8A9593020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3B8
-       mov       rdx,7FF7AD3BCF90
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C96F0
-       mov       rdx,7FF7AD3B92C8
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9650
-       mov       rdx,7FF7AD3B9228
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F55C8
-       mov       rdx,7FF7AD3E5290
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5618
-       mov       rdx,7FF7AD3E52E0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C90F0
-       mov       rdx,7FF7AD3B8CC8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E38
-       mov       rdx,7FF7AD3B8A10
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E08
-       mov       rdx,7FF7AD3B89E0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3B89C0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9048
-       mov       rdx,7FF7AD3B8C20
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,26B27592D30
-       mov       rdx,1A8A9592D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4c27a831-aa21-4c14-8c96-2c4a2da30456-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7f660b1e-2283-41ec-b220-572f73d4dc15-diff.temp
index cf82177..35c76d0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7f660b1e-2283-41ec-b220-572f73d4dc15-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4c27a831-aa21-4c14-8c96-2c4a2da30456-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD608
-       mov       rdx,7FF7AD3BD1A0
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1DEE473E1C0
-       mov       r8,1A8A9594368
        mov       r9,[r9]
+       mov       r9,1DF04733020
-       mov       r9,1A8A9593020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3F8
-       mov       rdx,7FF7AD3BCF90
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9730
-       mov       rdx,7FF7AD3B92C8
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9690
-       mov       rdx,7FF7AD3B9228
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5618
-       mov       rdx,7FF7AD3E5290
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5668
-       mov       rdx,7FF7AD3E52E0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9130
-       mov       rdx,7FF7AD3B8CC8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E78
-       mov       rdx,7FF7AD3B8A10
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E48
-       mov       rdx,7FF7AD3B89E0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E28
-       mov       rdx,7FF7AD3B89C0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9088
-       mov       rdx,7FF7AD3B8C20
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,1DF04732D30
-       mov       rdx,1A8A9592D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5ce6d3ee-4c8b-4c19-a72e-0b5e6887be7c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e50c2924-e55d-4879-af8c-b0bffc8881dc-diff.temp
index cf82177..4522928 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e50c2924-e55d-4879-af8c-b0bffc8881dc-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5ce6d3ee-4c8b-4c19-a72e-0b5e6887be7c-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD608
-       mov       rdx,7FF7AD3BD1A0
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,28FF96C4768
-       mov       r8,1A8A9594368
        mov       r9,[r9]
+       mov       r9,290296C1028
-       mov       r9,1A8A9593020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD3F8
-       mov       rdx,7FF7AD3BCF90
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9730
-       mov       rdx,7FF7AD3B92C8
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9690
-       mov       rdx,7FF7AD3B9228
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E5668
-       mov       rdx,7FF7AD3E5290
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E56B8
-       mov       rdx,7FF7AD3E52E0
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9130
-       mov       rdx,7FF7AD3B8CC8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E78
-       mov       rdx,7FF7AD3B8A10
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E48
-       mov       rdx,7FF7AD3B89E0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E28
-       mov       rdx,7FF7AD3B89C0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9088
-       mov       rdx,7FF7AD3B8C20
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3B8980
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,28FF96C2D30
-       mov       rdx,1A8A9592D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c6b44ea5-2213-4815-9941-10798560ee92-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aa626e9e-ecdb-448e-8d95-00f31e4a0480-diff.temp
index cf82177..b8a2b76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aa626e9e-ecdb-448e-8d95-00f31e4a0480-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c6b44ea5-2213-4815-9941-10798560ee92-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD5F0
-       mov       rdx,7FF7AD3AD608
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1D742516360
-       mov       r8,2C2D8D74768
        mov       r9,[r9]
+       mov       r9,1D742513020
-       mov       r9,2C2E8D71028
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD3E0
-       mov       rdx,7FF7AD3AD3F8
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9718
-       mov       rdx,7FF7AD3A9730
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9678
-       mov       rdx,7FF7AD3A9690
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E56F0
-       mov       rdx,7FF7AD3D56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E5740
-       mov       rdx,7FF7AD3D5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9118
-       mov       rdx,7FF7AD3A9130
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E60
-       mov       rdx,7FF7AD3A8E78
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E30
-       mov       rdx,7FF7AD3A8E48
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E10
-       mov       rdx,7FF7AD3A8E28
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DD0
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9070
-       mov       rdx,7FF7AD3A9088
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DD0
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DD0
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,1D742512D30
-       mov       rdx,2C2C8D72D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ab5ad07-35d2-43e2-ad56-ad8bbd7ce208-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96e9db0c-3c61-4bab-8b59-2e3e796bb3d7-diff.temp
index 58349dc..3459ca5 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/96e9db0c-3c61-4bab-8b59-2e3e796bb3d7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ab5ad07-35d2-43e2-ad56-ad8bbd7ce208-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD5C8
-       mov       rdx,7FF7AD3AD608
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,27935E801B8
-       mov       r8,2C2D8D74768
        mov       r9,[r9]
+       mov       r9,27925E73020
-       mov       r9,2C2E8D71028
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3B8
-       mov       rdx,7FF7AD3AD3F8
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C96F0
-       mov       rdx,7FF7AD3A9730
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9650
-       mov       rdx,7FF7AD3A9690
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F56F0
-       mov       rdx,7FF7AD3D56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5740
-       mov       rdx,7FF7AD3D5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C90F0
-       mov       rdx,7FF7AD3A9130
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E38
-       mov       rdx,7FF7AD3A8E78
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E08
-       mov       rdx,7FF7AD3A8E48
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3A8E28
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9048
-       mov       rdx,7FF7AD3A9088
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,27925E72D30
-       mov       rdx,2C2C8D72D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d357ac78-72a8-4a1b-a9d4-b42d60978b4e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e9da5687-7a7b-4aad-ba35-1ecea349116b-diff.temp
index 58349dc..0fa6303 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e9da5687-7a7b-4aad-ba35-1ecea349116b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d357ac78-72a8-4a1b-a9d4-b42d60978b4e-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD5C8
-       mov       rdx,7FF7AD3AD608
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,26B17591F58
-       mov       r8,2C2D8D74768
        mov       r9,[r9]
+       mov       r9,26B27593020
-       mov       r9,2C2E8D71028
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3B8
-       mov       rdx,7FF7AD3AD3F8
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C96F0
-       mov       rdx,7FF7AD3A9730
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9650
-       mov       rdx,7FF7AD3A9690
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F55C8
-       mov       rdx,7FF7AD3D56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5618
-       mov       rdx,7FF7AD3D5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C90F0
-       mov       rdx,7FF7AD3A9130
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E38
-       mov       rdx,7FF7AD3A8E78
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E08
-       mov       rdx,7FF7AD3A8E48
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3A8E28
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9048
-       mov       rdx,7FF7AD3A9088
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,26B27592D30
-       mov       rdx,2C2C8D72D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1d24ae63-2056-4e9c-912d-01e1bfd81aa7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/23dcb3a6-3001-4ecf-bee1-16aa480fa275-diff.temp
index 58349dc..35c76d0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/23dcb3a6-3001-4ecf-bee1-16aa480fa275-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1d24ae63-2056-4e9c-912d-01e1bfd81aa7-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD608
-       mov       rdx,7FF7AD3AD608
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1DEE473E1C0
-       mov       r8,2C2D8D74768
        mov       r9,[r9]
+       mov       r9,1DF04733020
-       mov       r9,2C2E8D71028
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3F8
-       mov       rdx,7FF7AD3AD3F8
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9730
-       mov       rdx,7FF7AD3A9730
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9690
-       mov       rdx,7FF7AD3A9690
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5618
-       mov       rdx,7FF7AD3D56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5668
-       mov       rdx,7FF7AD3D5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9130
-       mov       rdx,7FF7AD3A9130
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E78
-       mov       rdx,7FF7AD3A8E78
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E48
-       mov       rdx,7FF7AD3A8E48
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E28
-       mov       rdx,7FF7AD3A8E28
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9088
-       mov       rdx,7FF7AD3A9088
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,1DF04732D30
-       mov       rdx,2C2C8D72D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9dd9beb2-3baa-496b-9604-dea1df33e341-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/be39f5a9-c2c1-4deb-920f-d00170a16565-diff.temp
index 58349dc..4522928 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/be39f5a9-c2c1-4deb-920f-d00170a16565-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9dd9beb2-3baa-496b-9604-dea1df33e341-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD608
-       mov       rdx,7FF7AD3AD608
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,28FF96C4768
-       mov       r8,2C2D8D74768
        mov       r9,[r9]
+       mov       r9,290296C1028
-       mov       r9,2C2E8D71028
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD3F8
-       mov       rdx,7FF7AD3AD3F8
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9730
-       mov       rdx,7FF7AD3A9730
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9690
-       mov       rdx,7FF7AD3A9690
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E5668
-       mov       rdx,7FF7AD3D56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E56B8
-       mov       rdx,7FF7AD3D5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9130
-       mov       rdx,7FF7AD3A9130
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E78
-       mov       rdx,7FF7AD3A8E78
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E48
-       mov       rdx,7FF7AD3A8E48
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E28
-       mov       rdx,7FF7AD3A8E28
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9088
-       mov       rdx,7FF7AD3A9088
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3A8DE8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,28FF96C2D30
-       mov       rdx,2C2C8D72D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a9f33b0-b2af-4b8d-84aa-7b0b22dc1347-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a1a6e9c5-77f2-4eb1-a8cd-90f3e4859568-diff.temp
index 58349dc..b8a2b76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a1a6e9c5-77f2-4eb1-a8cd-90f3e4859568-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9a9f33b0-b2af-4b8d-84aa-7b0b22dc1347-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD5C8
-       mov       rdx,7FF7AD3BD5F0
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,27935E801B8
-       mov       r8,1D742516360
        mov       r9,[r9]
+       mov       r9,27925E73020
-       mov       r9,1D742513020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3B8
-       mov       rdx,7FF7AD3BD3E0
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C96F0
-       mov       rdx,7FF7AD3B9718
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9650
-       mov       rdx,7FF7AD3B9678
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F56F0
-       mov       rdx,7FF7AD3E56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5740
-       mov       rdx,7FF7AD3E5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C90F0
-       mov       rdx,7FF7AD3B9118
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E38
-       mov       rdx,7FF7AD3B8E60
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E08
-       mov       rdx,7FF7AD3B8E30
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3B8E10
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9048
-       mov       rdx,7FF7AD3B9070
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,27925E72D30
-       mov       rdx,1D742512D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5a11b756-0f98-4058-8fad-7dfa69e3d6dd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f276ab06-3e66-4a88-892c-e8872a8d95b8-diff.temp
index 3459ca5..0fa6303 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f276ab06-3e66-4a88-892c-e8872a8d95b8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5a11b756-0f98-4058-8fad-7dfa69e3d6dd-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD5C8
-       mov       rdx,7FF7AD3BD5F0
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,26B17591F58
-       mov       r8,1D742516360
        mov       r9,[r9]
+       mov       r9,26B27593020
-       mov       r9,1D742513020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3B8
-       mov       rdx,7FF7AD3BD3E0
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C96F0
-       mov       rdx,7FF7AD3B9718
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9650
-       mov       rdx,7FF7AD3B9678
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F55C8
-       mov       rdx,7FF7AD3E56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5618
-       mov       rdx,7FF7AD3E5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C90F0
-       mov       rdx,7FF7AD3B9118
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E38
-       mov       rdx,7FF7AD3B8E60
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E08
-       mov       rdx,7FF7AD3B8E30
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3B8E10
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9048
-       mov       rdx,7FF7AD3B9070
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DA8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,26B27592D30
-       mov       rdx,1D742512D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c38a8f0e-0dea-4e1f-ab0e-9b807e3a6baf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8d07526-19ef-44ca-92a5-aa2ed3da829d-diff.temp
index 3459ca5..35c76d0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c8d07526-19ef-44ca-92a5-aa2ed3da829d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c38a8f0e-0dea-4e1f-ab0e-9b807e3a6baf-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD608
-       mov       rdx,7FF7AD3BD5F0
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1DEE473E1C0
-       mov       r8,1D742516360
        mov       r9,[r9]
+       mov       r9,1DF04733020
-       mov       r9,1D742513020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3F8
-       mov       rdx,7FF7AD3BD3E0
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9730
-       mov       rdx,7FF7AD3B9718
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9690
-       mov       rdx,7FF7AD3B9678
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5618
-       mov       rdx,7FF7AD3E56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5668
-       mov       rdx,7FF7AD3E5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9130
-       mov       rdx,7FF7AD3B9118
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E78
-       mov       rdx,7FF7AD3B8E60
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E48
-       mov       rdx,7FF7AD3B8E30
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E28
-       mov       rdx,7FF7AD3B8E10
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9088
-       mov       rdx,7FF7AD3B9070
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,1DF04732D30
-       mov       rdx,1D742512D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/92f30307-db71-46fc-9f5e-7abe8e7b6cb1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b6d19753-d5b0-43e4-85cc-8a0a24c70de1-diff.temp
index 3459ca5..4522928 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b6d19753-d5b0-43e4-85cc-8a0a24c70de1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/92f30307-db71-46fc-9f5e-7abe8e7b6cb1-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD608
-       mov       rdx,7FF7AD3BD5F0
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,28FF96C4768
-       mov       r8,1D742516360
        mov       r9,[r9]
+       mov       r9,290296C1028
-       mov       r9,1D742513020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD3F8
-       mov       rdx,7FF7AD3BD3E0
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9730
-       mov       rdx,7FF7AD3B9718
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9690
-       mov       rdx,7FF7AD3B9678
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E5668
-       mov       rdx,7FF7AD3E56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E56B8
-       mov       rdx,7FF7AD3E5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9130
-       mov       rdx,7FF7AD3B9118
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E78
-       mov       rdx,7FF7AD3B8E60
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E48
-       mov       rdx,7FF7AD3B8E30
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E28
-       mov       rdx,7FF7AD3B8E10
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9088
-       mov       rdx,7FF7AD3B9070
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3B8DD0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,28FF96C2D30
-       mov       rdx,1D742512D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/80aab246-db99-4ba1-8ac7-9991fa30f83f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f324b3c2-d42b-4b69-88ef-a14bdd0b1f58-diff.temp
index 3459ca5..b8a2b76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f324b3c2-d42b-4b69-88ef-a14bdd0b1f58-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/80aab246-db99-4ba1-8ac7-9991fa30f83f-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F55C8
-       mov       rdx,7FF7AD3F56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5618
-       mov       rdx,7FF7AD3F5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,26B27592D30
-       mov       rdx,27925E72D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/42ed8430-e37e-40ae-8a4a-b9670432c3eb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7d77fdf3-8196-4aa7-8abc-2f36dc704bcf-diff.temp
index 0fa6303..35c76d0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7d77fdf3-8196-4aa7-8abc-2f36dc704bcf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/42ed8430-e37e-40ae-8a4a-b9670432c3eb-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD608
-       mov       rdx,7FF7AD3CD5C8
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1DEE473E1C0
-       mov       r8,27935E801B8
        mov       r9,[r9]
+       mov       r9,1DF04733020
-       mov       r9,27925E73020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3F8
-       mov       rdx,7FF7AD3CD3B8
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9730
-       mov       rdx,7FF7AD3C96F0
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9690
-       mov       rdx,7FF7AD3C9650
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5618
-       mov       rdx,7FF7AD3F56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5668
-       mov       rdx,7FF7AD3F5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9130
-       mov       rdx,7FF7AD3C90F0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E78
-       mov       rdx,7FF7AD3C8E38
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E48
-       mov       rdx,7FF7AD3C8E08
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E28
-       mov       rdx,7FF7AD3C8DE8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9088
-       mov       rdx,7FF7AD3C9048
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,1DF04732D30
-       mov       rdx,27925E72D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a8514b39-48bd-4716-a09a-d6ca7410b18e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6ba2e7c6-1eac-479c-8245-f38020fe5f51-diff.temp
index 0fa6303..4522928 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6ba2e7c6-1eac-479c-8245-f38020fe5f51-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a8514b39-48bd-4716-a09a-d6ca7410b18e-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD608
-       mov       rdx,7FF7AD3CD5C8
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,28FF96C4768
-       mov       r8,27935E801B8
        mov       r9,[r9]
+       mov       r9,290296C1028
-       mov       r9,27925E73020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD3F8
-       mov       rdx,7FF7AD3CD3B8
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9730
-       mov       rdx,7FF7AD3C96F0
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9690
-       mov       rdx,7FF7AD3C9650
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E5668
-       mov       rdx,7FF7AD3F56F0
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E56B8
-       mov       rdx,7FF7AD3F5740
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9130
-       mov       rdx,7FF7AD3C90F0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E78
-       mov       rdx,7FF7AD3C8E38
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E48
-       mov       rdx,7FF7AD3C8E08
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E28
-       mov       rdx,7FF7AD3C8DE8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9088
-       mov       rdx,7FF7AD3C9048
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,28FF96C2D30
-       mov       rdx,27925E72D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/667fa204-f8e0-48d9-80a4-d1a00e2b2092-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/04d34ffd-8ab6-477e-be8a-e9d0c58f3c52-diff.temp
index 0fa6303..b8a2b76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/04d34ffd-8ab6-477e-be8a-e9d0c58f3c52-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/667fa204-f8e0-48d9-80a4-d1a00e2b2092-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD608
-       mov       rdx,7FF7AD3CD5C8
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,1DEE473E1C0
-       mov       r8,26B17591F58
        mov       r9,[r9]
+       mov       r9,1DF04733020
-       mov       r9,26B27593020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3CD3F8
-       mov       rdx,7FF7AD3CD3B8
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9730
-       mov       rdx,7FF7AD3C96F0
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3C9690
-       mov       rdx,7FF7AD3C9650
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5618
-       mov       rdx,7FF7AD3F55C8
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3F5668
-       mov       rdx,7FF7AD3F5618
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9130
-       mov       rdx,7FF7AD3C90F0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E78
-       mov       rdx,7FF7AD3C8E38
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E48
-       mov       rdx,7FF7AD3C8E08
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8E28
-       mov       rdx,7FF7AD3C8DE8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C9088
-       mov       rdx,7FF7AD3C9048
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,1DF04732D30
-       mov       rdx,26B27592D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4bc04928-572d-4fe2-b29d-6167b1dbbf4a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4b054b84-4bc7-4da1-802c-dd7cb8e4d3a4-diff.temp
index 35c76d0..4522928 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4b054b84-4bc7-4da1-802c-dd7cb8e4d3a4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4bc04928-572d-4fe2-b29d-6167b1dbbf4a-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD608
-       mov       rdx,7FF7AD3CD5C8
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,28FF96C4768
-       mov       r8,26B17591F58
        mov       r9,[r9]
+       mov       r9,290296C1028
-       mov       r9,26B27593020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD3F8
-       mov       rdx,7FF7AD3CD3B8
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9730
-       mov       rdx,7FF7AD3C96F0
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9690
-       mov       rdx,7FF7AD3C9650
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E5668
-       mov       rdx,7FF7AD3F55C8
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E56B8
-       mov       rdx,7FF7AD3F5618
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9130
-       mov       rdx,7FF7AD3C90F0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E78
-       mov       rdx,7FF7AD3C8E38
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E48
-       mov       rdx,7FF7AD3C8E08
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E28
-       mov       rdx,7FF7AD3C8DE8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9088
-       mov       rdx,7FF7AD3C9048
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3C8DA8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,28FF96C2D30
-       mov       rdx,26B27592D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/66e35e38-1bda-456e-8dc4-e182d1ce264c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b927a4ca-f107-4462-9ef5-234d34cabb8c-diff.temp
index 35c76d0..b8a2b76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b927a4ca-f107-4462-9ef5-234d34cabb8c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/66e35e38-1bda-456e-8dc4-e182d1ce264c-diff.temp
```
**Diff for AddRange01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M03_L08:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD608
-       mov       rdx,7FF7AD3CD608
        mov       rcx,rsi
 M03_L07:
        jmp       short M03_L08
        je        short M03_L07
        test      rcx,rcx
        mov       rcx,[r14+28]
        jle       near ptr M03_L11
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rdi
        mov       byte ptr [r15+14],0
        call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
        mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
        mov       r8,[r8]
+       mov       r8,28FF96C4768
-       mov       r8,1DEE473E1C0
        mov       r9,[r9]
+       mov       r9,290296C1028
-       mov       r9,1DF04733020
        movzx     edx,dl
        sete      dl
        test      eax,eax
        call      qword ptr [r11]
        mov       rcx,rbx
 M03_L06:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3BD3F8
-       mov       rdx,7FF7AD3CD3F8
        mov       rcx,rsi
 M03_L05:
        jmp       short M03_L06
        je        short M03_L05
        test      r11,r11
        mov       r11,[r14+20]
        mov       rbx,[r15+8]
        call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
        mov       rcx,r12
        mov       [r12+8],al
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r12,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Boolean
 M03_L04:
        mov       rbp,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9730
-       mov       rdx,7FF7AD3C9730
        mov       rcx,rsi
 M03_L03:
        jmp       short M03_L04
        je        short M03_L03
        test      rbp,rbp
        mov       rbp,[r14+18]
        lea       rbx,[r15+8]
 M03_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3B9690
-       mov       rdx,7FF7AD3C9690
        mov       rcx,rsi
 M03_L00:
        jmp       short M03_L01
        mov       rcx,[r14+10]
        je        short M03_L00
        cmp       qword ptr [r14+10],0
        mov       r14,[rsi+10]
        mov       ebp,r9d
        mov       rdi,r8
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rsp+28],rcx
        sub       rsp,30
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r14
        push      r15
 ; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 137
        int       3
        call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
        mov       ecx,10
 M02_L04:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E5668
-       mov       rdx,7FF7AD3F5618
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      rdx,rdx
        mov       rdx,[rdx+18]
        mov       rdx,[rcx+10]
 M02_L01:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FF7AD3E56B8
-       mov       rdx,7FF7AD3F5668
 M02_L00:
        jmp       short M02_L01
        je        short M02_L00
        test      rdx,rdx
        mov       rdx,[rdx+20]
        mov       rdx,[rcx+10]
        jle       short M02_L02
        test      edi,edi
        je        short M02_L05
        test      rsi,rsi
        mov       edi,r8d
        mov       rsi,rdx
        mov       [rsp+20],rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
 ; Total bytes of code 689
        ret
        pop       rbp
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,28
        nop
        add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9130
-       mov       rdx,7FF7AD3C9130
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E78
-       mov       rdx,7FF7AD3C8E78
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E48
-       mov       rdx,7FF7AD3C8E48
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8E28
-       mov       rdx,7FF7AD3C8E28
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3C8DE8
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B9088
-       mov       rdx,7FF7AD3C9088
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3C8DE8
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8DE8
-       mov       rdx,7FF7AD3C8DE8
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 167
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rdi
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
        mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
        mov       rdx,rdi
        mov       r8,rax
        call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
        mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
        sar       r8d,1
        add       r8d,ecx
        shr       ecx,1F
        mov       ecx,r8d
        mov       r8d,[rsi+180]
        mov       rdx,[rsi+148]
        mov       rdi,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,[rdx]
+       mov       rdx,28FF96C2D30
-       mov       rdx,1DF04732D30
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(people);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new List<PersonProper>().ToCollection();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/636e7d4f-ee24-4db7-ba07-1d7329f5ecbe-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/27c465cd-9265-4acb-a812-2b2481323dcd-diff.temp
index 4522928..b8a2b76 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/27c465cd-9265-4acb-a812-2b2481323dcd-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/636e7d4f-ee24-4db7-ba07-1d7329f5ecbe-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8C18
-       mov       rdx,7FF7AD3987B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8960
-       mov       rdx,7FF7AD3984F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8930
-       mov       rdx,7FF7AD3984C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8910
-       mov       rdx,7FF7AD3984A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88D0
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8B70
-       mov       rdx,7FF7AD398708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88D0
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88D0
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b426796a-ea93-4a1a-b5aa-607676466430-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e0a5233e-3180-4cf3-98ad-66cc2b5a745f-diff.temp
index 593d641..ad8e10a 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e0a5233e-3180-4cf3-98ad-66cc2b5a745f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b426796a-ea93-4a1a-b5aa-607676466430-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398960
-       mov       rdx,7FF7AD3984F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398930
-       mov       rdx,7FF7AD3984C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398910
-       mov       rdx,7FF7AD3984A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988D0
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398B70
-       mov       rdx,7FF7AD398708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988D0
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988D0
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5017e226-ce43-40d4-97a6-614b28a2ae24-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/976e3916-e880-46fd-8dd5-eba1ddb46b14-diff.temp
index 593d641..70cbb37 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/976e3916-e880-46fd-8dd5-eba1ddb46b14-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5017e226-ce43-40d4-97a6-614b28a2ae24-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD290648]
+       mov       r11,7FF7ACE70648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD290648]
+       mov       r11,7FF7ACE70648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD290640]
+       mov       r11,7FF7ACE70640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8BD8
-       mov       rdx,7FF7AD3987B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8920
-       mov       rdx,7FF7AD3984F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD290640]
+       mov       r11,7FF7ACE70640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A88F0
-       mov       rdx,7FF7AD3984C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A88D0
-       mov       rdx,7FF7AD3984A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8890
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8B30
-       mov       rdx,7FF7AD398708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8890
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8890
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d1367ed6-a4a3-4a91-9268-52979a348157-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/066ed35c-1eca-4974-a494-00270694d86d-diff.temp
index 593d641..40ecdab 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/066ed35c-1eca-4974-a494-00270694d86d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d1367ed6-a4a3-4a91-9268-52979a348157-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8BD8
-       mov       rdx,7FF7AD3987B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8920
-       mov       rdx,7FF7AD3984F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88F0
-       mov       rdx,7FF7AD3984C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3984A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B30
-       mov       rdx,7FF7AD398708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bb876dcf-6408-4b80-a218-46d1982c3615-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a0ac1cba-a08a-48dc-b05f-e5341311278e-diff.temp
index 593d641..8d71945 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a0ac1cba-a08a-48dc-b05f-e5341311278e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bb876dcf-6408-4b80-a218-46d1982c3615-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8BD8
-       mov       rdx,7FF7AD3987B0
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8920
-       mov       rdx,7FF7AD3984F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88F0
-       mov       rdx,7FF7AD3984C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88D0
-       mov       rdx,7FF7AD3984A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8B30
-       mov       rdx,7FF7AD398708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/609cf62c-39ce-4e1f-9771-d6b37d6381b1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6a70191a-8df1-4397-8453-94a488008187-diff.temp
index 593d641..7296646 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6a70191a-8df1-4397-8453-94a488008187-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/609cf62c-39ce-4e1f-9771-d6b37d6381b1-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398948
-       mov       rdx,7FF7AD3984F8
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398918
-       mov       rdx,7FF7AD3984C8
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988F8
-       mov       rdx,7FF7AD3984A8
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398B58
-       mov       rdx,7FF7AD398708
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD398468
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2a5471cf-66a3-4090-99b5-af00bf543e76-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e49d7a2-c002-4da1-b061-8a01415e56eb-diff.temp
index 593d641..0f4c264 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e49d7a2-c002-4da1-b061-8a01415e56eb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2a5471cf-66a3-4090-99b5-af00bf543e76-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD280648]
+       mov       r11,7FF7ACE60648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD280648]
+       mov       r11,7FF7ACE60648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD280640]
+       mov       r11,7FF7ACE60640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398C18
-       mov       rdx,7FF7AD3B8C18
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398960
-       mov       rdx,7FF7AD3B8960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD280640]
+       mov       r11,7FF7ACE60640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398930
-       mov       rdx,7FF7AD3B8930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398910
-       mov       rdx,7FF7AD3B8910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988D0
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398B70
-       mov       rdx,7FF7AD3B8B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988D0
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988D0
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f9829030-818a-4574-aff8-040c22557a33-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/55947a94-5ca7-4977-b3ed-23fb5e3576d3-diff.temp
index ad8e10a..70cbb37 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/55947a94-5ca7-4977-b3ed-23fb5e3576d3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f9829030-818a-4574-aff8-040c22557a33-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD290648]
+       mov       r11,7FF7ACE70648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD290648]
+       mov       r11,7FF7ACE70648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD290640]
+       mov       r11,7FF7ACE70640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8BD8
-       mov       rdx,7FF7AD3B8C18
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8920
-       mov       rdx,7FF7AD3B8960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD290640]
+       mov       r11,7FF7ACE70640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A88F0
-       mov       rdx,7FF7AD3B8930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A88D0
-       mov       rdx,7FF7AD3B8910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8890
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8B30
-       mov       rdx,7FF7AD3B8B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8890
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8890
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d225342e-e9c4-4e66-9d82-b5bb3cb7faf7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/de19cf92-0a5b-4b68-90b7-7e88f0735e42-diff.temp
index ad8e10a..40ecdab 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/de19cf92-0a5b-4b68-90b7-7e88f0735e42-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d225342e-e9c4-4e66-9d82-b5bb3cb7faf7-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8BD8
-       mov       rdx,7FF7AD3B8C18
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8920
-       mov       rdx,7FF7AD3B8960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88F0
-       mov       rdx,7FF7AD3B8930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3B8910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B30
-       mov       rdx,7FF7AD3B8B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1c2d1c02-679a-491c-8da9-1268461b544d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/066b72cd-36ed-4e4c-9787-971e40bd6695-diff.temp
index ad8e10a..8d71945 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/066b72cd-36ed-4e4c-9787-971e40bd6695-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1c2d1c02-679a-491c-8da9-1268461b544d-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8920
-       mov       rdx,7FF7AD3B8960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88F0
-       mov       rdx,7FF7AD3B8930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88D0
-       mov       rdx,7FF7AD3B8910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8B30
-       mov       rdx,7FF7AD3B8B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c24e1a99-7a3e-4fc9-88fd-e0dae7ce099a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/482c9063-2004-4983-8a46-4505d6b6325a-diff.temp
index ad8e10a..7296646 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/482c9063-2004-4983-8a46-4505d6b6325a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c24e1a99-7a3e-4fc9-88fd-e0dae7ce099a-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD280648]
+       mov       r11,7FF7ACE60648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD280648]
+       mov       r11,7FF7ACE60648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD280640]
+       mov       r11,7FF7ACE60640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398C00
-       mov       rdx,7FF7AD3B8C18
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398948
-       mov       rdx,7FF7AD3B8960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD280640]
+       mov       r11,7FF7ACE60640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398918
-       mov       rdx,7FF7AD3B8930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988F8
-       mov       rdx,7FF7AD3B8910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398B58
-       mov       rdx,7FF7AD3B8B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d34d54e8-1f51-413a-ac12-7838a984c4d3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc9c2582-a1f0-49c9-81c6-8cf640409e24-diff.temp
index ad8e10a..0f4c264 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc9c2582-a1f0-49c9-81c6-8cf640409e24-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d34d54e8-1f51-413a-ac12-7838a984c4d3-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD290648]
+       mov       r11,7FF7ACE70648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD290648]
+       mov       r11,7FF7ACE70648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD290640]
+       mov       r11,7FF7ACE70640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8BD8
-       mov       rdx,7FF7AD398C18
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8920
-       mov       rdx,7FF7AD398960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD290640]
+       mov       r11,7FF7ACE70640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A88F0
-       mov       rdx,7FF7AD398930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A88D0
-       mov       rdx,7FF7AD398910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8890
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8B30
-       mov       rdx,7FF7AD398B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8890
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3A8890
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c401ac4d-0fd7-42dd-8a93-3c139b4fb9a3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ccda23e-68e3-400d-addb-190d7a27f221-diff.temp
index 70cbb37..40ecdab 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3ccda23e-68e3-400d-addb-190d7a27f221-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c401ac4d-0fd7-42dd-8a93-3c139b4fb9a3-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8BD8
-       mov       rdx,7FF7AD398C18
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8920
-       mov       rdx,7FF7AD398960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88F0
-       mov       rdx,7FF7AD398930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD398910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B30
-       mov       rdx,7FF7AD398B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a0560c87-3843-4a5d-b208-9e12b41b214b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9dcdd486-845a-474c-91e2-b30a95396e20-diff.temp
index 70cbb37..8d71945 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9dcdd486-845a-474c-91e2-b30a95396e20-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a0560c87-3843-4a5d-b208-9e12b41b214b-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD280648]
-       mov       r11,7FF7ACE60648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8BD8
-       mov       rdx,7FF7AD398C18
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8920
-       mov       rdx,7FF7AD398960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD280640]
-       mov       r11,7FF7ACE60640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88F0
-       mov       rdx,7FF7AD398930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88D0
-       mov       rdx,7FF7AD398910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8B30
-       mov       rdx,7FF7AD398B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9bdacb39-9fd2-4945-b290-d3b763900361-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2c95ffa6-25fc-460a-b6e9-1d4a43dacb06-diff.temp
index 70cbb37..7296646 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2c95ffa6-25fc-460a-b6e9-1d4a43dacb06-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9bdacb39-9fd2-4945-b290-d3b763900361-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398948
-       mov       rdx,7FF7AD398960
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398918
-       mov       rdx,7FF7AD398930
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988F8
-       mov       rdx,7FF7AD398910
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398B58
-       mov       rdx,7FF7AD398B70
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3988D0
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3114a28f-b38f-49a9-a0dd-7d27711a983f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0506b751-583b-43af-aae4-772f78c48cdf-diff.temp
index 70cbb37..0f4c264 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0506b751-583b-43af-aae4-772f78c48cdf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3114a28f-b38f-49a9-a0dd-7d27711a983f-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2B0648]
+       mov       r11,7FF7ACE90648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8BD8
-       mov       rdx,7FF7AD3A8BD8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8920
-       mov       rdx,7FF7AD3A8920
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2B0640]
+       mov       r11,7FF7ACE90640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88F0
-       mov       rdx,7FF7AD3A88F0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C88D0
-       mov       rdx,7FF7AD3A88D0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3A8890
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8B30
-       mov       rdx,7FF7AD3A8B30
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3A8890
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3C8890
-       mov       rdx,7FF7AD3A8890
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5d1540d2-89d8-407d-aa4e-48cd3a0141d8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/11f0a9fb-8017-48f2-aa40-9372233ae5ff-diff.temp
index 40ecdab..8d71945 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/11f0a9fb-8017-48f2-aa40-9372233ae5ff-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5d1540d2-89d8-407d-aa4e-48cd3a0141d8-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8BD8
-       mov       rdx,7FF7AD3A8BD8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8920
-       mov       rdx,7FF7AD3A8920
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88F0
-       mov       rdx,7FF7AD3A88F0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88D0
-       mov       rdx,7FF7AD3A88D0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3A8890
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8B30
-       mov       rdx,7FF7AD3A8B30
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3A8890
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3A8890
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/822ea592-b134-4af8-af7c-5506407a378a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9bded6c4-b6d1-40ca-a468-79319021405d-diff.temp
index 40ecdab..7296646 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9bded6c4-b6d1-40ca-a468-79319021405d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/822ea592-b134-4af8-af7c-5506407a378a-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD280648]
+       mov       r11,7FF7ACE60648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD280648]
+       mov       r11,7FF7ACE60648
-       call      qword ptr [7FF7AD290648]
-       mov       r11,7FF7ACE70648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD280640]
+       mov       r11,7FF7ACE60640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398C00
-       mov       rdx,7FF7AD3A8BD8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398948
-       mov       rdx,7FF7AD3A8920
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD280640]
+       mov       r11,7FF7ACE60640
-       call      qword ptr [7FF7AD290640]
-       mov       r11,7FF7ACE70640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398918
-       mov       rdx,7FF7AD3A88F0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988F8
-       mov       rdx,7FF7AD3A88D0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3A8890
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398B58
-       mov       rdx,7FF7AD3A8B30
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3A8890
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3A8890
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/21668a2e-8181-41da-b126-77a58984d2a0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/176b504b-2424-4190-8912-6e1e965be9f2-diff.temp
index 40ecdab..0f4c264 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/176b504b-2424-4190-8912-6e1e965be9f2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/21668a2e-8181-41da-b126-77a58984d2a0-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD2A0648]
+       mov       r11,7FF7ACE80648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8BD8
-       mov       rdx,7FF7AD3C8BD8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8920
-       mov       rdx,7FF7AD3C8920
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD2A0640]
+       mov       r11,7FF7ACE80640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88F0
-       mov       rdx,7FF7AD3C88F0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B88D0
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3C8890
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8B30
-       mov       rdx,7FF7AD3C8B30
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3C8890
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3B8890
-       mov       rdx,7FF7AD3C8890
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc314984-b0c2-47aa-900b-d05f266ef0cd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0846e440-c1ec-4a3f-b78c-e585b77c86ba-diff.temp
index 8d71945..7296646 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0846e440-c1ec-4a3f-b78c-e585b77c86ba-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc314984-b0c2-47aa-900b-d05f266ef0cd-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD280648]
+       mov       r11,7FF7ACE60648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD280648]
+       mov       r11,7FF7ACE60648
-       call      qword ptr [7FF7AD2B0648]
-       mov       r11,7FF7ACE90648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD280640]
+       mov       r11,7FF7ACE60640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398C00
-       mov       rdx,7FF7AD3C8BD8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398948
-       mov       rdx,7FF7AD3C8920
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD280640]
+       mov       r11,7FF7ACE60640
-       call      qword ptr [7FF7AD2B0640]
-       mov       r11,7FF7ACE90640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398918
-       mov       rdx,7FF7AD3C88F0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988F8
-       mov       rdx,7FF7AD3C88D0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3C8890
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398B58
-       mov       rdx,7FF7AD3C8B30
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3C8890
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3C8890
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b7f2f6bb-673f-4b73-8de0-715e3bf8b59c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/23846f0e-65ff-43f9-9aad-696013f0ad2b-diff.temp
index 8d71945..0f4c264 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/23846f0e-65ff-43f9-9aad-696013f0ad2b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b7f2f6bb-673f-4b73-8de0-715e3bf8b59c-diff.temp
```
**Diff for HasItems01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
add       rsp,28
        nop
 M01_L24:
+       call      qword ptr [7FF7AD280648]
+       mov       r11,7FF7ACE60648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
        je        short M01_L24
        cmp       qword ptr [rbp+0FFB8],0
        lea       rbp,[rbp+70]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,28
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
        int       3
        call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
 M01_L23:
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
        mov       rax,r14
+       call      qword ptr [7FF7AD280648]
+       mov       r11,7FF7ACE60648
-       call      qword ptr [7FF7AD2A0648]
-       mov       r11,7FF7ACE80648
        mov       rcx,[rbp+0FFB8]
 M01_L22:
        jne       near ptr M01_L13
        test      eax,eax
+       call      qword ptr [7FF7AD280640]
+       mov       r11,7FF7ACE60640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
 M01_L21:
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
        mov       rdx,rbx
        mov       rcx,r14
 M01_L18:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398C00
-       mov       rdx,7FF7AD3B8BD8
        mov       rcx,rsi
 M01_L17:
        jmp       short M01_L18
        je        short M01_L17
        test      rcx,rcx
        mov       rcx,[r15+38]
 M01_L15:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398948
-       mov       rdx,7FF7AD3B8920
        mov       rcx,rsi
 M01_L14:
        jmp       short M01_L15
        je        short M01_L14
        test      r11,r11
        mov       r11,[r15+28]
 M01_L13:
        je        near ptr M01_L22
        test      eax,eax
+       call      qword ptr [7FF7AD280640]
+       mov       r11,7FF7ACE60640
-       call      qword ptr [7FF7AD2A0640]
-       mov       r11,7FF7ACE80640
        mov       rcx,[rbp+0FFB8]
        mov       [rbp+0FFB8],rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M01_L12:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398918
-       mov       rdx,7FF7AD3B88F0
        mov       rcx,rsi
 M01_L11:
        jmp       short M01_L12
        je        short M01_L11
        test      r11,r11
        mov       r11,[r15+20]
        mov       rbx,rax
        call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       r8,r12
        mov       rdx,rbx
 M01_L10:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988F8
-       mov       rdx,7FF7AD3B88D0
        mov       rcx,rsi
 M01_L09:
        jmp       short M01_L10
        je        short M01_L09
        test      rcx,rcx
        mov       rcx,[r15+18]
 M01_L07:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3B8890
        mov       rcx,rsi
 M01_L06:
        jmp       short M01_L07
        je        short M01_L06
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       [r13+18],rcx
        mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r12
        lea       rcx,[r13+8]
        je        near ptr M01_L23
        test      r12,r12
        mov       r13,rax
        call      CORINFO_HELP_NEWSFAST
 M01_L05:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD398B58
-       mov       rdx,7FF7AD3B8B30
        mov       rcx,rsi
 M01_L04:
        jmp       short M01_L05
        je        short M01_L04
        test      rcx,rcx
        mov       rcx,[r15+30]
        mov       r12,[rax]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L03:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3B8890
        mov       rcx,rsi
 M01_L02:
        jmp       short M01_L03
        je        short M01_L02
        test      rcx,rcx
        mov       rcx,[r15+10]
        jne       near ptr M01_L08
        test      r12,r12
        mov       r12,[rax+8]
        call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
 M01_L01:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FF7AD3988B8
-       mov       rdx,7FF7AD3B8890
        mov       rcx,rsi
 M01_L00:
        jmp       short M01_L01
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[r15+10]
        mov       r15,[rcx+8]
        mov       rcx,[rsi+30]
        call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,r14
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,rsi
        mov       edi,r8d
        mov       rbx,rdx
        mov       rsi,rcx
        mov       [rbp+0FFC0],rcx
        mov       [rbp+0FFB0],rsp
        lea       rbp,[rsp+70]
        sub       rsp,38
        push      rbx
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
        push      rbp
 ; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
 ; Total bytes of code 62
        ret
        pop       rsi
        add       rsp,20
        mov       [rdx+54],al
        mov       rdx,[rsi+10]
        movzx     eax,al
        setg      al
        test      eax,eax
        call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rcx,rax
        call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
        xor       r8d,r8d
        mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdx,[rsi+148]
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			base.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var result = base.PersonProperList.ToCollection().HasItems();
 ; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3b9764ed-3080-425f-b727-32700fa201db-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3c7cbaf4-2069-4220-ab39-4f1ad5321df2-diff.temp
index 7296646..0f4c264 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3c7cbaf4-2069-4220-ab39-4f1ad5321df2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3b9764ed-3080-425f-b727-32700fa201db-diff.temp
```
