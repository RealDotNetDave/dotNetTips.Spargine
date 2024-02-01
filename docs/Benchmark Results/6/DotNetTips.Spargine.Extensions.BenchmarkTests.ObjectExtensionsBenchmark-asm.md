## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.As[[DotNetTips.Spargine.Tester.Models.RefTypes.IPerson, DotNetTips.Spargine.6.Tester]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.IPerson, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.IPerson ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       test      rdx,rdx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_CHKCASTARRAY
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910F3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910F3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 118
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       test      rdx,rdx
       jne       near ptr M00_L01
       call      qword ptr [7FFF8F9CD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L02
       lea       rcx,[rdi+0C]
       mov       rdx,224B5008990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rdi+12]
       mov       rdx,224B5002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,224B5002028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.IPerson
       call      qword ptr [7FFF8F55B888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.IPerson, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.IPerson ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC73018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FFF8F9CD678]
       int       3
; Total bytes of code 307
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFF8F639A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L04
       mov       rax,[rax+38]
       cmp       r8,4
       jl        short M02_L03
M02_L00:
       cmp       [rax],rcx
       je        short M02_L01
       cmp       [rax+8],rcx
       je        short M02_L01
       cmp       [rax+10],rcx
       je        short M02_L01
       cmp       [rax+18],rcx
       jne       short M02_L02
M02_L01:
       mov       rax,rdx
       ret
M02_L02:
       add       rax,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L00
       test      r8,r8
       je        short M02_L04
M02_L03:
       cmp       [rax],rcx
       je        short M02_L01
       add       rax,8
       dec       r8
       test      r8,r8
       jg        short M02_L03
M02_L04:
       jmp       qword ptr [7FFF8F55B870]
; Total bytes of code 97
```
```assembly
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
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
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
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       jne       short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,rax
       mov       r11,7FFF90CA0840
       call      qword ptr [7FFF90CA0840]
       jmp       short M00_L00
M00_L02:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 158
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M01_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L07
       cmp       rbp,40
       jle       near ptr M01_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M01_L08
M01_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M01_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M01_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M01_L14
M01_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M01_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M01_L15
M01_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M01_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M01_L16
M01_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFF91461840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M01_L09
       jmp       near ptr M01_L13
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFF91461A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFF91461A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M01_L17
M01_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M01_L18
M01_L12:
       lea       rcx,[rsp+20]
       call      00007FFF912287F0
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M01_L09
       jmp       short M01_L10
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFF91461A88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFF91461B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L03
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFF91461BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFF91461A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L11
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFF91461A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFF91395C50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
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
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonProperArray()
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,[rsi+198]
       test      rdi,rdi
       je        near ptr M00_L05
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFF8F54B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L02
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFF8FC59C48]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rax
M00_L00:
       test      rcx,rcx
       jne       near ptr M00_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M00_L06
       lea       rcx,[rsi+0C]
       mov       rdx,21926808990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L07
       lea       rcx,[rsi+12]
       mov       rdx,21926802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        near ptr M00_L04
       mov       rdi,rsi
M00_L01:
       mov       ecx,536
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       rcx,rdi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L02:
       mov       rcx,rax
       mov       r11,7FFF8F3A0870
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFF8F971468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,rax
       mov       r9,21930800BD8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21926802028
       mov       r9,[r9]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FFF8FC59DF8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+30],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+30]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC5B030]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       rcx,21926802028
       mov       rdi,[rcx]
       jmp       near ptr M00_L01
M00_L05:
       mov       ecx,10
       call      qword ptr [7FFF8F7AB780]
       int       3
M00_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L02
       mov       r9,[rax+38]
       cmp       r8,4
       jl        short M01_L01
M01_L00:
       cmp       [r9],rcx
       je        short M01_L03
       cmp       [r9+8],rcx
       je        short M01_L03
       cmp       [r9+10],rcx
       je        short M01_L03
       cmp       [r9+18],rcx
       je        short M01_L03
       add       r9,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L00
       test      r8,r8
       je        short M01_L02
M01_L01:
       cmp       [r9],rcx
       je        short M01_L03
       add       r9,8
       dec       r8
       test      r8,r8
       jg        short M01_L01
M01_L02:
       test      dword ptr [rax],406C0000
       jne       short M01_L04
       xor       edx,edx
M01_L03:
       mov       rax,rdx
       ret
M01_L04:
       jmp       qword ptr [7FFF8F54B840]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 107
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      qword ptr [7FFF8F54B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebp,eax
       test      ebp,ebp
       je        short M02_L04
       mov       rcx,[rsi+10]
       mov       rdx,[rcx+8]
       mov       rdi,rdx
       cmp       rdi,48
       jle       near ptr M02_L14
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+10]
       cmp       rdi,50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rbx
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       mov       rcx,[rsi+10]
       mov       r14,[rcx+8]
       cmp       r14,58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      qword ptr [7FFF8F8F76F0]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFF8FDA8E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFF8FDA9090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF8FDA9080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+28]
       mov       rdx,rax
       call      qword ptr [7FFF8FB7DAC8]
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+8],38
       jle       near ptr M02_L17
       mov       rax,[rbp+38]
       test      rax,rax
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+28]
       mov       rdx,rax
       mov       r8,rdi
       call      qword ptr [7FFF8FB7DB40]
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF8FB7DBD0]; System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L13:
       mov       rax,[rbx+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFF8FDA90A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF8FDA91B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF8FDA91E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF8FDA9080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF8FDA9080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 619
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M03_L01
M03_L00:
       cmp       rcx,rdx
       je        near ptr M03_L09
       jmp       near ptr M03_L11
M03_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M03_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M03_L04
       cmp       r8,40
       ja        near ptr M03_L07
M03_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M03_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M03_L09
M03_L04:
       test      r8b,18
       je        short M03_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M03_L09
M03_L05:
       test      r8b,4
       je        short M03_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M03_L09
M03_L06:
       test      r8,r8
       je        short M03_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M03_L09
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       mov       r10,r8
       shr       r10,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M03_L10
       jmp       short M03_L08
M03_L09:
       ret
M03_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M03_L09
M03_L11:
       jmp       qword ptr [7FFF8F629A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M04_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M04_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M04_L03
       jmp       short M04_L02
M04_L01:
       xor       r9d,r9d
M04_L02:
       test      r8,r8
       je        short M04_L03
       cmp       dword ptr [r8+8],0
       je        short M04_L03
       mov       rcx,r8
       jmp       near ptr M04_L06
M04_L03:
       test      r9d,r9d
       jne       near ptr M04_L06
       call      qword ptr [7FFF8F9AD498]
       mov       rdi,rax
       test      rsi,rsi
       je        short M04_L04
       cmp       dword ptr [rsi+8],0
       je        short M04_L04
       jmp       short M04_L05
M04_L04:
       mov       rsi,rdi
M04_L05:
       mov       ecx,536
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L06:
       test      dl,dl
       jne       short M04_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M05_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M05_L05
       lea       rcx,[rsi+0C]
       mov       rdx,21926808990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M05_L06
       lea       rcx,[rsi+12]
       mov       rdx,21926802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M05_L02
       mov       rcx,rsi
M05_L00:
       test      rcx,rcx
       jne       short M05_L01
       mov       eax,1
       jmp       near ptr M05_L07
M05_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M05_L07
M05_L02:
       mov       rcx,21926802028
       mov       rcx,[rcx]
       jmp       short M05_L00
M05_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFF8F9A5318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M05_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M05_L04
       mov       rdx,rax
       call      qword ptr [7FFF8F54B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M05_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF8FBA9738]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M05_L08
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F9A3150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF8F9A3330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M06_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M06_L01
       jmp       short M06_L01
M06_L00:
       xor       edx,edx
M06_L01:
       test      edx,edx
       jne       near ptr M06_L02
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,0B50
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M06_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M06_L04
M06_L03:
       mov       rcx,rsi
       mov       rdx,7FFF8FC65998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFF8FC59E58]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
```
```assembly
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
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFF91395A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonProperCollection()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,[rsi+198]
       test      rcx,rcx
       jne       near ptr M00_L01
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L02
       lea       rcx,[rdi+0C]
       mov       rdx,29AA0808990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rdi+12]
       mov       rdx,29AA0802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,29AA0802028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       call      qword ptr [7FFF8F981468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFF8FC698D0]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC6B840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FFF8F9BD678]
       int       3
; Total bytes of code 316
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFF8F639A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M02_L03
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M02_L05
       lea       rcx,[rsi+0C]
       mov       rdx,29AA0808990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L06
       lea       rcx,[rsi+12]
       mov       rdx,29AA0802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M02_L02
       mov       rcx,rsi
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L07
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
M02_L02:
       mov       rcx,29AA0802028
       mov       rcx,[rcx]
       jmp       short M02_L00
M02_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFF8F9B5318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M02_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M02_L04
       mov       rdx,rax
       call      qword ptr [7FFF8F55B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M02_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF8FBB9738]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short M03_L00
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short M03_L01
       jmp       short M03_L01
M03_L00:
       xor       ecx,ecx
M03_L01:
       test      ecx,ecx
       jne       near ptr M03_L02
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,767
       mov       rdx,7FFF8F968578
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6BE8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFF8FC74F88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8FC69EE8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 293
```
```assembly
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
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonProper()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFF91395A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonProper()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       test      rcx,rcx
       jne       near ptr M00_L01
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L02
       lea       rcx,[rdi+0C]
       mov       rdx,2FA29006998
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rdi+12]
       mov       rdx,2FA29000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,2FA29000030
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       call      qword ptr [7FFF8F971468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FFF8FC698D0]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC69BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FFF8F9AD678]
       int       3
; Total bytes of code 316
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFF8F629A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M02_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M02_L05
       lea       rcx,[rsi+0C]
       mov       rdx,2FA29006998
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L06
       lea       rcx,[rsi+12]
       mov       rdx,2FA29000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M02_L02
       mov       rcx,rsi
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L07
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
M02_L02:
       mov       rcx,2FA29000030
       mov       rcx,[rcx]
       jmp       short M02_L00
M02_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFF8F9A5318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M02_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M02_L04
       mov       rdx,rax
       call      qword ptr [7FFF8F54B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M02_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF8FBA99F0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short M03_L00
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short M03_L01
       jmp       short M03_L01
M03_L00:
       xor       ecx,ecx
M03_L01:
       test      ecx,ecx
       jne       near ptr M03_L02
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,767
       mov       rdx,7FFF8F958578
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFF8FC54720
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8FC699C0]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 293
```
```assembly
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
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+1A8]
       cmp       [rdi],edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       vmovupd   xmm0,[rdi+40]
       vmovupd   [rbx+40],xmm0
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+18]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+20]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+28]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+30]
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+38]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+1A8]
       cmp       [rdi],dil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       vmovupd   xmm0,[rdi+40]
       vmovupd   [rbx+40],xmm0
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+18]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+20]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+28]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+30]
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+38]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC698A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L04
       mov       rax,21B20011BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF90F186B8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
       mov       rcx,7FFF910E4380
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21B200184F0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-30],rdx
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L01
       mov       rcx,21B20011568
       mov       r14,[rcx]
       mov       rcx,21BB0011B90
       mov       r15,[rcx]
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rcx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L02
       cmp       ebx,edi
       jg        short M01_L00
