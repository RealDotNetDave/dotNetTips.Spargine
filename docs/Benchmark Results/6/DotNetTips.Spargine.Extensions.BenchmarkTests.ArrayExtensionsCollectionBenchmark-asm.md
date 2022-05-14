## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2391BDF3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,238FBDF15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD03BC58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD03BC98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD0371E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD0371F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD03BCB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD0371E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD03BC68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC980720
       call      qword ptr [7FFEBCFB0720]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD03BC80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980720
       call      qword ptr [7FFEBCFB0720]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980728
       call      qword ptr [7FFEBCFB0728]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980728
       call      qword ptr [7FFEBCFB0728]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,2391BDF3020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,2391BE02288
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF739F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,2391BE02290
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,2391BE02298
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF73B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF75550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1FA32103020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1FA521015C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD02BC38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD02BC78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD0271C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD0271D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD02BC90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD0271C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD02BC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC970720
       call      qword ptr [7FFEBCF90720]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD02BC60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970720
       call      qword ptr [7FFEBCF90720]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970728
       call      qword ptr [7FFEBCF90728]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970728
       call      qword ptr [7FFEBCF90728]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,1FA32103020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,1FA52102268
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCFE39A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,1FA52102270
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,1FA52102278
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCFE3AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCFE5508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2DFC9F93020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2DFC9FA1E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD02B9F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD02BA38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD0271B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD0271C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD02BA50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD0271B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD02BA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC970718
       call      qword ptr [7FFEBCFA0718]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD02BA20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970718
       call      qword ptr [7FFEBCFA0718]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970720
       call      qword ptr [7FFEBCFA0720]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970720
       call      qword ptr [7FFEBCFA0720]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,2DFC9F93020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,2DFA9F91A50
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF63988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,2DFA9F91A58
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,2DFA9F91A60
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF63AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF654E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2143E023020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2143E031E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD04BA40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD04BA80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD045700
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD045710
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD04BA98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+58]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD045700
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD04BA50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC990718
       call      qword ptr [7FFEBCFC0718]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD04BA68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC990718
       call      qword ptr [7FFEBCFC0718]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC990720
       call      qword ptr [7FFEBCFC0720]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC990720
       call      qword ptr [7FFEBCFC0720]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,2143E023020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,2142E021A50
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF839F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,2142E021A58
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,2142E021A60
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF83B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF85550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2D53AD53020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2D53AD61E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD03BA20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD03BA60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD037240
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD037250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD03BA78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD037240
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD03BA30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC980718
       call      qword ptr [7FFEBCFB0718]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD03BA48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980718
       call      qword ptr [7FFEBCFB0718]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980720
       call      qword ptr [7FFEBCFB0720]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980720
       call      qword ptr [7FFEBCFB0720]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,2D53AD53020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,2D53AD63AB8
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF739F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,2D53AD63AC0
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,2D53AD63AC8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF73B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF75550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,28A442E1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,28A442E39D8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD03BA20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD03BA60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD0357D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD0357E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD03BA78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+58]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD0357D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD03BA30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC980718
       call      qword ptr [7FFEBCFB0718]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD03BA48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980718
       call      qword ptr [7FFEBCFB0718]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980720
       call      qword ptr [7FFEBCFB0720]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980720
       call      qword ptr [7FFEBCFB0720]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,28A442E1028
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,28A442E4678
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF739F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,28A442E4680
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,28A442E4688
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF73B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF75550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1795AD91028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1795AD939D8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD03C1D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD03C218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD0357B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD0357C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD03C230
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+58]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD0357B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD03C1E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC980718
       call      qword ptr [7FFEBCFA0718]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD03C200
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980718
       call      qword ptr [7FFEBCFA0718]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980720
       call      qword ptr [7FFEBCFA0720]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980720
       call      qword ptr [7FFEBCFA0720]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,1795AD91028
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,1796AD91A50
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCFF3A38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,1796AD91A58
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,1796AD91A60
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCFF3B50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCFF5598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,17C0F943020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,17C2F9415C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD074070
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD0740B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+38]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+40]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBCF15C98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBCF15C90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD0740C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+40]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBCF15C98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD074080
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC9A0878
       call      qword ptr [7FFEBCF80878]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD074098
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0878
       call      qword ptr [7FFEBCF80878]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0880
       call      qword ptr [7FFEBCF80880]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0880
       call      qword ptr [7FFEBCF80880]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,17C0F943020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,17C0F94DDF0
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBD021A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,17C0F94DDF8
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,17C0F94DE00
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBD021B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBD023568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,14EE3A03020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,14EC3A015C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD03BB88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD03BBC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD037178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD037188
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD03BBE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD037178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD03BB98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC980720
       call      qword ptr [7FFEBCFB0720]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD03BBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980720
       call      qword ptr [7FFEBCFB0720]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980728
       call      qword ptr [7FFEBCFB0728]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980728
       call      qword ptr [7FFEBCFB0728]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,14EE3A03020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,14EC3A02268
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF73970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,14EC3A02270
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,14EC3A02278
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF73A88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF754D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,14CC64B3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,14CE64B15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD05BC50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD05BC90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD0571D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD0571E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD05BCA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD0571D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD05BC60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC9A0720
       call      qword ptr [7FFEBCFD0720]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD05BC78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0720
       call      qword ptr [7FFEBCFD0720]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0728
       call      qword ptr [7FFEBCFD0728]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0728
       call      qword ptr [7FFEBCFD0728]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,14CC64B3020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,14CE64B3280
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF939F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,14CE64B3288
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,14CE64B3290
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF93B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF95550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1A1D4303020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1A1F430D9F8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD02B9D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD02BA10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD0271F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD027200
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD02BA28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD0271F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD02B9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC970718
       call      qword ptr [7FFEBCFA0718]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD02B9F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970718
       call      qword ptr [7FFEBCFA0718]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970720
       call      qword ptr [7FFEBCFA0720]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970720
       call      qword ptr [7FFEBCFA0720]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,1A1D4303020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,1A1D4305E58
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF639F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,1A1D4305E60
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,1A1D4305E68
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF63B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF65550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1B9F7873020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1B9E78715C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD02BA20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD02BA60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD027240
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD027250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD02BA78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD027240
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD02BA30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC970718
       call      qword ptr [7FFEBCFA0718]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD02BA48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970718
       call      qword ptr [7FFEBCFA0718]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970720
       call      qword ptr [7FFEBCFA0720]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970720
       call      qword ptr [7FFEBCFA0720]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,1B9F7873020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,1B9E7872268
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF639F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,1B9E7872270
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,1B9E7872278
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF63B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF65550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2D763F03020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2D783F015C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD01BCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD01BCF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD017240
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD017250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD01BD10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD017240
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD01BCC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC960720
       call      qword ptr [7FFEBCF90720]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD01BCE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC960720
       call      qword ptr [7FFEBCF90720]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC960728
       call      qword ptr [7FFEBCF90728]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC960728
       call      qword ptr [7FFEBCF90728]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,2D763F03020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,2D763F06E70
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF539F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,2D763F06E78
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,2D763F06E80
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF53B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF55550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,228C59D3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,228A59D15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD05BA48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD05BA88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD055708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD055718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD05BAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+58]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD055708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD05BA58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC9A0718
       call      qword ptr [7FFEBCFD0718]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD05BA70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0718
       call      qword ptr [7FFEBCFD0718]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0720
       call      qword ptr [7FFEBCFD0720]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0720
       call      qword ptr [7FFEBCFD0720]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,228C59D3020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,228C59E2288
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF939F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,228C59E2290
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,228C59E2298
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF93B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF95550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2C062FE3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2C042FE15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD01BEA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD01BEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBD015708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBD015718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD01BF00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+58]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBD015708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD01BEB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC960718
       call      qword ptr [7FFEBCF90718]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD01BED0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC960718
       call      qword ptr [7FFEBCF90718]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC960720
       call      qword ptr [7FFEBCF90720]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC960720
       call      qword ptr [7FFEBCF90720]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,2C062FE3020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,2C062FF32A0
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBCF53A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,2C062FF32A8
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,2C062FF32B0
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF53B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF55568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,25749E73020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,25749E759D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBD073EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFEBD073F30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+38]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+40]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFEBCF14908
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFEBCF14900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFEBD073F48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+40]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBCF14908
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFEBD073F00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFEBC9A0878
       call      qword ptr [7FFEBCF80878]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFEBD073F18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0878
       call      qword ptr [7FFEBCF80878]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0880
       call      qword ptr [7FFEBCF80880]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0880
       call      qword ptr [7FFEBCF80880]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       [rsp+98],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rax,25749E73020
       mov       rbx,[rax]
       mov       [rsp+48],rbx
       mov       rbp,[rsp+98]
       mov       r14,[rdi+10]
       mov       rax,25749E76670
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbx
       cmp       qword ptr [r14+18],0
       je        short M03_L01
       mov       rcx,[r14+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFEBD0219A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r9,25749E76678
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbp
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       mov       [rsp+98],rax
       mov       [rsp+48],rbx
       mov       rax,25749E76680
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L04
       mov       rbx,[r14+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBD021AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+98]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+98]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBD023500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF24778]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       test      rax,rax
       je        short M00_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF24980]
       setae     sil
       movzx     esi,sil
       mov       rcx,2AF4B9D1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,2AF4B9D1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF24988]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2AF1B9D9858
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,2AF1B9D9860
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF2C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,2AF4B9D2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       rax,2AF1B9DFA40
       mov       rbx,[rax]
       test      edi,edi
       ja        short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorReadOnlySpanCannotBeNull()
       mov       rcx,rax
       cmp       dword ptr [rbx+8],0
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rbx,rcx
M02_L01:
       mov       rdx,2AF1B9DFA40
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      edi,edi
       jle       short M02_L04
       mov       rdx,2AF4B9D1568
       mov       r14,[rdx]
       mov       rdx,2AF1B9E1C00
       mov       r15,[rdx]
