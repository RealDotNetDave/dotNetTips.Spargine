## DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark-20231028-005904
**Diff for As method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+1A0]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.As[[DotNetTips.Spargine.Tester.Models.RefTypes.IPerson, DotNetTips.Spargine.6.Tester]](System.Object)
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
+       call      qword ptr [7FF9C6775FA8]; DotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.IPerson, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.IPerson ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6777018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
        push      rbp
-       sub       rsp,40
+       push      rdi
+       sub       rsp,38
        lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
-       mov       [rbp-8],rcx
+       mov       [rbp-18],rax
+       mov       [rbp-10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C597E7D0],0
+       cmp       dword ptr [7FF9C6453418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       r9,11E24DDF618
+       mov       r9,237A6C08AC8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,11E84DD3020
+       mov       r9,237A6C02028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
-       mov       [rbp-10],rax
+       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       [rbp-18],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx]
-       mov       rdx,[rbp-10]
-       call      CORINFO_HELP_CHKCASTARRAY
+       mov       rdx,[rbp-18]
+       call      qword ptr [7FF9C5FBB858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
        nop
-       add       rsp,40
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 126
+; Total bytes of code 130
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for ClonePersonProperArray method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonProperArray()
        push      rdi
        push      rsi
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rsi,rcx
        mov       rdi,[rsi+198]
        test      rdi,rdi
        je        short M00_L02
        mov       rdx,rdi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
-       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
+       call      qword ptr [7FF9C5FBB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L01
        mov       rdx,rdi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9C67673D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
 M00_L00:
        mov       rdx,rax
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](System.Object)
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
+       call      qword ptr [7FF9C6767318]; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       [rsp+20],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67677B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rax
-       mov       r11,7FF9C54C07C0
-       call      qword ptr [7FF9C54C07C0]
+       mov       r11,7FF9C5E107E0
+       call      qword ptr [r11]
        jmp       short M00_L00
 M00_L02:
        mov       ecx,10
-       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
+       call      qword ptr [7FF9C629B780]
        int       3
-; Total bytes of code 158
+; Total bytes of code 160
+; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       test      rdx,rdx
+       je        short M01_L03
+       mov       rax,[rdx]
+       movzx     r8d,word ptr [rax+0E]
+       test      r8,r8
+       je        short M01_L02
+       mov       r9,[rax+38]
+       cmp       r8,4
+       jl        short M01_L01
+M01_L00:
+       cmp       [r9],rcx
+       je        short M01_L03
+       cmp       [r9+8],rcx
+       je        short M01_L03
+       cmp       [r9+10],rcx
+       je        short M01_L03
+       cmp       [r9+18],rcx
+       je        short M01_L03
+       add       r9,20
+       add       r8,0FFFFFFFFFFFFFFFC
+       cmp       r8,4
+       jge       short M01_L00
+       test      r8,r8
+       je        short M01_L02
+M01_L01:
+       cmp       [r9],rcx
+       je        short M01_L03
+       add       r9,8
+       dec       r8
+       test      r8,r8
+       jg        short M01_L01
+M01_L02:
+       test      dword ptr [rax],406C0000
+       jne       short M01_L04
+       xor       edx,edx
+M01_L03:
+       mov       rax,rdx
+       ret
+M01_L04:
+       jmp       qword ptr [7FF9C5FBB840]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+; Total bytes of code 107
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,58
+       sub       rsp,60
+       xor       eax,eax
+       mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
-       mov       [rsp+50],rcx
+       mov       [rsp+50],rax
+       mov       [rsp+58],rcx
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,[rsi+10]
        mov       rcx,rbx
        mov       rbp,[rcx+8]
        cmp       rbp,30
-       jle       near ptr M01_L06
+       jle       near ptr M02_L06
        mov       rcx,[rcx+30]
        test      rcx,rcx
-       je        near ptr M01_L06
-M01_L00:
+       je        near ptr M02_L06
+M02_L00:
        mov       rdx,rdi
-       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
+       call      qword ptr [7FF9C5FBB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       r14,rax
        test      r14,r14
-       je        near ptr M01_L07
+       je        near ptr M02_L07
        cmp       rbp,40
-       jle       near ptr M01_L08
+       jle       near ptr M02_L08
        mov       r11,[rbx+40]
        test      r11,r11
-       je        near ptr M01_L08
-M01_L01:
+       je        near ptr M02_L08
+M02_L01:
        mov       rcx,r14
        call      qword ptr [r11]
-       mov       ebx,eax
-       test      ebx,ebx
-       je        short M01_L04
-       mov       rdx,[rsi+10]
-       cmp       qword ptr [rdx+8],48
-       jle       near ptr M01_L14
-       mov       rcx,[rdx+48]
+       mov       ebp,eax
+       test      ebp,ebp
+       je        short M02_L04
+       mov       rcx,[rsi+10]
+       mov       rdx,[rcx+8]
+       mov       rdi,rdx
+       cmp       rdi,48
+       jle       near ptr M02_L14
+       mov       rcx,[rcx+48]
        test      rcx,rcx
-       je        near ptr M01_L14
-M01_L02:
-       movsxd    rdx,ebx
+       je        near ptr M02_L14
+M02_L02:
+       movsxd    rdx,ebp
        call      CORINFO_HELP_NEWARR_1_OBJ
-       mov       r15,rax
+       mov       rbx,rax
        mov       rcx,[rsi+10]
-       cmp       qword ptr [rcx+8],50
-       jle       near ptr M01_L15
+       cmp       rdi,50
+       jle       near ptr M02_L15
        mov       r11,[rcx+50]
        test      r11,r11
-       je        near ptr M01_L15
-M01_L03:
+       je        near ptr M02_L15
+M02_L03:
        mov       rcx,r14
-       mov       rdx,r15
+       mov       rdx,rbx
        xor       r8d,r8d
        call      qword ptr [r11]
-       mov       rax,r15
-       add       rsp,58
+       mov       rax,rbx
+       add       rsp,60
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
-M01_L04:
+M02_L04:
        mov       rcx,[rsi+10]
-       cmp       qword ptr [rcx+8],58
-       jle       near ptr M01_L16
+       mov       r14,[rcx+8]
+       cmp       r14,58
+       jle       near ptr M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
-       je        near ptr M01_L16
-M01_L05:
-       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       je        near ptr M02_L16
+M02_L05:
+       call      qword ptr [7FF9C63F76F0]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
-       add       rsp,58
+       add       rsp,60
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
-M01_L06:
+M02_L06:
        mov       rcx,rsi
-       mov       rdx,7FF9C5D0F878
+       mov       rdx,7FF9C6899DF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
-       jmp       near ptr M01_L00
-M01_L07:
-       mov       r15,rbx
+       jmp       near ptr M02_L00
+M02_L07:
        cmp       rbp,38
-       jle       short M01_L09
-       jmp       near ptr M01_L13
-M01_L08:
+       jle       short M02_L09
+       jmp       near ptr M02_L13
+M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9C5D0FAA8
+       mov       rdx,7FF9C689A020
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
-       jmp       near ptr M01_L01
-M01_L09:
+       jmp       near ptr M02_L01
+M02_L09:
        mov       rcx,rsi
-       mov       rdx,7FF9C5D0FA98
+       mov       rdx,7FF9C689A010
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
-M01_L10:
-       lea       rcx,[rsp+20]
+M02_L10:
+       lea       rcx,[rsp+28]
+       mov       rdx,rax
+       call      qword ptr [7FF9C667B228]
+       mov       rbp,[rsi+10]
+       cmp       qword ptr [rbp+8],38
+       jle       near ptr M02_L17
+       mov       rax,[rbp+38]
+       test      rax,rax
+       je        near ptr M02_L17
+M02_L11:
+       lea       rcx,[rsp+28]
        mov       rdx,rax
-       mov       r8d,1
-       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
-       mov       rcx,[rsi+10]
-       cmp       qword ptr [rcx+8],38
-       jle       near ptr M01_L17
-       mov       rdx,[rcx+38]
-       test      rdx,rdx
-       je        near ptr M01_L17
-M01_L11:
-       lea       rcx,[rsp+20]
        mov       r8,rdi
-       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9C667B2A0]
        mov       rcx,[rsi+10]
        cmp       qword ptr [rcx+8],38
-       jle       near ptr M01_L18
+       jle       near ptr M02_L18
        mov       rdx,[rcx+38]
        test      rdx,rdx
-       je        near ptr M01_L18
-M01_L12:
-       lea       rcx,[rsp+20]
-       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
+       je        near ptr M02_L18
+M02_L12:
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FF9C667B330]; System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
        nop
-       add       rsp,58
+       add       rsp,60
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
-M01_L13:
-       mov       rax,[r15+38]
+M02_L13:
+       mov       rax,[rbx+38]
        test      rax,rax
-       je        near ptr M01_L09
-       jmp       short M01_L10
-M01_L14:
+       je        near ptr M02_L09
+       jmp       short M02_L10
+M02_L14:
        mov       rcx,rsi
-       mov       rdx,7FF9C5D0FAC0
+       mov       rdx,7FF9C689A038
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
-       jmp       near ptr M01_L02
-M01_L15:
+       jmp       near ptr M02_L02
+M02_L15:
        mov       rcx,rsi
-       mov       rdx,7FF9C5D0FBD0
+       mov       rdx,7FF9C689A148
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
-       jmp       near ptr M01_L03
-M01_L16:
+       jmp       near ptr M02_L03
+M02_L16:
        mov       rcx,rsi
-       mov       rdx,7FF9C5D0FC00
+       mov       rdx,7FF9C689A178
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
-       jmp       near ptr M01_L05
-M01_L17:
+       jmp       near ptr M02_L05
+M02_L17:
        mov       rcx,rsi
-       mov       rdx,7FF9C5D0FA98
+       mov       rdx,7FF9C689A010
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
-       mov       rdx,rax
-       jmp       near ptr M01_L11
-M01_L18:
+       jmp       near ptr M02_L11
+M02_L18:
        mov       rcx,rsi