M01_L01:
       mov       rdx,[rbp-30]
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L03
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       mov       rcx,21B200184F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
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
       lea       rbp,[rbp+60]
       mov       rcx,7FFF910E4380
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21B200184F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 438
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       call      qword ptr [7FFF8F961378]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC59498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-48],rsp
       test      rcx,rcx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F99D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L09
       lea       rcx,[rsi+0C]
       mov       rdx,1D324008990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L10
       lea       rcx,[rsi+12]
       mov       rdx,1D324002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M01_L02
       mov       rcx,rsi
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L11
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L11
M01_L02:
       mov       rcx,1D324002028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rax,1D324000BB0
       mov       rsi,[rax]
       call      qword ptr [7FFF8F961468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F7AD318]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      qword ptr [7FFF8FC592D0]; System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
       mov       rcx,1D3240077A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FB82D90]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-40],rdx
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L06
       mov       rcx,1D324000528
       mov       r15,[rcx]
       mov       rcx,1D334000BD8
       mov       r12,[rcx]
M01_L04:
       mov       ecx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       r8,r15
       movzx     ecx,byte ptr [rcx]
       mov       rdx,r12
       call      qword ptr [7FFF8F763FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       r13,[rbp-40]
       cmp       [r13],r13b
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r13
       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L05:
       add       ebx,1
       jo        short M01_L07
       cmp       r14d,ebx
       jg        short M01_L04
M01_L06:
       mov       rdx,[rbp-40]
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F7AD080]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FB82D98]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F761C78]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       call      qword ptr [7FFF8F761C78]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L11:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L12
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L12:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       mov       rcx,1D3240077A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FB82D98]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 792
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L04
       mov       rax,21057391BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF90F086B8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
       mov       rcx,7FFF910D4380
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,210573984F0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-30],rdx
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L01
       mov       rcx,21057391568
       mov       r14,[rcx]
       mov       rcx,21047391B88
       mov       r15,[rcx]
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rcx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L02
       cmp       ebx,edi
       jg        short M01_L00
M01_L01:
       mov       rdx,[rbp-30]
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFF90F2A610]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L03
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       mov       rcx,210573984F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
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
       lea       rbp,[rbp+60]
       mov       rcx,7FFF910D4380
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,210573984F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 438
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       call      qword ptr [7FFF8F971378]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC69240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-48],rsp
       test      rcx,rcx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L09
       lea       rcx,[rsi+0C]
       mov       rdx,19E08408990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L10
       lea       rcx,[rsi+12]
       mov       rdx,19E08402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M01_L02
       mov       rcx,rsi
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L11
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L11
M01_L02:
       mov       rcx,19E08402028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rax,19E08400BB0
       mov       rsi,[rax]
       call      qword ptr [7FFF8F971468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F7BD318]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      qword ptr [7FFF8FC672D0]; System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
       mov       rcx,19E084077A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FB90E78]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-40],rdx
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L06
       mov       rcx,19E08400528
       mov       r15,[rcx]
       mov       rcx,19E18400BD8
       mov       r12,[rcx]
M01_L04:
       mov       ecx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       r8,r15
       movzx     ecx,byte ptr [rcx]
       mov       rdx,r12
       call      qword ptr [7FFF8F773FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       r13,[rbp-40]
       cmp       [r13],r13b
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r13
       call      qword ptr [7FFF8F7DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L05:
       add       ebx,1
       jo        short M01_L07
       cmp       r14d,ebx
       jg        short M01_L04
M01_L06:
       mov       rdx,[rbp-40]
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F7BD080]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FB90E80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       call      qword ptr [7FFF8F771C78]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L11:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L12
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L12:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       mov       rcx,19E084077A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FB90E80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 792
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.DisposeFields()
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Data.DataTable..ctor()
       mov       rdx,2AECFCC1B90
       mov       rdx,[rdx]
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
; Total bytes of code 66
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rdx,2AE7FCC3020
       mov       rdi,[rdx]
       lea       rcx,[rsi+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+80]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+1C4],1
       mov       dword ptr [rsi+1B0],19
       mov       rdx,2AE7FCC1060
       mov       rdx,[rdx]
       vmovupd   xmm0,[rdx+8]
       vmovupd   [rsi+1D8],xmm0
       mov       rdx,2AE7FCC1060
       mov       rdx,[rdx]
       vmovupd   xmm0,[rdx+8]
       vmovupd   [rsi+1E8],xmm0
       mov       rdx,2AE7FCCDE60
       mov       rdx,[rdx]
       lea       rcx,[rsi+0D8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+1CC],1
       mov       rdx,2AE7FCCDE68
       mov       rdx,[rdx]
       lea       rcx,[rsi+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2AE7FCCDE70
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+180]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2AE7FCCDE78
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
       mov       rdx,7FFF90DA5340
       mov       ecx,1
       lock xadd [rdx],rcx
       inc       rcx
       mov       [rax+28],rcx
       lea       rcx,[rsi+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+1B8],0FFFFFFFF
       mov       rcx,7FFF9138888C
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rsi+1C0],eax
       mov       rcx,rsi
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,2AE7FCCD060
       mov       rdi,[rcx]
       mov       ebx,[rsi+1C0]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M01_L01
M01_L00:
       mov       qword ptr [rsi+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rsi+50]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rsi+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2AE7FCC2F48
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
       call      System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rdx,2AE7FCCDE90
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
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       rdx,rax
       mov       rcx,2AECFCC1B98
       mov       rcx,[rcx]
       call      System.String.Format(System.String, System.Object)
       mov       r8,rax
       mov       rcx,rdi
       mov       edx,1
       call      System.Diagnostics.Tracing.EventSource.WriteEvent(Int32, System.String)
       jmp       near ptr M01_L00
; Total bytes of code 915
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeFields(System.Type)
       mov       rdi,rax
       mov       rcx,7FFF910D4380
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2AE7FCC8608
       mov       r8,[rcx]
       test      r8,r8
       jne       short M02_L01
       mov       rcx,offset MT_System.Func`2[[System.Reflection.FieldInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2AE7FCC8600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M02_L09
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<DisposeFields>b__6_0(System.Reflection.FieldInfo)
       mov       [rbx+18],rdx
       mov       rcx,2AE7FCC8608
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M02_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>, System.Func`2<System.Reflection.FieldInfo,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       xor       ebx,ebx
       jmp       short M02_L07
M02_L04:
       cmp       ebx,[rdi+10]
       jae       near ptr M02_L10
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       near ptr M02_L12
       movsxd    rdx,ebx
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rbp,rax
       test      rbp,rbp
       je        short M02_L06
       mov       rdx,rbp
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L05
       mov       rcx,rax
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       jmp       short M02_L06
M02_L05:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L06
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ProcessCollectionToDispose(System.Collections.IEnumerable)
M02_L06:
       add       ebx,1
       jo        short M02_L08
M02_L07:
       mov       ecx,1
       test      ecx,ecx
       je        short M02_L11
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       movsxd    rcx,eax
       movsxd    rdx,ebx
       cmp       rcx,rdx
       jg        near ptr M02_L04
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L08:
       call      CORINFO_HELP_OVERFLOW
M02_L09:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M02_L10:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L11:
       mov       ecx,4D
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 502
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.DisposeFields()
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8FC87450]; System.Data.DataTable..ctor()
       mov       rdx,21B5E400BD8
       mov       rdx,[rdx]
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       qword ptr [7FFF8F9A1390]; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
; Total bytes of code 68
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       rdx,21B4E402028
       mov       rdi,[rdx]
       lea       rcx,[rsi+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+80]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+1C4],1
       mov       dword ptr [rsi+1B0],19
       mov       rdx,21B4E400068
       mov       rdx,[rdx]
       add       rdx,8
       vmovupd   xmm0,[rdx]
       vmovupd   [rsi+1D8],xmm0
       vmovupd   xmm0,[rdx]
       vmovupd   [rsi+1E8],xmm0
       mov       rdx,21B4E40C4F8
       mov       rdx,[rdx]
       lea       rcx,[rsi+0D8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+1CC],1
       mov       rdx,21B4E40C500
       mov       rdx,[rdx]
       lea       rcx,[rsi+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,21B4E40C508
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+180]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,21B4E40C510
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
       mov       rdx,7FFF8F4E5680
       mov       ecx,1
       lock xadd [rdx],rcx
       inc       rcx
       mov       [rax+28],rcx
       lea       rcx,[rsi+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+1B8],0FFFFFFFF
       mov       rcx,7FFF8FCC0E74
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rsi+1C0],eax
       mov       rcx,rsi
       call      qword ptr [7FFF8F8F76C0]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,21B4E40B6D0
       mov       rcx,[rcx]
       mov       rdi,rcx
       mov       ebx,[rsi+1C0]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L01
M01_L00:
       mov       qword ptr [rsi+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF8FCE18B8]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rsi+50]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFF8F7798A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rsi+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFF8FC8D9A8]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21B4E401F78
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
       call      qword ptr [7FFF8FC8F870]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rdx,21B4E40C528
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
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       rdx,21B5E400BE0
       mov       rdx,[rdx]
       mov       [rsp+28],r8
       mov       dword ptr [rsp+30],1
       lea       r8,[rsp+28]
       xor       ecx,ecx
       call      qword ptr [7FFF8F611DC8]
       mov       r8,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFF8F65F348]
       jmp       near ptr M01_L00
; Total bytes of code 958
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFF8FCEB480]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeFields(System.Type)
       mov       rdi,rax
       mov       rcx,21B4E4078C0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M02_L01
       mov       rcx,offset MT_System.Func`2[[System.Reflection.FieldInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21B4E4078B8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FCEA5B8
       mov       [rbx+18],rdx
       mov       rcx,21B4E4078C0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M02_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>, System.Func`2<System.Reflection.FieldInfo,Boolean>)
       call      qword ptr [7FFF8F8FDCF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>)
       call      qword ptr [7FFF8FCEB630]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      qword ptr [7FFF8F9A9C60]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jg        short M02_L03
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       xor       ebx,ebx
       jmp       short M02_L07
M02_L04:
       cmp       ebx,[rdi+10]
       jae       near ptr M02_L09
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       near ptr M02_L10
       mov       edx,ebx
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rbp,rax
       test      rbp,rbp
       je        short M02_L06
       mov       rdx,rbp
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF8F57B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L05
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF8F9A14C8]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       jmp       short M02_L06
M02_L05:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFF8F57B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L06
       mov       rcx,rax
       call      qword ptr [7FFF8F9A1330]; DotNetTips.Spargine.Extensions.ObjectExtensions.ProcessCollectionToDispose(System.Collections.IEnumerable)
M02_L06:
       add       ebx,1
       jo        short M02_L08
M02_L07:
       mov       rcx,rdi
       call      qword ptr [7FFF8F9A9C60]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       movsxd    rcx,eax
       movsxd    rdx,ebx
       cmp       rcx,rdx
       jg        near ptr M02_L04
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L08:
       call      CORINFO_HELP_OVERFLOW