M02_L03:
       movsxd    rdx,ebp
       add       rdx,rsi
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L05
       cmp       ebp,edi
       jl        short M02_L03
M02_L04:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD878C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF24318]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       test      rax,rax
       je        short M00_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF24520]
       setae     sil
       movzx     esi,sil
       mov       rcx,179686F1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,179686F1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF24528]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,179986F7448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,179986F7450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF2C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,179686F2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       rax,179686F5608
       mov       rbx,[rax]
       test      edi,edi
       ja        short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorReadOnlySpanCannotBeNull()
       mov       rcx,rax
       cmp       dword ptr [rbx+8],0
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rbx,rcx
M02_L01:
       mov       rdx,179686F5608
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      edi,edi
       jle       short M02_L04
       mov       rdx,179686F1568
       mov       r14,[rdx]
       mov       rdx,179886F1B90
       mov       r15,[rdx]
M02_L03:
       movsxd    rdx,ebp
       add       rdx,rsi
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L05
       cmp       ebp,edi
       jl        short M02_L03
M02_L04:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD878C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF34318]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       test      rax,rax
       je        short M00_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF34520]
       setae     sil
       movzx     esi,sil
       mov       rcx,2BE19AF1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,2BE19AF1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF34528]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2BE19AFB850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,2BE19AFB858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF3C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,2BE19AF2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       rax,2BE39AF1200
       mov       rbx,[rax]
       test      edi,edi
       ja        short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorReadOnlySpanCannotBeNull()
       mov       rcx,rax
       cmp       dword ptr [rbx+8],0
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rbx,rcx
M02_L01:
       mov       rdx,2BE39AF1200
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      edi,edi
       jle       short M02_L04
       mov       rdx,2BE19AF1568
       mov       r14,[rdx]
       mov       rdx,2BE19B023C8
       mov       r15,[rdx]