-       mov       rdx,7FF9C5D0FA98
+       mov       rdx,7FF9C689A010
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
-       jmp       near ptr M01_L12
-; Total bytes of code 617
+       jmp       near ptr M02_L12
+; Total bytes of code 619
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
-       xor       eax,eax
-       mov       [rbp-28],rax
+       push      rdi
+       sub       rsp,58
+       lea       rbp,[rsp+60]
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
-       mov       [rbp-10],rax
-       mov       [rbp-8],rcx
+       mov       [rbp-10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C596E7D0],0
-       je        short M02_L00
+       cmp       dword ptr [7FF9C6453418],0
+       je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
-M02_L00:
-       mov       r9,2B78D3C3A20
+M03_L00:
+       mov       r9,170C1012A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2B78D3B3020
+       mov       r9,170C1002028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-18],rax
+       mov       rcx,[rbp-18]
+       call      qword ptr [7FF9C6471468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       mov       [rbp-20],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
-       je        short M02_L01
+       je        short M03_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
-       mov       [rbp-20],rcx
-       jmp       short M02_L02
-M02_L01:
+       mov       [rbp-28],rcx
+       jmp       short M03_L02
+M03_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C35C50
+       mov       rdx,7FF9C67539C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
-       mov       [rbp-20],rax
-M02_L02:
-       mov       rcx,[rbp-20]
-       mov       rdx,[rbp-18]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rbp-28],rax
-       mov       rax,[rbp-28]
-       add       rsp,50
+M03_L02:
+       mov       rcx,[rbp-28]
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C6767408]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
+       mov       [rbp-30],rax
+       mov       rax,[rbp-30]
+       add       rsp,58
+       pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 208
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
-**Method was not JITted yet.**
-System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
```
**Diff for ClonePersonProperCollection method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonProperCollection()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+198]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Object)
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
+       call      qword ptr [7FF9C6785FA8]; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6787F78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
-       xor       eax,eax
-       mov       [rbp-28],rax
+       push      rdi
+       sub       rsp,58
+       lea       rbp,[rsp+60]
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
-       mov       [rbp-10],rax
-       mov       [rbp-8],rcx
+       mov       [rbp-10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C597E7D0],0
+       cmp       dword ptr [7FF9C6473418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       r9,20650543A20
+       mov       r9,1B487410A60
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20650533020
+       mov       r9,1B487400030
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-18],rax
+       mov       rcx,[rbp-18]
+       call      qword ptr [7FF9C6491468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       mov       [rbp-20],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
-       mov       [rbp-20],rcx
+       mov       [rbp-28],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C45A50
+       mov       rdx,7FF9C67730F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
-       mov       [rbp-20],rax
-M01_L02:
-       mov       rcx,[rbp-20]
-       mov       rdx,[rbp-18]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rbp-28],rax
-       mov       rax,[rbp-28]
-       add       rsp,50
+M01_L02:
+       mov       rcx,[rbp-28]
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C6787018]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
+       mov       [rbp-30],rax
+       mov       rax,[rbp-30]
+       add       rsp,58
+       pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 208
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for ClonePersonProper method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonProper()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+1A0]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Object)
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
+       call      qword ptr [7FF9C6797300]; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6797678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
-       xor       eax,eax
-       mov       [rbp-28],rax
+       push      rdi
+       sub       rsp,58
+       lea       rbp,[rsp+60]
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
-       mov       [rbp-10],rax
-       mov       [rbp-8],rcx
+       mov       [rbp-10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C596E7D0],0
+       cmp       dword ptr [7FF9C6483418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       r9,1A5B53F3A20
+       mov       r9,12E91C12A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1A5B53E3020
+       mov       r9,12E91C02028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       call      qword ptr [7FF9C64DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-18],rax
+       mov       rcx,[rbp-18]
+       call      qword ptr [7FF9C64A1468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       mov       [rbp-20],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
-       mov       [rbp-20],rcx
+       mov       [rbp-28],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C35A88
+       mov       rdx,7FF9C6783E08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
-       mov       [rbp-20],rax
-M01_L02:
-       mov       rcx,[rbp-20]
-       mov       rdx,[rbp-18]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rbp-28],rax
-       mov       rax,[rbp-28]
-       add       rsp,50
+M01_L02:
+       mov       rcx,[rbp-28]
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C6797360]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
+       mov       [rbp-30],rax
+       mov       rax,[rbp-30]
+       add       rsp,58
+       pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 208
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for ClonePersonRecord method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonRecord()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
        cmp       [rcx],ecx
-       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.<Clone>$()
+       call      qword ptr [7FF9C64912E8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.<Clone>$()
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6787FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 67
+; Total bytes of code 69
 ; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.<Clone>$()
        push      rbp
-       sub       rsp,30
+       push      rdi
+       sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
-       mov       [rbp-8],rax
+       mov       [rbp-10],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C580F518],0
+       cmp       dword ptr [7FF9C6310DD0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
+       mov       [rbp-10],rax
+       mov       rcx,[rbp-10]
        mov       rdx,[rbp+10]
-       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord..ctor(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
-       mov       rax,[rbp-8]
-       add       rsp,30
+       call      qword ptr [7FF9C6491300]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord..ctor(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
+       mov       rax,[rbp-10]
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 76
+; Total bytes of code 79
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for ComputeSha256Hash01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A0]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
+       call      qword ptr [7FF9C64B1378]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6799498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 67
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
        push      rbp
        sub       rsp,0D0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-98],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-0A8],rsp
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C596E7D0],0
+       cmp       dword ptr [7FF9C6493418],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
-       mov       r9,13A4CF33A20
+       mov       r9,15F5C812A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,13A4CF23020
+       mov       r9,15F5C802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64EBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rax,[rbp-28]
        mov       [rbp+10],rax
-       call      System.Text.Encoding.get_UTF8()
+       call      qword ptr [7FF9C60956F0]; System.Text.Encoding.get_UTF8()
        mov       [rbp-30],rax
        mov       rcx,[rbp+10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       call      qword ptr [7FF9C64B1468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       [rbp-38],rax
        mov       rcx,[rbp-30]
        mov       rdx,[rbp-38]
        mov       rax,[rbp-30]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
-       call      System.Security.Cryptography.SHA256.HashData(Byte[])
+       call      qword ptr [7FF9C67992D0]; System.Security.Cryptography.SHA256.HashData(Byte[])
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
        mov       [rbp-8],rcx
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6493908
        mov       edx,23
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,13A4CF2E2C8
+       mov       rcx,15F5C80D580
        mov       rcx,[rcx]
        mov       [rbp-90],rcx
        mov       rcx,[rbp-90]
        mov       rax,[rbp-90]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+20]
        mov       [rbp-50],rax
        mov       rax,[rbp-50]
        mov       [rbp-10],rax
        nop
        xor       eax,eax
        mov       [rbp-14],eax
        nop
        jmp       short M01_L05
        nop
        mov       rax,[rbp-8]
        mov       edx,[rbp-14]
        cmp       edx,[rax+8]
        jb        short M01_L03
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L03:
        mov       ecx,edx
        lea       rax,[rax+rcx+10]
        mov       [rbp-58],rax
        mov       rax,[rbp-10]
        mov       [rbp-60],rax
-       mov       rax,13AACF21B80
+       mov       rax,15F6C800BC0
        mov       rax,[rax]
        mov       [rbp-68],rax
-       call      System.Globalization.CultureInfo.get_InvariantCulture()
+       call      qword ptr [7FF9C6279990]; System.Globalization.CultureInfo.get_InvariantCulture()
        mov       [rbp-70],rax
        mov       rcx,[rbp-58]
        mov       rdx,[rbp-68]
        mov       r8,[rbp-70]
-       call      System.Byte.ToString(System.String, System.IFormatProvider)
+       call      qword ptr [7FF9C5FA9288]; System.Byte.ToString(System.String, System.IFormatProvider)
        mov       [rbp-78],rax
        mov       rcx,[rbp-60]
        mov       rdx,[rbp-78]
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
+       call      qword ptr [7FF9C631B288]; System.Text.StringBuilder.Append(System.String)
        mov       [rbp-80],rax
        nop
        nop
        mov       ecx,[rbp-14]
        add       ecx,1
        jno       short M01_L04
        call      CORINFO_HELP_OVERFLOW
        mov       [rbp-14],ecx
 M01_L05:
        mov       eax,[rbp-14]
        mov       rdx,[rbp-8]
        cmp       eax,[rdx+8]
        setl      al
        movzx     eax,al
        mov       [rbp-18],eax
        cmp       dword ptr [rbp-18],0
        jne       near ptr M01_L02
        mov       rcx,[rbp-10]
        mov       rax,[rbp-10]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-88],rax
        mov       rcx,[rbp-88]
        mov       [rbp-20],rcx
        nop
-       jmp       short M01_L06
-M01_L06:
        mov       rcx,rsp
-       call      M01_L07
+       call      M01_L06
        nop
        mov       rax,[rbp-20]
        add       rsp,0D0
        pop       rbp
        ret
-M01_L07:
+M01_L06:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+0D0]
        nop
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6493908
        mov       edx,23
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,13A4CF2E2C8
+       mov       rcx,15F5C80D580
        mov       rcx,[rcx]
        mov       [rbp-98],rcx
        mov       rcx,[rbp-98]
        mov       rdx,[rbp-10]
        mov       rax,[rbp-98]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+28]
        nop
        nop
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 617
+; Total bytes of code 622
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for ComputeSha256Hash02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
+       call      qword ptr [7FF9C64A1378]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6799528]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 67
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
        push      rbp
        sub       rsp,0D0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-98],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-0A8],rsp
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C598E7D0],0
+       cmp       dword ptr [7FF9C6483418],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
-       mov       r9,1D53C603A20
+       mov       r9,26675012A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D53C5F3020
+       mov       r9,26675002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rax,[rbp-28]
        mov       [rbp+10],rax
-       call      System.Text.Encoding.get_UTF8()
+       call      qword ptr [7FF9C60856F0]; System.Text.Encoding.get_UTF8()
        mov       [rbp-30],rax
        mov       rcx,[rbp+10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       call      qword ptr [7FF9C64A1468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       [rbp-38],rax
        mov       rcx,[rbp-30]
        mov       rdx,[rbp-38]
        mov       rax,[rbp-30]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
-       call      System.Security.Cryptography.SHA256.HashData(Byte[])
+       call      qword ptr [7FF9C6797600]; System.Security.Cryptography.SHA256.HashData(Byte[])
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
        mov       [rbp-8],rcx
-       mov       rcx,7FF9C598ED00
+       mov       rcx,7FF9C6483908
        mov       edx,23
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1D53C5FE2C8
+       mov       rcx,2667500D580
        mov       rcx,[rcx]
        mov       [rbp-90],rcx
        mov       rcx,[rbp-90]
        mov       rax,[rbp-90]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+20]
        mov       [rbp-50],rax
        mov       rax,[rbp-50]
        mov       [rbp-10],rax
        nop
        xor       eax,eax
        mov       [rbp-14],eax
        nop
        jmp       short M01_L05
        nop
        mov       rax,[rbp-8]
        mov       edx,[rbp-14]
        cmp       edx,[rax+8]
        jb        short M01_L03
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L03:
        mov       ecx,edx
        lea       rax,[rax+rcx+10]
        mov       [rbp-58],rax
        mov       rax,[rbp-10]
        mov       [rbp-60],rax
-       mov       rax,1D59C5F1B80
+       mov       rax,26685000BC0
        mov       rax,[rax]
        mov       [rbp-68],rax
-       call      System.Globalization.CultureInfo.get_InvariantCulture()
+       call      qword ptr [7FF9C6269990]; System.Globalization.CultureInfo.get_InvariantCulture()
        mov       [rbp-70],rax
        mov       rcx,[rbp-58]
        mov       rdx,[rbp-68]
        mov       r8,[rbp-70]
-       call      System.Byte.ToString(System.String, System.IFormatProvider)
+       call      qword ptr [7FF9C5F99288]; System.Byte.ToString(System.String, System.IFormatProvider)
        mov       [rbp-78],rax
        mov       rcx,[rbp-60]
        mov       rdx,[rbp-78]
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
+       call      qword ptr [7FF9C630B288]; System.Text.StringBuilder.Append(System.String)
        mov       [rbp-80],rax
        nop
        nop
        mov       ecx,[rbp-14]
        add       ecx,1
        jno       short M01_L04
        call      CORINFO_HELP_OVERFLOW
        mov       [rbp-14],ecx
 M01_L05:
        mov       eax,[rbp-14]
        mov       rdx,[rbp-8]
        cmp       eax,[rdx+8]
        setl      al
        movzx     eax,al
        mov       [rbp-18],eax
        cmp       dword ptr [rbp-18],0
        jne       near ptr M01_L02
        mov       rcx,[rbp-10]
        mov       rax,[rbp-10]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-88],rax
        mov       rcx,[rbp-88]
        mov       [rbp-20],rcx
        nop
-       jmp       short M01_L06
-M01_L06:
        mov       rcx,rsp
-       call      M01_L07
+       call      M01_L06
        nop
        mov       rax,[rbp-20]
        add       rsp,0D0
        pop       rbp
        ret
-M01_L07:
+M01_L06:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+0D0]
        nop
-       mov       rcx,7FF9C598ED00
+       mov       rcx,7FF9C6483908
        mov       edx,23
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1D53C5FE2C8
+       mov       rcx,2667500D580
        mov       rcx,[rcx]
        mov       [rbp-98],rcx
        mov       rcx,[rbp-98]
        mov       rdx,[rbp-10]
        mov       rax,[rbp-98]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+28]
        nop
        nop
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 617
+; Total bytes of code 622
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for DisposeFields method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.DisposeFields()
        push      rsi
        sub       rsp,20
        mov       rcx,offset MT_System.Data.DataTable
        call      CORINFO_HELP_NEWFAST
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.Data.DataTable..ctor()
-       mov       rdx,2249C2C5860
+       call      qword ptr [7FF9C6797150]; System.Data.DataTable..ctor()
+       mov       rdx,24DDE000BB8
        mov       rdx,[rdx]
        lea       rcx,[rsi+70]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rsi
        add       rsp,20
        pop       rsi
-       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
-; Total bytes of code 66
+       jmp       qword ptr [7FF9C64A1390]; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
+; Total bytes of code 68
 ; System.Data.DataTable..ctor()
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,20
+       sub       rsp,40
        vzeroupper
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rsp+28],xmm4
+       xor       eax,eax
+       mov       [rsp+38],rax
        mov       rsi,rcx
-       mov       rdx,2249C2B3020
+       mov       rdx,24DCC002028
        mov       rdi,[rdx]
        lea       rcx,[rsi+70]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+80]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       byte ptr [rsi+1C4],1
        mov       dword ptr [rsi+1B0],19
-       mov       rdx,2249C2B1060
+       mov       rdx,24DCC000068
        mov       rdx,[rdx]
-       vmovupd   xmm0,[rdx+8]
+       add       rdx,8
+       vmovupd   xmm0,[rdx]
        vmovupd   [rsi+1D8],xmm0
-       mov       rdx,2249C2B1060
-       mov       rdx,[rdx]
-       vmovupd   xmm0,[rdx+8]
+       vmovupd   xmm0,[rdx]
        vmovupd   [rsi+1E8],xmm0
-       mov       rdx,2249C2C23F0
+       mov       rdx,24DCC011AA0
        mov       rdx,[rdx]
        lea       rcx,[rsi+0D8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       byte ptr [rsi+1CC],1
-       mov       rdx,2249C2C23F8
+       mov       rdx,24DCC011AA8
        mov       rdx,[rdx]
        lea       rcx,[rsi+110]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2249C2C2400
+       mov       rdx,24DCC011AB0
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+180]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2249C2C2408
+       mov       rdx,24DCC011AB8
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+188]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
        call      CORINFO_HELP_NEWSFAST
        mov       dword ptr [rax+40],0FFFFFFFF
        mov       dword ptr [rax+44],0FFFFFFFF
        mov       byte ptr [rax+4D],1
-       mov       rdx,7FF9C55F5340
+       mov       rdx,7FF9C5F55680
        mov       ecx,1
        lock xadd [rdx],rcx
        inc       rcx
        mov       [rax+28],rcx
        lea       rcx,[rsi+198]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       dword ptr [rsi+1B8],0FFFFFFFF
-       mov       rcx,7FF9C5C72EC4
+       mov       rcx,7FF9C677ADAC
        mov       eax,1
        lock xadd [rcx],eax
        inc       eax
        mov       [rsi+1C0],eax
        mov       rcx,rsi
-       call      System.GC.SuppressFinalize(System.Object)
-       mov       rcx,2249C2C15F0
-       mov       rdi,[rcx]
+       call      qword ptr [7FF9C63E76C0]; System.GC.SuppressFinalize(System.Object)
+       mov       rcx,24DCC010C78
+       mov       rcx,[rcx]
+       mov       rdi,rcx
        mov       ebx,[rsi+1C0]
-       cmp       byte ptr [rdi+9D],0
+       cmp       byte ptr [rcx+9D],0
        jne       near ptr M01_L01
 M01_L00:
        mov       qword ptr [rsi+1A0],1
        mov       rcx,offset MT_System.Data.RecordManager
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      System.Data.RecordManager..ctor(System.Data.DataTable)
+       call      qword ptr [7FF9C67E18B8]; System.Data.RecordManager..ctor(System.Data.DataTable)
        lea       rcx,[rsi+50]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        lea       rcx,[rsi+90]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Data.DataColumnCollection
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
        mov       rdx,rsi
-       call      System.Data.DataColumnCollection..ctor(System.Data.DataTable)
+       call      qword ptr [7FF9C679D9A8]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
        lea       rcx,[rsi+30]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Data.ConstraintCollection
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,offset MT_System.Collections.ArrayList
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       mov       rdx,2249C2B2F48
+       mov       rdx,24DCC001F78
        mov       rdx,[rdx]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       dword ptr [rdi+28],1
        lea       rcx,[rdi+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+38]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Data.DataRowCollection
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,offset MT_System.Data.DataRowCollection+DataRowTree
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       dword ptr [rbx+30],2
        mov       rcx,rbx
-       call      System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
+       call      qword ptr [7FF9C679F870]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
        lea       rcx,[rdi+10]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+28]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.Index, System.Data.Common]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2249C2C2420
+       mov       rdx,24DCC011AD0
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+58]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Data.DataRowBuilder
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       dword ptr [rdi+10],0FFFFFFFF
        lea       rcx,[rsi+178]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        nop
-       add       rsp,20
+       add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       [rax+8],ebx
-       mov       rdx,rax
-       mov       rcx,2249C2C5868
-       mov       rcx,[rcx]
-       call      System.String.Format(System.String, System.Object)
+       mov       [rsp+38],rax
+       lea       r8,[rsp+38]
+       mov       rdx,24DDE000BC0
+       mov       rdx,[rdx]
+       mov       [rsp+28],r8
+       mov       dword ptr [rsp+30],1
+       lea       r8,[rsp+28]
+       xor       ecx,ecx
+       call      qword ptr [7FF9C6081DC8]
        mov       r8,rax
        mov       rcx,rdi
        mov       edx,1
-       call      System.Diagnostics.Tracing.EventSource.WriteEvent(Int32, System.String)
+       call      qword ptr [7FF9C60CF348]
        jmp       near ptr M01_L00
-; Total bytes of code 915
+; Total bytes of code 958
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
        push      rbp
        sub       rsp,0E0
        lea       rbp,[rsp+0E0]
        xor       eax,eax
        mov       [rbp-0B8],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-0B0],xmm4
        vmovdqa   xmmword ptr [rbp-0A0],xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M02_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C599E7D0],0
+       cmp       dword ptr [7FF9C6483418],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M02_L02
        nop
        nop
        jmp       near ptr M02_L11
 M02_L02:
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeFields(System.Type)
+       call      qword ptr [7FF9C67EB480]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeFields(System.Type)
        mov       [rbp-58],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,2249C2BE3E0
+       mov       rcx,24DCC00D698
        mov       rcx,[rcx]
        mov       [rbp-60],rcx
        mov       rcx,[rbp-58]
        mov       [rbp-68],rcx
        mov       rcx,[rbp-60]
        mov       [rbp-70],rcx
        cmp       qword ptr [rbp-60],0
        jne       near ptr M02_L03
        mov       rcx,offset MT_System.Func`2[[System.Reflection.FieldInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-0B0],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,2249C2BE3D8
+       mov       rdx,24DCC00D690
        mov       rdx,[rdx]
        mov       [rbp-0B8],rdx
        mov       rdx,[rbp-0B8]
        mov       rcx,[rbp-0B0]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<DisposeFields>b__6_0(System.Reflection.FieldInfo)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C599ED00
+       mov       r8,7FF9C67EA5B8
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,2249C2BE3E0
        mov       rdx,[rbp-0B0]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,24DCC00D698
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbp-0B0]
        mov       [rbp-70],r8
 M02_L03:
        mov       r8,[rbp-70]
        mov       rdx,[rbp-68]
        mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>, System.Func`2<System.Reflection.FieldInfo,Boolean>)
-       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9C63EDCF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-78],rax
        mov       rdx,[rbp-78]
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>)
-       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9C67EB630]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-80],rax
        mov       rdx,[rbp-80]
        mov       [rbp-8],rdx
        mov       rdx,[rbp-8]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.DoesNotHaveItems[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.List`1<System.Reflection.FieldInfo>)
-       call      DotNetTips.Spargine.Extensions.ListExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
+       call      qword ptr [7FF9C67EB8D0]; DotNetTips.Spargine.Extensions.ListExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
        mov       [rbp-84],eax
        mov       edx,[rbp-84]
        movzx     edx,dl
        mov       [rbp-10],edx
        cmp       dword ptr [rbp-10],0
        je        short M02_L04
        nop
        nop
        jmp       near ptr M02_L11
        xor       edx,edx
        mov       [rbp-14],edx
        nop
        jmp       near ptr M02_L10
 M02_L05:
        nop
        mov       rcx,[rbp-8]
        mov       edx,[rbp-14]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C576AEA0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
+       call      qword ptr [7FF9C61820E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-0A0]
        mov       rdx,[rbp+10]
        mov       rax,[rbp-0A0]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax]
        mov       [rbp-0A8],rax
        mov       rdx,[rbp-0A8]
        mov       [rbp-20],rdx
+       xor       edx,edx
        cmp       qword ptr [rbp-20],0
        setne     dl
-       movzx     edx,dl
        mov       [rbp-24],edx
        cmp       dword ptr [rbp-24],0
        je        short M02_L08
        nop
        mov       rdx,[rbp-20]
        mov       rcx,offset MT_System.IDisposable
-       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
+       call      qword ptr [7FF9C5FEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       [rbp-30],rax
+       xor       ecx,ecx
        cmp       qword ptr [rbp-30],0
        setne     cl
-       movzx     ecx,cl
        mov       [rbp-34],ecx
        cmp       dword ptr [rbp-34],0
        je        short M02_L06
        nop
        mov       rcx,[rbp-30]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable)
+       call      qword ptr [7FF9C64A14B0]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable)
        nop
        nop
        nop
        jmp       short M02_L07
 M02_L06:
        mov       rdx,[rbp-20]
        mov       rcx,offset MT_System.Collections.IEnumerable
-       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
+       call      qword ptr [7FF9C5FEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       [rbp-40],rax
+       xor       ecx,ecx
        cmp       qword ptr [rbp-40],0
        setne     cl
-       movzx     ecx,cl
        mov       [rbp-44],ecx
        cmp       dword ptr [rbp-44],0
        je        short M02_L07
        nop
        mov       rcx,[rbp-40]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeCollection(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C64A1318]; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeCollection(System.Collections.IEnumerable)
        nop
        nop
 M02_L07:
        mov       [rbp-14],eax
 M02_L10:
        mov       edx,[rbp-14]
        movsxd    rdx,edx
        mov       [rbp-90],rdx
        mov       rdx,[rbp-8]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>)
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9C67EB900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-98],rax
        mov       rcx,[rbp-90]
        cmp       rcx,[rbp-98]
        setl      cl
        movzx     ecx,cl
        mov       [rbp-48],ecx
        cmp       dword ptr [rbp-48],0
        jne       near ptr M02_L05
 M02_L11:
        nop
        add       rsp,0E0
        pop       rbp
        ret