M02_L09:
       call      qword ptr [7FFF8F7D7528]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 385
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,292DC2E1B88
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       short M01_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L03
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       ecx,771
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L01
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,1C0B5800BD8
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F9713C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC67498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       short M01_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        short M01_L01
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       edx,edx
M01_L02:
       test      edx,edx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9AD498]
       mov       rbx,rax
       mov       ecx,771
       mov       rdx,7FFF8F958578
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFF8FC67378]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF8FC66330
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>, Boolean ByRef)
       call      qword ptr [7FFF8FC35A08]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 403
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       mov       rdx,21895FE1B88
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       short M01_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L03
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       ecx,771
       mov       rdx,7FFF910F3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L01
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       mov       rdx,1AF47000BD8
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F9813C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC79498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       short M01_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        short M01_L01
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       edx,edx
M01_L02:
       test      edx,edx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9BD498]
       mov       rbx,rax
       mov       ecx,771
       mov       rdx,7FFF8F968578
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFF8FC79378]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF8FC78330
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>, Boolean ByRef)
       call      qword ptr [7FFF8FC37A08]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 403
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull01()
       sub       rsp,28
       mov       rdx,[rcx+1A0]
       test      rdx,rdx
       setne     dl
       movzx     edx,dl
       mov       [rsp+20],dl
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 46
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull01()
       sub       rsp,28
       xor       edx,edx
       cmp       qword ptr [rcx+1A0],0
       setne     dl
       mov       [rsp+20],dl
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC77318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 44
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull02()
       sub       rsp,28
       mov       rdx,[rcx+1A8]
       test      rdx,rdx
       setne     dl
       movzx     edx,dl
       mov       [rsp+20],dl
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 46
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull02()
       sub       rsp,28
       xor       edx,edx
       cmp       qword ptr [rcx+1A8],0
       setne     dl
       mov       [rsp+20],dl
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC69318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 44
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull01()
       sub       rsp,28
       mov       rdx,[rcx+1A0]
       test      rdx,rdx
       sete      dl
       movzx     edx,dl
       mov       [rsp+20],dl
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 46
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull01()
       sub       rsp,28
       xor       edx,edx
       cmp       qword ptr [rcx+1A0],0
       sete      dl
       mov       [rsp+20],dl
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC97888]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 44
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull02()
       sub       rsp,28
       mov       rdx,[rcx+1A8]
       test      rdx,rdx
       sete      dl
       movzx     edx,dl
       mov       [rsp+20],dl
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 46
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull02()
       sub       rsp,28
       xor       edx,edx
       cmp       qword ptr [rcx+1A8],0
       sete      dl
       mov       [rsp+20],dl
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC49B88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 44
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+1A8]
       cmp       [rdi],edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       vmovupd   xmm0,[rdi+40]
       vmovupd   [rbx+40],xmm0
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+18]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+20]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+28]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+30]
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+38]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2A3728F1B90
       mov       rdx,[rdx]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 210
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+1A8]
       cmp       [rdi],dil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       vmovupd   xmm0,[rdi+40]
       vmovupd   [rbx+40],xmm0
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+18]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+20]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+28]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+30]
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+38]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,26BB4009388
       mov       rdx,[rdx]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC498A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 212
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFF910D39F8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1AF14553738
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       mov       rdx,1AF14553740
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.PrintMembers(System.Text.StringBuilder)
       test      eax,eax
       je        short M01_L00
       mov       ecx,[rdi+18]
       mov       eax,ecx
       mov       rdx,[rdi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L02
       movsxd    rax,eax
       mov       word ptr [rdx+rax*2+10],20
       inc       ecx
       mov       [rdi+18],ecx
M01_L00:
       mov       ecx,[rdi+18]
       mov       eax,ecx
       mov       rdx,[rdi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L03
       movsxd    rax,eax
       mov       word ptr [rdx+rax*2+10],7D
       inc       ecx
       mov       [rdi+18],ecx
M01_L01:
       mov       rcx,rdi
       mov       rax,[System.Text.StringBuilder.ToString()]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       rcx,rdi
       mov       edx,20
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,7D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L01
; Total bytes of code 250
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F9783A8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC87AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,25B61C00BD8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,0C
       call      qword ptr [7FFF8F7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rdx,25B61C00BE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFF8F7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8F991258]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.PrintMembers(System.Text.StringBuilder)
       test      eax,eax
       je        short M01_L01
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L00
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       edx,20
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]
M01_L01:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L02
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],7D
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       edx,7D
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]
M01_L03:
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8F7DD080]; System.Text.StringBuilder.ToString()
; Total bytes of code 269
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,2310A503020
       mov       rdx,[rdx]
       mov       r8d,1
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0E0],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L31
       mov       rcx,rdi
       test      rcx,rcx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L32
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,7FFF90F55938
       mov       edx,38
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2310A507C90
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,r15
       call      DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L12
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FFF90CB06B0
       call      qword ptr [7FFF90CB06B0]
       mov       [rbp-0A0],rax
       mov       rcx,rax
       mov       r11,7FFF90CB06B8
       call      qword ptr [7FFF90CB06B8]
       test      eax,eax
       je        near ptr M01_L10
M01_L01:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFF90CB06C0
       call      qword ptr [7FFF90CB06C0]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L08
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r13,rax
       mov       [r12+8],r15d
       xor       r15d,r15d
       mov       rcx,7FFF90DB4938
       mov       edx,184
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2310A501388
       mov       rcx,[rcx]
       mov       rdx,2318A501B90
       mov       rdx,[rdx]
       mov       [rbp-98],rsi
       mov       [rbp-90],r12
       mov       [rbp-88],r15
       mov       [rbp-80],rcx
       mov       rcx,r13
       lea       r8,[rbp-98]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rdi,rax
       test      r14,r14
       je        near ptr M01_L07
       test      rdi,rdi
       je        near ptr M01_L06
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       near ptr M01_L09
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rcx,7FFF910E4380
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2310A508610
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2310A508600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L05
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rdx
       mov       rcx,2310A508610
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,2310A508618
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2310A508600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L05
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,2310A508618
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r14
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp-0A0]
       mov       r11,7FFF90CB06B8
       call      qword ptr [7FFF90CB06B8]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L01
       jmp       short M01_L10
M01_L05:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L06:
       mov       ecx,0E
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L07:
       mov       ecx,4
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L10:
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L11
       mov       rcx,rax
       mov       r11,7FFF90CB06C8
       call      qword ptr [7FFF90CB06C8]
M01_L11:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       jne       short M01_L13
       mov       rcx,2310A502F08
       mov       r15,[rcx]
       jmp       short M01_L15
M01_L13:
       cmp       dword ptr [rbp-68],1
       jne       short M01_L14
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L15
M01_L14:
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M01_L15:
       mov       rcx,2310A503020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L20
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,2310A502EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF90F3FA48]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       r8,[rbp-60]
       mov       [rbp-58],rax
       test      rax,rax
       jne       short M01_L16
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M01_L17
M01_L16:
       lea       rcx,[rax+10]
       mov       edx,[rax+8]
M01_L17:
       add       r8,18
       mov       [r8],rcx
       mov       [r8+8],edx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       short M01_L18
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L33
       mov       rcx,[rbp-48]
       mov       edx,[rbp-40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short M01_L18
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       short M01_L19
M01_L18:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
M01_L19:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
M01_L20:
       xor       esi,esi
       cmp       dword ptr [r15+8],0
       jle       near ptr M01_L29
M01_L21:
       cmp       esi,[r15+8]
       jae       near ptr M01_L37
       movsxd    rcx,esi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp-0A8],rax
       test      bl,bl
       je        near ptr M01_L23
       test      rax,rax
       je        near ptr M01_L28
M01_L22:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-0B0],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r13,rax
       mov       [rbp-0C8],r12
       xor       r8d,r8d
       mov       [rbp-0D0],r8
       mov       rcx,7FFF90DB4938
       mov       edx,184
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2310A501388
       mov       rcx,[rcx]
       mov       rdx,[rbp-0B0]
       mov       r8,2318A501B98
       mov       r8,[r8]
       mov       rax,[rbp-0C8]
       mov       [rbp-98],rax
       mov       [rbp-90],r13
       mov       r13,[rbp-0D0]
       mov       [rbp-88],r13
       mov       [rbp-80],rcx
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-98]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp-0A8]
       mov       r8d,1
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r13,rax
       test      r14,r14
       je        near ptr M01_L34
       test      r13,r13
       je        near ptr M01_L35
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M01_L24
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C0],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-0C0]
       mov       [r8+8],eax
       mov       [rbp-0C0],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-0C0]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L25
M01_L23:
       jmp       near ptr M01_L22
M01_L24:
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
M01_L25:
       mov       rcx,7FFF910E4380
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2310A508620
       mov       r13,[rcx]
       test      r13,r13
       jne       short M01_L26
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,2310A508600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L36
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,2310A508620
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L26:
       mov       rcx,2310A508628
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L27
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-0B8],r9
       mov       rdx,2310A508600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L36
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-0B8]
       mov       [r9+18],rdx
       mov       rcx,2310A508628
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp-0B8]
M01_L27:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L28:
       add       esi,1
       jo        short M01_L30
       cmp       [r15+8],esi
       jg        near ptr M01_L21
M01_L29:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       call      CORINFO_HELP_OVERFLOW
M01_L31:
       mov       ecx,4D
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,78B
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L32:
       mov       ecx,4D
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L33:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L34:
       mov       ecx,4
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L35:
       mov       ecx,0E
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L36:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L38
       mov       rcx,rax
       mov       r11,7FFF90CB06C8
       call      qword ptr [7FFF90CB06C8]
M01_L38:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 2388
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,13BB2C02028
       mov       rdx,[rdx]
       mov       r8d,1
       call      qword ptr [7FFF8F981420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC7BAB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-0E0],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[r14+18]
       call      qword ptr [7FFF8F5FBDC8]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       test      rax,rax
       je        short M01_L02
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       test      rsi,rsi
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0A
       jl        near ptr M01_L38
       lea       rcx,[rdi+0C]
       mov       rdx,13BB2C12780
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L39
       lea       rcx,[rdi+20]
       mov       rdx,13BB2C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,13BB2C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L40
       mov       eax,1
M01_L03:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF8F9BD498]
       mov       r14,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6BE8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rax,rdi
       test      rax,rax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L41
       lea       rcx,[rdi+0C]
       mov       rdx,13BB2C08990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L42
       lea       rcx,[rdi+12]
       mov       rdx,13BB2C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,13BB2C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L43
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,13BB2C06D28
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFF8F5FB2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L09
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFF8F5FB318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFF8FC77378]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L20
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFF8F55B888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFF8F3B0880
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
       mov       rcx,rax
       mov       r11,7FFF8F3B0888
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L10:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFF8F3B0890
       call      qword ptr [r11]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L15
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF8F7598A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       mov       [rbp-70],rsi
       mov       [rbp-68],r12
       lea       rdx,[rbp-70]
       mov       r8,13BB2C12788
       mov       r8,[r8]
       mov       [rbp-0A8],rdx
       mov       dword ptr [rbp-0A0],2
       mov       rdx,r8
       lea       r8,[rbp-0A8]
       call      qword ptr [7FFF8F5F1DC8]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFF8F981420]
       mov       rdi,rax
       test      r14,r14
       je        near ptr M01_L16
       test      rdi,rdi
       je        near ptr M01_L17
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF8F55B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L11
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L12
M01_L11:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
M01_L12:
       mov       rcx,13BB2C078C8
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L13
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,13BB2C078B8
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rdx
       mov       rcx,13BB2C078C8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,13BB2C078D0
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,13BB2C078B8
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,13BB2C078D0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
M01_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF8FC79BA0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp-0B0]
       mov       r11,7FFF8F3B0888
       call      qword ptr [r11]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L10
       jmp       short M01_L18
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       ecx,4
       call      qword ptr [7FFF8F7BB780]
       int       3