M02_L03:
       movsxd    rdx,ebp
       add       rdx,rsi
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L05
       cmp       ebp,edi
       jl        short M02_L03
M02_L04:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD978C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF241B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       test      rax,rax
       je        short M00_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF243C0]
       setae     sil
       movzx     esi,sil
       mov       rcx,1B62C751568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1B62C751380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF243C8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1B63C759858
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,1B63C759860
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF2C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,1B62C752E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       rax,1B65C751200
       mov       rbx,[rax]
       test      edi,edi
       ja        short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorReadOnlySpanCannotBeNull()
       mov       rcx,rax
       cmp       dword ptr [rbx+8],0
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rbx,rcx
M02_L01:
       mov       rdx,1B65C751200
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      edi,edi
       jle       short M02_L04
       mov       rdx,1B62C751568
       mov       r14,[rdx]
       mov       rdx,1B64C752BA8
       mov       r15,[rdx]
M02_L03:
       movsxd    rdx,ebp
       add       rdx,rsi
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L05
       cmp       ebp,edi
       jl        short M02_L03
M02_L04:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD878C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF24318]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       test      rax,rax
       je        short M00_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF24520]
       setae     sil
       movzx     esi,sil
       mov       rcx,23BFAF51568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,23BFAF51380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF24528]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,23BFAF5B850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,23BFAF5B858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF2C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,23BFAF52E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       rax,23BDAF51200
       mov       rbx,[rax]
       test      edi,edi
       ja        short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorReadOnlySpanCannotBeNull()
       mov       rcx,rax
       cmp       dword ptr [rbx+8],0
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rbx,rcx
M02_L01:
       mov       rdx,23BDAF51200
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      edi,edi
       jle       short M02_L04
       mov       rdx,23BFAF51568
       mov       r14,[rdx]
       mov       rdx,23BFAF623C8
       mov       r15,[rdx]