-; Total bytes of code 781
+; Total bytes of code 787
```
**Diff for HasProperty01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1A0]
-       mov       rdx,1F59C531B80
+       mov       rdx,26112400BB8
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
+       call      qword ptr [7FF9C64A13C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6797498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 60
+; Total bytes of code 62
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
        push      rbp
        sub       rsp,80
        lea       rbp,[rsp+80]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-50],xmm4
        vmovdqa   xmmword ptr [rbp-40],xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C597E7D0],0
+       cmp       dword ptr [7FF9C6483418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-20],rax
        mov       rcx,[rbp-20]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0..ctor()
+       call      qword ptr [7FF9C6797318]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0..ctor()
        mov       rdx,[rbp-20]
        mov       [rbp-8],rdx
        mov       rdx,[rbp-8]
        lea       rcx,[rdx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-14],ecx
        cmp       dword ptr [rbp-14],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-18],ecx
        nop
        jmp       near ptr M01_L02
 M01_L01:
        mov       rcx,[rbp-8]
        mov       [rbp-28],rcx
-       mov       rcx,1F59C531B88
+       mov       rcx,26100413330
        mov       rcx,[rcx]
        mov       [rsp+20],rcx
        mov       rcx,[rbp-8]
        mov       rcx,[rcx+8]
-       mov       r9,1F50C533020
+       mov       r9,26100402028
        mov       r9,[r9]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C64DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-30],rax
        mov       rdx,[rbp-28]
        lea       rcx,[rdx+8]
        mov       rdx,[rbp-30]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-38],rax
        mov       rcx,[rbp-38]
-       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
+       call      qword ptr [7FF9C6797378]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
        mov       [rbp-40],rax
        mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
        mov       rdx,[rbp-8]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FF9C6796330
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       r8,[rbp-48]
        mov       rdx,[rbp-40]
        mov       rcx,offset MD_System.Linq.Enumerable.FirstOrDefault[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
-       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9C6755930]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-50],rax
        mov       rax,[rbp-50]
        mov       [rbp-10],rax
+       xor       eax,eax
        cmp       qword ptr [rbp-10],0
        setne     al
-       movzx     eax,al
        mov       [rbp-18],eax
        nop
-       jmp       short M01_L02
 M01_L02:
        mov       eax,[rbp-18]
        add       rsp,80
        pop       rbp
        ret
-; Total bytes of code 368
+; Total bytes of code 369
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for HasProperty02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
-       mov       rdx,1D712981B80
+       mov       rdx,1C565000BC0
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
+       call      qword ptr [7FF9C64913C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6787150]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 60
+; Total bytes of code 62
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
        push      rbp
        sub       rsp,80
        lea       rbp,[rsp+80]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-50],xmm4
        vmovdqa   xmmword ptr [rbp-40],xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C598E7D0],0
+       cmp       dword ptr [7FF9C6473418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-20],rax
        mov       rcx,[rbp-20]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0..ctor()
+       call      qword ptr [7FF9C6785FC0]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0..ctor()
        mov       rdx,[rbp-20]
        mov       [rbp-8],rdx
        mov       rdx,[rbp-8]
        lea       rcx,[rdx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-14],ecx
        cmp       dword ptr [rbp-14],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-18],ecx
        nop
        jmp       near ptr M01_L02
 M01_L01:
        mov       rcx,[rbp-8]
        mov       [rbp-28],rcx
-       mov       rcx,1D712981B88
+       mov       rcx,1C563000660
        mov       rcx,[rcx]
        mov       [rsp+20],rcx
        mov       rcx,[rbp-8]
        mov       rcx,[rcx+8]
-       mov       r9,1D6B2983020
+       mov       r9,1C555002028
        mov       r9,[r9]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C64CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-30],rax
        mov       rdx,[rbp-28]
        lea       rcx,[rdx+8]
        mov       rdx,[rbp-30]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-38],rax
        mov       rcx,[rbp-38]
-       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
+       call      qword ptr [7FF9C6787030]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
        mov       [rbp-40],rax
        mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
        mov       rdx,[rbp-8]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FF9C6784FD8
+       call      qword ptr [7FF9C5FDB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       r8,[rbp-48]
        mov       rdx,[rbp-40]
        mov       rcx,offset MD_System.Linq.Enumerable.FirstOrDefault[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
-       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9C6745930]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-50],rax
        mov       rax,[rbp-50]
        mov       [rbp-10],rax
+       xor       eax,eax
        cmp       qword ptr [rbp-10],0
        setne     al
-       movzx     eax,al
        mov       [rbp-18],eax
        nop
-       jmp       short M01_L02
 M01_L02:
        mov       eax,[rbp-18]
        add       rsp,80
        pop       rbp
        ret
-; Total bytes of code 368
+; Total bytes of code 369
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsNotNull01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull01()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1A0]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNotNull(System.Object)
+       call      qword ptr [7FF9C64913F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNotNull(System.Object)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6779318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNotNull(System.Object)
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
+       push      rdi
+       sub       rsp,28
+       lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C596E7D0],0
+       cmp       dword ptr [7FF9C6473418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
+       xor       eax,eax
        cmp       qword ptr [rbp+10],0
        setne     al
-       movzx     eax,al
-       add       rsp,20
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 45
+; Total bytes of code 46
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsNotNull02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull02()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNotNull(System.Object)
+       call      qword ptr [7FF9C64A13F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNotNull(System.Object)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6795FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNotNull(System.Object)
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
+       push      rdi
+       sub       rsp,28
+       lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C595E7D0],0
+       cmp       dword ptr [7FF9C6483418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
+       xor       eax,eax
        cmp       qword ptr [rbp+10],0
        setne     al
-       movzx     eax,al
-       add       rsp,20
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 45
+; Total bytes of code 46
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsNull01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull01()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1A0]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
+       call      qword ptr [7FF9C6471408]; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6767888]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
+       push      rdi
+       sub       rsp,28
+       lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C596E7D0],0
+       cmp       dword ptr [7FF9C6453418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
+       xor       eax,eax
        cmp       qword ptr [rbp+10],0
        sete      al
-       movzx     eax,al
-       add       rsp,20
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 45
+; Total bytes of code 46
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsNull02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull02()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
+       call      qword ptr [7FF9C64B1408]; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67A5FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
+       push      rdi
+       sub       rsp,28
+       lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C599E7D0],0
+       cmp       dword ptr [7FF9C6493418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
+       xor       eax,eax
        cmp       qword ptr [rbp+10],0
        sete      al
-       movzx     eax,al
-       add       rsp,20
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 45
+; Total bytes of code 46
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for Duplicate01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
        push      rdi
        push      rsi
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
        cmp       [rcx],ecx
-       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.<Clone>$()
+       call      qword ptr [7FF9C64B12E8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.<Clone>$()
        mov       rdi,rax
-       mov       rdx,16376351B80
+       mov       rdx,20D61800BC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C596E388]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
+       call      qword ptr [7FF9C6492FC8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
        mov       [rsp+20],rdi
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 93
+; Total bytes of code 94
 ; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.<Clone>$()
        push      rbp
-       sub       rsp,30
+       push      rdi
+       sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
-       mov       [rbp-8],rax
+       mov       [rbp-10],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C57DF518],0
+       cmp       dword ptr [7FF9C6330DD0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
+       mov       [rbp-10],rax
+       mov       rcx,[rbp-10]
        mov       rdx,[rbp+10]
-       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord..ctor(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
-       mov       rax,[rbp-8]
-       add       rsp,30
+       call      qword ptr [7FF9C64B1300]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord..ctor(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
+       mov       rax,[rbp-10]
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 76
+; Total bytes of code 79
 ; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
+       push      rdi
+       sub       rsp,28
+       lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C57DF518],0
+       cmp       dword ptr [7FF9C6330DD0],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rdx,[rbp+10]
        lea       rcx,[rdx+38]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
-       add       rsp,20
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 56
+; Total bytes of code 58
```
**Diff for PersonRecordToString01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C598E360]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
+       call      qword ptr [7FF9C6482FA0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6797AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 68
+; Total bytes of code 69
 ; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-40],xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C57FF518],0
+       cmp       dword ptr [7FF9C6320DD0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,offset MT_System.Text.StringBuilder
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
-       call      System.Text.StringBuilder..ctor()
+       call      qword ptr [7FF9C630B078]; System.Text.StringBuilder..ctor()
        mov       rdx,[rbp-10]
        mov       [rbp-8],rdx
-       mov       rdx,20E90441B80
+       mov       rdx,21339001BD0
        mov       rdx,[rdx]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
+       call      qword ptr [7FF9C630B288]; System.Text.StringBuilder.Append(System.String)
        mov       [rbp-18],rax
        nop
-       mov       rdx,20E90441B88
+       mov       rdx,21339001BD8
        mov       rdx,[rdx]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
+       call      qword ptr [7FF9C630B288]; System.Text.StringBuilder.Append(System.String)
        mov       [rbp-20],rax
        nop
        mov       rcx,[rbp+10]
        mov       rdx,[rbp-8]
-       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.PrintMembers(System.Text.StringBuilder)
+       call      qword ptr [7FF9C64A1258]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.PrintMembers(System.Text.StringBuilder)
        mov       [rbp-24],eax
        cmp       dword ptr [rbp-24],0
        je        short M01_L01
        mov       rcx,[rbp-8]
        mov       edx,20
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(Char)
+       call      qword ptr [7FF9C630B3C0]; System.Text.StringBuilder.Append(Char)
        mov       [rbp-40],rax
        nop
 M01_L01:
        mov       rcx,[rbp-8]
        mov       edx,7D
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(Char)
+       call      qword ptr [7FF9C630B3C0]; System.Text.StringBuilder.Append(Char)
        mov       [rbp-30],rax
        nop
        mov       rcx,[rbp-8]
        mov       rax,[rbp-8]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-38],rax
        mov       rax,[rbp-38]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 242
+; Total bytes of code 248
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for PropertiesToDictionary01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A0]
-       mov       rdx,219D9903020
+       mov       rdx,1F682C02028
        mov       rdx,[rdx]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C6491420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C678BAB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 84
+; Total bytes of code 86
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+M01_L00:
        push      rbp
        sub       rsp,2B0
        lea       rbp,[rsp+2B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-280],xmm4
        mov       rax,0FFFFFFFFFFFFFD90
-M01_L00:
+M01_L01:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
-       jne       short M01_L00
+       jne       short M01_L01
        mov       [rbp-288],rsp
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C599E7D0],0
-       je        short M01_L01
+       cmp       dword ptr [7FF9C6473418],0
+       je        short M01_L02
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
-M01_L01:
+M01_L02:
        nop
        mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-0C0],rax
        mov       rcx,[rbp-0C0]
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9C607B000]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       r9,[rbp-0C0]
        mov       [rbp-8],r9
-       mov       r9,21A49901B80
+       mov       r9,1F694C00BC0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,219D9903020
+       mov       r9,1F682C02028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-0C8],rax
        nop
-       mov       r9,219D9913A20
+       mov       r9,1F682C12A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,219D9903020
+       mov       r9,1F682C02028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-0D0],rax
        mov       rcx,[rbp-0D0]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-0D8],rax
        mov       rax,[rbp-0D8]
        mov       [rbp-10],rax
-       call      DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
+       call      qword ptr [7FF9C67874C8]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
        mov       [rbp-0E0],rax
        mov       rcx,[rbp-0E0]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C56B3238]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
+       call      qword ptr [7FF9C6066878]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
        mov       [rbp-0E4],eax
        mov       ecx,[rbp-0E4]
        movzx     ecx,cl
        mov       [rbp-24],ecx
        cmp       dword ptr [rbp-24],0
-       je        short M01_L02
+       je        short M01_L03
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-248],rcx
        mov       rcx,[rbp+18]
        mov       [rbp-250],rcx
        mov       rcx,[rbp+10]
        mov       rax,[rbp+10]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-258],rax
        mov       rcx,[rbp-248]
        mov       rdx,[rbp-250]
        mov       r8,[rbp-258]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C56B3210]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
+       call      qword ptr [7FF9C6066850]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L21
-M01_L02:
+M01_L03:
        mov       rcx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
+       call      qword ptr [7FF9C67876C0]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
        mov       [rbp-0E8],eax
        mov       edx,[rbp-0E8]
        movzx     edx,dl
        mov       [rbp-34],edx
        cmp       dword ptr [rbp-34],0
        je        near ptr M01_L09
        nop
        xor       edx,edx
        mov       [rbp-38],edx
        nop
        mov       rdx,[rbp+10]
        mov       rcx,offset MT_System.Collections.IEnumerable
-       call      CORINFO_HELP_CHKCASTINTERFACE
+       call      qword ptr [7FF9C5FDB888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
        mov       [rbp-260],rax
        mov       rcx,[rbp-260]
-       mov       r11,7FF9C54F06B0
-       call      qword ptr [7FF9C54F06B0]
+       mov       r11,7FF9C5E30638
+       call      qword ptr [r11]
        mov       [rbp-1A8],rax
        mov       rcx,[rbp-1A8]
        mov       [rbp-40],rcx
        nop
-       jmp       near ptr M01_L07
-M01_L03:
+       jmp       near ptr M01_L08
+M01_L04:
        mov       rcx,[rbp-40]
-       mov       r11,7FF9C54F06C0
-       call      qword ptr [7FF9C54F06C0]
+       mov       r11,7FF9C5E30648
+       call      qword ptr [r11]
        mov       [rbp-1B8],rax
        mov       rax,[rbp-1B8]
        mov       [rbp-48],rax
        nop
        mov       eax,[rbp-38]
        mov       [rbp-1BC],eax
        mov       eax,[rbp-38]
        add       eax,1
-       jno       short M01_L04
+       jno       short M01_L05
        call      CORINFO_HELP_OVERFLOW
-M01_L04:
+M01_L05:
        mov       [rbp-38],eax
        mov       eax,[rbp-1BC]
        mov       [rbp-4C],eax
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62598A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       [rbp-1C8],rax
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-1D0],rax
        mov       r9,[rbp-1D0]
        mov       edx,[rbp-4C]
        mov       [r9+8],edx
        mov       r9,[rbp-1D0]
-       mov       rdx,21A49901B88
+       mov       rdx,1F694C00BC8
        mov       rdx,[rdx]
        mov       rcx,[rbp-1C8]
        mov       r8,[rbp+18]
-       call      System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
+       call      qword ptr [7FF9C6071D80]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
        mov       [rbp-1D8],rax
        mov       rcx,[rbp-1D8]
        mov       [rbp-58],rcx
        mov       rcx,[rbp-8]
        mov       [rbp-1E0],rcx
        mov       rcx,[rbp-48]
        mov       rdx,[rbp-58]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C6491420]
        mov       [rbp-1E8],rax
        mov       r8,[rbp-1E8]
        mov       rdx,[rbp-1E0]
        mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
-       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
+       call      qword ptr [7FF9C6787720]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
        mov       [rbp-1F0],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,219D990E3E8
+       mov       rcx,1F682C0D6A0
        mov       rcx,[rcx]
        mov       [rbp-1F8],rcx
        mov       rcx,[rbp-1F0]
        mov       [rbp-200],rcx
        mov       rcx,[rbp-1F8]
        mov       [rbp-208],rcx
        cmp       qword ptr [rbp-1F8],0
-       jne       near ptr M01_L05
+       jne       near ptr M01_L06
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-240],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,219D990E3D8
+       mov       rdx,1F682C0D690
        mov       rdx,[rdx]
        mov       [rbp-268],rdx
        mov       rdx,[rbp-268]
        mov       rcx,[rbp-240]
        mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C599ED00
+       call      qword ptr [7FF9C5FDB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,219D990E3E8
        mov       rdx,[rbp-240]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,1F682C0D6A0
+       call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-240]
        mov       [rbp-208],rcx
-M01_L05:
-       mov       rcx,7FF9C599ED00
+M01_L06:
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,219D990E3F0
+       mov       rcx,1F682C0D6A8
        mov       rcx,[rcx]
        mov       [rbp-210],rcx
        mov       rcx,[rbp-200]
        mov       [rbp-218],rcx
        mov       rcx,[rbp-208]
        mov       [rbp-220],rcx
        mov       rcx,[rbp-210]
        mov       [rbp-228],rcx
        cmp       qword ptr [rbp-210],0
-       jne       near ptr M01_L06
+       jne       near ptr M01_L07
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-238],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,219D990E3D8
+       mov       rdx,1F682C0D690
        mov       rdx,[rdx]
        mov       [rbp-270],rdx
        mov       rdx,[rbp-270]
        mov       rcx,[rbp-238]
        mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C599ED00
+       call      qword ptr [7FF9C5FDB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,219D990E3F0
        mov       rdx,[rbp-238]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,1F682C0D6A8
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r9,[rbp-238]
        mov       [rbp-228],r9
-M01_L06:
+M01_L07:
        mov       r9,[rbp-228]
        mov       rdx,[rbp-218]
        mov       r8,[rbp-220]
        mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6787858]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-230],rax
        mov       rdx,[rbp-230]
        mov       [rbp-8],rdx
        nop
-M01_L07:
+M01_L08:
        mov       rcx,[rbp-40]