M01_L17:
       mov       ecx,0E
       call      qword ptr [7FFF8F7BB780]
       int       3
M01_L18:
       mov       rdx,[rbp-0B0]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF8F55B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L19
       mov       rcx,rax
       mov       r11,7FFF8F3B0898
       call      qword ptr [r11]
M01_L19:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFF8F4D7330]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L35
       cmp       dword ptr [rbp-78],1
       jne       near ptr M01_L33
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M01_L21:
       mov       rcx,13BB2C02028
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,13BB2C01ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF8F7F1770]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L44
       lea       r13,[rax+10]
       mov       eax,[rax+8]
M01_L22:
       mov       [rbp-48],r13
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L36
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L45
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L36
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
M01_L23:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFF8FC77540]
       lea       rcx,[rbp-60]
       call      qword ptr [7FFF8F66D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
M01_L24:
       xor       r13d,r13d
       cmp       dword ptr [r15+8],0
       jle       near ptr M01_L31
M01_L25:
       mov       ecx,r13d
       mov       rsi,[r15+rcx*8+10]
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp-0B8],rax
       test      bl,bl
       je        near ptr M01_L32
       test      rax,rax
       je        near ptr M01_L30
M01_L26:
       call      qword ptr [7FFF8F7598A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-0C0],rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-98],r12
       mov       [rbp-90],rax
       lea       rcx,[rbp-98]
       mov       rsi,[rbp-0B8]
       mov       rdx,[rbp-0C0]
       mov       r8,13BB2C12790
       mov       r8,[r8]
       mov       [rbp-0A8],rcx
       mov       dword ptr [rbp-0A0],2
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-0A8]
       call      qword ptr [7FFF8F5F1DC8]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFF8F981420]
       mov       rsi,rax
       test      r14,r14
       je        near ptr M01_L46
       test      rsi,rsi
       je        near ptr M01_L47
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF8F55B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L34
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-0D0]
       mov       [r8+8],eax
       mov       [rbp-0D0],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-0D0]
       lea       rcx,[r14+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L27:
       mov       rcx,13BB2C078D8
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L28
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,13BB2C078B8
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC76480
       mov       [rsi+18],rdx
       mov       rcx,13BB2C078D8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L28:
       mov       rcx,13BB2C078E0
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L29
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-0C8],r9
       mov       rdx,13BB2C078B8
       mov       rdx,[rdx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC76498
       mov       r9,[rbp-0C8]
       mov       [r9+18],rdx
       mov       rcx,13BB2C078E0
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-0C8]
M01_L29:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF8FC79BA0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L30:
       add       r13d,1
       jo        near ptr M01_L37
       cmp       [r15+8],r13d
       jg        near ptr M01_L25
M01_L31:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
       jmp       near ptr M01_L26
M01_L33:
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFF8F807030]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
       jmp       near ptr M01_L21
M01_L34:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L27
M01_L35:
       mov       rcx,13BB2C01F20
       mov       r15,[rcx]
       jmp       near ptr M01_L21
M01_L36:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFF8F66DA50]
       jmp       near ptr M01_L23
M01_L37:
       call      CORINFO_HELP_OVERFLOW
M01_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L40:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L03
M01_L41:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L42:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L43:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
M01_L44:
       xor       r13d,r13d
       xor       eax,eax
       jmp       near ptr M01_L22
M01_L45:
       call      qword ptr [7FFF8F7B7498]
       int       3
M01_L46:
       mov       ecx,4
       call      qword ptr [7FFF8F7BB780]
       int       3
M01_L47:
       mov       ecx,0E
       call      qword ptr [7FFF8F7BB780]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp-0B0]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF8F55B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L48
       mov       rcx,rax
       mov       r11,7FFF8F3B0898
       call      qword ptr [r11]
M01_L48:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 2981
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,1C74EEF3020
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0E0],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L31
       mov       rcx,rdi
       test      rcx,rcx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L32
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,7FFF90F45938
       mov       edx,38
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C74EEF7C90
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,r15
       call      DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L12
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FFF90CA06B0
       call      qword ptr [7FFF90CA06B0]
       mov       [rbp-0A0],rax
       mov       rcx,rax
       mov       r11,7FFF90CA06B8
       call      qword ptr [7FFF90CA06B8]
       test      eax,eax
       je        near ptr M01_L10
M01_L01:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFF90CA06C0
       call      qword ptr [7FFF90CA06C0]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L08
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r13,rax
       mov       [r12+8],r15d
       xor       r15d,r15d
       mov       rcx,7FFF90DA4938
       mov       edx,184
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C74EEF1388
       mov       rcx,[rcx]
       mov       rdx,1C74EF03738
       mov       rdx,[rdx]
       mov       [rbp-98],rsi
       mov       [rbp-90],r12
       mov       [rbp-88],r15
       mov       [rbp-80],rcx
       mov       rcx,r13
       lea       r8,[rbp-98]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rdi,rax
       test      r14,r14
       je        near ptr M01_L07
       test      rdi,rdi
       je        near ptr M01_L06
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       near ptr M01_L09
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rcx,7FFF910D4380
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C74EEF8610
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1C74EEF8600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L05
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rdx
       mov       rcx,1C74EEF8610
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,1C74EEF8618
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1C74EEF8600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L05
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,1C74EEF8618
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r14
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp-0A0]
       mov       r11,7FFF90CA06B8
       call      qword ptr [7FFF90CA06B8]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L01
       jmp       short M01_L10
M01_L05:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L06:
       mov       ecx,0E
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L07:
       mov       ecx,4
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L10:
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L11
       mov       rcx,rax
       mov       r11,7FFF90CA06C8
       call      qword ptr [7FFF90CA06C8]
M01_L11:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       jne       short M01_L13
       mov       rcx,1C74EEF2F08
       mov       r15,[rcx]
       jmp       short M01_L15
M01_L13:
       cmp       dword ptr [rbp-68],1
       jne       short M01_L14
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L15
M01_L14:
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M01_L15:
       mov       rcx,1C74EEF3020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L20
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1C74EEF2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF90F2FA48]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       r8,[rbp-60]
       mov       [rbp-58],rax
       test      rax,rax
       jne       short M01_L16
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M01_L17
M01_L16:
       lea       rcx,[rax+10]
       mov       edx,[rax+8]
M01_L17:
       add       r8,18
       mov       [r8],rcx
       mov       [r8+8],edx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       short M01_L18
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L33
       mov       rcx,[rbp-48]
       mov       edx,[rbp-40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short M01_L18
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       short M01_L19
M01_L18:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
M01_L19:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
M01_L20:
       xor       esi,esi
       cmp       dword ptr [r15+8],0
       jle       near ptr M01_L29
M01_L21:
       cmp       esi,[r15+8]
       jae       near ptr M01_L37
       movsxd    rcx,esi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp-0A8],rax
       test      bl,bl
       je        near ptr M01_L23
       test      rax,rax
       je        near ptr M01_L28
M01_L22:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-0B0],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r13,rax
       mov       [rbp-0C8],r12
       xor       r8d,r8d
       mov       [rbp-0D0],r8
       mov       rcx,7FFF90DA4938
       mov       edx,184
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C74EEF1388
       mov       rcx,[rcx]
       mov       rdx,[rbp-0B0]
       mov       r8,1C74EF03740
       mov       r8,[r8]
       mov       rax,[rbp-0C8]
       mov       [rbp-98],rax
       mov       [rbp-90],r13
       mov       r13,[rbp-0D0]
       mov       [rbp-88],r13
       mov       [rbp-80],rcx
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-98]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp-0A8]
       mov       r8d,1
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r13,rax
       test      r14,r14
       je        near ptr M01_L34
       test      r13,r13
       je        near ptr M01_L35
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M01_L24
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C0],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-0C0]
       mov       [r8+8],eax
       mov       [rbp-0C0],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-0C0]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L25
M01_L23:
       jmp       near ptr M01_L22
M01_L24:
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
M01_L25:
       mov       rcx,7FFF910D4380
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C74EEF8620
       mov       r13,[rcx]
       test      r13,r13
       jne       short M01_L26
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,1C74EEF8600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L36
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,1C74EEF8620
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L26:
       mov       rcx,1C74EEF8628
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L27
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-0B8],r9
       mov       rdx,1C74EEF8600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L36
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-0B8]
       mov       [r9+18],rdx
       mov       rcx,1C74EEF8628
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp-0B8]
M01_L27:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L28:
       add       esi,1
       jo        short M01_L30
       cmp       [r15+8],esi
       jg        near ptr M01_L21
M01_L29:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       call      CORINFO_HELP_OVERFLOW
M01_L31:
       mov       ecx,4D
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,78B
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L32:
       mov       ecx,4D
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L33:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L34:
       mov       ecx,4
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L35:
       mov       ecx,0E
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L36:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L38
       mov       rcx,rax
       mov       r11,7FFF90CA06C8
       call      qword ptr [7FFF90CA06C8]
M01_L38:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 2388
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,266A0402028
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      qword ptr [7FFF8F961420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC4F048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-0E0],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[r14+18]
       call      qword ptr [7FFF8F5DBDC8]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       test      rax,rax
       je        short M01_L02
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       test      rsi,rsi
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F99D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0A
       jl        near ptr M01_L38
       lea       rcx,[rdi+0C]
       mov       rdx,266AA400BD8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L39
       lea       rcx,[rdi+20]
       mov       rdx,266A0402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,266A0402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5D1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L40
       mov       eax,1
M01_L03:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF8F99D498]
       mov       r14,rax
       mov       ecx,536
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rax,rdi
       test      rax,rax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F99D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L41
       lea       rcx,[rdi+0C]
       mov       rdx,266A0408990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L42
       lea       rcx,[rdi+12]
       mov       rdx,266A0402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,266A0402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5D1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L43
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,266A0406D28
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFF8F5DB2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L09
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFF8F5DB318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFF8FC49C30]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L20
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFF8F53B888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFF8F390880
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
       mov       rcx,rax
       mov       r11,7FFF8F390888
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L10:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFF8F390890
       call      qword ptr [r11]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L15
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF8F7398A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       mov       [rbp-70],rsi
       mov       [rbp-68],r12
       lea       rdx,[rbp-70]
       mov       r8,266AA400BE0
       mov       r8,[r8]
       mov       [rbp-0A8],rdx
       mov       dword ptr [rbp-0A0],2
       mov       rdx,r8
       lea       r8,[rbp-0A8]
       call      qword ptr [7FFF8F5D1DC8]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFF8F961420]
       mov       rdi,rax
       test      r14,r14
       je        near ptr M01_L16
       test      rdi,rdi
       je        near ptr M01_L17
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF8F53B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L11
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L12
M01_L11:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
M01_L12:
       mov       rcx,266A04078C8
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L13
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,266A04078B8
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rdx
       mov       rcx,266A04078C8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,266A04078D0
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,266A04078B8
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,266A04078D0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
M01_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF8FC4D2E8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp-0B0]
       mov       r11,7FFF8F390888
       call      qword ptr [r11]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L10
       jmp       short M01_L18
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       ecx,4
       call      qword ptr [7FFF8F79B780]
       int       3