M02_L03:
       movsxd    rdx,ebp
       add       rdx,rsi
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L05
       cmp       ebp,edi
       jl        short M02_L03
M02_L04:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD878C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF243B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       test      rax,rax
       je        short M00_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF245C0]
       setae     sil
       movzx     esi,sil
       mov       rcx,28E31CF1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,28E31CF1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF245C8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,28E41CF7448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,28E41CF7450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF2C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,28E31CF2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       rax,28E31CF31F8
       mov       rbx,[rax]
       test      edi,edi
       ja        short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorReadOnlySpanCannotBeNull()
       mov       rcx,rax
       cmp       dword ptr [rbx+8],0
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rbx,rcx
M02_L01:
       mov       rdx,28E31CF31F8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      edi,edi
       jle       short M02_L04
       mov       rdx,28E31CF1568
       mov       r14,[rdx]
       mov       rdx,28E11CF3FA0
       mov       r15,[rdx]
M02_L03:
       movsxd    rdx,ebp
       add       rdx,rsi
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L05
       cmp       ebp,edi
       jl        short M02_L03
M02_L04:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD878C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF34818]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       test      rax,rax
       je        short M00_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF34A20]
       setae     sil
       movzx     esi,sil
       mov       rcx,1F221061568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1F221061380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF34A28]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1F251067448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,1F251067450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF3C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,1F221062E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       rax,1F221065608
       mov       rbx,[rax]
       test      edi,edi
       ja        short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorReadOnlySpanCannotBeNull()
       mov       rcx,rax
       cmp       dword ptr [rbx+8],0
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rbx,rcx
M02_L01:
       mov       rdx,1F221065608
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      edi,edi
       jle       short M02_L04
       mov       rdx,1F221061568
       mov       r14,[rdx]
       mov       rdx,1F2210677C8
       mov       r15,[rdx]
M02_L03:
       movsxd    rdx,ebp
       add       rdx,rsi
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L05
       cmp       ebp,edi
       jl        short M02_L03
M02_L04:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD978C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF30B88]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       test      rax,rax
       je        short M00_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF30D90]
       setae     sil
       movzx     esi,sil
       mov       rcx,1CEFBDB1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1CEFBDB1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF30D98]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1CEFBDBB850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,1CEFBDBB858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF3C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,1CEFBDB2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       rax,1CEFBDC1A38
       mov       rbx,[rax]
       test      edi,edi
       ja        short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorReadOnlySpanCannotBeNull()
       mov       rcx,rax
       cmp       dword ptr [rbx+8],0
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rbx,rcx
M02_L01:
       mov       rdx,1CEFBDC1A38
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      edi,edi
       jle       short M02_L04
       mov       rdx,1CEFBDB1568
       mov       r14,[rdx]
       mov       rdx,1CEEBDB1B90
       mov       r15,[rdx]
M02_L03:
       movsxd    rdx,ebp
       add       rdx,rsi
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L05
       cmp       ebp,edi
       jl        short M02_L03