-       mov       r11,7FF9C54F06B8
-       call      qword ptr [7FF9C54F06B8]
+       mov       r11,7FF9C5E30640
+       call      qword ptr [r11]
        mov       [rbp-1AC],eax
        cmp       dword ptr [rbp-1AC],0
-       jne       near ptr M01_L03
+       jne       near ptr M01_L04
        nop
-       jmp       short M01_L08
-M01_L08:
        mov       rcx,rsp
        call      M01_L22
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L21
 M01_L09:
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      System.Type.GetProperties()
+       call      qword ptr [7FF9C5F55330]; System.Type.GetProperties()
        mov       [rbp-0F0],rax
        mov       rcx,[rbp-0F0]
        mov       [rbp-18],rcx
-       mov       rcx,219D9903020
+       mov       rcx,1F682C02028
        mov       rcx,[rcx]
        mov       [rbp-20],rcx
        mov       rcx,[rbp+18]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6071BA0]; System.String.get_Length()
        mov       [rbp-0F4],eax
+       xor       ecx,ecx
        cmp       dword ptr [rbp-0F4],0
        setg      cl
-       movzx     ecx,cl
        mov       [rbp-64],ecx
        cmp       dword ptr [rbp-64],0
        je        short M01_L10
        nop
        lea       rcx,[rbp-90]
        xor       edx,edx
        mov       r8d,2
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
+       call      qword ptr [7FF9C616D8A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
        lea       rcx,[rbp-90]
        mov       rdx,[rbp+18]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
+       call      qword ptr [7FF9C616DA38]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
        nop
        lea       rcx,[rbp-90]
        mov       edx,2E
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
+       call      qword ptr [7FF9C6787888]
        nop
        lea       rcx,[rbp-90]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
+       call      qword ptr [7FF9C616D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
        mov       [rbp-1A0],rax
        mov       rcx,[rbp-1A0]
        mov       [rbp-20],rcx
        nop
        nop
        mov       rcx,[rbp-18]
        mov       edx,[rbp-94]
        cmp       edx,[rcx+8]
        jb        short M01_L12
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L12:
        mov       r8d,edx
        lea       rcx,[rcx+r8*8+10]
        mov       rcx,[rcx]
        mov       [rbp-0A0],rcx
        mov       rcx,[rbp-0A0]
        mov       rdx,[rbp+10]
        xor       r8d,r8d
        mov       rax,[rbp-0A0]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+30]
        mov       [rbp-100],rax
        mov       rax,[rbp-100]
        mov       [rbp-0A8],rax
        mov       eax,[rbp+20]
        movzx     eax,al
        test      eax,eax
        je        short M01_L13
+       xor       eax,eax
        cmp       qword ptr [rbp-0A8],0
        sete      al
-       movzx     eax,al
        mov       [rbp-104],eax
        jmp       short M01_L14
 M01_L13:
        mov       eax,[rbp-104]
        movzx     eax,al
        mov       [rbp-0B4],eax
        cmp       dword ptr [rbp-0B4],0
        je        short M01_L15
        nop
        nop
        jmp       near ptr M01_L18
 M01_L15:
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62598A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       [rbp-110],rax
-       mov       rcx,21A49901B90
+       mov       rcx,1F694C00BD0
        mov       rcx,[rcx]
        mov       [rbp-118],rcx
        mov       rcx,[rbp-20]
        mov       [rbp-120],rcx
        mov       rcx,[rbp-0A0]
        mov       rax,[rbp-0A0]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-128],rax
        mov       rcx,[rbp-110]
        mov       rdx,[rbp-118]
        mov       r8,[rbp-120]
        mov       r9,[rbp-128]
-       call      System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
+       call      qword ptr [7FF9C6071D80]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
        mov       [rbp-130],rax
        mov       rcx,[rbp-130]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-8]
        mov       [rbp-138],rcx
        mov       rcx,[rbp-0A8]
        mov       rdx,[rbp-0B0]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C6491420]
        mov       [rbp-140],rax
        mov       r8,[rbp-140]
        mov       rdx,[rbp-138]
        mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
-       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
+       call      qword ptr [7FF9C6787720]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
        mov       [rbp-148],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,219D990E3F8
+       mov       rcx,1F682C0D6B0
        mov       rcx,[rcx]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-148]
        mov       [rbp-158],rcx
        mov       rcx,[rbp-150]
        mov       [rbp-160],rcx
        cmp       qword ptr [rbp-150],0
        jne       near ptr M01_L16
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-198],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,219D990E3D8
+       mov       rdx,1F682C0D690
        mov       rdx,[rdx]
        mov       [rbp-278],rdx
        mov       rdx,[rbp-278]
        mov       rcx,[rbp-198]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C599ED00
+       mov       r8,7FF9C67867C8
+       call      qword ptr [7FF9C5FDB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,219D990E3F8
        mov       rdx,[rbp-198]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,1F682C0D6B0
+       call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-198]
        mov       [rbp-160],rcx
 M01_L16:
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,219D990E400
+       mov       rcx,1F682C0D6B8
        mov       rcx,[rcx]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-158]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-160]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-168]
        mov       [rbp-180],rcx
        cmp       qword ptr [rbp-168],0
        jne       near ptr M01_L17
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-190],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,219D990E3D8
+       mov       rdx,1F682C0D690
        mov       rdx,[rdx]
        mov       [rbp-280],rdx
        mov       rdx,[rbp-280]
        mov       rcx,[rbp-190]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C599ED00
+       mov       r8,7FF9C67867E0
+       call      qword ptr [7FF9C5FDB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,219D990E400
        mov       rdx,[rbp-190]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,1F682C0D6B8
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r9,[rbp-190]
        mov       [rbp-180],r9
 M01_L17:
        mov       r9,[rbp-180]
        mov       rdx,[rbp-170]
        mov       r8,[rbp-178]
        mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6787858]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-188],rax
        mov       rax,[rbp-188]
        mov       [rbp-8],rax
        nop
        mov       [rbp-94],eax
 M01_L20:
        mov       ecx,[rbp-94]
        mov       rdx,[rbp-18]
        cmp       ecx,[rdx+8]
        setl      cl
        movzx     ecx,cl
        mov       [rbp-0B8],ecx
        cmp       dword ptr [rbp-0B8],0
        jne       near ptr M01_L11
        mov       rax,[rbp-8]
        mov       [rbp-30],rax
        nop
-       jmp       short M01_L21
 M01_L21:
        mov       rax,[rbp-30]
        add       rsp,2B0
        mov       rax,[rbp-30]
        add       rsp,2B0
        pop       rbp
        ret
 M01_L22:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+2B0]
        mov       rdx,[rbp-40]
        mov       rcx,offset MT_System.IDisposable
-       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
+       call      qword ptr [7FF9C5FDB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       [rbp-60],rax
        cmp       qword ptr [rbp-60],0
        je        short M01_L23
        mov       rcx,[rbp-60]
-       mov       r11,7FF9C54F06C8
-       call      qword ptr [7FF9C54F06C8]
+       mov       r11,7FF9C5E30650
+       call      qword ptr [r11]
        nop
 M01_L23:
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 2642
+; Total bytes of code 2651
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for PropertiesToDictionary02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A0]
-       mov       rdx,1F3D4983020
+       mov       rdx,1CA02802028
        mov       rdx,[rdx]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C6491420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C678BAB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 81
+; Total bytes of code 83
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+M01_L00:
        push      rbp
        sub       rsp,2B0
        lea       rbp,[rsp+2B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-280],xmm4
        mov       rax,0FFFFFFFFFFFFFD90
-M01_L00:
+M01_L01:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
-       jne       short M01_L00
+       jne       short M01_L01
        mov       [rbp-288],rsp
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C596E7D0],0
-       je        short M01_L01
+       cmp       dword ptr [7FF9C6473418],0
+       je        short M01_L02
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
-M01_L01:
+M01_L02:
        nop
        mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-0C0],rax
        mov       rcx,[rbp-0C0]
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9C607B000]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       r9,[rbp-0C0]
        mov       [rbp-8],r9
-       mov       r9,1F3D4995868
+       mov       r9,1CA14800BC0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F3D4983020
+       mov       r9,1CA02802028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-0C8],rax
        nop
-       mov       r9,1F3D4993A20
+       mov       r9,1CA02812A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F3D4983020
+       mov       r9,1CA02802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-0D0],rax
        mov       rcx,[rbp-0D0]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-0D8],rax
        mov       rax,[rbp-0D8]
        mov       [rbp-10],rax
-       call      DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
+       call      qword ptr [7FF9C67874C8]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
        mov       [rbp-0E0],rax
        mov       rcx,[rbp-0E0]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C5683238]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
+       call      qword ptr [7FF9C6066878]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
        mov       [rbp-0E4],eax
        mov       ecx,[rbp-0E4]
        movzx     ecx,cl
        mov       [rbp-24],ecx
        cmp       dword ptr [rbp-24],0
-       je        short M01_L02
+       je        short M01_L03
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-248],rcx
        mov       rcx,[rbp+18]
        mov       [rbp-250],rcx
        mov       rcx,[rbp+10]
        mov       rax,[rbp+10]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-258],rax
        mov       rcx,[rbp-248]
        mov       rdx,[rbp-250]
        mov       r8,[rbp-258]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C5683210]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
+       call      qword ptr [7FF9C6066850]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L21
-M01_L02:
+M01_L03:
        mov       rcx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
+       call      qword ptr [7FF9C67876C0]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
        mov       [rbp-0E8],eax
        mov       edx,[rbp-0E8]
        movzx     edx,dl
        mov       [rbp-34],edx
        cmp       dword ptr [rbp-34],0
        je        near ptr M01_L09
        nop
        xor       edx,edx
        mov       [rbp-38],edx
        nop
        mov       rdx,[rbp+10]
        mov       rcx,offset MT_System.Collections.IEnumerable
-       call      CORINFO_HELP_CHKCASTINTERFACE
+       call      qword ptr [7FF9C5FDB888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
        mov       [rbp-260],rax
        mov       rcx,[rbp-260]
-       mov       r11,7FF9C54C06B0
-       call      qword ptr [7FF9C54C06B0]
+       mov       r11,7FF9C5E30638
+       call      qword ptr [r11]
        mov       [rbp-1A8],rax
        mov       rcx,[rbp-1A8]
        mov       [rbp-40],rcx
        nop
-       jmp       near ptr M01_L07
-M01_L03:
+       jmp       near ptr M01_L08
+M01_L04:
        mov       rcx,[rbp-40]
-       mov       r11,7FF9C54C06C0
-       call      qword ptr [7FF9C54C06C0]
+       mov       r11,7FF9C5E30648
+       call      qword ptr [r11]
        mov       [rbp-1B8],rax
        mov       rax,[rbp-1B8]
        mov       [rbp-48],rax
        nop
        mov       eax,[rbp-38]
        mov       [rbp-1BC],eax
        mov       eax,[rbp-38]
        add       eax,1
-       jno       short M01_L04
+       jno       short M01_L05
        call      CORINFO_HELP_OVERFLOW
-M01_L04:
+M01_L05:
        mov       [rbp-38],eax
        mov       eax,[rbp-1BC]
        mov       [rbp-4C],eax
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62598A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       [rbp-1C8],rax
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-1D0],rax
        mov       r9,[rbp-1D0]
        mov       edx,[rbp-4C]
        mov       [r9+8],edx
        mov       r9,[rbp-1D0]
-       mov       rdx,1F3D4995870
+       mov       rdx,1CA14800BC8
        mov       rdx,[rdx]
        mov       rcx,[rbp-1C8]
        mov       r8,[rbp+18]
-       call      System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
+       call      qword ptr [7FF9C6071D80]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
        mov       [rbp-1D8],rax
        mov       rcx,[rbp-1D8]
        mov       [rbp-58],rcx
        mov       rcx,[rbp-8]
        mov       [rbp-1E0],rcx
        mov       rcx,[rbp-48]
        mov       rdx,[rbp-58]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C6491420]
        mov       [rbp-1E8],rax
        mov       r8,[rbp-1E8]
        mov       rdx,[rbp-1E0]
        mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
-       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
+       call      qword ptr [7FF9C6787720]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
        mov       [rbp-1F0],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1F3D498E3E8
+       mov       rcx,1CA0280D6A0
        mov       rcx,[rcx]
        mov       [rbp-1F8],rcx
        mov       rcx,[rbp-1F0]
        mov       [rbp-200],rcx
        mov       rcx,[rbp-1F8]
        mov       [rbp-208],rcx
        cmp       qword ptr [rbp-1F8],0
-       jne       near ptr M01_L05
+       jne       near ptr M01_L06
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-240],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,1F3D498E3D8
+       mov       rdx,1CA0280D690
        mov       rdx,[rdx]
        mov       [rbp-268],rdx
        mov       rdx,[rbp-268]
        mov       rcx,[rbp-240]
        mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C596ED00
+       call      qword ptr [7FF9C5FDB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1F3D498E3E8
        mov       rdx,[rbp-240]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,1CA0280D6A0
+       call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-240]
        mov       [rbp-208],rcx
-M01_L05:
-       mov       rcx,7FF9C596ED00
+M01_L06:
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1F3D498E3F0
+       mov       rcx,1CA0280D6A8
        mov       rcx,[rcx]
        mov       [rbp-210],rcx
        mov       rcx,[rbp-200]
        mov       [rbp-218],rcx
        mov       rcx,[rbp-208]
        mov       [rbp-220],rcx
        mov       rcx,[rbp-210]
        mov       [rbp-228],rcx
        cmp       qword ptr [rbp-210],0
-       jne       near ptr M01_L06
+       jne       near ptr M01_L07
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-238],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,1F3D498E3D8
+       mov       rdx,1CA0280D690
        mov       rdx,[rdx]
        mov       [rbp-270],rdx
        mov       rdx,[rbp-270]
        mov       rcx,[rbp-238]
        mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C596ED00
+       call      qword ptr [7FF9C5FDB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1F3D498E3F0
        mov       rdx,[rbp-238]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,1CA0280D6A8
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r9,[rbp-238]
        mov       [rbp-228],r9
-M01_L06:
+M01_L07:
        mov       r9,[rbp-228]
        mov       rdx,[rbp-218]
        mov       r8,[rbp-220]
        mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6787858]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-230],rax
        mov       rdx,[rbp-230]
        mov       [rbp-8],rdx
        nop
-M01_L07:
+M01_L08:
        mov       rcx,[rbp-40]
-       mov       r11,7FF9C54C06B8
-       call      qword ptr [7FF9C54C06B8]
+       mov       r11,7FF9C5E30640
+       call      qword ptr [r11]
        mov       [rbp-1AC],eax
        cmp       dword ptr [rbp-1AC],0
-       jne       near ptr M01_L03
+       jne       near ptr M01_L04
        nop
-       jmp       short M01_L08
-M01_L08:
        mov       rcx,rsp
        call      M01_L22
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L21
 M01_L09:
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      System.Type.GetProperties()
+       call      qword ptr [7FF9C5F55330]; System.Type.GetProperties()
        mov       [rbp-0F0],rax
        mov       rcx,[rbp-0F0]
        mov       [rbp-18],rcx
-       mov       rcx,1F3D4983020
+       mov       rcx,1CA02802028
        mov       rcx,[rcx]
        mov       [rbp-20],rcx
        mov       rcx,[rbp+18]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6071BA0]; System.String.get_Length()
        mov       [rbp-0F4],eax
+       xor       ecx,ecx
        cmp       dword ptr [rbp-0F4],0
        setg      cl
-       movzx     ecx,cl
        mov       [rbp-64],ecx
        cmp       dword ptr [rbp-64],0
        je        short M01_L10
        nop
        lea       rcx,[rbp-90]
        xor       edx,edx
        mov       r8d,2
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
+       call      qword ptr [7FF9C616D8A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
        lea       rcx,[rbp-90]
        mov       rdx,[rbp+18]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
+       call      qword ptr [7FF9C616DA38]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
        nop
        lea       rcx,[rbp-90]
        mov       edx,2E
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
+       call      qword ptr [7FF9C6787888]
        nop
        lea       rcx,[rbp-90]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
+       call      qword ptr [7FF9C616D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
        mov       [rbp-1A0],rax
        mov       rcx,[rbp-1A0]
        mov       [rbp-20],rcx
        nop
        nop
        mov       rcx,[rbp-18]
        mov       edx,[rbp-94]
        cmp       edx,[rcx+8]
        jb        short M01_L12
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L12:
        mov       r8d,edx
        lea       rcx,[rcx+r8*8+10]
        mov       rcx,[rcx]
        mov       [rbp-0A0],rcx
        mov       rcx,[rbp-0A0]
        mov       rdx,[rbp+10]
        xor       r8d,r8d
        mov       rax,[rbp-0A0]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+30]
        mov       [rbp-100],rax
        mov       rax,[rbp-100]
        mov       [rbp-0A8],rax
        mov       eax,[rbp+20]
        movzx     eax,al
        test      eax,eax
        je        short M01_L13
+       xor       eax,eax
        cmp       qword ptr [rbp-0A8],0
        sete      al
-       movzx     eax,al
        mov       [rbp-104],eax
        jmp       short M01_L14
 M01_L13:
        mov       eax,[rbp-104]
        movzx     eax,al
        mov       [rbp-0B4],eax
        cmp       dword ptr [rbp-0B4],0
        je        short M01_L15
        nop
        nop
        jmp       near ptr M01_L18
 M01_L15:
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62598A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       [rbp-110],rax
-       mov       rcx,1F3D4995878
+       mov       rcx,1CA14800BD0
        mov       rcx,[rcx]
        mov       [rbp-118],rcx
        mov       rcx,[rbp-20]
        mov       [rbp-120],rcx
        mov       rcx,[rbp-0A0]
        mov       rax,[rbp-0A0]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-128],rax
        mov       rcx,[rbp-110]
        mov       rdx,[rbp-118]
        mov       r8,[rbp-120]
        mov       r9,[rbp-128]