M01_L17:
       mov       ecx,0E
       call      qword ptr [7FFF8F79B780]
       int       3
M01_L18:
       mov       rdx,[rbp-0B0]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF8F53B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L19
       mov       rcx,rax
       mov       r11,7FFF8F390898
       call      qword ptr [r11]
M01_L19:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFF8F4B7330]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L35
       cmp       dword ptr [rbp-78],1
       jne       near ptr M01_L33
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M01_L21:
       mov       rcx,266A0402028
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,266A0401ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF8F7D1770]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L44
       lea       r13,[rax+10]
       mov       eax,[rax+8]
M01_L22:
       mov       [rbp-48],r13
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L36
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L45
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L36
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
M01_L23:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFF8FC49DF8]
       lea       rcx,[rbp-60]
       call      qword ptr [7FFF8F64D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
M01_L24:
       xor       r13d,r13d
       cmp       dword ptr [r15+8],0
       jle       near ptr M01_L31
M01_L25:
       mov       ecx,r13d
       mov       rsi,[r15+rcx*8+10]
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp-0B8],rax
       test      bl,bl
       je        near ptr M01_L32
       test      rax,rax
       je        near ptr M01_L30
M01_L26:
       call      qword ptr [7FFF8F7398A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-0C0],rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-98],r12
       mov       [rbp-90],rax
       lea       rcx,[rbp-98]
       mov       rsi,[rbp-0B8]
       mov       rdx,[rbp-0C0]
       mov       r8,266AA400BE8
       mov       r8,[r8]
       mov       [rbp-0A8],rcx
       mov       dword ptr [rbp-0A0],2
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-0A8]
       call      qword ptr [7FFF8F5D1DC8]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFF8F961420]
       mov       rsi,rax
       test      r14,r14
       je        near ptr M01_L46
       test      rsi,rsi
       je        near ptr M01_L47
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF8F53B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L34
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-0D0]
       mov       [r8+8],eax
       mov       [rbp-0D0],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-0D0]
       lea       rcx,[r14+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L27:
       mov       rcx,266A04078D8
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L28
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,266A04078B8
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC48D38
       mov       [rsi+18],rdx
       mov       rcx,266A04078D8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L28:
       mov       rcx,266A04078E0
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L29
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-0C8],r9
       mov       rdx,266A04078B8
       mov       rdx,[rdx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC48D50
       mov       r9,[rbp-0C8]
       mov       [r9+18],rdx
       mov       rcx,266A04078E0
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-0C8]
M01_L29:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF8FC4D2E8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L30:
       add       r13d,1
       jo        near ptr M01_L37
       cmp       [r15+8],r13d
       jg        near ptr M01_L25
M01_L31:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
       jmp       near ptr M01_L26
M01_L33:
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFF8F7E7030]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
       jmp       near ptr M01_L21
M01_L34:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L27
M01_L35:
       mov       rcx,266A0401F20
       mov       r15,[rcx]
       jmp       near ptr M01_L21
M01_L36:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFF8F64DA50]
       jmp       near ptr M01_L23
M01_L37:
       call      CORINFO_HELP_OVERFLOW
M01_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F761C78]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F761C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L40:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L03
M01_L41:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L42:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L43:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
M01_L44:
       xor       r13d,r13d
       xor       eax,eax
       jmp       near ptr M01_L22
M01_L45:
       call      qword ptr [7FFF8F797498]
       int       3
M01_L46:
       mov       ecx,4
       call      qword ptr [7FFF8F79B780]
       int       3
M01_L47:
       mov       ecx,0E
       call      qword ptr [7FFF8F79B780]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp-0B0]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF8F53B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L48
       mov       rcx,rax
       mov       r11,7FFF8F390898
       call      qword ptr [r11]
M01_L48:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 2981
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       mov       rdx,1EA6FDA3020
       mov       rdx,[rdx]
       mov       r8d,1
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0E0],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L31
       mov       rcx,rdi
       test      rcx,rcx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L32
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,7FFF90F55938
       mov       edx,38
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EA6FDA7C90
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,r15
       call      DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L12
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FFF90CB06B0
       call      qword ptr [7FFF90CB06B0]
       mov       [rbp-0A0],rax
       mov       rcx,rax
       mov       r11,7FFF90CB06B8
       call      qword ptr [7FFF90CB06B8]
       test      eax,eax
       je        near ptr M01_L10
M01_L01:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFF90CB06C0
       call      qword ptr [7FFF90CB06C0]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L08
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r13,rax
       mov       [r12+8],r15d
       xor       r15d,r15d
       mov       rcx,7FFF90DB4938
       mov       edx,184
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EA6FDA1388
       mov       rcx,[rcx]
       mov       rdx,1EAFFDA1B88
       mov       rdx,[rdx]
       mov       [rbp-98],rsi
       mov       [rbp-90],r12
       mov       [rbp-88],r15
       mov       [rbp-80],rcx
       mov       rcx,r13
       lea       r8,[rbp-98]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rdi,rax
       test      r14,r14
       je        near ptr M01_L07
       test      rdi,rdi
       je        near ptr M01_L06
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       near ptr M01_L09
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rcx,7FFF910E4380
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EA6FDA8610
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1EA6FDA8600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L05
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rdx
       mov       rcx,1EA6FDA8610
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,1EA6FDA8618
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1EA6FDA8600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L05
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,1EA6FDA8618
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r14
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp-0A0]
       mov       r11,7FFF90CB06B8
       call      qword ptr [7FFF90CB06B8]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L01
       jmp       short M01_L10
M01_L05:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L06:
       mov       ecx,0E
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L07:
       mov       ecx,4
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L10:
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L11
       mov       rcx,rax
       mov       r11,7FFF90CB06C8
       call      qword ptr [7FFF90CB06C8]
M01_L11:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       jne       short M01_L13
       mov       rcx,1EA6FDA2F08
       mov       r15,[rcx]
       jmp       short M01_L15
M01_L13:
       cmp       dword ptr [rbp-68],1
       jne       short M01_L14
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L15
M01_L14:
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M01_L15:
       mov       rcx,1EA6FDA3020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L20
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1EA6FDA2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF90F3FA48]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       r8,[rbp-60]
       mov       [rbp-58],rax
       test      rax,rax
       jne       short M01_L16
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M01_L17
M01_L16:
       lea       rcx,[rax+10]
       mov       edx,[rax+8]
M01_L17:
       add       r8,18
       mov       [r8],rcx
       mov       [r8+8],edx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       short M01_L18
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L33
       mov       rcx,[rbp-48]
       mov       edx,[rbp-40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short M01_L18
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       short M01_L19
M01_L18:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
M01_L19:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
M01_L20:
       xor       esi,esi
       cmp       dword ptr [r15+8],0
       jle       near ptr M01_L29
M01_L21:
       cmp       esi,[r15+8]
       jae       near ptr M01_L37
       movsxd    rcx,esi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp-0A8],rax
       test      bl,bl
       je        near ptr M01_L23
       test      rax,rax
       je        near ptr M01_L28
M01_L22:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-0B0],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r13,rax
       mov       [rbp-0C8],r12
       xor       r8d,r8d
       mov       [rbp-0D0],r8
       mov       rcx,7FFF90DB4938
       mov       edx,184
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EA6FDA1388
       mov       rcx,[rcx]
       mov       rdx,[rbp-0B0]
       mov       r8,1EAFFDA1B90
       mov       r8,[r8]
       mov       rax,[rbp-0C8]
       mov       [rbp-98],rax
       mov       [rbp-90],r13
       mov       r13,[rbp-0D0]
       mov       [rbp-88],r13
       mov       [rbp-80],rcx
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-98]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp-0A8]
       mov       r8d,1
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r13,rax
       test      r14,r14
       je        near ptr M01_L34
       test      r13,r13
       je        near ptr M01_L35
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M01_L24
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C0],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-0C0]
       mov       [r8+8],eax
       mov       [rbp-0C0],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-0C0]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L25
M01_L23:
       jmp       near ptr M01_L22
M01_L24:
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
M01_L25:
       mov       rcx,7FFF910E4380
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EA6FDA8620
       mov       r13,[rcx]
       test      r13,r13
       jne       short M01_L26
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,1EA6FDA8600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L36
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,1EA6FDA8620
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L26:
       mov       rcx,1EA6FDA8628
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L27
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-0B8],r9
       mov       rdx,1EA6FDA8600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L36
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-0B8]
       mov       [r9+18],rdx
       mov       rcx,1EA6FDA8628
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp-0B8]
M01_L27:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L28:
       add       esi,1
       jo        short M01_L30
       cmp       [r15+8],esi
       jg        near ptr M01_L21
M01_L29:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       call      CORINFO_HELP_OVERFLOW
M01_L31:
       mov       ecx,4D
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,78B
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L32:
       mov       ecx,4D
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L33:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L34:
       mov       ecx,4
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L35:
       mov       ecx,0E
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L36:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L38
       mov       rcx,rax
       mov       r11,7FFF90CB06C8
       call      qword ptr [7FFF90CB06C8]
M01_L38:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 2388
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       mov       rdx,21353802028
       mov       rdx,[rdx]
       mov       r8d,1
       call      qword ptr [7FFF8F991420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC8BEA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-0E0],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[r14+18]
       call      qword ptr [7FFF8F60BDC8]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       test      rax,rax
       je        short M01_L02
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       test      rsi,rsi
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F9CD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0A
       jl        near ptr M01_L38
       lea       rcx,[rdi+0C]
       mov       rdx,21353811768
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L39
       lea       rcx,[rdi+20]
       mov       rdx,21353802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,21353802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F601C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L40
       mov       eax,1
M01_L03:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF8F9CD498]
       mov       r14,rax
       mov       ecx,536
       mov       rdx,7FFF8F806BE8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9CD078]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF8F9CD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rax,rdi
       test      rax,rax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9CD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L41
       lea       rcx,[rdi+0C]
       mov       rdx,21353808990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L42
       lea       rcx,[rdi+12]
       mov       rdx,21353802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,21353802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F601C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L43
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFF8F9CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,21353806D28
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFF8F60B2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L09
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFF8F60B318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFF8FC87C30]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L20
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFF8F56B888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFF8F3C08B0
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
       mov       rcx,rax
       mov       r11,7FFF8F3C08B8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L10:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFF8F3C08C0
       call      qword ptr [r11]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L15
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF8F7698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       mov       [rbp-70],rsi
       mov       [rbp-68],r12
       lea       rdx,[rbp-70]
       mov       r8,21353811770
       mov       r8,[r8]
       mov       [rbp-0A8],rdx
       mov       dword ptr [rbp-0A0],2
       mov       rdx,r8
       lea       r8,[rbp-0A8]
       call      qword ptr [7FFF8F601DC8]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFF8F991420]
       mov       rdi,rax
       test      r14,r14
       je        near ptr M01_L16
       test      rdi,rdi
       je        near ptr M01_L17
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF8F56B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L11
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L12
M01_L11:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
M01_L12:
       mov       rcx,213538078C8
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L13
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,213538078B8
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC86D08
       mov       [rdi+18],rdx
       mov       rcx,213538078C8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,213538078D0
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,213538078B8
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC86D20
       mov       [r14+18],rdx
       mov       rcx,213538078D0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