M02_L04:
       mov       rcx,rbx
       call      qword ptr [7FFEBCF378C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2A7B1853020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2A7D18515C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,198B76D1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,198876D15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,21F5D8B3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,21F7D8BD9F8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1D0BDA53020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1D09DA59560
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,255027A3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,255027A59D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1E67C893020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1E65C8915C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2206E243020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2208E2415C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2770B1F3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2770B1F39D8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2BC99AE3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2BCB9AE15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2A1C4993020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2A1E49915C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1B6AB473020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1B6CB47F9F0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,19F7B353020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,19FAB35D9F8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,22B2AC93020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,22B0AC915C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1E0B2541028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1E0D25435C0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,270242B3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,270242C1E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,287DC991028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,287FC9915C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,27FAAF23020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,27F8AF215C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1E9AA323020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1E9AA331E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,17950AD3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,17950AE1E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2561EC13020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2561EC21E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,16DC3523020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,16DA35215C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1E90EE13020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1E8EEE115C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,22BAD523020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,22BAD5259D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,207ACA23020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2078CA215C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1EE4CBB3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1EE4CBC1E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFEBD022E70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFEBD022E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rax,1EE4CBB3020
       mov       rbp,[rax]
       mov       [rsp+50],rbp
       mov       r14,[rdi+10]
       mov       rax,1EE4CBC1A38
       mov       rax,[rax]
       mov       [rsp+48],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+40],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+50],rbp
       mov       rax,1EE4CBC2AA0
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       ebp,[rsi+8]
       add       ebp,1
       jo        near ptr M03_L05
       cmp       qword ptr [r14+20],0
       je        short M03_L02
       mov       rcx,[r14+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF73A30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 378
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,297B5323020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,297C53215C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFEBD031F10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFEBD031F20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rax,297B5323020
       mov       rbp,[rax]
       mov       [rsp+50],rbp
       mov       r14,[rdi+10]
       mov       rax,297C5321200
       mov       rax,[rax]
       mov       [rsp+48],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+40],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+50],rbp
       mov       rax,297B53332A0
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       ebp,[rsi+8]
       add       ebp,1
       jo        near ptr M03_L05
       cmp       qword ptr [r14+20],0
       je        short M03_L02
       mov       rcx,[r14+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF73A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 378
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1CEC0FE3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1CEC0FF1E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFEBD021E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFEBD021E90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rax,1CEC0FE3020
       mov       rbp,[rax]
       mov       [rsp+50],rbp
       mov       r14,[rdi+10]
       mov       rax,1CEC0FF1A38
       mov       rax,[rax]
       mov       [rsp+48],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+40],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+50],rbp
       mov       rax,1CEC0FF2AA0
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       ebp,[rsi+8]
       add       ebp,1
       jo        near ptr M03_L05
       cmp       qword ptr [r14+20],0
       je        short M03_L02
       mov       rcx,[r14+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF63A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 378
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2125F573020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2126F5715C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFEBD031E18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFEBD031E28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rax,2125F573020
       mov       rbp,[rax]
       mov       [rsp+50],rbp
       mov       r14,[rdi+10]
       mov       rax,2126F571200
       mov       rax,[rax]
       mov       [rsp+48],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+40],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+50],rbp
       mov       rax,2126F572268
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       ebp,[rsi+8]
       add       ebp,1
       jo        near ptr M03_L05
       cmp       qword ptr [r14+20],0
       je        short M03_L02
       mov       rcx,[r14+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF73A30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 378
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,17A369E3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,17A369E59D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFEBD021EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFEBD021ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rax,17A369E3020
       mov       rbp,[rax]
       mov       [rsp+50],rbp
       mov       r14,[rdi+10]
       mov       rax,17A369E5608
       mov       rax,[rax]
       mov       [rsp+48],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+40],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+50],rbp
       mov       rax,17A569E99E8
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       ebp,[rsi+8]
       add       ebp,1
       jo        near ptr M03_L05
       cmp       qword ptr [r14+20],0
       je        short M03_L02
       mov       rcx,[r14+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF63A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 378
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,129318A1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,129318A39D8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFEBD011E30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFEBD011E40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rax,129318A1028
       mov       rbp,[rax]
       mov       [rsp+50],rbp
       mov       r14,[rdi+10]
       mov       rax,129318A3610
       mov       rax,[rax]
       mov       [rsp+48],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+40],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+50],rbp
       mov       rax,129518AFE78
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       ebp,[rsi+8]
       add       ebp,1
       jo        near ptr M03_L05
       cmp       qword ptr [r14+20],0
       je        short M03_L02
       mov       rcx,[r14+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF53A30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 378
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,219FBBD3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,219DBBD15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFEBD051F50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFEBD051F60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rax,219FBBD3020
       mov       rbp,[rax]
       mov       [rsp+50],rbp
       mov       r14,[rdi+10]
       mov       rax,219DBBD1200
       mov       rax,[rax]
       mov       [rsp+48],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+40],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+50],rbp
       mov       rax,219DBBD2268
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       ebp,[rsi+8]
       add       ebp,1
       jo        near ptr M03_L05
       cmp       qword ptr [r14+20],0
       je        short M03_L02
       mov       rcx,[r14+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBD013B88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 378
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2CCD97F1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2CCD97FFE08
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFEBCEF5C80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFEBCEF5C78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rax,2CCD97F1028
       mov       rbp,[rax]
       mov       [rsp+50],rbp
       mov       r14,[rdi+10]
       mov       rax,2CCD97FFA40
       mov       rax,[rax]
       mov       [rsp+48],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+40],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+50],rbp
       mov       rax,2CCD9800AA8
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       ebp,[rsi+8]
       add       ebp,1
       jo        near ptr M03_L05
       cmp       qword ptr [r14+20],0
       je        short M03_L02
       mov       rcx,[r14+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBD001AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 378
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,278610C3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,278810C15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rax,278610C3020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rbp,[rdi+10]
       mov       rax,278810C1200
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF73820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 315
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2C621CC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2C621CC59D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rax,2C621CC3020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rbp,[rdi+10]
       mov       rax,2C621CC5608
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF83820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 315
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,26BD6821028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,26BE68215C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rax,26BD6821028
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rbp,[rdi+10]
       mov       rax,26BE6821200
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF837B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 315
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,21B28C53020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,21B38C515C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rax,21B28C53020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rbp,[rdi+10]
       mov       rax,21B38C51200
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCFE37D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 315
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,273F9653020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,274196515C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rax,273F9653020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rbp,[rdi+10]
       mov       rax,27419651200
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF63820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 315
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,202113D3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,202313DF9F0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rax,202113D3020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rbp,[rdi+10]
       mov       rax,202313DF628
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCFE3820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 315
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,25D61AC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,25D61AC59D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rax,25D61AC3020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rbp,[rdi+10]
       mov       rax,25D61AC5608
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF73820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 315
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2F317FC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2F2F7FC15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rax,2F317FC3020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rbp,[rdi+10]
       mov       rax,2F2F7FC1200
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBD0017D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 315
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF14510]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF14710]
       setae     sil
       movzx     esi,sil
       mov       rcx,1C8F18C1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1C8F18C1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF14718]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1C8E18C9858
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,1C8E18C9860
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF1C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,1C8F18C2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rax,1C8E18C1028
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,1C8E18CFA40
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M02_L02
       mov       rdx,1C8F18C1568
       mov       r14,[rdx]
       mov       rdx,1C9018C2BA8
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L03
       cmp       ebx,ebp
       jg        short M02_L01