-       call      System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
+       call      qword ptr [7FF9C6071D80]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
        mov       [rbp-130],rax
        mov       rcx,[rbp-130]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-8]
        mov       [rbp-138],rcx
        mov       rcx,[rbp-0A8]
        mov       rdx,[rbp-0B0]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C6491420]
        mov       [rbp-140],rax
        mov       r8,[rbp-140]
        mov       rdx,[rbp-138]
        mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
-       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
+       call      qword ptr [7FF9C6787720]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
        mov       [rbp-148],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1F3D498E3F8
+       mov       rcx,1CA0280D6B0
        mov       rcx,[rcx]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-148]
        mov       [rbp-158],rcx
        mov       rcx,[rbp-150]
        mov       [rbp-160],rcx
        cmp       qword ptr [rbp-150],0
        jne       near ptr M01_L16
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-198],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,1F3D498E3D8
+       mov       rdx,1CA0280D690
        mov       rdx,[rdx]
        mov       [rbp-278],rdx
        mov       rdx,[rbp-278]
        mov       rcx,[rbp-198]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C596ED00
+       mov       r8,7FF9C67867C8
+       call      qword ptr [7FF9C5FDB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1F3D498E3F8
        mov       rdx,[rbp-198]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,1CA0280D6B0
+       call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-198]
        mov       [rbp-160],rcx
 M01_L16:
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1F3D498E400
+       mov       rcx,1CA0280D6B8
        mov       rcx,[rcx]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-158]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-160]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-168]
        mov       [rbp-180],rcx
        cmp       qword ptr [rbp-168],0
        jne       near ptr M01_L17
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-190],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,1F3D498E3D8
+       mov       rdx,1CA0280D690
        mov       rdx,[rdx]
        mov       [rbp-280],rdx
        mov       rdx,[rbp-280]
        mov       rcx,[rbp-190]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C596ED00
+       mov       r8,7FF9C67867E0
+       call      qword ptr [7FF9C5FDB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6473908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1F3D498E400
        mov       rdx,[rbp-190]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,1CA0280D6B8
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r9,[rbp-190]
        mov       [rbp-180],r9
 M01_L17:
        mov       r9,[rbp-180]
        mov       rdx,[rbp-170]
        mov       r8,[rbp-178]
        mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6787858]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-188],rax
        mov       rax,[rbp-188]
        mov       [rbp-8],rax
        nop
        mov       [rbp-94],eax
 M01_L20:
        mov       ecx,[rbp-94]
        mov       rdx,[rbp-18]
        cmp       ecx,[rdx+8]
        setl      cl
        movzx     ecx,cl
        mov       [rbp-0B8],ecx
        cmp       dword ptr [rbp-0B8],0
        jne       near ptr M01_L11
        mov       rax,[rbp-8]
        mov       [rbp-30],rax
        nop
-       jmp       short M01_L21
 M01_L21:
        mov       rax,[rbp-30]
        add       rsp,2B0
        mov       rax,[rbp-30]
        add       rsp,2B0
        pop       rbp
        ret
 M01_L22:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+2B0]
        mov       rdx,[rbp-40]
        mov       rcx,offset MT_System.IDisposable
-       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
+       call      qword ptr [7FF9C5FDB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       [rbp-60],rax
        cmp       qword ptr [rbp-60],0
        je        short M01_L23
        mov       rcx,[rbp-60]
-       mov       r11,7FF9C54C06C8
-       call      qword ptr [7FF9C54C06C8]
+       mov       r11,7FF9C5E30650
+       call      qword ptr [r11]
        nop
 M01_L23:
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 2642
+; Total bytes of code 2651
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for PropertiesToDictionary05 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
-       mov       rdx,18FF8EA3020
+       mov       rdx,20D26802028
        mov       rdx,[rdx]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C64A1420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C679B768]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 84
+; Total bytes of code 86
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+M01_L00:
        push      rbp
        sub       rsp,2B0
        lea       rbp,[rsp+2B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-280],xmm4
        mov       rax,0FFFFFFFFFFFFFD90
-M01_L00:
+M01_L01:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
-       jne       short M01_L00
+       jne       short M01_L01
        mov       [rbp-288],rsp
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C596E7D0],0
-       je        short M01_L01
+       cmp       dword ptr [7FF9C6483418],0
+       je        short M01_L02
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
-M01_L01:
+M01_L02:
        nop
        mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-0C0],rax
        mov       rcx,[rbp-0C0]
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9C608B000]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       r9,[rbp-0C0]
        mov       [rbp-8],r9
-       mov       r9,19068EA1B80
+       mov       r9,20D36800BB8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18FF8EA3020
+       mov       r9,20D26802028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-0C8],rax
        nop
-       mov       r9,18FF8EB3A20
+       mov       r9,20D26812A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18FF8EA3020
+       mov       r9,20D26802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-0D0],rax
        mov       rcx,[rbp-0D0]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-0D8],rax
        mov       rax,[rbp-0D8]
        mov       [rbp-10],rax
-       call      DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
+       call      qword ptr [7FF9C6797180]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
        mov       [rbp-0E0],rax
        mov       rcx,[rbp-0E0]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C5683238]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
+       call      qword ptr [7FF9C6076878]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
        mov       [rbp-0E4],eax
        mov       ecx,[rbp-0E4]
        movzx     ecx,cl
        mov       [rbp-24],ecx
        cmp       dword ptr [rbp-24],0
-       je        short M01_L02
+       je        short M01_L03
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-248],rcx
        mov       rcx,[rbp+18]
        mov       [rbp-250],rcx
        mov       rcx,[rbp+10]
        mov       rax,[rbp+10]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-258],rax
        mov       rcx,[rbp-248]
        mov       rdx,[rbp-250]
        mov       r8,[rbp-258]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C5683210]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
+       call      qword ptr [7FF9C6076850]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L21
-M01_L02:
+M01_L03:
        mov       rcx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
+       call      qword ptr [7FF9C6797378]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
        mov       [rbp-0E8],eax
        mov       edx,[rbp-0E8]
        movzx     edx,dl
        mov       [rbp-34],edx
        cmp       dword ptr [rbp-34],0
        je        near ptr M01_L09
        nop
        xor       edx,edx
        mov       [rbp-38],edx
        nop
        mov       rdx,[rbp+10]
        mov       rcx,offset MT_System.Collections.IEnumerable
-       call      CORINFO_HELP_CHKCASTINTERFACE
+       call      qword ptr [7FF9C5FEB888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
        mov       [rbp-260],rax
        mov       rcx,[rbp-260]
-       mov       r11,7FF9C54C06B0
-       call      qword ptr [7FF9C54C06B0]
+       mov       r11,7FF9C5E40638
+       call      qword ptr [r11]
        mov       [rbp-1A8],rax
        mov       rcx,[rbp-1A8]
        mov       [rbp-40],rcx
        nop
-       jmp       near ptr M01_L07
-M01_L03:
+       jmp       near ptr M01_L08
+M01_L04:
        mov       rcx,[rbp-40]
-       mov       r11,7FF9C54C06C0
-       call      qword ptr [7FF9C54C06C0]
+       mov       r11,7FF9C5E40648
+       call      qword ptr [r11]
        mov       [rbp-1B8],rax
        mov       rax,[rbp-1B8]
        mov       [rbp-48],rax
        nop
        mov       eax,[rbp-38]
        mov       [rbp-1BC],eax
        mov       eax,[rbp-38]
        add       eax,1
-       jno       short M01_L04
+       jno       short M01_L05
        call      CORINFO_HELP_OVERFLOW
-M01_L04:
+M01_L05:
        mov       [rbp-38],eax
        mov       eax,[rbp-1BC]
        mov       [rbp-4C],eax
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       [rbp-1C8],rax
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-1D0],rax
        mov       r9,[rbp-1D0]
        mov       edx,[rbp-4C]
        mov       [r9+8],edx
        mov       r9,[rbp-1D0]
-       mov       rdx,19068EA1B88
+       mov       rdx,20D36800BC0
        mov       rdx,[rdx]
        mov       rcx,[rbp-1C8]
        mov       r8,[rbp+18]
-       call      System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
+       call      qword ptr [7FF9C6081D80]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
        mov       [rbp-1D8],rax
        mov       rcx,[rbp-1D8]
        mov       [rbp-58],rcx
        mov       rcx,[rbp-8]
        mov       [rbp-1E0],rcx
        mov       rcx,[rbp-48]
        mov       rdx,[rbp-58]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C64A1420]
        mov       [rbp-1E8],rax
        mov       r8,[rbp-1E8]
        mov       rdx,[rbp-1E0]
        mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
-       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
+       call      qword ptr [7FF9C67973D8]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
        mov       [rbp-1F0],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,18FF8EAE3E8
+       mov       rcx,20D2680D6A0
        mov       rcx,[rcx]
        mov       [rbp-1F8],rcx
        mov       rcx,[rbp-1F0]
        mov       [rbp-200],rcx
        mov       rcx,[rbp-1F8]
        mov       [rbp-208],rcx
        cmp       qword ptr [rbp-1F8],0
-       jne       near ptr M01_L05
+       jne       near ptr M01_L06
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-240],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,18FF8EAE3D8
+       mov       rdx,20D2680D690
        mov       rdx,[rdx]
        mov       [rbp-268],rdx
        mov       rdx,[rbp-268]
        mov       rcx,[rbp-240]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C596ED00
+       mov       r8,7FF9C6796450
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,18FF8EAE3E8
        mov       rdx,[rbp-240]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,20D2680D6A0
+       call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-240]
        mov       [rbp-208],rcx
-M01_L05:
-       mov       rcx,7FF9C596ED00
+M01_L06:
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,18FF8EAE3F0
+       mov       rcx,20D2680D6A8
        mov       rcx,[rcx]
        mov       [rbp-210],rcx
        mov       rcx,[rbp-200]
        mov       [rbp-218],rcx
        mov       rcx,[rbp-208]
        mov       [rbp-220],rcx
        mov       rcx,[rbp-210]
        mov       [rbp-228],rcx
        cmp       qword ptr [rbp-210],0
-       jne       near ptr M01_L06
+       jne       near ptr M01_L07
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-238],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,18FF8EAE3D8
+       mov       rdx,20D2680D690
        mov       rdx,[rdx]
        mov       [rbp-270],rdx
        mov       rdx,[rbp-270]
        mov       rcx,[rbp-238]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C596ED00
+       mov       r8,7FF9C6796468
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,18FF8EAE3F0
        mov       rdx,[rbp-238]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,20D2680D6A8
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r9,[rbp-238]
        mov       [rbp-228],r9
-M01_L06:
+M01_L07:
        mov       r9,[rbp-228]
        mov       rdx,[rbp-218]
        mov       r8,[rbp-220]
        mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6797510]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-230],rax
        mov       rdx,[rbp-230]
        mov       [rbp-8],rdx
        nop
-M01_L07:
+M01_L08:
        mov       rcx,[rbp-40]
-       mov       r11,7FF9C54C06B8
-       call      qword ptr [7FF9C54C06B8]
+       mov       r11,7FF9C5E40640
+       call      qword ptr [r11]
        mov       [rbp-1AC],eax
        cmp       dword ptr [rbp-1AC],0
-       jne       near ptr M01_L03
+       jne       near ptr M01_L04
        nop
-       jmp       short M01_L08
-M01_L08:
        mov       rcx,rsp
        call      M01_L22
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L21
 M01_L09:
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      System.Type.GetProperties()
+       call      qword ptr [7FF9C5F65330]; System.Type.GetProperties()
        mov       [rbp-0F0],rax
        mov       rcx,[rbp-0F0]
        mov       [rbp-18],rcx
-       mov       rcx,18FF8EA3020
+       mov       rcx,20D26802028
        mov       rcx,[rcx]
        mov       [rbp-20],rcx
        mov       rcx,[rbp+18]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6081BA0]; System.String.get_Length()
        mov       [rbp-0F4],eax
+       xor       ecx,ecx
        cmp       dword ptr [rbp-0F4],0
        setg      cl
-       movzx     ecx,cl
        mov       [rbp-64],ecx
        cmp       dword ptr [rbp-64],0
        je        short M01_L10
        nop
        lea       rcx,[rbp-90]
        xor       edx,edx
        mov       r8d,2
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
+       call      qword ptr [7FF9C617D8A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
        lea       rcx,[rbp-90]
        mov       rdx,[rbp+18]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
+       call      qword ptr [7FF9C617DA38]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
        nop
        lea       rcx,[rbp-90]
        mov       edx,2E
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
+       call      qword ptr [7FF9C6797540]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
        nop
        lea       rcx,[rbp-90]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
+       call      qword ptr [7FF9C617D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
        mov       [rbp-1A0],rax
        mov       rcx,[rbp-1A0]
        mov       [rbp-20],rcx
        nop
        nop
        mov       rcx,[rbp-18]
        mov       edx,[rbp-94]
        cmp       edx,[rcx+8]
        jb        short M01_L12
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L12:
        mov       r8d,edx
        lea       rcx,[rcx+r8*8+10]
        mov       rcx,[rcx]
        mov       [rbp-0A0],rcx
        mov       rcx,[rbp-0A0]
        mov       rdx,[rbp+10]
        xor       r8d,r8d
        mov       rax,[rbp-0A0]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+30]
        mov       [rbp-100],rax
        mov       rax,[rbp-100]
        mov       [rbp-0A8],rax
        mov       eax,[rbp+20]
        movzx     eax,al
        test      eax,eax
        je        short M01_L13
+       xor       eax,eax
        cmp       qword ptr [rbp-0A8],0
        sete      al
-       movzx     eax,al
        mov       [rbp-104],eax
        jmp       short M01_L14
 M01_L13:
        mov       eax,[rbp-104]
        movzx     eax,al
        mov       [rbp-0B4],eax
        cmp       dword ptr [rbp-0B4],0
        je        short M01_L15
        nop
        nop
        jmp       near ptr M01_L18
 M01_L15:
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       [rbp-110],rax
-       mov       rcx,19068EA1B90
+       mov       rcx,20D36800BC8
        mov       rcx,[rcx]
        mov       [rbp-118],rcx
        mov       rcx,[rbp-20]
        mov       [rbp-120],rcx
        mov       rcx,[rbp-0A0]
        mov       rax,[rbp-0A0]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-128],rax
        mov       rcx,[rbp-110]
        mov       rdx,[rbp-118]
        mov       r8,[rbp-120]
        mov       r9,[rbp-128]
-       call      System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
+       call      qword ptr [7FF9C6081D80]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
        mov       [rbp-130],rax
        mov       rcx,[rbp-130]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-8]
        mov       [rbp-138],rcx
        mov       rcx,[rbp-0A8]
        mov       rdx,[rbp-0B0]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C64A1420]
        mov       [rbp-140],rax
        mov       r8,[rbp-140]
        mov       rdx,[rbp-138]
        mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
-       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
+       call      qword ptr [7FF9C67973D8]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
        mov       [rbp-148],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,18FF8EAE3F8
+       mov       rcx,20D2680D6B0
        mov       rcx,[rcx]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-148]
        mov       [rbp-158],rcx
        mov       rcx,[rbp-150]
        mov       [rbp-160],rcx
        cmp       qword ptr [rbp-150],0
        jne       near ptr M01_L16
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-198],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,18FF8EAE3D8
+       mov       rdx,20D2680D690
        mov       rdx,[rdx]
        mov       [rbp-278],rdx
        mov       rdx,[rbp-278]
        mov       rcx,[rbp-198]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C596ED00
+       mov       r8,7FF9C6796480
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,18FF8EAE3F8
        mov       rdx,[rbp-198]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,20D2680D6B0
+       call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-198]
        mov       [rbp-160],rcx
 M01_L16:
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,18FF8EAE400
+       mov       rcx,20D2680D6B8
        mov       rcx,[rcx]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-158]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-160]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-168]
        mov       [rbp-180],rcx
        cmp       qword ptr [rbp-168],0
        jne       near ptr M01_L17
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-190],rax
-       mov       rcx,7FF9C596ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,18FF8EAE3D8
+       mov       rdx,20D2680D690
        mov       rdx,[rdx]
        mov       [rbp-280],rdx
        mov       rdx,[rbp-280]
        mov       rcx,[rbp-190]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C596ED00