M01_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF8FC8B2E8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp-0B0]
       mov       r11,7FFF8F3C08B8
       call      qword ptr [r11]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L10
       jmp       short M01_L18
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       ecx,4
       call      qword ptr [7FFF8F7CB780]
       int       3
M01_L17:
       mov       ecx,0E
       call      qword ptr [7FFF8F7CB780]
       int       3
M01_L18:
       mov       rdx,[rbp-0B0]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF8F56B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L19
       mov       rcx,rax
       mov       r11,7FFF8F3C08C8
       call      qword ptr [r11]
M01_L19:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFF8F4E7330]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L35
       cmp       dword ptr [rbp-78],1
       jne       near ptr M01_L33
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M01_L21:
       mov       rcx,21353802028
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,21353801ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF8F801770]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L44
       lea       r13,[rax+10]
       mov       eax,[rax+8]
M01_L22:
       mov       [rbp-48],r13
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L36
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L45
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L36
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
M01_L23:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFF8FC87DF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFF8F67D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
M01_L24:
       xor       r13d,r13d
       cmp       dword ptr [r15+8],0
       jle       near ptr M01_L31
M01_L25:
       mov       ecx,r13d
       mov       rsi,[r15+rcx*8+10]
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp-0B8],rax
       test      bl,bl
       je        near ptr M01_L32
       test      rax,rax
       je        near ptr M01_L30
M01_L26:
       call      qword ptr [7FFF8F7698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-0C0],rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-98],r12
       mov       [rbp-90],rax
       lea       rcx,[rbp-98]
       mov       rsi,[rbp-0B8]
       mov       rdx,[rbp-0C0]
       mov       r8,21353811778
       mov       r8,[r8]
       mov       [rbp-0A8],rcx
       mov       dword ptr [rbp-0A0],2
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-0A8]
       call      qword ptr [7FFF8F601DC8]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFF8F991420]
       mov       rsi,rax
       test      r14,r14
       je        near ptr M01_L46
       test      rsi,rsi
       je        near ptr M01_L47
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF8F56B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L34
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-0D0]
       mov       [r8+8],eax
       mov       [rbp-0D0],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-0D0]
       lea       rcx,[r14+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L27:
       mov       rcx,213538078D8
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L28
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,213538078B8
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC86D38
       mov       [rsi+18],rdx
       mov       rcx,213538078D8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L28:
       mov       rcx,213538078E0
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L29
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-0C8],r9
       mov       rdx,213538078B8
       mov       rdx,[rdx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC86D50
       mov       r9,[rbp-0C8]
       mov       [r9+18],rdx
       mov       rcx,213538078E0
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-0C8]
M01_L29:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF8FC8B2E8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L30:
       add       r13d,1
       jo        near ptr M01_L37
       cmp       [r15+8],r13d
       jg        near ptr M01_L25
M01_L31:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
       jmp       near ptr M01_L26
M01_L33:
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFF8F817030]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
       jmp       near ptr M01_L21
M01_L34:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L27
M01_L35:
       mov       rcx,21353801F20
       mov       r15,[rcx]
       jmp       near ptr M01_L21
M01_L36:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFF8F67DA50]
       jmp       near ptr M01_L23
M01_L37:
       call      CORINFO_HELP_OVERFLOW
M01_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L40:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L03
M01_L41:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L42:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L43:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
M01_L44:
       xor       r13d,r13d
       xor       eax,eax
       jmp       near ptr M01_L22
M01_L45:
       call      qword ptr [7FFF8F7C7498]
       int       3
M01_L46:
       mov       ecx,4
       call      qword ptr [7FFF8F7CB780]
       int       3
M01_L47:
       mov       ecx,0E
       call      qword ptr [7FFF8F7CB780]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp-0B0]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF8F56B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L48
       mov       rcx,rax
       mov       r11,7FFF8F3C08C8
       call      qword ptr [r11]
M01_L48:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 2981
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       mov       rdx,1D2CC563020
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0E0],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L31
       mov       rcx,rdi
       test      rcx,rcx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L32
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,7FFF90F75938
       mov       edx,38
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D2CC567C90
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,r15
       call      DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L12
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FFF90CD06B0
       call      qword ptr [7FFF90CD06B0]
       mov       [rbp-0A0],rax
       mov       rcx,rax
       mov       r11,7FFF90CD06B8
       call      qword ptr [7FFF90CD06B8]
       test      eax,eax
       je        near ptr M01_L10
M01_L01:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFF90CD06C0
       call      qword ptr [7FFF90CD06C0]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L08
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r13,rax
       mov       [r12+8],r15d
       xor       r15d,r15d
       mov       rcx,7FFF90DD4938
       mov       edx,184
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D2CC561388
       mov       rcx,[rcx]
       mov       rdx,1D35C561B88
       mov       rdx,[rdx]
       mov       [rbp-98],rsi
       mov       [rbp-90],r12
       mov       [rbp-88],r15
       mov       [rbp-80],rcx
       mov       rcx,r13
       lea       r8,[rbp-98]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rdi,rax
       test      r14,r14
       je        near ptr M01_L07
       test      rdi,rdi
       je        near ptr M01_L06
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       near ptr M01_L09
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rcx,7FFF91104380
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D2CC568610
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D2CC568600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L05
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rdx
       mov       rcx,1D2CC568610
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,1D2CC568618
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1D2CC568600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L05
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,1D2CC568618
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r14
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp-0A0]
       mov       r11,7FFF90CD06B8
       call      qword ptr [7FFF90CD06B8]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L01
       jmp       short M01_L10
M01_L05:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L06:
       mov       ecx,0E
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L07:
       mov       ecx,4
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L10:
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L11
       mov       rcx,rax
       mov       r11,7FFF90CD06C8
       call      qword ptr [7FFF90CD06C8]
M01_L11:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       jne       short M01_L13
       mov       rcx,1D2CC562F08
       mov       r15,[rcx]
       jmp       short M01_L15
M01_L13:
       cmp       dword ptr [rbp-68],1
       jne       short M01_L14
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L15
M01_L14:
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M01_L15:
       mov       rcx,1D2CC563020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L20
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1D2CC562EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF90F5FA48]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       r8,[rbp-60]
       mov       [rbp-58],rax
       test      rax,rax
       jne       short M01_L16
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M01_L17
M01_L16:
       lea       rcx,[rax+10]
       mov       edx,[rax+8]
M01_L17:
       add       r8,18
       mov       [r8],rcx
       mov       [r8+8],edx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       short M01_L18
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L33
       mov       rcx,[rbp-48]
       mov       edx,[rbp-40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short M01_L18
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       short M01_L19
M01_L18:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
M01_L19:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
M01_L20:
       xor       esi,esi
       cmp       dword ptr [r15+8],0
       jle       near ptr M01_L29
M01_L21:
       cmp       esi,[r15+8]
       jae       near ptr M01_L37
       movsxd    rcx,esi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp-0A8],rax
       test      bl,bl
       je        near ptr M01_L23
       test      rax,rax
       je        near ptr M01_L28
M01_L22:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-0B0],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r13,rax
       mov       [rbp-0C8],r12
       xor       r8d,r8d
       mov       [rbp-0D0],r8
       mov       rcx,7FFF90DD4938
       mov       edx,184
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D2CC561388
       mov       rcx,[rcx]
       mov       rdx,[rbp-0B0]
       mov       r8,1D35C561B90
       mov       r8,[r8]
       mov       rax,[rbp-0C8]
       mov       [rbp-98],rax
       mov       [rbp-90],r13
       mov       r13,[rbp-0D0]
       mov       [rbp-88],r13
       mov       [rbp-80],rcx
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-98]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp-0A8]
       mov       r8d,1
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r13,rax
       test      r14,r14
       je        near ptr M01_L34
       test      r13,r13
       je        near ptr M01_L35
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M01_L24
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C0],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-0C0]
       mov       [r8+8],eax
       mov       [rbp-0C0],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-0C0]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L25
M01_L23:
       jmp       near ptr M01_L22
M01_L24:
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
M01_L25:
       mov       rcx,7FFF91104380
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D2CC568620
       mov       r13,[rcx]
       test      r13,r13
       jne       short M01_L26
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,1D2CC568600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L36
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,1D2CC568620
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L26:
       mov       rcx,1D2CC568628
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L27
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-0B8],r9
       mov       rdx,1D2CC568600
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L36
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-0B8]
       mov       [r9+18],rdx
       mov       rcx,1D2CC568628
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp-0B8]
M01_L27:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L28:
       add       esi,1
       jo        short M01_L30
       cmp       [r15+8],esi
       jg        near ptr M01_L21
M01_L29:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       call      CORINFO_HELP_OVERFLOW
M01_L31:
       mov       ecx,4D
       mov       rdx,7FFF91103BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,78B
       mov       rdx,7FFF91103BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L32:
       mov       ecx,4D
       mov       rdx,7FFF91103BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF91103BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L33:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L34:
       mov       ecx,4
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L35:
       mov       ecx,0E
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L36:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L38
       mov       rcx,rax
       mov       r11,7FFF90CD06C8
       call      qword ptr [7FFF90CD06C8]
M01_L38:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 2388
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       mov       rdx,25317002028
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      qword ptr [7FFF8F991420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC8B768]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-0E0],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[r14+18]
       call      qword ptr [7FFF8F60BDC8]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       test      rax,rax
       je        short M01_L02
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       test      rsi,rsi
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F9CD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0A
       jl        near ptr M01_L38
       lea       rcx,[rdi+0C]
       mov       rdx,25327000BD0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L39
       lea       rcx,[rdi+20]
       mov       rdx,25317002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,25317002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F601C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L40
       mov       eax,1
M01_L03:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF8F9CD498]
       mov       r14,rax
       mov       ecx,536
       mov       rdx,7FFF8F806BE8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9CD078]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF8F9CD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rax,rdi
       test      rax,rax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9CD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L41
       lea       rcx,[rdi+0C]
       mov       rdx,25317008990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L42
       lea       rcx,[rdi+12]
       mov       rdx,25317002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,25317002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F601C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L43
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFF8F9CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,25317006D28
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFF8F60B2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L09
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFF8F60B318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFF8FC87378]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L20
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFF8F56B888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFF8F3C08B0
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
       mov       rcx,rax
       mov       r11,7FFF8F3C08B8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L10:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFF8F3C08C0
       call      qword ptr [r11]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L15
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF8F7698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       mov       [rbp-70],rsi
       mov       [rbp-68],r12
       lea       rdx,[rbp-70]
       mov       r8,25327000BD8
       mov       r8,[r8]
       mov       [rbp-0A8],rdx
       mov       dword ptr [rbp-0A0],2
       mov       rdx,r8
       lea       r8,[rbp-0A8]
       call      qword ptr [7FFF8F601DC8]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFF8F991420]
       mov       rdi,rax
       test      r14,r14
       je        near ptr M01_L16
       test      rdi,rdi
       je        near ptr M01_L17
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF8F56B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L11
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L12
M01_L11:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
M01_L12:
       mov       rcx,253170078C8
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L13
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,253170078B8
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC86450
       mov       [rdi+18],rdx
       mov       rcx,253170078C8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,253170078D0
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,253170078B8
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC86468
       mov       [r14+18],rdx
       mov       rcx,253170078D0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