M02_L02:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD778C0]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 256
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF047D0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF049D0]
       setae     sil
       movzx     esi,sil
       mov       rcx,298B3D61568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,298B3D61380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF049D8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,298D3D67448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,298D3D67450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF0C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,298B3D62E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rax,298B3D63020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,298D3D6D630
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M02_L02
       mov       rdx,298B3D61568
       mov       r14,[rdx]
       mov       rdx,298B3D66FB0
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L03
       cmp       ebx,ebp
       jg        short M02_L01
M02_L02:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD678C0]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 256
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF442D0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF444D0]
       setae     sil
       movzx     esi,sil
       mov       rcx,23517D61568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,23517D61380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF444D8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,23507D67448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,23507D67450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF4C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,23517D62E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rax,23517D63020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,23527D61200
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M02_L02
       mov       rdx,23517D61568
       mov       r14,[rdx]
       mov       rdx,23517D65F98
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L03
       cmp       ebx,ebp
       jg        short M02_L01
M02_L02:
       mov       rcx,rdi
       call      qword ptr [7FFEBCDA78C0]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 256
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF14410]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF14610]
       setae     sil
       movzx     esi,sil
       mov       rcx,21A48421568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,21A48421380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF14618]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,21A4842B850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,21A4842B858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF1C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,21A48422E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rax,21A48423020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,21A48431A38
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M02_L02
       mov       rdx,21A48421568
       mov       r14,[rdx]
       mov       rdx,21A28421B90
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L03
       cmp       ebx,ebp
       jg        short M02_L01