+       mov       r8,7FF9C6796498
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,18FF8EAE400
        mov       rdx,[rbp-190]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,20D2680D6B8
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r9,[rbp-190]
        mov       [rbp-180],r9
 M01_L17:
        mov       r9,[rbp-180]
        mov       rdx,[rbp-170]
        mov       r8,[rbp-178]
        mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6797510]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-188],rax
        mov       rax,[rbp-188]
        mov       [rbp-8],rax
        nop
        mov       [rbp-94],eax
 M01_L20:
        mov       ecx,[rbp-94]
        mov       rdx,[rbp-18]
        cmp       ecx,[rdx+8]
        setl      cl
        movzx     ecx,cl
        mov       [rbp-0B8],ecx
        cmp       dword ptr [rbp-0B8],0
        jne       near ptr M01_L11
        mov       rax,[rbp-8]
        mov       [rbp-30],rax
        nop
-       jmp       short M01_L21
 M01_L21:
        mov       rax,[rbp-30]
        add       rsp,2B0
        mov       rax,[rbp-30]
        add       rsp,2B0
        pop       rbp
        ret
 M01_L22:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+2B0]
        mov       rdx,[rbp-40]
        mov       rcx,offset MT_System.IDisposable
-       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
+       call      qword ptr [7FF9C5FEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       [rbp-60],rax
        cmp       qword ptr [rbp-60],0
        je        short M01_L23
        mov       rcx,[rbp-60]
-       mov       r11,7FF9C54C06C8
-       call      qword ptr [7FF9C54C06C8]
+       mov       r11,7FF9C5E40650
+       call      qword ptr [r11]
        nop
 M01_L23:
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 2642
+; Total bytes of code 2651
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for PropertiesToDictionary04 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
-       mov       rdx,21CA7573020
+       mov       rdx,250C8402028
        mov       rdx,[rdx]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C64A1420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C679B768]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 81
+; Total bytes of code 83
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+M01_L00:
        push      rbp
        sub       rsp,2B0
        lea       rbp,[rsp+2B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-280],xmm4
        mov       rax,0FFFFFFFFFFFFFD90
-M01_L00:
+M01_L01:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
-       jne       short M01_L00
+       jne       short M01_L01
        mov       [rbp-288],rsp
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C599E7D0],0
-       je        short M01_L01
+       cmp       dword ptr [7FF9C6483418],0
+       je        short M01_L02
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
-M01_L01:
+M01_L02:
        nop
        mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-0C0],rax
        mov       rcx,[rbp-0C0]
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9C608B000]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       r9,[rbp-0C0]
        mov       [rbp-8],r9
-       mov       r9,21D17571B80
+       mov       r9,250D8400BC0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,21CA7573020
+       mov       r9,250C8402028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-0C8],rax
        nop
-       mov       r9,21CA7583A20
+       mov       r9,250C8412A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,21CA7573020
+       mov       r9,250C8402028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-0D0],rax
        mov       rcx,[rbp-0D0]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-0D8],rax
        mov       rax,[rbp-0D8]
        mov       [rbp-10],rax
-       call      DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
+       call      qword ptr [7FF9C6797180]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
        mov       [rbp-0E0],rax
        mov       rcx,[rbp-0E0]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C56B3238]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
+       call      qword ptr [7FF9C6076878]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
        mov       [rbp-0E4],eax
        mov       ecx,[rbp-0E4]
        movzx     ecx,cl
        mov       [rbp-24],ecx
        cmp       dword ptr [rbp-24],0
-       je        short M01_L02
+       je        short M01_L03
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-248],rcx
        mov       rcx,[rbp+18]
        mov       [rbp-250],rcx
        mov       rcx,[rbp+10]
        mov       rax,[rbp+10]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-258],rax
        mov       rcx,[rbp-248]
        mov       rdx,[rbp-250]
        mov       r8,[rbp-258]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C56B3210]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
+       call      qword ptr [7FF9C6076850]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L21
-M01_L02:
+M01_L03:
        mov       rcx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
+       call      qword ptr [7FF9C6797378]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
        mov       [rbp-0E8],eax
        mov       edx,[rbp-0E8]
        movzx     edx,dl
        mov       [rbp-34],edx
        cmp       dword ptr [rbp-34],0
        je        near ptr M01_L09
        nop
        xor       edx,edx
        mov       [rbp-38],edx
        nop
        mov       rdx,[rbp+10]
        mov       rcx,offset MT_System.Collections.IEnumerable
-       call      CORINFO_HELP_CHKCASTINTERFACE
+       call      qword ptr [7FF9C5FEB888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
        mov       [rbp-260],rax
        mov       rcx,[rbp-260]
-       mov       r11,7FF9C54F06B0
-       call      qword ptr [7FF9C54F06B0]
+       mov       r11,7FF9C5E40638
+       call      qword ptr [r11]
        mov       [rbp-1A8],rax
        mov       rcx,[rbp-1A8]
        mov       [rbp-40],rcx
        nop
-       jmp       near ptr M01_L07
-M01_L03:
+       jmp       near ptr M01_L08
+M01_L04:
        mov       rcx,[rbp-40]
-       mov       r11,7FF9C54F06C0
-       call      qword ptr [7FF9C54F06C0]
+       mov       r11,7FF9C5E40648
+       call      qword ptr [r11]
        mov       [rbp-1B8],rax
        mov       rax,[rbp-1B8]
        mov       [rbp-48],rax
        nop
        mov       eax,[rbp-38]
        mov       [rbp-1BC],eax
        mov       eax,[rbp-38]
        add       eax,1
-       jno       short M01_L04
+       jno       short M01_L05
        call      CORINFO_HELP_OVERFLOW
-M01_L04:
+M01_L05:
        mov       [rbp-38],eax
        mov       eax,[rbp-1BC]
        mov       [rbp-4C],eax
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       [rbp-1C8],rax
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-1D0],rax
        mov       r9,[rbp-1D0]
        mov       edx,[rbp-4C]
        mov       [r9+8],edx
        mov       r9,[rbp-1D0]
-       mov       rdx,21D17571B88
+       mov       rdx,250D8400BC8
        mov       rdx,[rdx]
        mov       rcx,[rbp-1C8]
        mov       r8,[rbp+18]
-       call      System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
+       call      qword ptr [7FF9C6081D80]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
        mov       [rbp-1D8],rax
        mov       rcx,[rbp-1D8]
        mov       [rbp-58],rcx
        mov       rcx,[rbp-8]
        mov       [rbp-1E0],rcx
        mov       rcx,[rbp-48]
        mov       rdx,[rbp-58]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C64A1420]
        mov       [rbp-1E8],rax
        mov       r8,[rbp-1E8]
        mov       rdx,[rbp-1E0]
        mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
-       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
+       call      qword ptr [7FF9C67973D8]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
        mov       [rbp-1F0],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,21CA757E3E8
+       mov       rcx,250C840D6A0
        mov       rcx,[rcx]
        mov       [rbp-1F8],rcx
        mov       rcx,[rbp-1F0]
        mov       [rbp-200],rcx
        mov       rcx,[rbp-1F8]
        mov       [rbp-208],rcx
        cmp       qword ptr [rbp-1F8],0
-       jne       near ptr M01_L05
+       jne       near ptr M01_L06
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-240],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,21CA757E3D8
+       mov       rdx,250C840D690
        mov       rdx,[rdx]
        mov       [rbp-268],rdx
        mov       rdx,[rbp-268]
        mov       rcx,[rbp-240]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C599ED00
+       mov       r8,7FF9C6796450
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,21CA757E3E8
        mov       rdx,[rbp-240]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,250C840D6A0
+       call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-240]
        mov       [rbp-208],rcx
-M01_L05:
-       mov       rcx,7FF9C599ED00
+M01_L06:
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,21CA757E3F0
+       mov       rcx,250C840D6A8
        mov       rcx,[rcx]
        mov       [rbp-210],rcx
        mov       rcx,[rbp-200]
        mov       [rbp-218],rcx
        mov       rcx,[rbp-208]
        mov       [rbp-220],rcx
        mov       rcx,[rbp-210]
        mov       [rbp-228],rcx
        cmp       qword ptr [rbp-210],0
-       jne       near ptr M01_L06
+       jne       near ptr M01_L07
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-238],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,21CA757E3D8
+       mov       rdx,250C840D690
        mov       rdx,[rdx]
        mov       [rbp-270],rdx
        mov       rdx,[rbp-270]
        mov       rcx,[rbp-238]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C599ED00
+       mov       r8,7FF9C6796468
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,21CA757E3F0
        mov       rdx,[rbp-238]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,250C840D6A8
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r9,[rbp-238]
        mov       [rbp-228],r9
-M01_L06:
+M01_L07:
        mov       r9,[rbp-228]
        mov       rdx,[rbp-218]
        mov       r8,[rbp-220]
        mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6797510]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-230],rax
        mov       rdx,[rbp-230]
        mov       [rbp-8],rdx
        nop
-M01_L07:
+M01_L08:
        mov       rcx,[rbp-40]
-       mov       r11,7FF9C54F06B8
-       call      qword ptr [7FF9C54F06B8]
+       mov       r11,7FF9C5E40640
+       call      qword ptr [r11]
        mov       [rbp-1AC],eax
        cmp       dword ptr [rbp-1AC],0
-       jne       near ptr M01_L03
+       jne       near ptr M01_L04
        nop
-       jmp       short M01_L08
-M01_L08:
        mov       rcx,rsp
        call      M01_L22
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L21
 M01_L09:
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      System.Type.GetProperties()
+       call      qword ptr [7FF9C5F65330]; System.Type.GetProperties()
        mov       [rbp-0F0],rax
        mov       rcx,[rbp-0F0]
        mov       [rbp-18],rcx
-       mov       rcx,21CA7573020
+       mov       rcx,250C8402028
        mov       rcx,[rcx]
        mov       [rbp-20],rcx
        mov       rcx,[rbp+18]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6081BA0]; System.String.get_Length()
        mov       [rbp-0F4],eax
+       xor       ecx,ecx
        cmp       dword ptr [rbp-0F4],0
        setg      cl
-       movzx     ecx,cl
        mov       [rbp-64],ecx
        cmp       dword ptr [rbp-64],0
        je        short M01_L10
        nop
        lea       rcx,[rbp-90]
        xor       edx,edx
        mov       r8d,2
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
+       call      qword ptr [7FF9C617D8A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
        lea       rcx,[rbp-90]
        mov       rdx,[rbp+18]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
+       call      qword ptr [7FF9C617DA38]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
        nop
        lea       rcx,[rbp-90]
        mov       edx,2E
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
+       call      qword ptr [7FF9C6797540]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
        nop
        lea       rcx,[rbp-90]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
+       call      qword ptr [7FF9C617D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
        mov       [rbp-1A0],rax
        mov       rcx,[rbp-1A0]
        mov       [rbp-20],rcx
        nop
        nop
        mov       rcx,[rbp-18]
        mov       edx,[rbp-94]
        cmp       edx,[rcx+8]
        jb        short M01_L12
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L12:
        mov       r8d,edx
        lea       rcx,[rcx+r8*8+10]
        mov       rcx,[rcx]
        mov       [rbp-0A0],rcx
        mov       rcx,[rbp-0A0]
        mov       rdx,[rbp+10]
        xor       r8d,r8d
        mov       rax,[rbp-0A0]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+30]
        mov       [rbp-100],rax
        mov       rax,[rbp-100]
        mov       [rbp-0A8],rax
        mov       eax,[rbp+20]
        movzx     eax,al
        test      eax,eax
        je        short M01_L13
+       xor       eax,eax
        cmp       qword ptr [rbp-0A8],0
        sete      al
-       movzx     eax,al
        mov       [rbp-104],eax
        jmp       short M01_L14
 M01_L13:
        mov       eax,[rbp-104]
        movzx     eax,al
        mov       [rbp-0B4],eax
        cmp       dword ptr [rbp-0B4],0
        je        short M01_L15
        nop
        nop
        jmp       near ptr M01_L18
 M01_L15:
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       [rbp-110],rax
-       mov       rcx,21D17571B90
+       mov       rcx,250D8400BD0
        mov       rcx,[rcx]
        mov       [rbp-118],rcx
        mov       rcx,[rbp-20]
        mov       [rbp-120],rcx
        mov       rcx,[rbp-0A0]
        mov       rax,[rbp-0A0]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-128],rax
        mov       rcx,[rbp-110]
        mov       rdx,[rbp-118]
        mov       r8,[rbp-120]
        mov       r9,[rbp-128]
-       call      System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
+       call      qword ptr [7FF9C6081D80]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
        mov       [rbp-130],rax
        mov       rcx,[rbp-130]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-8]
        mov       [rbp-138],rcx
        mov       rcx,[rbp-0A8]
        mov       rdx,[rbp-0B0]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C64A1420]
        mov       [rbp-140],rax
        mov       r8,[rbp-140]
        mov       rdx,[rbp-138]
        mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
-       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
+       call      qword ptr [7FF9C67973D8]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
        mov       [rbp-148],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,21CA757E3F8
+       mov       rcx,250C840D6B0
        mov       rcx,[rcx]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-148]
        mov       [rbp-158],rcx
        mov       rcx,[rbp-150]
        mov       [rbp-160],rcx
        cmp       qword ptr [rbp-150],0
        jne       near ptr M01_L16
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-198],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,21CA757E3D8
+       mov       rdx,250C840D690
        mov       rdx,[rdx]
        mov       [rbp-278],rdx
        mov       rdx,[rbp-278]
        mov       rcx,[rbp-198]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C599ED00
+       mov       r8,7FF9C6796480
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,21CA757E3F8
        mov       rdx,[rbp-198]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,250C840D6B0
+       call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-198]
        mov       [rbp-160],rcx
 M01_L16:
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,21CA757E400
+       mov       rcx,250C840D6B8
        mov       rcx,[rcx]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-158]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-160]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-168]
        mov       [rbp-180],rcx
        cmp       qword ptr [rbp-168],0
        jne       near ptr M01_L17
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-190],rax
-       mov       rcx,7FF9C599ED00
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rdx,21CA757E3D8
+       mov       rdx,250C840D690
        mov       rdx,[rdx]
        mov       [rbp-280],rdx
        mov       rdx,[rbp-280]
        mov       rcx,[rbp-190]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,7FF9C599ED00
+       mov       r8,7FF9C6796498
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,7FF9C6483908
        mov       edx,5B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,21CA757E400
        mov       rdx,[rbp-190]
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,250C840D6B8
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r9,[rbp-190]
        mov       [rbp-180],r9
 M01_L17:
        mov       r9,[rbp-180]
        mov       rdx,[rbp-170]
        mov       r8,[rbp-178]
        mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6797510]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-188],rax
        mov       rax,[rbp-188]
        mov       [rbp-8],rax
        nop
        mov       [rbp-94],eax
 M01_L20:
        mov       ecx,[rbp-94]
        mov       rdx,[rbp-18]
        cmp       ecx,[rdx+8]
        setl      cl
        movzx     ecx,cl
        mov       [rbp-0B8],ecx
        cmp       dword ptr [rbp-0B8],0
        jne       near ptr M01_L11
        mov       rax,[rbp-8]
        mov       [rbp-30],rax
        nop
-       jmp       short M01_L21
 M01_L21:
        mov       rax,[rbp-30]
        add       rsp,2B0
        mov       rax,[rbp-30]
        add       rsp,2B0
        pop       rbp
        ret
 M01_L22:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+2B0]
        mov       rdx,[rbp-40]
        mov       rcx,offset MT_System.IDisposable
-       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
+       call      qword ptr [7FF9C5FEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       [rbp-60],rax
        cmp       qword ptr [rbp-60],0
        je        short M01_L23
        mov       rcx,[rbp-60]
-       mov       r11,7FF9C54F06C8
-       call      qword ptr [7FF9C54F06C8]
+       mov       r11,7FF9C5E40650
+       call      qword ptr [r11]
        nop
 M01_L23:
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 2642
+; Total bytes of code 2651
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for PropertiesToString01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
        push      rsi
        sub       rsp,40
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rsi,rcx
        mov       dword ptr [rsp+20],1
        mov       dword ptr [rsp+28],1
        mov       rcx,[rsi+1A0]
-       mov       rdx,273EB5C3020
+       mov       rdx,2C7B1802028
        mov       rdx,[rdx]
-       mov       r9,273EB5D3AA8
+       mov       r9,2C7B1812AC8
        mov       r9,[r9]
        mov       r8d,3A
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
+       call      qword ptr [7FF9C6471438]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
        mov       [rsp+38],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,40
        pop       rsi
        ret
-; Total bytes of code 110
+; Total bytes of code 111
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
        push      rbp
        sub       rsp,0D0
        lea       rbp,[rsp+0D0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-0B0],xmm4
        vmovdqa   xmmword ptr [rbp-0A0],xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        mov       [rbp+28],r9
-       cmp       dword ptr [7FF9C597E7D0],0
+       cmp       dword ptr [7FF9C6453418],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0..ctor()
+       call      qword ptr [7FF9C6759000]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0..ctor()
        mov       rdx,[rbp-40]
        mov       [rbp-8],rdx
        mov       rdx,[rbp-8]
        lea       rcx,[rdx+8]
        mov       rdx,[rbp+28]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-8]
        mov       eax,[rbp+20]
        mov       [rcx+10],ax
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-24],ecx
        cmp       dword ptr [rbp-24],0
        je        short M01_L02
        nop
