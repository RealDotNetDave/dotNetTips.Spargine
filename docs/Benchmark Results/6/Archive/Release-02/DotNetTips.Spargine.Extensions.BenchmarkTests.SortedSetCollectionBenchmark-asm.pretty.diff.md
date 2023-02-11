## DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark-20220802-044817
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
+       call      qword ptr [7FFB47890830]
+       mov       r11,7FFB47230830
-       call      qword ptr [7FFB478B0830]
-       mov       r11,7FFB47250830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB47890828]
+       mov       r11,7FFB47230828
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
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
+       mov       rdx,7FFB4790E938
-       mov       rdx,7FFB4792E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB47890828]
+       mov       r11,7FFB47230828
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4790E860
-       mov       rdx,7FFB4792E860
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
+       vucomisd  xmm0,qword ptr [7FFB47887D80]
+       vdivsd    xmm0,xmm0,[7FFB47887D78]
-       vucomisd  xmm0,qword ptr [7FFB478A7D80]
-       vdivsd    xmm0,xmm0,[7FFB478A7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,236BC2EB308
-       mov       rcx,199B7A5B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,236BC2EB300
-       mov       rdx,199B7A5B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,236BC2EB308
-       mov       rcx,199B7A5B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e59701fe-b658-41c2-a7da-776d22ff8943-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0f6f379b-7cb1-4bb8-ac16-0e08a6ae9197-diff.temp
index 65c055d..dbbbd6b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0f6f379b-7cb1-4bb8-ac16-0e08a6ae9197-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e59701fe-b658-41c2-a7da-776d22ff8943-diff.temp
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
+       call      qword ptr [7FFB478D0830]
+       mov       r11,7FFB47270830
-       call      qword ptr [7FFB478B0830]
-       mov       r11,7FFB47250830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D0828]
+       mov       r11,7FFB47270828
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
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
+       mov       rdx,7FFB4794E938
-       mov       rdx,7FFB4792E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D0828]
+       mov       r11,7FFB47270828
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E860
-       mov       rdx,7FFB4792E860
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
+       vucomisd  xmm0,qword ptr [7FFB478C7D80]
+       vdivsd    xmm0,xmm0,[7FFB478C7D78]
-       vucomisd  xmm0,qword ptr [7FFB478A7D80]
-       vdivsd    xmm0,xmm0,[7FFB478A7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,283B852B308
-       mov       rcx,199B7A5B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,283B852B300
-       mov       rdx,199B7A5B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,283B852B308
-       mov       rcx,199B7A5B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2ac04bfd-f212-4fa2-89a5-aaacf862ab0c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/944d6dd8-ea94-4827-b9ec-057f0f4cda80-diff.temp
index 65c055d..ae71632 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/944d6dd8-ea94-4827-b9ec-057f0f4cda80-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2ac04bfd-f212-4fa2-89a5-aaacf862ab0c-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E608
-       mov       rdx,7FFB4792E860
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
+       vucomisd  xmm0,qword ptr [7FFB478A7C00]
+       vdivsd    xmm0,xmm0,[7FFB478A7BF8]
-       vucomisd  xmm0,qword ptr [7FFB478A7D80]
-       vdivsd    xmm0,xmm0,[7FFB478A7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1DB289ED300
-       mov       rcx,199B7A5B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1DB289ED2F8
-       mov       rdx,199B7A5B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1DB289ED300
-       mov       rcx,199B7A5B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2c08ecfb-fb06-49fc-8277-67c8bc09ff1d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/090bed62-5879-416a-81ea-1c4921f3d518-diff.temp
index 65c055d..151de52 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/090bed62-5879-416a-81ea-1c4921f3d518-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2c08ecfb-fb06-49fc-8277-67c8bc09ff1d-diff.temp
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
+       call      qword ptr [7FFB478C0830]
+       mov       r11,7FFB47260830
-       call      qword ptr [7FFB478B0830]
-       mov       r11,7FFB47250830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478C0828]
+       mov       r11,7FFB47260828
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
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
+       mov       rdx,7FFB4793E938
-       mov       rdx,7FFB4792E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478C0828]
+       mov       r11,7FFB47260828
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E860
-       mov       rdx,7FFB4792E860
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
+       vucomisd  xmm0,qword ptr [7FFB478B7C00]
+       vdivsd    xmm0,xmm0,[7FFB478B7BF8]
-       vucomisd  xmm0,qword ptr [7FFB478A7D80]
-       vdivsd    xmm0,xmm0,[7FFB478A7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,24C1912D300
-       mov       rcx,199B7A5B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,24C1912D2F8
-       mov       rdx,199B7A5B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,24C1912D300
-       mov       rcx,199B7A5B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9d1a2f76-740e-465b-a8fa-e31fb6467a82-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/13c6b67d-261b-4a68-b4bd-726caeef4f75-diff.temp
index 65c055d..b92d710 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/13c6b67d-261b-4a68-b4bd-726caeef4f75-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9d1a2f76-740e-465b-a8fa-e31fb6467a82-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E608
-       mov       rdx,7FFB4792E860
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
+       vucomisd  xmm0,qword ptr [7FFB478A7A80]
+       vdivsd    xmm0,xmm0,[7FFB478A7A78]
-       vucomisd  xmm0,qword ptr [7FFB478A7D80]
-       vdivsd    xmm0,xmm0,[7FFB478A7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1A0BBB8D300
-       mov       rcx,199B7A5B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1A0BBB8D2F8
-       mov       rdx,199B7A5B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1A0BBB8D300
-       mov       rcx,199B7A5B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/57bcfc73-2271-4204-86a7-bc291a7486be-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/205b0dab-048e-493c-9495-d0f0ef3693b1-diff.temp
index 65c055d..e19f0dc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/205b0dab-048e-493c-9495-d0f0ef3693b1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/57bcfc73-2271-4204-86a7-bc291a7486be-diff.temp
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
+       call      qword ptr [7FFB478C0930]
+       mov       r11,7FFB47260930
-       call      qword ptr [7FFB478B0830]
-       mov       r11,7FFB47250830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
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
+       mov       rdx,7FFB47979500
-       mov       rdx,7FFB4792E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979428
-       mov       rdx,7FFB4792E860
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
+       vucomisd  xmm0,qword ptr [7FFB478BAAC0]
+       vdivsd    xmm0,xmm0,[7FFB478BAAB8]
-       vucomisd  xmm0,qword ptr [7FFB478A7D80]
-       vdivsd    xmm0,xmm0,[7FFB478A7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,239959FD300
-       mov       rcx,199B7A5B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,239959FD2F8
-       mov       rdx,199B7A5B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,239959FD300
-       mov       rcx,199B7A5B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61831741-3905-4813-ba85-816bc22270ba-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/963ef017-62ef-479e-b117-7ddc0cca03b9-diff.temp
index 65c055d..b7ddf23 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/963ef017-62ef-479e-b117-7ddc0cca03b9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/61831741-3905-4813-ba85-816bc22270ba-diff.temp
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
+       call      qword ptr [7FFB478B0930]
+       mov       r11,7FFB47250930
-       call      qword ptr [7FFB478B0830]
-       mov       r11,7FFB47250830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
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
+       mov       rdx,7FFB47969660
-       mov       rdx,7FFB4792E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969588
-       mov       rdx,7FFB4792E860
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
+       vucomisd  xmm0,qword ptr [7FFB478AAC40]
+       vdivsd    xmm0,xmm0,[7FFB478AAC38]
-       vucomisd  xmm0,qword ptr [7FFB478A7D80]
-       vdivsd    xmm0,xmm0,[7FFB478A7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,214F651D300
-       mov       rcx,199B7A5B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,214F651D2F8
-       mov       rdx,199B7A5B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,214F651D300
-       mov       rcx,199B7A5B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e29b4287-ec0d-4e6c-a31f-1bf847ee3123-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5df07665-efa2-4a53-ad96-bdaa40f1a77f-diff.temp
index 65c055d..302be70 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5df07665-efa2-4a53-ad96-bdaa40f1a77f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e29b4287-ec0d-4e6c-a31f-1bf847ee3123-diff.temp
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
+       call      qword ptr [7FFB478D0830]
+       mov       r11,7FFB47270830
-       call      qword ptr [7FFB47890830]
-       mov       r11,7FFB47230830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478D0828]
+       mov       r11,7FFB47270828
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
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
+       mov       rdx,7FFB4794E938
-       mov       rdx,7FFB4790E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478D0828]
+       mov       r11,7FFB47270828
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4794E860
-       mov       rdx,7FFB4790E860
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
+       vucomisd  xmm0,qword ptr [7FFB478C7D80]
+       vdivsd    xmm0,xmm0,[7FFB478C7D78]
-       vucomisd  xmm0,qword ptr [7FFB47887D80]
-       vdivsd    xmm0,xmm0,[7FFB47887D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,283B852B308
-       mov       rcx,236BC2EB308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,283B852B300
-       mov       rdx,236BC2EB300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,283B852B308
-       mov       rcx,236BC2EB308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/399f5ade-1cfd-4d55-bb2b-07ac164d28ce-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0fe9526d-244c-4ecd-adfd-9be2d578f416-diff.temp
index dbbbd6b..ae71632 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0fe9526d-244c-4ecd-adfd-9be2d578f416-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/399f5ade-1cfd-4d55-bb2b-07ac164d28ce-diff.temp
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
+       call      qword ptr [7FFB478B0830]
+       mov       r11,7FFB47250830
-       call      qword ptr [7FFB47890830]
-       mov       r11,7FFB47230830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0828]
+       mov       r11,7FFB47250828
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
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
+       mov       rdx,7FFB4792E6E0
-       mov       rdx,7FFB4790E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0828]
+       mov       r11,7FFB47250828
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E608
-       mov       rdx,7FFB4790E860
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
+       vucomisd  xmm0,qword ptr [7FFB478A7C00]
+       vdivsd    xmm0,xmm0,[7FFB478A7BF8]
-       vucomisd  xmm0,qword ptr [7FFB47887D80]
-       vdivsd    xmm0,xmm0,[7FFB47887D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1DB289ED300
-       mov       rcx,236BC2EB308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1DB289ED2F8
-       mov       rdx,236BC2EB300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1DB289ED300
-       mov       rcx,236BC2EB308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9a1b6885-e779-4214-be59-ce61f1638984-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d487a0f9-e96b-4e5b-ba96-59c53f16b53e-diff.temp
index dbbbd6b..151de52 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d487a0f9-e96b-4e5b-ba96-59c53f16b53e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9a1b6885-e779-4214-be59-ce61f1638984-diff.temp
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
+       call      qword ptr [7FFB478C0830]
+       mov       r11,7FFB47260830
-       call      qword ptr [7FFB47890830]
-       mov       r11,7FFB47230830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478C0828]
+       mov       r11,7FFB47260828
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
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
+       mov       rdx,7FFB4793E938
-       mov       rdx,7FFB4790E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478C0828]
+       mov       r11,7FFB47260828
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E860
-       mov       rdx,7FFB4790E860
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
+       vucomisd  xmm0,qword ptr [7FFB478B7C00]
+       vdivsd    xmm0,xmm0,[7FFB478B7BF8]
-       vucomisd  xmm0,qword ptr [7FFB47887D80]
-       vdivsd    xmm0,xmm0,[7FFB47887D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,24C1912D300
-       mov       rcx,236BC2EB308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,24C1912D2F8
-       mov       rdx,236BC2EB300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,24C1912D300
-       mov       rcx,236BC2EB308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8e2abe3f-7b5d-42fc-988c-c349bbc1f98e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/278bb932-efd1-4b44-8b3b-0d8226e4e14f-diff.temp
index dbbbd6b..b92d710 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/278bb932-efd1-4b44-8b3b-0d8226e4e14f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8e2abe3f-7b5d-42fc-988c-c349bbc1f98e-diff.temp
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
+       call      qword ptr [7FFB478B0830]
+       mov       r11,7FFB47250830
-       call      qword ptr [7FFB47890830]
-       mov       r11,7FFB47230830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0828]
+       mov       r11,7FFB47250828
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
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
+       mov       rdx,7FFB4792E6E0
-       mov       rdx,7FFB4790E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0828]
+       mov       r11,7FFB47250828
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E608
-       mov       rdx,7FFB4790E860
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
+       vucomisd  xmm0,qword ptr [7FFB478A7A80]
+       vdivsd    xmm0,xmm0,[7FFB478A7A78]
-       vucomisd  xmm0,qword ptr [7FFB47887D80]
-       vdivsd    xmm0,xmm0,[7FFB47887D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1A0BBB8D300
-       mov       rcx,236BC2EB308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1A0BBB8D2F8
-       mov       rdx,236BC2EB300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1A0BBB8D300
-       mov       rcx,236BC2EB308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/de853cb2-620d-466d-b7a2-f851d1ae5936-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a798cb82-d353-436e-a9f4-6bb2d36e070a-diff.temp
index dbbbd6b..e19f0dc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a798cb82-d353-436e-a9f4-6bb2d36e070a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/de853cb2-620d-466d-b7a2-f851d1ae5936-diff.temp
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
+       call      qword ptr [7FFB478C0930]
+       mov       r11,7FFB47260930
-       call      qword ptr [7FFB47890830]
-       mov       r11,7FFB47230830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
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
+       mov       rdx,7FFB47979500
-       mov       rdx,7FFB4790E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979428
-       mov       rdx,7FFB4790E860
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
+       vucomisd  xmm0,qword ptr [7FFB478BAAC0]
+       vdivsd    xmm0,xmm0,[7FFB478BAAB8]
-       vucomisd  xmm0,qword ptr [7FFB47887D80]
-       vdivsd    xmm0,xmm0,[7FFB47887D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,239959FD300
-       mov       rcx,236BC2EB308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,239959FD2F8
-       mov       rdx,236BC2EB300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,239959FD300
-       mov       rcx,236BC2EB308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c6be52b5-ca40-4e81-abf1-823bc4b4859c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4234b6ac-1530-4e2d-aeaa-bd846d445a0f-diff.temp
index dbbbd6b..b7ddf23 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4234b6ac-1530-4e2d-aeaa-bd846d445a0f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c6be52b5-ca40-4e81-abf1-823bc4b4859c-diff.temp
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
+       call      qword ptr [7FFB478B0930]
+       mov       r11,7FFB47250930
-       call      qword ptr [7FFB47890830]
-       mov       r11,7FFB47230830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
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
+       mov       rdx,7FFB47969660
-       mov       rdx,7FFB4790E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB47890828]
-       mov       r11,7FFB47230828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969588
-       mov       rdx,7FFB4790E860
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
+       vucomisd  xmm0,qword ptr [7FFB478AAC40]
+       vdivsd    xmm0,xmm0,[7FFB478AAC38]
-       vucomisd  xmm0,qword ptr [7FFB47887D80]
-       vdivsd    xmm0,xmm0,[7FFB47887D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,214F651D300
-       mov       rcx,236BC2EB308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,214F651D2F8
-       mov       rdx,236BC2EB300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,214F651D300
-       mov       rcx,236BC2EB308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a6fded0d-0a3c-4b30-9dbd-8904c2d0fbe3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1e68d034-bb75-4ecd-b0a3-eab4586a42eb-diff.temp
index dbbbd6b..302be70 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1e68d034-bb75-4ecd-b0a3-eab4586a42eb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a6fded0d-0a3c-4b30-9dbd-8904c2d0fbe3-diff.temp
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
+       call      qword ptr [7FFB478B0830]
+       mov       r11,7FFB47250830
-       call      qword ptr [7FFB478D0830]
-       mov       r11,7FFB47270830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0828]
+       mov       r11,7FFB47250828
-       call      qword ptr [7FFB478D0828]
-       mov       r11,7FFB47270828
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
+       mov       rdx,7FFB4792E6E0
-       mov       rdx,7FFB4794E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0828]
+       mov       r11,7FFB47250828
-       call      qword ptr [7FFB478D0828]
-       mov       r11,7FFB47270828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E608
-       mov       rdx,7FFB4794E860
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
+       vucomisd  xmm0,qword ptr [7FFB478A7C00]
+       vdivsd    xmm0,xmm0,[7FFB478A7BF8]
-       vucomisd  xmm0,qword ptr [7FFB478C7D80]
-       vdivsd    xmm0,xmm0,[7FFB478C7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1DB289ED300
-       mov       rcx,283B852B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1DB289ED2F8
-       mov       rdx,283B852B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1DB289ED300
-       mov       rcx,283B852B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/716cdb02-89f2-423c-9fbf-4763d3777a3d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b36a6c31-a386-4f2c-8ddd-69cbb97ffc28-diff.temp
index ae71632..151de52 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b36a6c31-a386-4f2c-8ddd-69cbb97ffc28-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/716cdb02-89f2-423c-9fbf-4763d3777a3d-diff.temp
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
+       call      qword ptr [7FFB478C0830]
+       mov       r11,7FFB47260830
-       call      qword ptr [7FFB478D0830]
-       mov       r11,7FFB47270830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478C0828]
+       mov       r11,7FFB47260828
-       call      qword ptr [7FFB478D0828]
-       mov       r11,7FFB47270828
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
+       mov       rdx,7FFB4793E938
-       mov       rdx,7FFB4794E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478C0828]
+       mov       r11,7FFB47260828
-       call      qword ptr [7FFB478D0828]
-       mov       r11,7FFB47270828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E860
-       mov       rdx,7FFB4794E860
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
+       vucomisd  xmm0,qword ptr [7FFB478B7C00]
+       vdivsd    xmm0,xmm0,[7FFB478B7BF8]
-       vucomisd  xmm0,qword ptr [7FFB478C7D80]
-       vdivsd    xmm0,xmm0,[7FFB478C7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,24C1912D300
-       mov       rcx,283B852B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,24C1912D2F8
-       mov       rdx,283B852B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,24C1912D300
-       mov       rcx,283B852B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8172c922-f740-4bcd-a992-f74c9e5a01d2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/763879f7-ec2b-420f-be96-d53d214b261e-diff.temp
index ae71632..b92d710 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/763879f7-ec2b-420f-be96-d53d214b261e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8172c922-f740-4bcd-a992-f74c9e5a01d2-diff.temp
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
+       call      qword ptr [7FFB478B0830]
+       mov       r11,7FFB47250830
-       call      qword ptr [7FFB478D0830]
-       mov       r11,7FFB47270830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0828]
+       mov       r11,7FFB47250828
-       call      qword ptr [7FFB478D0828]
-       mov       r11,7FFB47270828
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
+       mov       rdx,7FFB4792E6E0
-       mov       rdx,7FFB4794E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0828]
+       mov       r11,7FFB47250828
-       call      qword ptr [7FFB478D0828]
-       mov       r11,7FFB47270828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E608
-       mov       rdx,7FFB4794E860
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
+       vucomisd  xmm0,qword ptr [7FFB478A7A80]
+       vdivsd    xmm0,xmm0,[7FFB478A7A78]
-       vucomisd  xmm0,qword ptr [7FFB478C7D80]
-       vdivsd    xmm0,xmm0,[7FFB478C7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1A0BBB8D300
-       mov       rcx,283B852B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1A0BBB8D2F8
-       mov       rdx,283B852B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1A0BBB8D300
-       mov       rcx,283B852B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/47a8bd88-7bcd-4409-8fd4-89e2f0883ba3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b2afc74c-0175-4ccb-a8a4-dcc2c755efd1-diff.temp
index ae71632..e19f0dc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b2afc74c-0175-4ccb-a8a4-dcc2c755efd1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/47a8bd88-7bcd-4409-8fd4-89e2f0883ba3-diff.temp
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
+       call      qword ptr [7FFB478C0930]
+       mov       r11,7FFB47260930
-       call      qword ptr [7FFB478D0830]
-       mov       r11,7FFB47270830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB478D0828]
-       mov       r11,7FFB47270828
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
+       mov       rdx,7FFB47979500
-       mov       rdx,7FFB4794E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB478D0828]
-       mov       r11,7FFB47270828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979428
-       mov       rdx,7FFB4794E860
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
+       vucomisd  xmm0,qword ptr [7FFB478BAAC0]
+       vdivsd    xmm0,xmm0,[7FFB478BAAB8]
-       vucomisd  xmm0,qword ptr [7FFB478C7D80]
-       vdivsd    xmm0,xmm0,[7FFB478C7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,239959FD300
-       mov       rcx,283B852B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,239959FD2F8
-       mov       rdx,283B852B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,239959FD300
-       mov       rcx,283B852B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dda642b7-3e10-4c60-b5d9-bee8e0157445-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/476c3d4b-b169-4f0d-8b3d-3eb9aa08554c-diff.temp
index ae71632..b7ddf23 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/476c3d4b-b169-4f0d-8b3d-3eb9aa08554c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/dda642b7-3e10-4c60-b5d9-bee8e0157445-diff.temp
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
+       call      qword ptr [7FFB478B0930]
+       mov       r11,7FFB47250930
-       call      qword ptr [7FFB478D0830]
-       mov       r11,7FFB47270830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478D0828]
-       mov       r11,7FFB47270828
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
+       mov       rdx,7FFB47969660
-       mov       rdx,7FFB4794E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478D0828]
-       mov       r11,7FFB47270828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969588
-       mov       rdx,7FFB4794E860
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
+       vucomisd  xmm0,qword ptr [7FFB478AAC40]
+       vdivsd    xmm0,xmm0,[7FFB478AAC38]
-       vucomisd  xmm0,qword ptr [7FFB478C7D80]
-       vdivsd    xmm0,xmm0,[7FFB478C7D78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,214F651D300
-       mov       rcx,283B852B308
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,214F651D2F8
-       mov       rdx,283B852B300
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,214F651D300
-       mov       rcx,283B852B308
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/43c740ba-5eff-429a-88c6-99df6bd544c9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bc458cf7-8a0a-4a0d-82f6-d5f77f1d4e02-diff.temp
index ae71632..302be70 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bc458cf7-8a0a-4a0d-82f6-d5f77f1d4e02-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/43c740ba-5eff-429a-88c6-99df6bd544c9-diff.temp
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
+       call      qword ptr [7FFB478C0830]
+       mov       r11,7FFB47260830
-       call      qword ptr [7FFB478B0830]
-       mov       r11,7FFB47250830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478C0828]
+       mov       r11,7FFB47260828
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
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
+       mov       rdx,7FFB4793E938
-       mov       rdx,7FFB4792E6E0
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478C0828]
+       mov       r11,7FFB47260828
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4793E860
-       mov       rdx,7FFB4792E608
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
+       vucomisd  xmm0,qword ptr [7FFB478B7C00]
+       vdivsd    xmm0,xmm0,[7FFB478B7BF8]
-       vucomisd  xmm0,qword ptr [7FFB478A7C00]
-       vdivsd    xmm0,xmm0,[7FFB478A7BF8]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,24C1912D300
-       mov       rcx,1DB289ED300
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,24C1912D2F8
-       mov       rdx,1DB289ED2F8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,24C1912D300
-       mov       rcx,1DB289ED300
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/721fd38f-6854-4ad4-91b2-e90660c90be7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/01bd034f-8692-4cec-9866-cb237d4094df-diff.temp
index 151de52..b92d710 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/01bd034f-8692-4cec-9866-cb237d4094df-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/721fd38f-6854-4ad4-91b2-e90660c90be7-diff.temp
```
**Diff for HasItemsWithPredicate method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1A0BBB8D300
-       mov       rcx,1DB289ED300
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1A0BBB8D2F8
-       mov       rdx,1DB289ED2F8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1A0BBB8D300
-       mov       rcx,1DB289ED300
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/99ce3075-54fd-4dd8-b0d9-63c15f0d5209-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/32fbe516-e3b9-4409-97fe-ed135733aa6f-diff.temp
index 151de52..e19f0dc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/32fbe516-e3b9-4409-97fe-ed135733aa6f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/99ce3075-54fd-4dd8-b0d9-63c15f0d5209-diff.temp
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
+       call      qword ptr [7FFB478C0930]
+       mov       r11,7FFB47260930
-       call      qword ptr [7FFB478B0830]
-       mov       r11,7FFB47250830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
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
+       mov       rdx,7FFB47979500
-       mov       rdx,7FFB4792E6E0
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979428
-       mov       rdx,7FFB4792E608
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
+       vucomisd  xmm0,qword ptr [7FFB478BAAC0]
+       vdivsd    xmm0,xmm0,[7FFB478BAAB8]
-       vucomisd  xmm0,qword ptr [7FFB478A7C00]
-       vdivsd    xmm0,xmm0,[7FFB478A7BF8]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,239959FD300
-       mov       rcx,1DB289ED300
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,239959FD2F8
-       mov       rdx,1DB289ED2F8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,239959FD300
-       mov       rcx,1DB289ED300
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f24de4ca-73c5-4ce9-834d-b519a0f5bfbb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/36f9465e-9203-4bba-b841-4094c08a4ce8-diff.temp
index 151de52..b7ddf23 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/36f9465e-9203-4bba-b841-4094c08a4ce8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f24de4ca-73c5-4ce9-834d-b519a0f5bfbb-diff.temp
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
+       call      qword ptr [7FFB478B0930]
+       mov       r11,7FFB47250930
-       call      qword ptr [7FFB478B0830]
-       mov       r11,7FFB47250830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
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
+       mov       rdx,7FFB47969660
-       mov       rdx,7FFB4792E6E0
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969588
-       mov       rdx,7FFB4792E608
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
+       vucomisd  xmm0,qword ptr [7FFB478AAC40]
+       vdivsd    xmm0,xmm0,[7FFB478AAC38]
-       vucomisd  xmm0,qword ptr [7FFB478A7C00]
-       vdivsd    xmm0,xmm0,[7FFB478A7BF8]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,214F651D300
-       mov       rcx,1DB289ED300
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,214F651D2F8
-       mov       rdx,1DB289ED2F8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,214F651D300
-       mov       rcx,1DB289ED300
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/387e2339-5354-4378-a151-0da2429b29b8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/13cd3718-3274-4b8e-9ef3-f0b4b549fbff-diff.temp
index 151de52..302be70 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/13cd3718-3274-4b8e-9ef3-f0b4b549fbff-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/387e2339-5354-4378-a151-0da2429b29b8-diff.temp
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
+       call      qword ptr [7FFB478B0830]
+       mov       r11,7FFB47250830
-       call      qword ptr [7FFB478C0830]
-       mov       r11,7FFB47260830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0828]
+       mov       r11,7FFB47250828
-       call      qword ptr [7FFB478C0828]
-       mov       r11,7FFB47260828
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
+       mov       rdx,7FFB4792E6E0
-       mov       rdx,7FFB4793E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0828]
+       mov       r11,7FFB47250828
-       call      qword ptr [7FFB478C0828]
-       mov       r11,7FFB47260828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB4792E608
-       mov       rdx,7FFB4793E860
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
+       vucomisd  xmm0,qword ptr [7FFB478A7A80]
+       vdivsd    xmm0,xmm0,[7FFB478A7A78]
-       vucomisd  xmm0,qword ptr [7FFB478B7C00]
-       vdivsd    xmm0,xmm0,[7FFB478B7BF8]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,1A0BBB8D300
-       mov       rcx,24C1912D300
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,1A0BBB8D2F8
-       mov       rdx,24C1912D2F8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,1A0BBB8D300
-       mov       rcx,24C1912D300
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/21d89b6c-c011-4d93-a516-7a275f6c63bf-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ba274bd6-c769-45fc-8b65-dd9a2ba3504c-diff.temp
index b92d710..e19f0dc 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ba274bd6-c769-45fc-8b65-dd9a2ba3504c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/21d89b6c-c011-4d93-a516-7a275f6c63bf-diff.temp
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
+       call      qword ptr [7FFB478C0930]
+       mov       r11,7FFB47260930
-       call      qword ptr [7FFB478C0830]
-       mov       r11,7FFB47260830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB478C0828]
-       mov       r11,7FFB47260828
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
+       mov       rdx,7FFB47979500
-       mov       rdx,7FFB4793E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB478C0828]
-       mov       r11,7FFB47260828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979428
-       mov       rdx,7FFB4793E860
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
+       vucomisd  xmm0,qword ptr [7FFB478BAAC0]
+       vdivsd    xmm0,xmm0,[7FFB478BAAB8]
-       vucomisd  xmm0,qword ptr [7FFB478B7C00]
-       vdivsd    xmm0,xmm0,[7FFB478B7BF8]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,239959FD300
-       mov       rcx,24C1912D300
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,239959FD2F8
-       mov       rdx,24C1912D2F8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,239959FD300
-       mov       rcx,24C1912D300
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0058e61e-9d71-493f-982b-604c4f220b0e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ce313e00-14ca-4b74-b7e4-da25f1944f8b-diff.temp
index b92d710..b7ddf23 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ce313e00-14ca-4b74-b7e4-da25f1944f8b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0058e61e-9d71-493f-982b-604c4f220b0e-diff.temp
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
+       call      qword ptr [7FFB478B0930]
+       mov       r11,7FFB47250930
-       call      qword ptr [7FFB478C0830]
-       mov       r11,7FFB47260830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478C0828]
-       mov       r11,7FFB47260828
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
+       mov       rdx,7FFB47969660
-       mov       rdx,7FFB4793E938
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478C0828]
-       mov       r11,7FFB47260828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969588
-       mov       rdx,7FFB4793E860
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
+       vucomisd  xmm0,qword ptr [7FFB478AAC40]
+       vdivsd    xmm0,xmm0,[7FFB478AAC38]
-       vucomisd  xmm0,qword ptr [7FFB478B7C00]
-       vdivsd    xmm0,xmm0,[7FFB478B7BF8]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,214F651D300
-       mov       rcx,24C1912D300
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,214F651D2F8
-       mov       rdx,24C1912D2F8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,214F651D300
-       mov       rcx,24C1912D300
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5e247e67-250e-44b0-873c-2f03f578b85d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/eac58bb1-9d60-45a9-9e95-2d0cd0c66534-diff.temp
index b92d710..302be70 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/eac58bb1-9d60-45a9-9e95-2d0cd0c66534-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5e247e67-250e-44b0-873c-2f03f578b85d-diff.temp
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
+       call      qword ptr [7FFB478C0930]
+       mov       r11,7FFB47260930
-       call      qword ptr [7FFB478B0830]
-       mov       r11,7FFB47250830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
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
+       mov       rdx,7FFB47979500
-       mov       rdx,7FFB4792E6E0
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478C0928]
+       mov       r11,7FFB47260928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47979428
-       mov       rdx,7FFB4792E608
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
+       vucomisd  xmm0,qword ptr [7FFB478BAAC0]
+       vdivsd    xmm0,xmm0,[7FFB478BAAB8]
-       vucomisd  xmm0,qword ptr [7FFB478A7A80]
-       vdivsd    xmm0,xmm0,[7FFB478A7A78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,239959FD300
-       mov       rcx,1A0BBB8D300
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,239959FD2F8
-       mov       rdx,1A0BBB8D2F8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,239959FD300
-       mov       rcx,1A0BBB8D300
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/22d56bc9-2430-4d83-90ef-8f0e45a2e0dc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7e019042-8fdf-4a21-b885-bb8a0de8e563-diff.temp
index e19f0dc..b7ddf23 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7e019042-8fdf-4a21-b885-bb8a0de8e563-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/22d56bc9-2430-4d83-90ef-8f0e45a2e0dc-diff.temp
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
+       call      qword ptr [7FFB478B0930]
+       mov       r11,7FFB47250930
-       call      qword ptr [7FFB478B0830]
-       mov       r11,7FFB47250830
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
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
+       mov       rdx,7FFB47969660
-       mov       rdx,7FFB4792E6E0
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478B0828]
-       mov       r11,7FFB47250828
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969588
-       mov       rdx,7FFB4792E608
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
+       vucomisd  xmm0,qword ptr [7FFB478AAC40]
+       vdivsd    xmm0,xmm0,[7FFB478AAC38]
-       vucomisd  xmm0,qword ptr [7FFB478A7A80]
-       vdivsd    xmm0,xmm0,[7FFB478A7A78]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,214F651D300
-       mov       rcx,1A0BBB8D300
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,214F651D2F8
-       mov       rdx,1A0BBB8D2F8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,214F651D300
-       mov       rcx,1A0BBB8D300
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d7bbc9de-d050-4b25-8f64-add237674e36-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/405f1630-0d75-4f42-b2df-0d68f3351993-diff.temp
index e19f0dc..302be70 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/405f1630-0d75-4f42-b2df-0d68f3351993-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d7bbc9de-d050-4b25-8f64-add237674e36-diff.temp
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
+       call      qword ptr [7FFB478B0930]
+       mov       r11,7FFB47250930
-       call      qword ptr [7FFB478C0930]
-       mov       r11,7FFB47260930
        mov       rcx,[rbp+0FFC8]
 M02_L06:
        jmp       short M02_L07
        mov       dword ptr [rbp+0FFD4],1
        jmp       short M02_L06
        jne       short M02_L02
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478C0928]
-       mov       r11,7FFB47260928
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
+       mov       rdx,7FFB47969660
-       mov       rdx,7FFB47979500
        mov       rcx,rsi
 M02_L03:
        jmp       short M02_L04
        je        short M02_L03
        test      r11,r11
        mov       r11,[r14+28]
 M02_L02:
        je        short M02_L06
        test      eax,eax
+       call      qword ptr [7FFB478B0928]
+       mov       r11,7FFB47250928
-       call      qword ptr [7FFB478C0928]
-       mov       r11,7FFB47260928
        mov       [rbp+0FFC8],rcx
        mov       rcx,rax
        call      qword ptr [r11]
        mov       rcx,rbx
 M02_L01:
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,7FFB47969588
-       mov       rdx,7FFB47979428
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
+       vucomisd  xmm0,qword ptr [7FFB478AAC40]
+       vdivsd    xmm0,xmm0,[7FFB478AAC38]
-       vucomisd  xmm0,qword ptr [7FFB478BAAC0]
-       vdivsd    xmm0,xmm0,[7FFB478BAAB8]
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
 ; 			                                                 ^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
 ; Total bytes of code 156
        ret
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,20
        mov       [rsi+54],bl
 M00_L03:
        mov       ebx,eax
        call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
        mov       rdx,rdi
        mov       r8,rbx
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,rbx
+       mov       rcx,214F651D300
-       mov       rcx,239959FD300
        mov       [rbx+18],rdx
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rbx+8]
        mov       rdx,[rdx]
+       mov       rdx,214F651D2F8
-       mov       rdx,239959FD2F8
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
        jne       short M00_L00
        test      r8,r8
        mov       r8,[rcx]
+       mov       rcx,214F651D300
-       mov       rcx,239959FD300
        mov       rdi,[rcx+2B0]
        mov       rsi,[rcx+18]
        sub       rsp,20
        push      rbx
        push      rsi
        push      rdi
 ; 		^
 ; 		}
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(this._people.HasItems(p => p.Age.TotalDays > 5));
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/81fd74ac-efe9-4673-914a-0468f57c436a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8fcb366c-ad55-44b2-a05d-be6c93052a4f-diff.temp
index b7ddf23..302be70 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8fcb366c-ad55-44b2-a05d-be6c93052a4f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/81fd74ac-efe9-4673-914a-0468f57c436a-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5c52383b-490b-490b-bf6e-e51f6270234d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7f83d5f7-5bf1-4bca-afbe-2d43345fe918-diff.temp
index d3fdeff..814689b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7f83d5f7-5bf1-4bca-afbe-2d43345fe918-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5c52383b-490b-490b-bf6e-e51f6270234d-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4754C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790FF90
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+60]
        je        short M01_L28
        cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47940048
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47940088
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479400F8
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479400F8
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479400D8
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47940110
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+88]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47940048
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,2AADCA02FF8
-       mov       r8,1E8E6052FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/62d0a3fc-cc59-44db-b431-42dd4c18691c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d8b6f889-de88-4fb6-a9d8-82ccdce4400b-diff.temp
index d3fdeff..fc9df85 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d8b6f889-de88-4fb6-a9d8-82ccdce4400b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/62d0a3fc-cc59-44db-b431-42dd4c18691c-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4755C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4791FF90
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+60]
        je        short M01_L28
        cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950048
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950088
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500F8
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500F8
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500D8
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950110
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+88]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950048
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,16B5A3C2FF8
-       mov       r8,1E8E6052FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3d1a6865-71bb-4fb4-93e4-68d37de86169-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/85ce2d0a-7415-40fb-b43d-48f76984c5ab-diff.temp
index d3fdeff..b7bb729 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/85ce2d0a-7415-40fb-b43d-48f76984c5ab-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3d1a6865-71bb-4fb4-93e4-68d37de86169-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4754C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F428
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F4D8
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F518
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F588
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F588
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F568
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F5A0
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F4D8
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,18F2C352FF8
-       mov       r8,1E8E6052FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7e15f59c-fa8d-4613-8dad-18bfa3f85ac1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9ae3a566-c7a0-47c2-a85d-9af9bb04a679-diff.temp
index d3fdeff..1e71420 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9ae3a566-c7a0-47c2-a85d-9af9bb04a679-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7e15f59c-fa8d-4613-8dad-18bfa3f85ac1-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4755C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4791FFD8
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+60]
        je        short M01_L28
        cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950058
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950098
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950108
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950108
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500E8
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950120
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+88]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950058
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,232C2592FF8
-       mov       r8,1E8E6052FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4ba24d08-5816-4dc7-8df9-a4c77a3b932a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5c98c4bb-ca4c-49be-8d24-ce61c21ced4f-diff.temp
index d3fdeff..94d4045 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5c98c4bb-ca4c-49be-8d24-ce61c21ced4f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4ba24d08-5816-4dc7-8df9-a4c77a3b932a-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4757C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A110
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A1B8
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A208
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A240
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,2303C7B3000
-       mov       r8,1E8E6052FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3d0b51d7-4d39-44c7-aadc-6a4cbfec0020-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ce258439-bb33-47f6-b7cd-3640137a33c5-diff.temp
index d3fdeff..b331fad 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ce258439-bb33-47f6-b7cd-3640137a33c5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3d0b51d7-4d39-44c7-aadc-6a4cbfec0020-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4758C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A1E0
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A288
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2D8
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A310
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,1C8078F3000
-       mov       r8,1E8E6052FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98831b32-c120-4826-afb5-6acdaf656f58-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6ee712eb-d101-416a-92ee-c58391cd9aa9-diff.temp
index d3fdeff..f770540 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6ee712eb-d101-416a-92ee-c58391cd9aa9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/98831b32-c120-4826-afb5-6acdaf656f58-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4754C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790FF90
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+60]
        je        short M01_L28
        cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47940048
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47940088
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479400F8
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479400F8
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479400D8
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47940110
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+88]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47940048
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,2AADCA02FF8
-       mov       r8,1C658D12FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/626e6106-9bc9-4f63-9769-2791d8d2741c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1175bf45-2139-473a-bb1c-d6e5e55eabf8-diff.temp
index 814689b..fc9df85 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1175bf45-2139-473a-bb1c-d6e5e55eabf8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/626e6106-9bc9-4f63-9769-2791d8d2741c-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4755C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4791FF90
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+60]
        je        short M01_L28
        cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950048
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950088
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500F8
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500F8
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500D8
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950110
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+88]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950048
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,16B5A3C2FF8
-       mov       r8,1C658D12FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f00475c-b8b7-45c4-918f-bc8698ff9692-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/efa76672-4350-49a3-9b35-f9f288813562-diff.temp
index 814689b..b7bb729 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/efa76672-4350-49a3-9b35-f9f288813562-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f00475c-b8b7-45c4-918f-bc8698ff9692-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4754C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F428
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F4D8
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F518
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F588
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F588
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F568
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F5A0
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F4D8
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,18F2C352FF8
-       mov       r8,1C658D12FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f73a66a8-f128-4adb-adcd-c4fc1a6ce26a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/85824d3d-1bdb-427b-97e2-4830f98dc436-diff.temp
index 814689b..1e71420 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/85824d3d-1bdb-427b-97e2-4830f98dc436-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f73a66a8-f128-4adb-adcd-c4fc1a6ce26a-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4755C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4791FFD8
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+60]
        je        short M01_L28
        cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950058
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950098
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950108
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950108
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500E8
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950120
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+88]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950058
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,232C2592FF8
-       mov       r8,1C658D12FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a3c1e673-1bec-495b-88a8-5f7fff84a60c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ab6579ad-d158-4198-9574-341d25c40182-diff.temp
index 814689b..94d4045 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ab6579ad-d158-4198-9574-341d25c40182-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a3c1e673-1bec-495b-88a8-5f7fff84a60c-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4757C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A110
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A1B8
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A208
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A240
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,2303C7B3000
-       mov       r8,1C658D12FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/df7fefa9-2072-41d3-9eb1-fb713c42a0eb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1071e612-aefb-4b8f-8d10-f5ca89c4895d-diff.temp
index 814689b..b331fad 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1071e612-aefb-4b8f-8d10-f5ca89c4895d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/df7fefa9-2072-41d3-9eb1-fb713c42a0eb-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4758C270
-       mov       rdx,7FFB4756C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A1E0
-       mov       rdx,7FFB4792FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB47960048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A288
-       mov       rdx,7FFB47960088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB479600F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB479600F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2D8
-       mov       rdx,7FFB479600D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A310
-       mov       rdx,7FFB47960110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB47960048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,1C8078F3000
-       mov       r8,1C658D12FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4a3409a8-ca2a-4eb3-8cd7-494e6eb17207-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3cd6c015-c333-4f61-9522-2e160151606a-diff.temp
index 814689b..f770540 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3cd6c015-c333-4f61-9522-2e160151606a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4a3409a8-ca2a-4eb3-8cd7-494e6eb17207-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4755C270
-       mov       rdx,7FFB4754C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4791FF90
-       mov       rdx,7FFB4790FF90
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+60]
        je        short M01_L28
        cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950048
-       mov       rdx,7FFB47940048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950088
-       mov       rdx,7FFB47940088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500F8
-       mov       rdx,7FFB479400F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500F8
-       mov       rdx,7FFB479400F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500D8
-       mov       rdx,7FFB479400D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950110
-       mov       rdx,7FFB47940110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+88]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950048
-       mov       rdx,7FFB47940048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,16B5A3C2FF8
-       mov       r8,2AADCA02FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e110ab95-481f-42b8-96ec-2a4b4ca21b1a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6aa57354-bed4-4c8a-858a-219ade1abd34-diff.temp
index fc9df85..b7bb729 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6aa57354-bed4-4c8a-858a-219ade1abd34-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e110ab95-481f-42b8-96ec-2a4b4ca21b1a-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F428
-       mov       rdx,7FFB4790FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F4D8
-       mov       rdx,7FFB47940048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F518
-       mov       rdx,7FFB47940088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F588
-       mov       rdx,7FFB479400F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F588
-       mov       rdx,7FFB479400F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F568
-       mov       rdx,7FFB479400D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F5A0
-       mov       rdx,7FFB47940110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F4D8
-       mov       rdx,7FFB47940048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,18F2C352FF8
-       mov       r8,2AADCA02FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bcd7be89-045b-422e-a8da-ee771fe4576a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4e6fa46a-918a-4efa-bfd8-3e8dd8d02afe-diff.temp
index fc9df85..1e71420 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4e6fa46a-918a-4efa-bfd8-3e8dd8d02afe-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/bcd7be89-045b-422e-a8da-ee771fe4576a-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4755C270
-       mov       rdx,7FFB4754C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4791FFD8
-       mov       rdx,7FFB4790FF90
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+60]
        je        short M01_L28
        cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950058
-       mov       rdx,7FFB47940048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950098
-       mov       rdx,7FFB47940088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950108
-       mov       rdx,7FFB479400F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950108
-       mov       rdx,7FFB479400F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500E8
-       mov       rdx,7FFB479400D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950120
-       mov       rdx,7FFB47940110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+88]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950058
-       mov       rdx,7FFB47940048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,232C2592FF8
-       mov       r8,2AADCA02FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1ba31751-9570-457f-9174-6d1e102a9805-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/32ffd1be-d576-4121-8a22-6ccedd4e7730-diff.temp
index fc9df85..94d4045 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/32ffd1be-d576-4121-8a22-6ccedd4e7730-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1ba31751-9570-457f-9174-6d1e102a9805-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4757C270
-       mov       rdx,7FFB4754C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A110
-       mov       rdx,7FFB4790FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB47940048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A1B8
-       mov       rdx,7FFB47940088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB479400F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB479400F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A208
-       mov       rdx,7FFB479400D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A240
-       mov       rdx,7FFB47940110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB47940048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,2303C7B3000
-       mov       r8,2AADCA02FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a211b6aa-5ecb-4200-8ed5-9c62bb262e66-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/830d1305-78e0-404d-89e2-bc03d2504bf5-diff.temp
index fc9df85..b331fad 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/830d1305-78e0-404d-89e2-bc03d2504bf5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a211b6aa-5ecb-4200-8ed5-9c62bb262e66-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4758C270
-       mov       rdx,7FFB4754C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A1E0
-       mov       rdx,7FFB4790FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB47940048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A288
-       mov       rdx,7FFB47940088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB479400F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB479400F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2D8
-       mov       rdx,7FFB479400D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A310
-       mov       rdx,7FFB47940110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB47940048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,1C8078F3000
-       mov       r8,2AADCA02FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e55fe63e-b7a9-439d-9422-5e63357b0df5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/af68181e-8a09-47a2-babc-067eadda889d-diff.temp
index fc9df85..f770540 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/af68181e-8a09-47a2-babc-067eadda889d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e55fe63e-b7a9-439d-9422-5e63357b0df5-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4754C270
-       mov       rdx,7FFB4755C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F428
-       mov       rdx,7FFB4791FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F4D8
-       mov       rdx,7FFB47950048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F518
-       mov       rdx,7FFB47950088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F588
-       mov       rdx,7FFB479500F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F588
-       mov       rdx,7FFB479500F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F568
-       mov       rdx,7FFB479500D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F5A0
-       mov       rdx,7FFB47950110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4790F4D8
-       mov       rdx,7FFB47950048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,18F2C352FF8
-       mov       r8,16B5A3C2FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/93a3ae5a-317e-4ed0-bb2b-bcdfb9903aee-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/258bb3f3-cd94-4a53-b912-e36244832173-diff.temp
index b7bb729..1e71420 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/258bb3f3-cd94-4a53-b912-e36244832173-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/93a3ae5a-317e-4ed0-bb2b-bcdfb9903aee-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950058
-       mov       rdx,7FFB47950048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950098
-       mov       rdx,7FFB47950088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950108
-       mov       rdx,7FFB479500F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950108
-       mov       rdx,7FFB479500F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500E8
-       mov       rdx,7FFB479500D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950120
-       mov       rdx,7FFB47950110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+88]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950058
-       mov       rdx,7FFB47950048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,232C2592FF8
-       mov       r8,16B5A3C2FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a1dbc9f1-abb8-4c31-9f2a-ada003a56b1d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6c9c4dd6-c03d-457a-b019-dda7b51f9504-diff.temp
index b7bb729..94d4045 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6c9c4dd6-c03d-457a-b019-dda7b51f9504-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/a1dbc9f1-abb8-4c31-9f2a-ada003a56b1d-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4757C270
-       mov       rdx,7FFB4755C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A110
-       mov       rdx,7FFB4791FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB47950048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A1B8
-       mov       rdx,7FFB47950088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB479500F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB479500F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A208
-       mov       rdx,7FFB479500D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A240
-       mov       rdx,7FFB47950110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB47950048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,2303C7B3000
-       mov       r8,16B5A3C2FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/69c9ceb1-4ed8-4a27-ba05-4d91645e33c1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4b86300d-37e5-4810-8690-6f4e8373b09e-diff.temp
index b7bb729..b331fad 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/4b86300d-37e5-4810-8690-6f4e8373b09e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/69c9ceb1-4ed8-4a27-ba05-4d91645e33c1-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4758C270
-       mov       rdx,7FFB4755C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A1E0
-       mov       rdx,7FFB4791FF90
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB47950048
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A288
-       mov       rdx,7FFB47950088
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB479500F8
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB479500F8
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2D8
-       mov       rdx,7FFB479500D8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A310
-       mov       rdx,7FFB47950110
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB47950048
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,1C8078F3000
-       mov       r8,16B5A3C2FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0f7a3c13-a418-417e-9dbb-fcc9c9fa134c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6381ae10-0a65-46d6-999b-1be2fbeff4a5-diff.temp
index b7bb729..f770540 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6381ae10-0a65-46d6-999b-1be2fbeff4a5-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0f7a3c13-a418-417e-9dbb-fcc9c9fa134c-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4755C270
-       mov       rdx,7FFB4754C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4791FFD8
-       mov       rdx,7FFB4790F428
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+60]
-       mov       rcx,[r15+58]
        je        short M01_L28
+       cmp       qword ptr [r15+60],0
-       cmp       qword ptr [r15+58],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950058
-       mov       rdx,7FFB4790F4D8
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+78]
-       mov       r12,[r15+70]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950098
-       mov       rdx,7FFB4790F518
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+68]
-       mov       r15,[r15+60]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950108
-       mov       rdx,7FFB4790F588
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+80]
-       mov       r11,[r15+78]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950108
-       mov       rdx,7FFB4790F588
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+80]
-       mov       r11,[r15+78]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB479500E8
-       mov       rdx,7FFB4790F568
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950120
-       mov       rdx,7FFB4790F5A0
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+88]
-       mov       rax,[r15+80]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+70]
-       mov       rdx,[r15+68]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB47950058
-       mov       rdx,7FFB4790F4D8
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+60]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,232C2592FF8
-       mov       r8,18F2C352FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/11a78e09-3dec-4341-ab00-27f5a4588e24-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/46891178-60ce-43ae-90a6-1e8a1692bca4-diff.temp
index 1e71420..94d4045 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/46891178-60ce-43ae-90a6-1e8a1692bca4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/11a78e09-3dec-4341-ab00-27f5a4588e24-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4757C270
-       mov       rdx,7FFB4754C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A110
-       mov       rdx,7FFB4790F428
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+58]
        je        short M01_L28
        cmp       qword ptr [r15+58],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB4790F4D8
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+70]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A1B8
-       mov       rdx,7FFB4790F518
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB4790F588
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+78]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB4790F588
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+78]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A208
-       mov       rdx,7FFB4790F568
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A240
-       mov       rdx,7FFB4790F5A0
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+80]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB4790F4D8
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+60]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,2303C7B3000
-       mov       r8,18F2C352FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9ef182c4-35a7-4620-9f51-c7a6f3b45775-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fb84d160-43e8-4af5-ba60-8024c3ff563b-diff.temp
index 1e71420..b331fad 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/fb84d160-43e8-4af5-ba60-8024c3ff563b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9ef182c4-35a7-4620-9f51-c7a6f3b45775-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4758C270
-       mov       rdx,7FFB4754C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A1E0
-       mov       rdx,7FFB4790F428
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+58]
        je        short M01_L28
        cmp       qword ptr [r15+58],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB4790F4D8
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+70]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A288
-       mov       rdx,7FFB4790F518
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB4790F588
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+78]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB4790F588
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+78]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2D8
-       mov       rdx,7FFB4790F568
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A310
-       mov       rdx,7FFB4790F5A0
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+80]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB4790F4D8
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+60]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,1C8078F3000
-       mov       r8,18F2C352FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b68fbc71-8578-4173-8c44-7e918881937e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1aa2505d-caa7-4713-b3c3-4903ea2f789f-diff.temp
index 1e71420..f770540 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1aa2505d-caa7-4713-b3c3-4903ea2f789f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b68fbc71-8578-4173-8c44-7e918881937e-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4757C270
-       mov       rdx,7FFB4755C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A110
-       mov       rdx,7FFB4791FFD8
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB47950058
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A1B8
-       mov       rdx,7FFB47950098
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB47950108
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A228
-       mov       rdx,7FFB47950108
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A208
-       mov       rdx,7FFB479500E8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A240
-       mov       rdx,7FFB47950120
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4797A178
-       mov       rdx,7FFB47950058
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,2303C7B3000
-       mov       r8,232C2592FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e1745c04-2a01-44a5-8f56-88fbfb967860-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/37e1272d-5b58-496c-823d-945125774a7e-diff.temp
index 94d4045..b331fad 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/37e1272d-5b58-496c-823d-945125774a7e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e1745c04-2a01-44a5-8f56-88fbfb967860-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4758C270
-       mov       rdx,7FFB4755C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A1E0
-       mov       rdx,7FFB4791FFD8
 M01_L28:
        jmp       short M01_L29
+       mov       rcx,[r15+58]
-       mov       rcx,[r15+60]
        je        short M01_L28
+       cmp       qword ptr [r15+58],0
-       cmp       qword ptr [r15+60],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L27:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB47950058
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
+       mov       r12,[r15+70]
-       mov       r12,[r15+78]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A288
-       mov       rdx,7FFB47950098
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        jmp       short M01_L24
        je        short M01_L23
        test      r15,r15
+       mov       r15,[r15+60]
-       mov       r15,[r15+68]
        dec       r14d
        mov       r14d,[rsp+48]
        mov       rcx,r14
        mov       [rsp+48],ebx
 M01_L19:
        jl        near ptr M01_L15
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB47950108
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
 M01_L15:
        jmp       near ptr M01_L19
        jl        near ptr M01_L11
        cmp       r12d,[rsp+48]
        inc       r12d
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB47950108
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
+       mov       r11,[r15+78]
-       mov       r11,[r15+80]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
 M01_L11:
        je        near ptr M01_L15
        test      edx,ecx
        movzx     edx,dl
        setle     dl
        cmp       [rsp+48],r13d
        mov       r13d,[rbp+8]
        movzx     ecx,cl
        setge     cl
        cmp       dword ptr [rsp+48],0
        je        near ptr M01_L15
        test      rbp,rbp
        jle       near ptr M01_L19
        cmp       dword ptr [rsp+48],1
        mov       r12d,1
        mov       ebx,1
        call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       r8d,r8d
        mov       r9d,ebx
        mov       rdx,rbp
        mov       rcx,rax
        mov       [rsp+20],rsi
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2D8
-       mov       rdx,7FFB479500E8
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A310
-       mov       rdx,7FFB47950120
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
+       mov       rax,[r15+80]
-       mov       rax,[r15+88]
        mov       rcx,r14
 M01_L04:
        jmp       near ptr M01_L22
        je        near ptr M01_L21
        test      rdx,rdx
+       mov       rdx,[r15+68]
-       mov       rdx,[r15+70]
        mov       rcx,r14
 M01_L03:
        jne       short M01_L04
        test      r12,r12
        mov       r12,rax
        call      CORINFO_HELP_ISINSTANCEOFCLASS
        mov       rdx,rbx
        mov       rcx,rdx
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB47950058
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
+       mov       rdx,[r15+60]
-       mov       rdx,[r15+68]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
 M01_L00:
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,1C8078F3000
-       mov       r8,232C2592FF8
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/86094f15-b6e3-456e-9459-e5ab3a65dac6-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/694a6c49-e73a-42e2-8d21-d2205e0e0138-diff.temp
index 94d4045..f770540 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/694a6c49-e73a-42e2-8d21-d2205e0e0138-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/86094f15-b6e3-456e-9459-e5ab3a65dac6-diff.temp
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
call      CORINFO_HELP_THROW
        mov       rcx,rsi
        call      System.ArgumentNullException..ctor(System.String)
        mov       rcx,rsi
        mov       rdx,rax
        call      CORINFO_HELP_STRCNS
+       mov       rdx,7FFB4758C270
-       mov       rdx,7FFB4757C270
        mov       ecx,7BD
        mov       rsi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.ArgumentNullException
 M01_L30:
        jne       near ptr M01_L00
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rax
        call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
 M01_L29:
        mov       rcx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A1E0
-       mov       rdx,7FFB4797A110
 M01_L28:
        jmp       short M01_L29
        mov       rcx,[r15+58]
        je        short M01_L28
        cmp       qword ptr [r15+58],0
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rbp]
 M01_L24:
        jmp       short M01_L25
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB4797A178
 M01_L23:
        jmp       near ptr M01_L10
        mov       rax,r12
        je        near ptr M01_L09
        test      r12,r12
        mov       r12,[r15+70]
        mov       ebx,[rsp+48]
        mov       rcx,r14
        mov       rsi,[rdi+10]
        jle       short M01_L26
        cmp       dword ptr [rsp+48],0
        mov       rbp,rax
        call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       rdx,rbx
        mov       rcx,rdx
        lea       r8,[rsp+48]
 M01_L22:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A288
-       mov       rdx,7FFB4797A1B8
 M01_L21:
        jmp       near ptr M01_L07
        call      qword ptr [rax+10]
        mov       rax,[rax+48]
        mov       rax,[r12]
        mov       edx,1
        mov       rcx,r12
        mov       rax,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB4797A228
 M01_L16:
        jmp       short M01_L17
        mov       rax,[rsp+30]
        je        short M01_L16
        test      r11,r11
        mov       r11,[r15+78]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        lea       ecx,[r12+0FFFF]
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rcx*8+10]
        movsxd    rcx,r12d
        jae       near ptr M01_L32
        cmp       r12d,r13d
        mov       r13d,[rbp+8]
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        mov       r11,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2F8
-       mov       rdx,7FFB4797A228
 M01_L12:
        jmp       short M01_L13
        mov       r9,[rsp+28]
        mov       r8,[rsp+30]
        je        short M01_L12
        test      r11,r11
        mov       r11,[r15+78]
        mov       rcx,r14
        mov       [rsp+28],r9
        mov       r9,[rbp+rcx*8+10]
        movsxd    rcx,ecx
        jae       near ptr M01_L32
        cmp       ecx,r13d
        lea       ecx,[r12+0FFFF]
        mov       [rsp+30],r8
        mov       r8,[rbp+rax*8+10]
        mov       [rsp+38],rax
        movsxd    rax,r12d
        mov       [rsp+20],rsi
 M01_L10:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A2D8
-       mov       rdx,7FFB4797A208
 M01_L09:
        ret
        pop       r15
        pop       r14
        pop       r13
        pop       r12
        pop       rdi
        pop       rsi
        pop       rbp
        pop       rbx
        add       rsp,58
        mov       rcx,r12
 M01_L06:
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A310
-       mov       rdx,7FFB4797A240
 M01_L05:
        jmp       short M01_L06
        je        short M01_L05
        test      rax,rax
        mov       rax,[r15+80]
        mov       rcx,r14
 M01_L02:
        mov       rdx,rax
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rdx,7FFB4798A248
-       mov       rdx,7FFB4797A178
 M01_L01:
        jmp       short M01_L02
        je        short M01_L01
        test      rdx,rdx
        mov       rdx,[r15+60]
        mov       r15,[rdx]
        mov       rdx,[rcx+30]
        mov       rcx,r14
        mov       r14,[rdi]
        je        near ptr M01_L30
        test      rbx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        je        near ptr M01_L27
        test      rdx,rdx
        mov       rdx,rsi
        mov       rbp,rdi
        mov       rsi,r8
        mov       rbx,rdx
        mov       rdi,rcx
        mov       [rsp+50],rcx
        sub       rsp,58
        push      rbx
        push      rbp
        push      rsi
        push      rdi
        push      r12
        push      r13
        push      r14
        push      r15
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
 ; Total bytes of code 85
        ret
        pop       rdi
        pop       rsi
        add       rsp,28
        mov       [rsi+54],al
        movzx     eax,al
        setle     al
        test      eax,eax
        call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       rsi,[rsi+18]
        mov       rcx,rdi
        call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rdi
        mov       r8,[r8]
+       mov       r8,1C8078F3000
-       mov       r8,2303C7B3000
        mov       rdx,[rsi+2B0]
        mov       rdi,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
        mov       rsi,rcx
        sub       rsp,28
        push      rsi
        push      rdi
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(people.DoesNotHaveItems());
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			var people = new SortedSet<PersonProper>(_people);
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ee058886-7ae8-46c7-978f-c3a013375162-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/548e460d-00ba-4a02-bf26-35fb6274cee7-diff.temp
index b331fad..f770540 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/548e460d-00ba-4a02-bf26-35fb6274cee7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ee058886-7ae8-46c7-978f-c3a013375162-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6be1f301-ebc7-48ff-b85b-9076bb0eb74a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/da014a10-a1a4-4008-9a33-69bc9b0b2991-diff.temp
index d07b826..76267c6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/da014a10-a1a4-4008-9a33-69bc9b0b2991-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/6be1f301-ebc7-48ff-b85b-9076bb0eb74a-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/49fa8514-94bc-4afc-a665-eb87226bcc43-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e47456a5-1f22-4d45-9044-5e9d545afdc7-diff.temp
index d07b826..2c0c2f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e47456a5-1f22-4d45-9044-5e9d545afdc7-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/49fa8514-94bc-4afc-a665-eb87226bcc43-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/89bbae52-a756-40b6-b1b5-df8558981550-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8c67a6e3-72aa-4343-8286-32b41a7b4999-diff.temp
index d07b826..2c0c2f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8c67a6e3-72aa-4343-8286-32b41a7b4999-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/89bbae52-a756-40b6-b1b5-df8558981550-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d3a7bd93-c152-49ff-85f5-00a446e5e5a5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9b367f24-f121-4729-93dc-33a061be5c58-diff.temp
index d07b826..76267c6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9b367f24-f121-4729-93dc-33a061be5c58-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d3a7bd93-c152-49ff-85f5-00a446e5e5a5-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/39664494-dd66-49f8-8c3a-d3fd5f8e40b0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1feb8159-2561-4e5c-9657-88f4e1ffb546-diff.temp
index d07b826..2c0c2f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1feb8159-2561-4e5c-9657-88f4e1ffb546-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/39664494-dd66-49f8-8c3a-d3fd5f8e40b0-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/67b8bffe-c30b-4ee7-9cd2-f8fe3a65eb19-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3cc9c804-e70c-4bde-94a9-ca50b066b2f9-diff.temp
index d07b826..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/3cc9c804-e70c-4bde-94a9-ca50b066b2f9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/67b8bffe-c30b-4ee7-9cd2-f8fe3a65eb19-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b46834cc-91a8-4c15-b8da-bff33718a706-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2aba1341-78ec-40bb-93ae-764b023ce082-diff.temp
index d07b826..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/2aba1341-78ec-40bb-93ae-764b023ce082-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b46834cc-91a8-4c15-b8da-bff33718a706-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/31a389c3-1079-4756-8c83-dfa5161ed5ae-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63908573-f45f-4512-b463-1f831bfd71bf-diff.temp
index 76267c6..2c0c2f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/63908573-f45f-4512-b463-1f831bfd71bf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/31a389c3-1079-4756-8c83-dfa5161ed5ae-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1e299c15-6b00-42f9-986a-ce3b5caeaf72-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b19f8e16-06a5-49ea-97d0-73e15e0f36c8-diff.temp
index 76267c6..2c0c2f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/b19f8e16-06a5-49ea-97d0-73e15e0f36c8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1e299c15-6b00-42f9-986a-ce3b5caeaf72-diff.temp
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/737f936e-fd90-43aa-8539-51130ca8f340-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c8498da-4750-49bf-945e-7acae0dd2653-diff.temp
index 76267c6..2c0c2f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/9c8498da-4750-49bf-945e-7acae0dd2653-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/737f936e-fd90-43aa-8539-51130ca8f340-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7649eccc-6070-4fa2-897e-773956e9bf03-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/502ff880-4562-4429-8a96-506b117450e8-diff.temp
index 76267c6..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/502ff880-4562-4429-8a96-506b117450e8-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/7649eccc-6070-4fa2-897e-773956e9bf03-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f9288b9-eff8-4886-8a54-1e2601fa818d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5a8541e3-f99d-40af-887c-3e2b6451c25f-diff.temp
index 76267c6..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5a8541e3-f99d-40af-887c-3e2b6451c25f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1f9288b9-eff8-4886-8a54-1e2601fa818d-diff.temp
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/21f5444d-e0cb-4b4f-b9d4-0efd08ea1241-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/87439e9f-ee4d-45b4-bb7e-001cd489d24f-diff.temp
index 2c0c2f4..76267c6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/87439e9f-ee4d-45b4-bb7e-001cd489d24f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/21f5444d-e0cb-4b4f-b9d4-0efd08ea1241-diff.temp
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/85b940a0-0fee-4fd4-be56-e9d823dfc1f9-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d1aa7aa7-443f-4c69-b07f-00c27e4c5e81-diff.temp
index 2c0c2f4..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d1aa7aa7-443f-4c69-b07f-00c27e4c5e81-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/85b940a0-0fee-4fd4-be56-e9d823dfc1f9-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ba14d4e6-b244-4f7d-a872-4a1668b43202-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ddf195df-4923-4ad6-a7d9-79370b4cfae3-diff.temp
index 2c0c2f4..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ddf195df-4923-4ad6-a7d9-79370b4cfae3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ba14d4e6-b244-4f7d-a872-4a1668b43202-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8fb5df39-bc46-4e9d-968d-d368cd8ce64c-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ae2837eb-d10c-4989-9f8c-a3e36681cdd0-diff.temp
index 2c0c2f4..76267c6 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ae2837eb-d10c-4989-9f8c-a3e36681cdd0-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/8fb5df39-bc46-4e9d-968d-d368cd8ce64c-diff.temp
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1bd7dc9a-664e-4c8d-b94d-ab321a03d749-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/546bc720-4858-4430-8e0a-d8d296400e8b-diff.temp
index 2c0c2f4..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/546bc720-4858-4430-8e0a-d8d296400e8b-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/1bd7dc9a-664e-4c8d-b94d-ab321a03d749-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/26faa57a-d845-4f68-bdd5-ea60e107d5d3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e8606494-161e-4ea0-a208-7fd8d3cf2303-diff.temp
index 2c0c2f4..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/e8606494-161e-4ea0-a208-7fd8d3cf2303-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/26faa57a-d845-4f68-bdd5-ea60e107d5d3-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/62093853-b140-4dbc-b79a-3181d25864dc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0c19ebf7-4f3a-44fc-ac1e-156a760674b1-diff.temp
index 76267c6..2c0c2f4 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/0c19ebf7-4f3a-44fc-ac1e-156a760674b1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/62093853-b140-4dbc-b79a-3181d25864dc-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/15a36ae9-0566-4f48-9530-f93929567749-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d4c4eea2-73d5-4cb4-890f-254ecd3d4c47-diff.temp
index 76267c6..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/d4c4eea2-73d5-4cb4-890f-254ecd3d4c47-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/15a36ae9-0566-4f48-9530-f93929567749-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/34aece67-2e4c-4321-916e-c1588fd33562-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5fbd6e39-ce04-4813-bef1-6244624029e1-diff.temp
index 76267c6..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/5fbd6e39-ce04-4813-bef1-6244624029e1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/34aece67-2e4c-4321-916e-c1588fd33562-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/72f6de42-8ffa-481c-93e3-43d5a9156ae4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c5ba71f6-deab-4c2d-b924-c3727d509029-diff.temp
index 2c0c2f4..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/c5ba71f6-deab-4c2d-b924-c3727d509029-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/72f6de42-8ffa-481c-93e3-43d5a9156ae4-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ae99615d-586d-4a17-bc7a-725134d13a10-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f685b55e-45d7-43d4-b641-43679058743e-diff.temp
index 2c0c2f4..7f794e3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/f685b55e-45d7-43d4-b641-43679058743e-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/6/appbin/net6.0/BenchmarkDotNet.Artifacts/results/ae99615d-586d-4a17-bc7a-725134d13a10-diff.temp
```
**Diff for HasItems method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```diff

```
