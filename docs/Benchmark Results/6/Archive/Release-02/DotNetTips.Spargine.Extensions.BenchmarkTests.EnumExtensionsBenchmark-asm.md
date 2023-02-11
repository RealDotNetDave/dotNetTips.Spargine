## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription01()
; 			var result = this._testEnum.GetDescription();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsi+1C8]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rbx,[rax+40]
       call      qword ptr [rbx+8]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1C
       cmp       [rcx],ecx
       call      qword ptr [7FFB47659638]
       mov       rdi,rax
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute[]
       call      CORINFO_HELP_CHKCASTARRAY
       cmp       dword ptr [rax+8],0
       jne       short M01_L00
       mov       rcx,rsi
       mov       rax,[rbx+8]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L00:
       mov       rcx,[rax+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 157
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems01()
; 			System.Collections.Generic.IList<(string Description, int Value)> result = this._testEnum.GetItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsi+1C8]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,7FFB47364928
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,17F534C2F70
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Enum.GetNames(System.Type)
       mov       rbx,rax
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       near ptr M01_L04
M01_L00:
       movsxd    rcx,ebp
       mov       r15,[rbx+rcx*8+10]
       mov       rcx,rsi
       lea       rdx,[rsp+38]
       mov       [rsp+20],rdx
       mov       rdx,r15
       xor       r8d,r8d
       mov       r9d,1
       call      System.Enum.TryParse(System.Type, System.String, Boolean, Boolean, System.Object ByRef)
       mov       r12,[rsp+38]
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       rdx,offset MT_System.Int32
       cmp       [r12],rdx
       je        short M01_L01
       mov       rdx,r12
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_UNBOX
M01_L01:
       mov       r12d,[r12+8]
       mov       rdx,r15
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       short M01_L02
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       movsxd    rax,eax
       shl       rax,4
       lea       r15,[rcx+rax+10]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [r15+8],r12d
       jmp       short M01_L03
M01_L02:
       lea       rcx,[rsp+28]
       mov       [rcx],rdx
       mov       [rcx+8],r12d
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,Int32>)
M01_L03:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M01_L00
M01_L04:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 326
```