M02_L02:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD778C0]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 256
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF247D0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF249D0]
       setae     sil
       movzx     esi,sil
       mov       rcx,18EF79B1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,18EF79B1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF249D8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,18ED79B7448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,18ED79B7450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF2C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,18EF79B2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rax,18EF79B3020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,18ED79BD630
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M02_L02
       mov       rdx,18EF79B1568
       mov       r14,[rdx]
       mov       rdx,18EF79B6FB0
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L03
       cmp       ebx,ebp
       jg        short M02_L01
M02_L02:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD878C0]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 256
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF23EA0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF240A0]
       setae     sil
       movzx     esi,sil
       mov       rcx,24994011568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,24994011380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF240A8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2499401B850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,2499401B858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF2C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,24994012E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rax,24994013020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,249B4011200
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M02_L02
       mov       rdx,24994011568
       mov       r14,[rdx]
       mov       rdx,249940223C8
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L03
       cmp       ebx,ebp
       jg        short M02_L01
M02_L02:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD878C0]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 256
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF24710]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF24910]
       setae     sil
       movzx     esi,sil
       mov       rcx,12020971568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,12020971380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF24918]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1202097B850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,1202097B858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF2C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,12020972E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rax,12020973020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,12000971200
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M02_L02
       mov       rdx,12020971568
       mov       r14,[rdx]
       mov       rdx,120009723A8
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L03
       cmp       ebx,ebp
       jg        short M02_L01
M02_L02:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD878C0]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 256
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCF410B0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCF412B0]
       setae     sil
       movzx     esi,sil
       mov       rcx,23451151568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,23451151380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCF412B8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2345115B850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,2345115B858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCF4C938]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,23451152E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rax,23451153020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,23451161A38
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M02_L02
       mov       rdx,23451151568
       mov       r14,[rdx]
       mov       rdx,23431152BA8
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M02_L03
       cmp       ebx,ebp
       jg        short M02_L01
M02_L02:
       mov       rcx,rdi
       call      qword ptr [7FFEBCF478C0]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 256
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rax,17DC3523020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,rdi
       mov       rdx,17DE352EE88
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L04
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L13
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCF13218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L11
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF132E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 484
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rax,284CC3C3020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,rdi
       mov       rdx,284EC3C5ED8
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L04
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L13
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCF23218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L11
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF232E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 484
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rax,20B7A163020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,rdi
       mov       rdx,20BAA161A40
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L04
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L13
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF3218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L11
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF32E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 484
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rax,1FFECAB3020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,rdi
       mov       rdx,1FFCCAB2A58
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L04
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L13
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCF03218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L11
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF032E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 484
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rax,1A1A8793020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,rdi
       mov       rdx,1A1C8791A40
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L04
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L13
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCF03218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L11
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF032E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 484
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rax,1E889301028
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,rdi
       mov       rdx,1E889304E68
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L04
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L13
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCF13218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L11
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF132E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 484
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rax,1FC6FFE1028
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,rdi
       mov       rdx,1FC3FFE2258
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L04
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L13
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF3218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L11
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF32E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 484
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFAB228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rax,21C73233020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rax,rdi
       mov       rdx,21C53232258
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L04
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCFABB28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L13
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCFABB28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCFAC0C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L11
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCFAC188
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 484
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+108]
       mov       rsi,[rcx+10]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+108]
       mov       rsi,[rcx+10]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+108]
       mov       rsi,[rcx+10]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+108]
       mov       rsi,[rcx+10]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+108]
       mov       rsi,[rcx+10]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+108]
       mov       rsi,[rcx+10]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+108]
       mov       rsi,[rcx+10]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+108]
       mov       rsi,[rcx+10]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

