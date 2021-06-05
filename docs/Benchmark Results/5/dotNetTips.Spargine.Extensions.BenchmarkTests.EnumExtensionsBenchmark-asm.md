## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription01()
; 			var result = this._testEnum.GetDescription();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsi+0D0]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,242E9061028
       mov       r8,[r8]
       mov       rdx,242D90617B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Enum, System.String, System.String)
       mov       rcx,rsi
       call      00007FFADE7E0330
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1C
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF449A0]
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
       mov       edi,[rax+8]
       test      edi,edi
       jne       short M01_L00
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       mov       rax,[rax+8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L00:
       cmp       edi,0
       jbe       short M01_L01
       mov       rcx,[rax+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       mov       rax,[rax+38]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 207
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems01()
; 			var result = this._testEnum.GetItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsi+0D0]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
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
       mov       r8,20914D03020
       mov       r8,[r8]
       mov       rdx,20914D03520
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Enum, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,7FFA7EC50020
       mov       edx,22
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,20934D06CA8
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      00007FFADE7E0330
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
; Total bytes of code 360
```