-       mov       rcx,273EB5C3020
+       mov       rcx,2C7B1802028
        mov       rcx,[rcx]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L07
 M01_L02:
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
        mov       rax,[rbp-48]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,offset MT_System.Collections.Generic.List`1
        call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
        mov       [rbp-58],rax
        mov       rcx,[rbp-10]
        mov       [rbp-60],rcx
        mov       rcx,[rbp-58]
-       call      System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
+       call      qword ptr [7FF9C5F330C0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       rax,[rbp-68]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-70],rax
        mov       rcx,[rbp-60]
        mov       rdx,[rbp-70]
        mov       r8d,4
-       call      System.String.Equals(System.String, System.String, System.StringComparison)
+       call      qword ptr [7FF9C6051378]; System.String.Equals(System.String, System.String, System.StringComparison)
        mov       [rbp-74],eax
        mov       r8d,[rbp-74]
        movzx     r8d,r8b
        mov       [rbp-34],r8d
        cmp       dword ptr [rbp-34],0
        je        short M01_L03
        nop
-       mov       r8,2745B5C1B78
+       mov       r8,2C7C3801BD8
        mov       r8,[r8]
        mov       [rbp-10],r8
        nop
        nop
        jmp       short M01_L04
 M01_L03:
        mov       r8d,[rbp+38]
        movzx     r8d,r8b
        test      r8d,r8d
        sete      r8b
        movzx     r8d,r8b
        mov       [rbp-38],r8d
        cmp       dword ptr [rbp-38],0
        je        short M01_L04
        nop
-       mov       r8,273EB5C3020
+       mov       r8,2C7B1802028
        mov       r8,[r8]
        mov       [rbp-10],r8
        nop
 M01_L04:
        mov       r8d,[rbp+30]
        movzx     r8d,r8b
        mov       rcx,[rbp+10]
        mov       rdx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C6471420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
        mov       [rbp-80],rax
        mov       rcx,[rbp-80]
        mov       [rbp-18],rcx
        mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-88],rax
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-8]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FF9C6758018
+       call      qword ptr [7FF9C5FBB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       r9,[rbp-88]
        mov       rdx,[rbp-18]
        mov       r8,[rbp+18]
        mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6759090]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-90],rax
        mov       rdx,[rbp-90]
        mov       [rbp-20],rdx
        mov       rdx,[rbp-8]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-20]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      System.String.StartsWith(System.String, System.StringComparison)
+       call      qword ptr [7FF9C6051498]; System.String.StartsWith(System.String, System.StringComparison)
        mov       [rbp-94],eax
        cmp       dword ptr [rbp-94],0
        jne       short M01_L05
        mov       rcx,[rbp-20]
        mov       [rbp-0B0],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp-20]
        mov       [rbp-0A0],rcx
        xor       ecx,ecx
        mov       [rbp-0A4],ecx
        mov       rcx,[rbp-8]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6051BA0]; System.String.get_Length()
        mov       [rbp-0A8],eax
        mov       rcx,[rbp-0A0]
        mov       edx,[rbp-0A4]
        mov       r8d,[rbp-0A8]
        cmp       [rcx],ecx
-       call      System.String.Remove(Int32, Int32)
+       call      qword ptr [7FF9C6053030]; System.String.Remove(Int32, Int32)
        mov       [rbp-0B0],rax
 M01_L06:
        mov       rax,[rbp-0B0]
        mov       [rbp-30],rax
        nop
-       jmp       short M01_L07
 M01_L07:
        mov       rax,[rbp-30]
        add       rsp,0D0
        pop       rbp
        ret
-; Total bytes of code 705
+; Total bytes of code 711
```
**Diff for PropertiesToString02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString02()
        push      rsi
        sub       rsp,40
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rsi,rcx
        xor       ecx,ecx
        mov       [rsp+20],ecx
        mov       dword ptr [rsp+28],1
        mov       rcx,[rsi+1A0]
-       mov       rdx,11D442F3020
+       mov       rdx,2AAA2802028
        mov       rdx,[rdx]
-       mov       r9,11D44303AA8
+       mov       r9,2AAA2812AC8
        mov       r9,[r9]
        mov       r8d,3A
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
+       call      qword ptr [7FF9C6471438]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
        mov       [rsp+38],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,40
        pop       rsi
        ret
-; Total bytes of code 108
+; Total bytes of code 109
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
        push      rbp
        sub       rsp,0D0
        lea       rbp,[rsp+0D0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-0B0],xmm4
        vmovdqa   xmmword ptr [rbp-0A0],xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        mov       [rbp+28],r9
-       cmp       dword ptr [7FF9C598E7D0],0
+       cmp       dword ptr [7FF9C6453418],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0..ctor()
+       call      qword ptr [7FF9C67698A0]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0..ctor()
        mov       rdx,[rbp-40]
        mov       [rbp-8],rdx
        mov       rdx,[rbp-8]
        lea       rcx,[rdx+8]
        mov       rdx,[rbp+28]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-8]
        mov       eax,[rbp+20]
        mov       [rcx+10],ax
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-24],ecx
        cmp       dword ptr [rbp-24],0
        je        short M01_L02
        nop
-       mov       rcx,11D442F3020
+       mov       rcx,2AAA2802028
        mov       rcx,[rcx]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L07
 M01_L02:
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
        mov       rax,[rbp-48]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,offset MT_System.Collections.Generic.List`1
        call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
        mov       [rbp-58],rax
        mov       rcx,[rbp-10]
        mov       [rbp-60],rcx
        mov       rcx,[rbp-58]
-       call      System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
+       call      qword ptr [7FF9C5F330C0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       rax,[rbp-68]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-70],rax
        mov       rcx,[rbp-60]
        mov       rdx,[rbp-70]
        mov       r8d,4
-       call      System.String.Equals(System.String, System.String, System.StringComparison)
+       call      qword ptr [7FF9C6051378]; System.String.Equals(System.String, System.String, System.StringComparison)
        mov       [rbp-74],eax
        mov       r8d,[rbp-74]
        movzx     r8d,r8b
        mov       [rbp-34],r8d
        cmp       dword ptr [rbp-34],0
        je        short M01_L03
        nop
-       mov       r8,11DA42F1B80
+       mov       r8,2AAA2813890
        mov       r8,[r8]
        mov       [rbp-10],r8
        nop
        nop
        jmp       short M01_L04
 M01_L03:
        mov       r8d,[rbp+38]
        movzx     r8d,r8b
        test      r8d,r8d
        sete      r8b
        movzx     r8d,r8b
        mov       [rbp-38],r8d
        cmp       dword ptr [rbp-38],0
        je        short M01_L04
        nop
-       mov       r8,11D442F3020
+       mov       r8,2AAA2802028
        mov       r8,[r8]
        mov       [rbp-10],r8
        nop
 M01_L04:
        mov       r8d,[rbp+30]
        movzx     r8d,r8b
        mov       rcx,[rbp+10]
        mov       rdx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C6471420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
        mov       [rbp-80],rax
        mov       rcx,[rbp-80]
        mov       [rbp-18],rcx
        mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-88],rax
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-8]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FF9C67688B8
+       call      qword ptr [7FF9C5FBB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       r9,[rbp-88]
        mov       rdx,[rbp-18]
        mov       r8,[rbp+18]
        mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6769930]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-90],rax
        mov       rdx,[rbp-90]
        mov       [rbp-20],rdx
        mov       rdx,[rbp-8]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-20]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      System.String.StartsWith(System.String, System.StringComparison)
+       call      qword ptr [7FF9C6051498]; System.String.StartsWith(System.String, System.StringComparison)
        mov       [rbp-94],eax
        cmp       dword ptr [rbp-94],0
        jne       short M01_L05
        mov       rcx,[rbp-20]
        mov       [rbp-0B0],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp-20]
        mov       [rbp-0A0],rcx
        xor       ecx,ecx
        mov       [rbp-0A4],ecx
        mov       rcx,[rbp-8]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6051BA0]; System.String.get_Length()
        mov       [rbp-0A8],eax
        mov       rcx,[rbp-0A0]
        mov       edx,[rbp-0A4]
        mov       r8d,[rbp-0A8]
        cmp       [rcx],ecx
-       call      System.String.Remove(Int32, Int32)
+       call      qword ptr [7FF9C6053030]; System.String.Remove(Int32, Int32)
        mov       [rbp-0B0],rax
 M01_L06:
        mov       rax,[rbp-0B0]
        mov       [rbp-30],rax
        nop
-       jmp       short M01_L07
 M01_L07:
        mov       rax,[rbp-30]
        add       rsp,0D0
        pop       rbp
        ret
-; Total bytes of code 705
+; Total bytes of code 711
```
**Diff for PropertiesToString03 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
        push      rsi
        sub       rsp,40
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rsi,rcx
        mov       dword ptr [rsp+20],1
        mov       dword ptr [rsp+28],1
        mov       rcx,[rsi+1A8]
-       mov       rdx,11D4A3C3020
+       mov       rdx,27649002028
        mov       rdx,[rdx]
-       mov       r9,11D4A3D3AA8
+       mov       r9,27649012AC8
        mov       r9,[r9]
        mov       r8d,3A
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
+       call      qword ptr [7FF9C6481438]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
        mov       [rsp+38],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,40
        pop       rsi
        ret
-; Total bytes of code 110
+; Total bytes of code 111
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
        push      rbp
        sub       rsp,0D0
        lea       rbp,[rsp+0D0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-0B0],xmm4
        vmovdqa   xmmword ptr [rbp-0A0],xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        mov       [rbp+28],r9
-       cmp       dword ptr [7FF9C598E7D0],0
+       cmp       dword ptr [7FF9C6463418],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0..ctor()
+       call      qword ptr [7FF9C67698A0]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0..ctor()
        mov       rdx,[rbp-40]
        mov       [rbp-8],rdx
        mov       rdx,[rbp-8]
        lea       rcx,[rdx+8]
        mov       rdx,[rbp+28]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-8]
        mov       eax,[rbp+20]
        mov       [rcx+10],ax
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-24],ecx
        cmp       dword ptr [rbp-24],0
        je        short M01_L02
        nop
-       mov       rcx,11D4A3C3020
+       mov       rcx,27649002028
        mov       rcx,[rcx]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L07
 M01_L02:
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
        mov       rax,[rbp-48]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,offset MT_System.Collections.Generic.List`1
        call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
        mov       [rbp-58],rax
        mov       rcx,[rbp-10]
        mov       [rbp-60],rcx
        mov       rcx,[rbp-58]
-       call      System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
+       call      qword ptr [7FF9C5F430C0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       rax,[rbp-68]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-70],rax
        mov       rcx,[rbp-60]
        mov       rdx,[rbp-70]
        mov       r8d,4
-       call      System.String.Equals(System.String, System.String, System.StringComparison)
+       call      qword ptr [7FF9C6061378]; System.String.Equals(System.String, System.String, System.StringComparison)
        mov       [rbp-74],eax
        mov       r8d,[rbp-74]
        movzx     r8d,r8b
        mov       [rbp-34],r8d
        cmp       dword ptr [rbp-34],0
        je        short M01_L03
        nop
-       mov       r8,11DBA3C1B80
+       mov       r8,27649013890
        mov       r8,[r8]
        mov       [rbp-10],r8
        nop
        nop
        jmp       short M01_L04
 M01_L03:
        mov       r8d,[rbp+38]
        movzx     r8d,r8b
        test      r8d,r8d
        sete      r8b
        movzx     r8d,r8b
        mov       [rbp-38],r8d
        cmp       dword ptr [rbp-38],0
        je        short M01_L04
        nop
-       mov       r8,11D4A3C3020
+       mov       r8,27649002028
        mov       r8,[r8]
        mov       [rbp-10],r8
        nop
 M01_L04:
        mov       r8d,[rbp+30]
        movzx     r8d,r8b
        mov       rcx,[rbp+10]
        mov       rdx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C6481420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
        mov       [rbp-80],rax
        mov       rcx,[rbp-80]
        mov       [rbp-18],rcx
        mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-88],rax
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-8]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FF9C67688B8
+       call      qword ptr [7FF9C5FCB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       r9,[rbp-88]
        mov       rdx,[rbp-18]
        mov       r8,[rbp+18]
        mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6769930]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-90],rax
        mov       rdx,[rbp-90]
        mov       [rbp-20],rdx
        mov       rdx,[rbp-8]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-20]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      System.String.StartsWith(System.String, System.StringComparison)
+       call      qword ptr [7FF9C6061498]; System.String.StartsWith(System.String, System.StringComparison)
        mov       [rbp-94],eax
        cmp       dword ptr [rbp-94],0
        jne       short M01_L05
        mov       rcx,[rbp-20]
        mov       [rbp-0B0],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp-20]
        mov       [rbp-0A0],rcx
        xor       ecx,ecx
        mov       [rbp-0A4],ecx
        mov       rcx,[rbp-8]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6061BA0]; System.String.get_Length()
        mov       [rbp-0A8],eax
        mov       rcx,[rbp-0A0]
        mov       edx,[rbp-0A4]
        mov       r8d,[rbp-0A8]
        cmp       [rcx],ecx
-       call      System.String.Remove(Int32, Int32)
+       call      qword ptr [7FF9C6063030]; System.String.Remove(Int32, Int32)
        mov       [rbp-0B0],rax
 M01_L06:
        mov       rax,[rbp-0B0]
        mov       [rbp-30],rax
        nop
-       jmp       short M01_L07
 M01_L07:
        mov       rax,[rbp-30]
        add       rsp,0D0
        pop       rbp
        ret
-; Total bytes of code 705
+; Total bytes of code 711
```
**Diff for PropertiesToString04 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString04()
        push      rsi
        sub       rsp,40
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rsi,rcx
        xor       ecx,ecx
        mov       [rsp+20],ecx
        mov       dword ptr [rsp+28],1
        mov       rcx,[rsi+1A8]
-       mov       rdx,24966563020
+       mov       rdx,19739802028
        mov       rdx,[rdx]
-       mov       r9,24966573AA8
+       mov       r9,19739812AC8
        mov       r9,[r9]
        mov       r8d,3A
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
+       call      qword ptr [7FF9C64A1438]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
        mov       [rsp+38],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,40
        pop       rsi
        ret
-; Total bytes of code 108
+; Total bytes of code 109
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
        push      rbp
        sub       rsp,0D0
        lea       rbp,[rsp+0D0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-0B0],xmm4
        vmovdqa   xmmword ptr [rbp-0A0],xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        mov       [rbp+28],r9
-       cmp       dword ptr [7FF9C598E7D0],0
+       cmp       dword ptr [7FF9C6483418],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0..ctor()
+       call      qword ptr [7FF9C6797000]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0..ctor()
        mov       rdx,[rbp-40]
        mov       [rbp-8],rdx
        mov       rdx,[rbp-8]
        lea       rcx,[rdx+8]
        mov       rdx,[rbp+28]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-8]
        mov       eax,[rbp+20]
        mov       [rcx+10],ax
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-24],ecx
        cmp       dword ptr [rbp-24],0
        je        short M01_L02
        nop
-       mov       rcx,24966563020
+       mov       rcx,19739802028
        mov       rcx,[rcx]
        mov       [rbp-30],rcx
        nop
        jmp       near ptr M01_L07
 M01_L02:
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
        mov       rax,[rbp-48]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,offset MT_System.Collections.Generic.List`1
        call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
        mov       [rbp-58],rax
        mov       rcx,[rbp-10]
        mov       [rbp-60],rcx
        mov       rcx,[rbp-58]
-       call      System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
+       call      qword ptr [7FF9C5F630C0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       rax,[rbp-68]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       [rbp-70],rax
        mov       rcx,[rbp-60]
        mov       rdx,[rbp-70]
        mov       r8d,4
-       call      System.String.Equals(System.String, System.String, System.StringComparison)
+       call      qword ptr [7FF9C6081378]; System.String.Equals(System.String, System.String, System.StringComparison)
        mov       [rbp-74],eax
        mov       r8d,[rbp-74]
        movzx     r8d,r8b
        mov       [rbp-34],r8d
        cmp       dword ptr [rbp-34],0
        je        short M01_L03
        nop
-       mov       r8,249D6561B80
+       mov       r8,1974B800BB8
        mov       r8,[r8]
        mov       [rbp-10],r8
        nop
        nop
        jmp       short M01_L04
 M01_L03:
        mov       r8d,[rbp+38]
        movzx     r8d,r8b
        test      r8d,r8d
        sete      r8b
        movzx     r8d,r8b
        mov       [rbp-38],r8d
        cmp       dword ptr [rbp-38],0
        je        short M01_L04
        nop
-       mov       r8,24966563020
+       mov       r8,19739802028
        mov       r8,[r8]
        mov       [rbp-10],r8
        nop
 M01_L04:
        mov       r8d,[rbp+30]
        movzx     r8d,r8b
        mov       rcx,[rbp+10]
        mov       rdx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
+       call      qword ptr [7FF9C64A1420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
        mov       [rbp-80],rax
        mov       rcx,[rbp-80]
        mov       [rbp-18],rcx
        mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-88],rax
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-8]
-       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
-       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FF9C6796018
+       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       r9,[rbp-88]
        mov       rdx,[rbp-18]
        mov       r8,[rbp+18]
        mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
-       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
+       call      qword ptr [7FF9C6797090]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
        mov       [rbp-90],rax
        mov       rdx,[rbp-90]
        mov       [rbp-20],rdx
        mov       rdx,[rbp-8]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-20]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      System.String.StartsWith(System.String, System.StringComparison)
+       call      qword ptr [7FF9C6081498]; System.String.StartsWith(System.String, System.StringComparison)
        mov       [rbp-94],eax
        cmp       dword ptr [rbp-94],0
        jne       short M01_L05
        mov       rcx,[rbp-20]
        mov       [rbp-0B0],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp-20]
        mov       [rbp-0A0],rcx
        xor       ecx,ecx
        mov       [rbp-0A4],ecx
        mov       rcx,[rbp-8]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6081BA0]; System.String.get_Length()
        mov       [rbp-0A8],eax
        mov       rcx,[rbp-0A0]
        mov       edx,[rbp-0A4]
        mov       r8d,[rbp-0A8]
        cmp       [rcx],ecx
-       call      System.String.Remove(Int32, Int32)
+       call      qword ptr [7FF9C6083030]; System.String.Remove(Int32, Int32)
        mov       [rbp-0B0],rax
 M01_L06:
        mov       rax,[rbp-0B0]
        mov       [rbp-30],rax
        nop
-       jmp       short M01_L07
 M01_L07:
        mov       rax,[rbp-30]
        add       rsp,0D0
        pop       rbp
        ret
-; Total bytes of code 705
+; Total bytes of code 711
```
**Diff for StripNull method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A0]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.StripNull(System.Object)
+       call      qword ptr [7FF9C6481450]; DotNetTips.Spargine.Extensions.ObjectExtensions.StripNull(System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6777330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 67
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.StripNull(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-8],rax
        mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C596E7D0],0