M01_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF8FC89BA0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp-0B0]
       mov       r11,7FFF8F3C08B8
       call      qword ptr [r11]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L10
       jmp       short M01_L18
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       ecx,4
       call      qword ptr [7FFF8F7CB780]
       int       3
M01_L17:
       mov       ecx,0E
       call      qword ptr [7FFF8F7CB780]
       int       3
M01_L18:
       mov       rdx,[rbp-0B0]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF8F56B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L19
       mov       rcx,rax
       mov       r11,7FFF8F3C08C8
       call      qword ptr [r11]
M01_L19:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFF8F4E7330]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L35
       cmp       dword ptr [rbp-78],1
       jne       near ptr M01_L33
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M01_L21:
       mov       rcx,25317002028
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,25317001ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF8F801770]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L44
       lea       r13,[rax+10]
       mov       eax,[rax+8]
M01_L22:
       mov       [rbp-48],r13
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L36
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L45
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L36
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
M01_L23:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFF8FC87540]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFF8F67D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
M01_L24:
       xor       r13d,r13d
       cmp       dword ptr [r15+8],0
       jle       near ptr M01_L31
M01_L25:
       mov       ecx,r13d
       mov       rsi,[r15+rcx*8+10]
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp-0B8],rax
       test      bl,bl
       je        near ptr M01_L32
       test      rax,rax
       je        near ptr M01_L30
M01_L26:
       call      qword ptr [7FFF8F7698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-0C0],rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-98],r12
       mov       [rbp-90],rax
       lea       rcx,[rbp-98]
       mov       rsi,[rbp-0B8]
       mov       rdx,[rbp-0C0]
       mov       r8,25327000BE0
       mov       r8,[r8]
       mov       [rbp-0A8],rcx
       mov       dword ptr [rbp-0A0],2
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-0A8]
       call      qword ptr [7FFF8F601DC8]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFF8F991420]
       mov       rsi,rax
       test      r14,r14
       je        near ptr M01_L46
       test      rsi,rsi
       je        near ptr M01_L47
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF8F56B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L34
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-0D0]
       mov       [r8+8],eax
       mov       [rbp-0D0],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-0D0]
       lea       rcx,[r14+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L27:
       mov       rcx,253170078D8
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L28
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,253170078B8
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC86480
       mov       [rsi+18],rdx
       mov       rcx,253170078D8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L28:
       mov       rcx,253170078E0
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L29
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-0C8],r9
       mov       rdx,253170078B8
       mov       rdx,[rdx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF8FC86498
       mov       r9,[rbp-0C8]
       mov       [r9+18],rdx
       mov       rcx,253170078E0
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-0C8]
M01_L29:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF8FC89BA0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L30:
       add       r13d,1
       jo        near ptr M01_L37
       cmp       [r15+8],r13d
       jg        near ptr M01_L25
M01_L31:
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
       jmp       near ptr M01_L26
M01_L33:
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFF8F817030]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
       jmp       near ptr M01_L21
M01_L34:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L27
M01_L35:
       mov       rcx,25317001F20
       mov       r15,[rcx]
       jmp       near ptr M01_L21
M01_L36:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFF8F67DA50]
       jmp       near ptr M01_L23
M01_L37:
       call      CORINFO_HELP_OVERFLOW
M01_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L40:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L03
M01_L41:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L42:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L43:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
M01_L44:
       xor       r13d,r13d
       xor       eax,eax
       jmp       near ptr M01_L22
M01_L45:
       call      qword ptr [7FFF8F7C7498]
       int       3
M01_L46:
       mov       ecx,4
       call      qword ptr [7FFF8F7CB780]
       int       3
M01_L47:
       mov       ecx,0E
       call      qword ptr [7FFF8F7CB780]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp-0B0]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF8F56B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L48
       mov       rcx,rax
       mov       r11,7FFF8F3C08C8
       call      qword ptr [r11]
M01_L48:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 2981
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rsi+1A0]
       mov       rdx,1788F4E3020
       mov       rdx,[rdx]
       mov       r9,1788F4E99E0
       mov       r9,[r9]
       mov       r8d,3A
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
; Total bytes of code 110
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,1788F4E3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L01
       mov       r8,1790F4E1B90
       mov       rdi,[r8]
       jmp       short M01_L02
M01_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L02
       mov       r8,1788F4E3020
       mov       rdi,[r8]
M01_L02:
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L03
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 344
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rsi+1A0]
       mov       rdx,137ABC02028
       mov       rdx,[rdx]
       mov       r9,137ABC08A00
       mov       r9,[r9]
       mov       r8d,3A
       call      qword ptr [7FFF8F9A1438]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
; Total bytes of code 111
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,137ABC02028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF8F4F7978]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF8F4F7978]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [7FFF8F611378]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L01
       mov       r8,137B3C08B68
       mov       rdi,[r8]
       jmp       short M01_L02
M01_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L02
       mov       r8,137ABC02028
       mov       rdi,[r8]
M01_L02:
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8F9A1420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF8FC96348
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF8FC973C0]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F611498]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L03
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFF8F613030]; System.String.Remove(Int32, Int32)
; Total bytes of code 351
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
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
       mov       rdx,1A480BF3020
       mov       rdx,[rdx]
       mov       r9,1A480BF99E0
       mov       r9,[r9]
       mov       r8d,3A
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,1A480BF3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L01
       mov       r8,1A500BF1B90
       mov       rdi,[r8]
       jmp       short M01_L02
M01_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L02
       mov       r8,1A480BF3020
       mov       rdi,[r8]
M01_L02:
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L03
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 344
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
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
       mov       rdx,20D51002028
       mov       rdx,[rdx]
       mov       r9,20D51008A00
       mov       r9,[r9]
       mov       r8d,3A
       call      qword ptr [7FFF8F961438]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
; Total bytes of code 109
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,20D51002028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF8F4B7978]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF8F4B7978]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [7FFF8F5D1378]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L01
       mov       r8,20D61000BD8
       mov       rdi,[r8]
       jmp       short M01_L02
M01_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L02
       mov       r8,20D51002028
       mov       rdi,[r8]
M01_L02:
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8F961420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF8FC56BB8
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF8FC57C30]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F5D1498]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L03
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFF8F5D3030]; System.String.Remove(Int32, Int32)
; Total bytes of code 351
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rsi+1A8]
       mov       rdx,1C3449E3020
       mov       rdx,[rdx]
       mov       r9,1C3449E99E0
       mov       r9,[r9]
       mov       r8d,3A
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
; Total bytes of code 110
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,1C3449E3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L01
       mov       r8,1C3249E1B90
       mov       rdi,[r8]
       jmp       short M01_L02
M01_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L02
       mov       r8,1C3449E3020
       mov       rdi,[r8]
M01_L02:
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L03
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 344
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rsi+1A8]
       mov       rdx,1F026C02028
       mov       rdx,[rdx]
       mov       r9,1F026C08A00
       mov       r9,[r9]
       mov       r8d,3A
       call      qword ptr [7FFF8F961438]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
; Total bytes of code 111
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,1F026C02028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF8F4B7978]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF8F4B7978]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [7FFF8F5D1378]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L01
       mov       r8,1F022C09B88
       mov       rdi,[r8]
       jmp       short M01_L02
M01_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L02
       mov       r8,1F026C02028
       mov       rdi,[r8]
M01_L02:
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8F961420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF8FC588B8
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF8FC59930]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F5D1498]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L03
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFF8F5D3030]; System.String.Remove(Int32, Int32)
; Total bytes of code 351
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
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
       mov       rdx,1BB24F23020
       mov       rdx,[rdx]
       mov       r9,1BB24F299E0
       mov       r9,[r9]
       mov       r8d,3A
       call      00007FFF91002958
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
; Total bytes of code 108
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
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
       mov       rdx,1862C402028
       mov       rdx,[rdx]
       mov       r9,1862C408A00
       mov       r9,[r9]
       mov       r8d,3A
       call      qword ptr [7FFF8F991438]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
; Total bytes of code 109
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,1862C402028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF8F4E7978]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF8F4E7978]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [7FFF8F601378]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L01
       mov       r8,18636400BD8
       mov       rdi,[r8]
       jmp       short M01_L02
M01_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L02
       mov       r8,1862C402028
       mov       rdi,[r8]
M01_L02:
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8F991420]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF8FC86BB8
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF8FC87C30]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F601498]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L03
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFF8F603030]; System.String.Remove(Int32, Int32)
; Total bytes of code 351
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       test      rcx,rcx
       je        short M00_L00
       call      qword ptr [7FFF910ED8C0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.ToString()
       jmp       short M00_L01
M00_L00:
       mov       rax,12AF3223020
       mov       rax,[rax]
M00_L01:
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.ToString()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+48]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rsi],esi
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       test      rcx,rcx
       je        short M00_L00
       call      qword ptr [7FFF8F9721C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.ToString()
       jmp       short M00_L01
M00_L00:
       mov       rax,23AC2002028
       mov       rax,[rax]
M00_L01:
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC79BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.ToString()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+48]
       call      qword ptr [7FFF8F7698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rsi],sil
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 27
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
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
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FFF8FC97FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
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
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FFF8FC85FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
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
       call      System.Text.Json.JsonSerializerOptions.get_Default()
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
       mov       rcx,[rsp+30]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
       int       3
; Total bytes of code 114
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       sub       rsp,28
       mov       rax,2812A0D8A48
       mov       rax,[rax]
       test      rax,rax
       jne       short M01_L00
       call      System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
M01_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-28],xmm4
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       mov       rsi,r8
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L02
       mov       [rbp-28],rdx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       call      System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       r8,rax
M02_L00:
       lea       rdx,[rbp-28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       edx,edx
       mov       [rbp-18],rdx
M02_L01:
       mov       rdx,[rbp-20]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFF910F3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910F3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       r8,rdx
       lea       rcx,[rbp-20]
       mov       rdx,offset MD_DotNetTips.Spargine.Core.SimpleResult.FromException[[System.String, System.Private.CoreLib]](System.Exception)
       call      DotNetTips.Spargine.Core.SimpleResult.FromException[[System.__Canon, System.Private.CoreLib]](System.Exception)
       lea       rax,[M02_L01]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 321
```
```assembly
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
**Method was not JITted yet.**
System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FFF8F9C3138]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,rdi
       call      qword ptr [7FFF8F991480]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
       mov       rcx,[rsp+30]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC79858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFF8FC797F8]
       int       3
; Total bytes of code 118
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       sub       rsp,28
       mov       rax,208D94081A0
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFF8F9C3690]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
       jmp       short M01_L00
; Total bytes of code 35
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-38],rsp
       mov       [rbp+10],rcx
       mov       rsi,r8
       test      rdx,rdx
       jne       near ptr M02_L03
       call      qword ptr [7FFF8F9CD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L06
       lea       rcx,[rdi+0C]
       mov       rdx,208D9408990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L07
       lea       rcx,[rdi+12]
       mov       rdx,208D9402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       mov       rcx,rdi
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L08
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L08
M02_L02:
       mov       rcx,208D9402028
       mov       rcx,[rcx]
       jmp       short M02_L00
M02_L03:
       mov       [rbp-30],rdx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9C5318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M02_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M02_L04
       mov       rdx,rax
       call      qword ptr [7FFF8F56B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M02_L04:
       lea       rdx,[rbp-30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF8FBC7738]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rbp-28],rax
       xor       edx,edx
       mov       [rbp-20],rdx
M02_L05:
       mov       rdx,[rbp-28]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L09
       call      qword ptr [7FFF8F9CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+60]
       mov       r8,rdx
       lea       rcx,[rbp-28]
       mov       rdx,offset MD_DotNetTips.Spargine.Core.SimpleResult.FromException[[System.String, System.Private.CoreLib]](System.Exception)
       call      qword ptr [7FFF8FC79540]
       lea       rax,[M02_L05]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 699
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L07
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rsi,rax
       call      System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rdi,rax
       cmp       byte ptr [rdi+85],0
       jne       short M01_L00
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L00:
       mov       rcx,298B5E68BC0
       cmp       rsi,[rcx]
       je        short M01_L04
       mov       rbx,[rdi+10]
       test      rbx,rbx
       jne       short M01_L01
       xor       ecx,ecx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbx+0C0]
M01_L02:
       cmp       rcx,rsi
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,1
       xor       r9d,r9d
       call      System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       mov       rdx,rbx
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       rdx,rax
M01_L05:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L06
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       r8,rax
M01_L06:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       ecx,4D
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910E3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 304
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       call      qword ptr [7FFF8F971468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC598A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L05
       lea       rcx,[rsi+0C]
       mov       rdx,2ADDA408990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rsi+12]
       mov       rdx,2ADDA402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M01_L02
       mov       rcx,rsi
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,2ADDA402028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFF8F9A5318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M01_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L04
       mov       rdx,rax
       call      qword ptr [7FFF8F54B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF8FBA99F0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L07
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rsi,rax
       call      System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rdi,rax
       cmp       byte ptr [rdi+85],0
       jne       short M01_L00
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L00:
       mov       rcx,187110F8BC0
       cmp       rsi,[rcx]
       je        short M01_L04
       mov       rbx,[rdi+10]
       test      rbx,rbx
       jne       short M01_L01
       xor       ecx,ecx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbx+0C0]
M01_L02:
       cmp       rcx,rsi
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,1
       xor       r9d,r9d
       call      System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       mov       rdx,rbx
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       rdx,rax
M01_L05:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L06
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       r8,rax
M01_L06:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       ecx,4D
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,75F
       mov       rdx,7FFF910D3BD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 304
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       call      qword ptr [7FFF8F971468]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC57D20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L05
       lea       rcx,[rsi+0C]
       mov       rdx,1F2D7008990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rsi+12]
       mov       rdx,1F2D7002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M01_L02
       mov       rcx,rsi
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,1F2D7002028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFF8F9A5318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M01_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L04
       mov       rdx,rax
       call      qword ptr [7FFF8F54B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF8FBA5E70]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
```
```assembly
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Data.DataTable..ctor()
       mov       rdx,1D007603738
       mov       rdx,[rdx]
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rsi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
; Total bytes of code 68
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rdx,1D0075F3020
       mov       rdi,[rdx]
       lea       rcx,[rsi+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+80]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+1C4],1
       mov       dword ptr [rsi+1B0],19
       mov       rdx,1D0075F1060
       mov       rdx,[rdx]
       vmovupd   xmm0,[rdx+8]
       vmovupd   [rsi+1D8],xmm0
       mov       rdx,1D0075F1060
       mov       rdx,[rdx]
       vmovupd   xmm0,[rdx+8]
       vmovupd   [rsi+1E8],xmm0
       mov       rdx,1D0075FDE60
       mov       rdx,[rdx]
       lea       rcx,[rsi+0D8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+1CC],1
       mov       rdx,1D0075FDE68
       mov       rdx,[rdx]
       lea       rcx,[rsi+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D0075FDE70
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+180]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D0075FDE78
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
       mov       rdx,7FFF90DB5340
       mov       ecx,1
       lock xadd [rdx],rcx
       inc       rcx
       mov       [rax+28],rcx
       lea       rcx,[rsi+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+1B8],0FFFFFFFF
       mov       rcx,7FFF9139888C
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rsi+1C0],eax
       mov       rcx,rsi
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,1D0075FD060
       mov       rdi,[rcx]
       mov       ebx,[rsi+1C0]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M01_L01
M01_L00:
       mov       qword ptr [rsi+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rsi+50]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rsi+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D0075F2F48
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
       call      System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rdx,1D0075FDE90
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
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       rdx,rax
       mov       rcx,1D007603740
       mov       rcx,[rcx]
       call      System.String.Format(System.String, System.Object)
       mov       r8,rax
       mov       rcx,rdi
       mov       edx,1
       call      System.Diagnostics.Tracing.EventSource.WriteEvent(Int32, System.String)
       jmp       near ptr M01_L00
; Total bytes of code 915
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       [rbp+18],edx
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IAsyncDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        near ptr M02_L04
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FFF90CB0848
       call      qword ptr [7FFF90CB0848]
       mov       rsi,[rbp-20]
       test      rsi,rsi
       jne       short M02_L01
       xor       edi,edi
       jmp       short M02_L03
M02_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L02
       test      dword ptr [rax+34],200000
       setne     dil
       movzx     edi,dil
       jmp       short M02_L03
M02_L02:
       mov       edx,[rbp-18]
       movsx     rdx,dx
       mov       rcx,rsi
       mov       r11,7FFF90CB0850
       call      qword ptr [7FFF90CB0850]
       cmp       eax,2
       sete      dil
       movzx     edi,dil
M02_L03:
       test      edi,edi
       je        short M02_L05
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ThereIsAnIssueDisposingOfTheObjectUsingAsyncDispose()
       mov       rsi,rax
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidOperation()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.InvalidOperationException..ctor(System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,rsi
       mov       r11,7FFF90CB0840
       call      qword ptr [7FFF90CB0840]
       nop
M02_L05:
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+18],0
       je        short M02_L06
       call      CORINFO_HELP_RETHROW
M02_L06:
       lea       rax,[M02_L05]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 324
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8FC6B000]; System.Data.DataTable..ctor()
       mov       rdx,28BFF800BD8
       mov       rdx,[rdx]
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rsi
       jmp       qword ptr [7FFF8F9814C8]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
; Total bytes of code 70
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       rdx,28C03802028
       mov       rdi,[rdx]
       lea       rcx,[rsi+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+80]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+1C4],1
       mov       dword ptr [rsi+1B0],19
       mov       rdx,28C03800068
       mov       rdx,[rdx]
       add       rdx,8
       vmovupd   xmm0,[rdx]
       vmovupd   [rsi+1D8],xmm0
       vmovupd   xmm0,[rdx]
       vmovupd   [rsi+1E8],xmm0
       mov       rdx,28C07803900
       mov       rdx,[rdx]
       lea       rcx,[rsi+0D8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+1CC],1
       mov       rdx,28C07803908
       mov       rdx,[rdx]
       lea       rcx,[rsi+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,28C07803910
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+180]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,28C07803918
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
       mov       rdx,7FFF8F4C5680
       mov       ecx,1
       lock xadd [rdx],rcx
       inc       rcx
       mov       [rax+28],rcx
       lea       rcx,[rsi+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+1B8],0FFFFFFFF
       mov       rcx,7FFF8FC82D1C
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rsi+1C0],eax
       mov       rcx,rsi
       call      qword ptr [7FFF8F8D76C0]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,28C07802AD8
       mov       rcx,[rcx]
       mov       rdi,rcx
       mov       ebx,[rsi+1C0]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M01_L01
M01_L00:
       mov       qword ptr [rsi+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF8FCC58B8]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rsi+50]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFF8F7598A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rsi+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFF8FCC19A8]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28C03801F78
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
       call      qword ptr [7FFF8FCC3870]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rdx,28C07803930
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
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       rdx,28BFF800BE0
       mov       rdx,[rdx]
       mov       [rsp+28],r8
       mov       dword ptr [rsp+30],1
       lea       r8,[rsp+28]
       xor       ecx,ecx
       call      qword ptr [7FFF8F5F1DC8]
       mov       r8,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFF8F63F348]
       jmp       near ptr M01_L00
; Total bytes of code 958
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       [rbp+18],edx
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IAsyncDisposable
       call      qword ptr [7FFF8F55B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L04
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FFF8F3B07F8
       call      qword ptr [r11]
       mov       rsi,[rbp-20]
       test      rsi,rsi
       jne       short M02_L01
       xor       edi,edi
       jmp       short M02_L03
M02_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      qword ptr [7FFF8F55B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       xor       edi,edi
       test      dword ptr [rax+34],200000
       setne     dil
       jmp       short M02_L03
M02_L02:
       mov       edx,[rbp-18]
       movsx     rdx,dx
       mov       rcx,rsi
       mov       r11,7FFF8F3B0800
       call      qword ptr [r11]
       xor       edi,edi
       cmp       eax,2
       sete      dil
M02_L03:
       test      edi,edi
       je        short M02_L05
       call      qword ptr [7FFF8FCCFE70]
       mov       rsi,rax
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD270]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F785870]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,rsi
       mov       r11,7FFF8F3B07F0
       call      qword ptr [r11]
       nop
M02_L05:
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+18],0
       je        short M02_L06
       call      CORINFO_HELP_RETHROW
M02_L06:
       lea       rax,[M02_L05]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 317
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJson()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.String)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L02
       cmp       dword ptr [rdx+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,767
       mov       rdx,7FFF91103BD8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF913C5B38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 154
```
```assembly
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJson()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       test      rcx,rcx
       je        short M00_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       edx,edx
M00_L01:
       test      edx,edx
       jne       near ptr M00_L02
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,767
       mov       rdx,7FFF8F948578
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FFF8FC57960]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC57B88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M01_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M01_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L02
M01_L01:
       xor       r9d,r9d
M01_L02:
       test      r8,r8
       je        short M01_L03
       cmp       dword ptr [r8+8],0
       je        short M01_L03
       mov       rcx,r8
       jmp       near ptr M01_L06
M01_L03:
       test      r9d,r9d
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F99D498]
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rsi,rdi
M01_L05:
       mov       ecx,536
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       test      dl,dl
       jne       short M01_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx-1]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       mov       ecx,ecx
       mov       rax,7FFFEE55D860
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF8FC5DB88]
       test      eax,eax
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        near ptr M02_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M02_L10
       test      r14d,r14d
       jl        short M02_L07
       test      r15d,r15d
       jl        short M02_L07
       cmp       ebx,r14d
       jle       short M02_L07
M02_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       mov       ecx,ecx
       mov       rax,7FFFEE55D860
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF8FC5DB88]
       test      eax,eax
       je        short M02_L10
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
       jmp       short M02_L10
M02_L07:
       cmp       r14d,ebx
       jae       short M02_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L08
       mov       ecx,ecx
       mov       rax,7FFFEE55D860
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF8FC5DB88]
       test      eax,eax
       je        short M02_L10
M02_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L07
M02_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M02_L12
       mov       rax,rsi
M02_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L12:
       test      r8d,r8d
       je        short M02_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFF8F5D3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,14EBE800030
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F993150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF8F993330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M03_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M03_L01
       jmp       short M03_L01
M03_L00:
       xor       edx,edx
M03_L01:
       test      edx,edx
       jne       near ptr M03_L02
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,0B50
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,536
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFF8FC44830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFF8FC579C0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
```
```assembly
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