+       cmp       dword ptr [7FF9C6463418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        cmp       qword ptr [rbp+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rax,[rbp+10]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
+       mov       [rbp-18],rax
+       mov       rax,[rbp-18]
        mov       [rbp-10],rax
-       mov       rax,[rbp-10]
-       mov       [rbp-8],rax
        jmp       short M01_L02
 M01_L01:
-       mov       rax,1E154913020
+       mov       rax,1C3D6402028
        mov       rax,[rax]
-       mov       [rbp-8],rax
+       mov       [rbp-10],rax
 M01_L02:
-       mov       rax,[rbp-8]
-       add       rsp,30
+       mov       rax,[rbp-10]
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 104
+; Total bytes of code 106
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for TestingForNull01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TestingForNull01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Object, System.Private.CoreLib]](System.Object ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6775FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 68
+; Total bytes of code 69
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for TestingForNull02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TestingForNull02()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Object, System.Private.CoreLib]](System.Object ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6775FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 68
+; Total bytes of code 69
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for ToJson03 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson03()
        push      rdi
        push      rsi
        sub       rsp,38
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        xor       eax,eax
        mov       [rsp+30],rax
        mov       rsi,rcx
        mov       rdi,[rsi+1A0]
-       call      System.Text.Json.JsonSerializerOptions.get_Default()
+       call      qword ptr [7FF9C64D3138]; System.Text.Json.JsonSerializerOptions.get_Default()
        mov       r8,rax
        lea       rcx,[rsp+28]
        mov       rdx,rdi
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
+       call      qword ptr [7FF9C64A1480]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
        lea       rcx,[rsp+28]
        mov       rdx,offset MT_DotNetTips.Spargine.Core.SimpleResult`1[[System.String, System.Private.CoreLib]]
-       call      DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9C6797738]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       [rsp+20],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,38
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 110
+; Total bytes of code 113
 ; System.Text.Json.JsonSerializerOptions.get_Default()
        sub       rsp,28
-       mov       rax,2024058E820
+       mov       rax,14A0340DF78
        mov       rax,[rax]
        test      rax,rax
-       jne       short M01_L00
-       call      System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
+       je        short M01_L01
 M01_L00:
-       nop
        add       rsp,28
        ret
-; Total bytes of code 33
+M01_L01:
+       call      qword ptr [7FF9C64D3690]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
+       jmp       short M01_L00
+; Total bytes of code 35
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,80
        vzeroupper
        lea       rbp,[rsp+90]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-60],xmm4
        vmovdqa   xmmword ptr [rbp-50],xmm4
        vmovdqa   xmmword ptr [rbp-40],xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-68],rsp
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
-       cmp       dword ptr [7FF9C596E7D0],0
+       cmp       dword ptr [7FF9C6483418],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        nop
-       mov       r9,20240593A20
+       mov       r9,14A03412A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20240583020
+       mov       r9,14A03402028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-30],rax
        mov       r8,[rbp-30]
        mov       [rbp+18],r8
        nop
        mov       r8,[rbp+20]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
-       call      System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
+       call      qword ptr [7FF9C66D3F00]; System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
        mov       [rbp-38],rax
        lea       rcx,[rbp-48]
        mov       r8,[rbp-38]
        mov       rdx,offset MD_DotNetTips.Spargine.Core.SimpleResult.FromValue[[System.String, System.Private.CoreLib]](System.String)
-       call      DotNetTips.Spargine.Core.SimpleResult.FromValue[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       call      qword ptr [7FF9C6797810]; DotNetTips.Spargine.Core.SimpleResult.FromValue[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        vmovdqu   xmm0,xmmword ptr [rbp-48]
        vmovdqu   xmmword ptr [rbp-20],xmm0
        nop
-       jmp       short M02_L01
 M02_L01:
        mov       rdi,[rbp+10]
        lea       rsi,[rbp-20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        mov       rax,[rbp+10]
        add       rsp,80
        pop       rsi
        pop       rdi
        pop       rbp
        ret
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,30
        vzeroupper
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+90]
        mov       [rbp-50],rdx
        mov       rcx,[rbp-50]
        mov       [rbp-28],rcx
        nop
        lea       rcx,[rbp-60]
        mov       r8,[rbp-28]
        mov       rdx,offset MD_DotNetTips.Spargine.Core.SimpleResult.FromException[[System.String, System.Private.CoreLib]](System.Exception)
-       call      DotNetTips.Spargine.Core.SimpleResult.FromException[[System.__Canon, System.Private.CoreLib]](System.Exception)
+       call      qword ptr [7FF9C6797840]
        vmovdqu   xmm0,xmmword ptr [rbp-60]
        vmovdqu   xmmword ptr [rbp-20],xmm0
        nop
        lea       rax,[M02_L01]
        add       rsp,30
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 331
+; Total bytes of code 333
 ; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        push      rbp
        push      rbp
        sub       rsp,30
        sub       rsp,30
        lea       rbp,[rsp+30]
        lea       rbp,[rsp+30]
        xor       eax,eax
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp-10],rax
        mov       [rbp-8],rdx
        mov       [rbp-8],rdx
        mov       [rbp+10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C5800340],0
-       cmp       dword ptr [7FF9C5800340],0
+       cmp       dword ptr [7FF9C6321B58],0
+       cmp       dword ptr [7FF9C6321B58],0
        je        short M03_L00
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
 M03_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
        mov       rdx,[rbp+18]
-       call      DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].Validate()
-       call      DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].Validate()
+       call      qword ptr [7FF9C67975A0]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].Validate()
+       call      qword ptr [7FF9C67975A0]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].Validate()
        nop
        nop
        mov       rax,[rbp+10]
        mov       rax,[rbp+10]
        mov       rax,[rax]
        mov       rax,[rax]
        mov       [rbp-10],rax
        mov       [rbp-10],rax
        nop
        nop
-       jmp       short M03_L01
-       jmp       short M03_L01
-M03_L01:
        mov       rax,[rbp-10]
-M03_L01:
        mov       rax,[rbp-10]
        add       rsp,30
        add       rsp,30
        pop       rbp
        pop       rbp
        ret
        ret
-; Total bytes of code 162
+; Total bytes of code 160
```
**Diff for ToJson01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A0]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       call      qword ptr [7FF9C6481468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6769330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 67
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        push      rbp
-       sub       rsp,40
+       push      rdi
+       sub       rsp,38
        lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-8],rax
        mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C597E7D0],0
+       cmp       dword ptr [7FF9C6463418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       r9,26865FB3A20
+       mov       r9,2364A012A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,26865FA3020
+       mov       r9,2364A002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
-       mov       [rbp-8],rax
-       mov       rdx,[rbp-8]
+       call      qword ptr [7FF9C64BBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       [rbp-10],rax
+       mov       rdx,[rbp-10]
        mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
        xor       r8d,r8d
-       call      System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
-       mov       [rbp-10],rax
-       mov       rax,[rbp-10]
-       add       rsp,40
+       call      qword ptr [7FF9C66B57C8]; System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
+       mov       [rbp-18],rax
+       mov       rax,[rbp-18]
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 131
+; Total bytes of code 135
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for ToJson02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       call      qword ptr [7FF9C6471468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6767F48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 67
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        push      rbp
-       sub       rsp,40
+       push      rdi
+       sub       rsp,38
        lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-8],rax
        mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C597E7D0],0
+       cmp       dword ptr [7FF9C6453418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       r9,291C74A3A20
+       mov       r9,1837E012A58
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,291C7493020
+       mov       r9,1837E002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
-       mov       [rbp-8],rax
-       mov       rdx,[rbp-8]
+       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       [rbp-10],rax
+       mov       rdx,[rbp-10]
        mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
        xor       r8d,r8d
-       call      System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
-       mov       [rbp-10],rax
-       mov       rax,[rbp-10]
-       add       rsp,40
+       call      qword ptr [7FF9C66A3780]; System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
+       mov       [rbp-18],rax
+       mov       rax,[rbp-18]
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 131
+; Total bytes of code 135
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for TryDispose method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
        push      rsi
        sub       rsp,20
        mov       rcx,offset MT_System.Data.DataTable
        call      CORINFO_HELP_NEWFAST
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.Data.DataTable..ctor()
-       mov       rdx,1F214331B78
+       call      qword ptr [7FF9C6767450]; System.Data.DataTable..ctor()
+       mov       rdx,212D5800BC0
        mov       rdx,[rdx]
        lea       rcx,[rsi+70]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rsi
        add       rsp,20
        pop       rsi
-       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable)
-; Total bytes of code 66
+       jmp       qword ptr [7FF9C64714B0]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable)
+; Total bytes of code 68
 ; System.Data.DataTable..ctor()
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,20
+       sub       rsp,40
        vzeroupper
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rsp+28],xmm4
+       xor       eax,eax
+       mov       [rsp+38],rax
        mov       rsi,rcx
-       mov       rdx,1F1B4333020
+       mov       rdx,212CF802028
        mov       rdi,[rdx]
        lea       rcx,[rsi+70]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+80]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       byte ptr [rsi+1C4],1
        mov       dword ptr [rsi+1B0],19
-       mov       rdx,1F1B4331060
+       mov       rdx,212CF800068
        mov       rdx,[rdx]
-       vmovupd   xmm0,[rdx+8]
+       add       rdx,8
+       vmovupd   xmm0,[rdx]
        vmovupd   [rsi+1D8],xmm0
-       mov       rdx,1F1B4331060
-       mov       rdx,[rdx]
-       vmovupd   xmm0,[rdx+8]
+       vmovupd   xmm0,[rdx]
        vmovupd   [rsi+1E8],xmm0
-       mov       rdx,1F1B43423F0
+       mov       rdx,212CB80F690
        mov       rdx,[rdx]
        lea       rcx,[rsi+0D8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       byte ptr [rsi+1CC],1
-       mov       rdx,1F1B43423F8
+       mov       rdx,212CB80F698
        mov       rdx,[rdx]
        lea       rcx,[rsi+110]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F1B4342400
+       mov       rdx,212CB80F6A0
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+180]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F1B4342408
+       mov       rdx,212CB80F6A8
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+188]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
        call      CORINFO_HELP_NEWSFAST
        mov       dword ptr [rax+40],0FFFFFFFF
        mov       dword ptr [rax+44],0FFFFFFFF
        mov       byte ptr [rax+4D],1
-       mov       rdx,7FF9C55D5340
+       mov       rdx,7FF9C5F25680
        mov       ecx,1
        lock xadd [rdx],rcx
        inc       rcx
        mov       [rax+28],rcx
        lea       rcx,[rsi+198]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       dword ptr [rsi+1B8],0FFFFFFFF
-       mov       rcx,7FF9C5C531CC
+       mov       rcx,7FF9C674ADDC
        mov       eax,1
        lock xadd [rcx],eax
        inc       eax
        mov       [rsi+1C0],eax
        mov       rcx,rsi
-       call      System.GC.SuppressFinalize(System.Object)
-       mov       rcx,1F1B43415F0
-       mov       rdi,[rcx]
+       call      qword ptr [7FF9C63B76C0]; System.GC.SuppressFinalize(System.Object)
+       mov       rcx,212CB80E868
+       mov       rcx,[rcx]
+       mov       rdi,rcx
        mov       ebx,[rsi+1C0]
-       cmp       byte ptr [rdi+9D],0
+       cmp       byte ptr [rcx+9D],0
        jne       near ptr M01_L01
 M01_L00:
        mov       qword ptr [rsi+1A0],1
        mov       rcx,offset MT_System.Data.RecordManager
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      System.Data.RecordManager..ctor(System.Data.DataTable)
+       call      qword ptr [7FF9C67B18B8]; System.Data.RecordManager..ctor(System.Data.DataTable)
        lea       rcx,[rsi+50]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62398A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        lea       rcx,[rsi+90]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Data.DataColumnCollection
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
        mov       rdx,rsi
-       call      System.Data.DataColumnCollection..ctor(System.Data.DataTable)
+       call      qword ptr [7FF9C676D9A8]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
        lea       rcx,[rsi+30]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Data.ConstraintCollection
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,offset MT_System.Collections.ArrayList
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       mov       rdx,1F1B4332F48
+       mov       rdx,212CF801F78
        mov       rdx,[rdx]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+10]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       dword ptr [rdi+28],1
        lea       rcx,[rdi+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+38]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Data.DataRowCollection
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,offset MT_System.Data.DataRowCollection+DataRowTree
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       dword ptr [rbx+30],2
        mov       rcx,rbx
-       call      System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
+       call      qword ptr [7FF9C676F870]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
        lea       rcx,[rdi+10]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rdi+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+28]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.Index, System.Data.Common]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F1B4342420
+       mov       rdx,212CB80F6C0
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+58]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset MT_System.Data.DataRowBuilder
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        mov       dword ptr [rdi+10],0FFFFFFFF
        lea       rcx,[rsi+178]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        nop
-       add       rsp,20
+       add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       [rax+8],ebx
-       mov       rdx,rax
-       mov       rcx,1F214331B80
-       mov       rcx,[rcx]
-       call      System.String.Format(System.String, System.Object)
+       mov       [rsp+38],rax
+       lea       r8,[rsp+38]
+       mov       rdx,212D5800BC8
+       mov       rdx,[rdx]
+       mov       [rsp+28],r8
+       mov       dword ptr [rsp+30],1
+       lea       r8,[rsp+28]
+       xor       ecx,ecx
+       call      qword ptr [7FF9C6051DC8]
        mov       r8,rax
        mov       rcx,rdi
        mov       edx,1
-       call      System.Diagnostics.Tracing.EventSource.WriteEvent(Int32, System.String)
+       call      qword ptr [7FF9C609F348]
        jmp       near ptr M01_L00
-; Total bytes of code 915
+; Total bytes of code 958
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable)
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
+       push      rdi
+       sub       rsp,28
+       lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C597E7D0],0
+       cmp       dword ptr [7FF9C6453418],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        xor       edx,edx
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
+       call      qword ptr [7FF9C64714C8]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
        nop
        nop
-       add       rsp,20
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 47
+; Total bytes of code 50
```
**Diff for FromJson method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJson()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+190]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.String)
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FF9C6777FA8]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67792D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        push      rbp
-       sub       rsp,50
+       push      rdi
+       sub       rsp,48
        lea       rbp,[rsp+50]
        xor       eax,eax
-       mov       [rbp-10],rax
-       mov       [rbp-20],rax
-       mov       [rbp-8],rcx
+       mov       [rbp-18],rax
+       mov       [rbp-28],rax
+       mov       [rbp-10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C598E7D0],0
+       cmp       dword ptr [7FF9C6473418],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       r9,22F76271B80
+       mov       r9,1A041C00BC0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,22F16273020
+       mov       r9,1A039C02028
        mov       r9,[r9]
        mov       rcx,[rbp+18]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
-       mov       [rbp-10],rax
+       call      qword ptr [7FF9C64CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       [rbp-18],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
-       mov       [rbp-18],rcx
+       mov       [rbp-20],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C55B38
+       mov       rdx,7FF9C67852E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
-       mov       [rbp-18],rax
-M01_L02:
-       mov       rcx,[rbp-18]
-       mov       rdx,[rbp-10]
-       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rbp-20],rax
-       mov       rax,[rbp-20]
-       add       rsp,50
+M01_L02:
+       mov       rcx,[rbp-20]
+       mov       rdx,[rbp-18]
+       call      qword ptr [7FF9C67790A8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
+       mov       [rbp-28],rax
+       mov       rax,[rbp-28]
+       add       rsp,48
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 181
+; Total bytes of code 185
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
