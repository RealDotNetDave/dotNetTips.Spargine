## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1FE637D9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 240
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       sub       rsp,50
       sub       rsp,50
       lea       rbp,[rsp+50]
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-18]
M01_L01:
       mov       rcx,[rbp-18]
       mov       rdx,7FF9C7D21218
       mov       rdx,7FF9C7D21218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rdx,[rbp-28]
       mov       rdx,[rbp-28]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,50
       add       rsp,50
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 450
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M02_L00
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M03_L00
; Total bytes of code 106
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9C7C177E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9C7C179A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
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
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+0A0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L48
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L49
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L20
M06_L00:
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       lea       edx,[rax-1]
       test      edx,edx
       jl        near ptr M06_L19
M06_L01:
       cmp       edx,eax
       jae       near ptr M06_L55
       mov       [rsp+44],edx
       movsxd    rcx,edx
       mov       r8,[rsi+rcx*8+10]
       mov       [rsp+28],r8
       test      r8,r8
       je        near ptr M06_L50
       mov       ecx,[r8+34]
       test      ecx,1600000
       setne     r9b
       movzx     r9d,r9b
       mov       [rsp+40],r9d
       test      r9d,r9d
       jne       near ptr M06_L13
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0A0],0
       je        near ptr M06_L06
M06_L02:
       mov       [rsp+30],eax
       mov       [rsp+3C],eax
       test      rbp,rbp
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+3C]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L03:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L05
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L04:
       mov       rdx,1FE637D9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L03
M06_L05:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L06:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rcx,r8
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L07
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       jmp       short M06_L08
M06_L07:
       xor       ecx,ecx
M06_L08:
       movzx     r9d,cl
       mov       edx,r9d
       mov       [rsp+40],edx
       test      edx,edx
       jne       near ptr M06_L10
       mov       r8d,[rsp+30]
       mov       [rsp+38],r8d
       test      rbp,rbp
       jne       short M06_L09
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+38]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L11
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L09:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L12
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L10:
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L11:
       mov       rdx,1FE637D9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L09
M06_L12:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L13:
       cmp       dword ptr [rsp+40],0
       je        near ptr M06_L18
       mov       r8,[rsp+28]
       test      dword ptr [r8+34],200000
       je        short M06_L14
       mov       r15d,1
       jmp       short M06_L15
M06_L14:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L15
       mov       r12d,1
M06_L15:
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L18
       test      r14,r14
       jne       short M06_L16
       mov       [rsp+30],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+30]
M06_L16:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L17
       mov       [rsp+30],eax
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L18
M06_L17:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L18:
       mov       edx,[rsp+44]
       dec       edx
       test      edx,edx
       jge       near ptr M06_L01
M06_L19:
       test      rbp,rbp
       je        near ptr M06_L31
       mov       [rsp+30],eax
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0A0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L30
       mov       edi,[rbp+14]
       xor       ecx,ecx
       jmp       short M06_L22
M06_L20:
       mov       rcx,[rsp+0A0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L52
       jmp       near ptr M06_L00
M06_L21:
       mov       [rsp+34],ecx
       mov       rcx,r8
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       ecx,[rsp+34]
M06_L22:
       mov       rax,rbp
       cmp       edi,[rax+14]
       jne       near ptr M06_L33
       cmp       ecx,[rbp+10]
       jae       near ptr M06_L34
       jmp       near ptr M06_L28
       mov       [rsp+30],edi
       mov       ecx,edx
       mov       edi,r13d
       mov       r13d,eax
       jmp       short M06_L22
M06_L23:
       test      dword ptr [rax+34],200000
       je        short M06_L24
       mov       r15d,1
       jmp       short M06_L25
M06_L24:
       mov       edx,[rax+34]
       and       edx,600000
       cmp       edx,400000
       jne       short M06_L25
       mov       r12d,1
M06_L25:
       test      dword ptr [rax+34],10000000
       mov       [rsp+20],rax
       mov       ecx,[rsp+34]
       je        short M06_L22
       test      r14,r14
       jne       short M06_L27
       mov       [rsp+34],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+20]
       mov       ecx,[rsp+34]
M06_L26:
       mov       r8,r14
       inc       dword ptr [r8+14]
       mov       r9,[r8+8]
       mov       edx,[r8+10]
       cmp       [r9+8],edx
       jbe       near ptr M06_L21
       mov       [rsp+34],ecx
       lea       r10d,[rdx+1]
       mov       [r8+10],r10d
       mov       rcx,r9
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+34]
       jmp       near ptr M06_L22
M06_L27:
       mov       rax,[rsp+20]
       jmp       short M06_L26
M06_L28:
       mov       rax,[rbp+8]
       cmp       ecx,[rax+8]
       jae       near ptr M06_L55
       movsxd    rdx,ecx
       mov       rax,[rax+rdx*8+10]
       inc       ecx
       mov       [rsp+34],ecx
       mov       edx,1
M06_L29:
       test      edx,edx
       jne       near ptr M06_L23
M06_L30:
       mov       eax,[rsp+30]
M06_L31:
       test      r13d,r13d
       je        near ptr M06_L47
       test      r14,r14
       je        short M06_L32
       mov       edi,[r14+14]
       xor       ebp,ebp
       jmp       short M06_L36
M06_L32:
       mov       [rsp+30],eax
       jmp       short M06_L38
M06_L33:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L53
M06_L34:
       mov       ecx,[rbp+10]
       inc       ecx
       mov       edx,ecx
       xor       ecx,ecx
       xor       r8d,r8d
       mov       [rsp+34],edx
       mov       rax,rcx
       mov       edx,r8d
       jmp       short M06_L29
M06_L35:
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L38
       mov       eax,[rsp+30]
M06_L36:
       mov       rcx,r14
       cmp       edi,[rcx+14]
       jne       near ptr M06_L45
       cmp       ebp,[r14+10]
       jae       near ptr M06_L46
       mov       rcx,[r14+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M06_L55
       movsxd    rdx,ebp
       mov       rcx,[rcx+rdx*8+10]
       inc       ebp
       mov       edx,1
M06_L37:
       test      edx,edx
       mov       [rsp+30],eax
       jne       short M06_L35
M06_L38:
       or        r12d,r15d
       je        near ptr M06_L47
       test      r15d,r15d
       jne       short M06_L39
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L44
M06_L39:
       xor       edi,edi
       mov       r12d,[rsp+30]
       test      r12d,r12d
       jle       near ptr M06_L51
M06_L40:
       cmp       edi,r12d
       jae       near ptr M06_L55
       movsxd    rcx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,1
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.GetExceptions(Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M06_L42
       mov       rcx,r14
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.UpdateExceptionObservedStatus()
       test      rbx,rbx
       jne       short M06_L41
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rbp+78]
       mov       edx,[rdx+8]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L43
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L41:
       mov       r8,[rbp+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
M06_L42:
       inc       edi
       cmp       r12d,edi
       jle       near ptr M06_L51
       jmp       near ptr M06_L40
M06_L43:
       mov       rcx,7FF9C76E4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1FE637D9280
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L41
M06_L44:
       mov       rax,[rsp+0A0]
       cmp       dword ptr [rax+20],0
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M06_L39
       jmp       short M06_L52
M06_L45:
       cmp       edi,[r14+14]
       jne       short M06_L53
M06_L46:
       mov       ebp,[r14+10]
       inc       ebp
       xor       ecx,ecx
       xor       edx,edx
       jmp       near ptr M06_L37
M06_L47:
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L48:
       mov       ecx,33
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L49:
       mov       ecx,3C
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L50:
       mov       ecx,2C
       mov       edx,33
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L51:
       mov       rcx,rbx
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L52:
       lea       rcx,[rsp+0A0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L53:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M06_L54:
       mov       ecx,16
       mov       edx,0B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M06_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1721
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       jmp       short M07_L03
       jmp       short M07_L03
M07_L03:
       mov       rcx,rsp
M07_L03:
       mov       rcx,rsp
       call      M07_L04
       call      M07_L04
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L04:
       push      rbp
M07_L04:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L05
       je        short M07_L05
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L05:
       nop
M07_L05:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 512
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CE55B0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1B8D98082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9CE0A5E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9CE0A5E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CDF07A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CDF07A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FF9CDF07F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE02B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FF9CE55B168]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 254
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE099F50],0
       cmp       dword ptr [7FF9CE099F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF9CDD61030]; System.Object..ctor()
       call      qword ptr [7FF9CDD61030]; System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9CDD61030]; System.Object..ctor()
       call      qword ptr [7FF9CDD61030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-20]
M01_L01:
       mov       rcx,[rbp-20]
       mov       rdx,7FF9CE54EF90
       mov       rdx,7FF9CE54EF90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-28],rax
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-30],rcx
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9CE55B210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FF9CE55B210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-38]
       mov       rdx,[rbp-38]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 460
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CE55F3A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CE55F138]
       jmp       short M02_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CE585798]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CE55F138]
       jmp       short M03_L00
; Total bytes of code 108
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       short M04_L03
       mov       ecx,4
M04_L00:
       cmp       ecx,7FFFFFC7
       ja        short M04_L05
M04_L01:
       cmp       ecx,edx
       mov       [rsp+24],ecx
       jl        short M04_L04
M04_L02:
       mov       rcx,rsi
       mov       edx,[rsp+24]
       call      qword ptr [7FF9CDF07960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       movsxd    rdx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       short M04_L00
M04_L04:
       mov       [rsp+24],edx
       jmp       short M04_L02
M04_L05:
       mov       eax,7FFFFFC7
       mov       ecx,eax
       jmp       short M04_L01
; Total bytes of code 120
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+68]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9CE5B0858
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9CE5B0868
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      qword ptr [7FF9CDD69018]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+58],xmm4
       xor       eax,eax
       mov       [rsp+68],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L55
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L56
       cmp       qword ptr [rsp+0D0],0
       jne       near ptr M06_L47
M06_L00:
       xor       ebx,ebx
       mov       [rsp+40],rbx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       mov       [rsp+48],eax
       lea       edx,[rax-1]
       test      edx,edx
       jl        short M06_L04
       cmp       eax,edx
       jle       near ptr M06_L17
M06_L01:
       mov       [rsp+74],edx
       mov       ecx,edx
       mov       r8,[rsi+rcx*8+10]
       test      r8,r8
       je        near ptr M06_L18
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L05
M06_L02:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L57
M06_L03:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L01
M06_L04:
       test      rbp,rbp
       je        near ptr M06_L35
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF9CE02B090]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L34
       mov       edi,[rbp+14]
       xor       eax,eax
       jmp       near ptr M06_L14
M06_L05:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L15
M06_L06:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L09
M06_L07:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       jbe       near ptr M06_L16
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L08:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L42
       jmp       short M06_L11
M06_L09:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       je        short M06_L13
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L10:
       jmp       near ptr M06_L07
M06_L11:
       mov       eax,[rbp+10]
       inc       eax
       mov       r8d,eax
       xor       edx,edx
       xor       ecx,ecx
       mov       eax,r8d
M06_L12:
       test      ecx,ecx
       jne       near ptr M06_L32
       jmp       near ptr M06_L34
M06_L13:
       mov       rdx,1B8D98082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L10
M06_L14:
       mov       rcx,rbp
       cmp       edi,[rcx+14]
       jne       near ptr M06_L08
       cmp       eax,[rbp+10]
       jae       short M06_L11
       mov       rcx,[rbp+8]
       cmp       eax,[rcx+8]
       jae       near ptr M06_L85
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       inc       eax
       mov       ecx,1
       jmp       short M06_L12
M06_L15:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L58
       jmp       near ptr M06_L06
M06_L16:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CDF07A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L17:
       cmp       edx,eax
       jae       near ptr M06_L85
       mov       [rsp+74],edx
       mov       r8d,edx
       mov       r8,[rsi+r8*8+10]
       test      r8,r8
       jne       short M06_L19
M06_L18:
       mov       ecx,2E
       mov       edx,33
       call      qword ptr [7FF9CE057768]
       int       3
M06_L19:
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L22
M06_L20:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L68
M06_L21:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L17
       jmp       near ptr M06_L04
M06_L22:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L31
M06_L23:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L26
M06_L24:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       ja        short M06_L25
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CDF07A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L25:
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L26:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jge       short M06_L28
M06_L27:
       mov       ecx,16
       mov       edx,0C
       call      qword ptr [7FF9CE0577F8]
       int       3
M06_L28:
       test      eax,eax
       je        short M06_L30
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L29:
       jmp       near ptr M06_L24
M06_L30:
       mov       rdx,1B8D98082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L29
M06_L31:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L69
       jmp       near ptr M06_L23
M06_L32:
       mov       [rsp+30],rdx
       test      dword ptr [rdx+34],200000
       jne       near ptr M06_L79
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M06_L80
M06_L33:
       test      dword ptr [rdx+34],10000000
       jne       near ptr M06_L81
       jmp       near ptr M06_L14
M06_L34:
       mov       eax,[rsp+48]
M06_L35:
       test      r13d,r13d
       je        short M06_L37
       test      r14,r14
       jne       near ptr M06_L84
M06_L36:
       or        r12d,r15d
       jne       near ptr M06_L45
M06_L37:
       mov       eax,r13d
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L38:
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE029270]
       test      eax,eax
       jne       short M06_L40
M06_L39:
       mov       rax,[rsp+58]
       mov       edx,[rsp+6C]
       cmp       edx,[rax+14]
       jne       short M06_L41
       mov       edx,[rsp+68]
       cmp       edx,[rax+10]
       jae       short M06_L43
       mov       rax,[rax+8]
       mov       edx,[rax+8]
       cmp       [rsp+68],edx
       jae       near ptr M06_L85
       mov       edx,[rsp+68]
       mov       rax,[rax+rdx*8+10]
       mov       [rsp+60],rax
       mov       eax,[rsp+68]
       inc       eax
       mov       [rsp+68],eax
       mov       edi,1
       jmp       short M06_L44
M06_L40:
       mov       eax,[rsp+48]
       jmp       short M06_L36
M06_L41:
       mov       eax,[rsp+6C]
       mov       rdx,[rsp+58]
       cmp       eax,[rdx+14]
       je        short M06_L43
M06_L42:
       call      qword ptr [7FF9CE057A80]
       int       3
M06_L43:
       mov       rcx,[rsp+58]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rsp+68],ecx
       xor       ecx,ecx
       mov       [rsp+60],rcx
       xor       edi,edi
M06_L44:
       test      edi,edi
       jne       near ptr M06_L38
       mov       eax,[rsp+48]
       jmp       near ptr M06_L36
M06_L45:
       test      r15d,r15d
       jne       short M06_L48
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE02B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE02B720]
       int       3
M06_L47:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       je        near ptr M06_L00
       jmp       short M06_L46
M06_L48:
       xor       r15d,r15d
       jmp       near ptr M06_L54
M06_L49:
       cmp       r15d,eax
       jae       near ptr M06_L85
       mov       ecx,r15d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       mov       edx,1
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE029720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE0297B0]
       mov       rbx,[rsp+40]
       test      rbx,rbx
       jne       short M06_L52
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r13+78]
       mov       edi,[rcx+8]
       test      edi,edi
       jl        near ptr M06_L27
       test      edi,edi
       jne       short M06_L51
       mov       rcx,7FF9CDD54C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1B8D98082C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L52
M06_L50:
       mov       rbx,[rsp+40]
       jmp       short M06_L53
M06_L51:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L52:
       mov       r8,[r13+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      qword ptr [7FF9CDF07E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FF9CE0579D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FF9CE0577B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FF9CE0577E0]
       int       3
M06_L57:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L64
       mov       r15d,1
       jmp       near ptr M06_L65
M06_L58:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE029AB0]
       test      eax,eax
       je        short M06_L59
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L60
M06_L59:
       xor       edx,edx
M06_L60:
       movzx     r9d,dl
       mov       r8d,r9d
       mov       [rsp+70],r8d
       test      r8d,r8d
       mov       eax,[rsp+48]
       jne       near ptr M06_L02
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L62
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L61
       mov       rdx,1B8D98082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L62
M06_L61:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L62:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L63
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L63:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CDF07A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L64:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L65
       mov       r12d,1
M06_L65:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L03
       test      r14,r14
       jne       short M06_L66
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L66:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L67
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L67:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CDF07A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L68:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L75
       mov       r15d,1
       jmp       near ptr M06_L76
M06_L69:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE029AB0]
       test      eax,eax
       je        short M06_L70
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L71
M06_L70:
       xor       edx,edx
M06_L71:
       movzx     r9d,dl
       mov       edx,r9d
       mov       [rsp+70],edx
       test      edx,edx
       mov       eax,[rsp+48]
       jne       near ptr M06_L20
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L73
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L72
       mov       rdx,1B8D98082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L73
M06_L72:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L73:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L74
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L74:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CDF07A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L75:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L76
       mov       r12d,1
M06_L76:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L21
       test      r14,r14
       jne       short M06_L77
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L77:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L78
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L78:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CDF07A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L79:
       mov       r15d,1
       jmp       near ptr M06_L33
M06_L80:
       mov       r12d,1
       jmp       near ptr M06_L33
M06_L81:
       test      r14,r14
       jne       short M06_L82
       mov       [rsp+4C],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+4C]
M06_L82:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L83
       mov       [rsp+4C],eax
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r9d
       mov       rcx,r8
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L83:
       mov       [rsp+4C],eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FF9CDF07A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9CDF07D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE099F50],0
       cmp       dword ptr [7FF9CE099F50],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9CDE89018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FF9CDE89018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE55B3C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CE55B3C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE55B3C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CE55B3C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1E4C7369270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 240
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       sub       rsp,50
       sub       rsp,50
       lea       rbp,[rsp+50]
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7876D08],0
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-18]
M01_L01:
       mov       rcx,[rbp-18]
       mov       rdx,7FF9C7D01218
       mov       rdx,7FF9C7D01218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rdx,[rbp-28]
       mov       rdx,[rbp-28]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,50
       add       rsp,50
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 450
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M02_L00
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M03_L00
; Total bytes of code 106
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9C7BF78C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9C7BF78D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
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
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+0A0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L48
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L49
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L20
M06_L00:
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       lea       edx,[rax-1]
       test      edx,edx
       jl        near ptr M06_L19
M06_L01:
       cmp       edx,eax
       jae       near ptr M06_L55
       mov       [rsp+44],edx
       movsxd    rcx,edx
       mov       r8,[rsi+rcx*8+10]
       mov       [rsp+28],r8
       test      r8,r8
       je        near ptr M06_L50
       mov       ecx,[r8+34]
       test      ecx,1600000
       setne     r9b
       movzx     r9d,r9b
       mov       [rsp+40],r9d
       test      r9d,r9d
       jne       near ptr M06_L13
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0A0],0
       je        near ptr M06_L06
M06_L02:
       mov       [rsp+30],eax
       mov       [rsp+3C],eax
       test      rbp,rbp
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+3C]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L03:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L05
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L04:
       mov       rdx,1E4C7369270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L03
M06_L05:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L06:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rcx,r8
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L07
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       jmp       short M06_L08
M06_L07:
       xor       ecx,ecx
M06_L08:
       movzx     r9d,cl
       mov       edx,r9d
       mov       [rsp+40],edx
       test      edx,edx
       jne       near ptr M06_L10
       mov       r8d,[rsp+30]
       mov       [rsp+38],r8d
       test      rbp,rbp
       jne       short M06_L09
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+38]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L11
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L09:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L12
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L10:
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L11:
       mov       rdx,1E4C7369270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L09
M06_L12:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L13:
       cmp       dword ptr [rsp+40],0
       je        near ptr M06_L18
       mov       r8,[rsp+28]
       test      dword ptr [r8+34],200000
       je        short M06_L14
       mov       r15d,1
       jmp       short M06_L15
M06_L14:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L15
       mov       r12d,1
M06_L15:
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L18
       test      r14,r14
       jne       short M06_L16
       mov       [rsp+30],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+30]
M06_L16:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L17
       mov       [rsp+30],eax
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L18
M06_L17:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L18:
       mov       edx,[rsp+44]
       dec       edx
       test      edx,edx
       jge       near ptr M06_L01
M06_L19:
       test      rbp,rbp
       je        near ptr M06_L31
       mov       [rsp+30],eax
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0A0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L30
       mov       edi,[rbp+14]
       xor       ecx,ecx
       jmp       short M06_L22
M06_L20:
       mov       rcx,[rsp+0A0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L52
       jmp       near ptr M06_L00
M06_L21:
       mov       [rsp+34],ecx
       mov       rcx,r8
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       ecx,[rsp+34]
M06_L22:
       mov       rax,rbp
       cmp       edi,[rax+14]
       jne       near ptr M06_L33
       cmp       ecx,[rbp+10]
       jae       near ptr M06_L34
       jmp       near ptr M06_L28
       mov       [rsp+30],edi
       mov       ecx,edx
       mov       edi,r13d
       mov       r13d,eax
       jmp       short M06_L22
M06_L23:
       test      dword ptr [rax+34],200000
       je        short M06_L24
       mov       r15d,1
       jmp       short M06_L25
M06_L24:
       mov       edx,[rax+34]
       and       edx,600000
       cmp       edx,400000
       jne       short M06_L25
       mov       r12d,1
M06_L25:
       test      dword ptr [rax+34],10000000
       mov       [rsp+20],rax
       mov       ecx,[rsp+34]
       je        short M06_L22
       test      r14,r14
       jne       short M06_L27
       mov       [rsp+34],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+20]
       mov       ecx,[rsp+34]
M06_L26:
       mov       r8,r14
       inc       dword ptr [r8+14]
       mov       r9,[r8+8]
       mov       edx,[r8+10]
       cmp       [r9+8],edx
       jbe       near ptr M06_L21
       mov       [rsp+34],ecx
       lea       r10d,[rdx+1]
       mov       [r8+10],r10d
       mov       rcx,r9
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+34]
       jmp       near ptr M06_L22
M06_L27:
       mov       rax,[rsp+20]
       jmp       short M06_L26
M06_L28:
       mov       rax,[rbp+8]
       cmp       ecx,[rax+8]
       jae       near ptr M06_L55
       movsxd    rdx,ecx
       mov       rax,[rax+rdx*8+10]
       inc       ecx
       mov       [rsp+34],ecx
       mov       edx,1
M06_L29:
       test      edx,edx
       jne       near ptr M06_L23
M06_L30:
       mov       eax,[rsp+30]
M06_L31:
       test      r13d,r13d
       je        near ptr M06_L47
       test      r14,r14
       je        short M06_L32
       mov       edi,[r14+14]
       xor       ebp,ebp
       jmp       short M06_L36
M06_L32:
       mov       [rsp+30],eax
       jmp       short M06_L38
M06_L33:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L53
M06_L34:
       mov       ecx,[rbp+10]
       inc       ecx
       mov       edx,ecx
       xor       ecx,ecx
       xor       r8d,r8d
       mov       [rsp+34],edx
       mov       rax,rcx
       mov       edx,r8d
       jmp       short M06_L29
M06_L35:
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L38
       mov       eax,[rsp+30]
M06_L36:
       mov       rcx,r14
       cmp       edi,[rcx+14]
       jne       near ptr M06_L45
       cmp       ebp,[r14+10]
       jae       near ptr M06_L46
       mov       rcx,[r14+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M06_L55
       movsxd    rdx,ebp
       mov       rcx,[rcx+rdx*8+10]
       inc       ebp
       mov       edx,1
M06_L37:
       test      edx,edx
       mov       [rsp+30],eax
       jne       short M06_L35
M06_L38:
       or        r12d,r15d
       je        near ptr M06_L47
       test      r15d,r15d
       jne       short M06_L39
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L44
M06_L39:
       xor       edi,edi
       mov       r12d,[rsp+30]
       test      r12d,r12d
       jle       near ptr M06_L51
M06_L40:
       cmp       edi,r12d
       jae       near ptr M06_L55
       movsxd    rcx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,1
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.GetExceptions(Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M06_L42
       mov       rcx,r14
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.UpdateExceptionObservedStatus()
       test      rbx,rbx
       jne       short M06_L41
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rbp+78]
       mov       edx,[rdx+8]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L43
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L41:
       mov       r8,[rbp+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
M06_L42:
       inc       edi
       cmp       r12d,edi
       jle       near ptr M06_L51
       jmp       near ptr M06_L40
M06_L43:
       mov       rcx,7FF9C76C4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1E4C7369280
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L41
M06_L44:
       mov       rax,[rsp+0A0]
       cmp       dword ptr [rax+20],0
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M06_L39
       jmp       short M06_L52
M06_L45:
       cmp       edi,[r14+14]
       jne       short M06_L53
M06_L46:
       mov       ebp,[r14+10]
       inc       ebp
       xor       ecx,ecx
       xor       edx,edx
       jmp       near ptr M06_L37
M06_L47:
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L48:
       mov       ecx,33
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L49:
       mov       ecx,3C
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L50:
       mov       ecx,2C
       mov       edx,33
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L51:
       mov       rcx,rbx
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L52:
       lea       rcx,[rsp+0A0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L53:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M06_L54:
       mov       ecx,16
       mov       edx,0B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M06_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1721
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7876D08],0
       cmp       dword ptr [7FF9C7876D08],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       jmp       short M07_L03
       jmp       short M07_L03
M07_L03:
       mov       rcx,rsp
M07_L03:
       mov       rcx,rsp
       call      M07_L04
       call      M07_L04
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L04:
       push      rbp
M07_L04:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L05
       je        short M07_L05
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L05:
       nop
M07_L05:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 512
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CEE3B3C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1C2614082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9CE995E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9CE995E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FF9CE7F7F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE91B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FF9CEE3B468]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 254
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE989F50],0
       cmp       dword ptr [7FF9CE989F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF9CE651030]; System.Object..ctor()
       call      qword ptr [7FF9CE651030]; System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9CE651030]; System.Object..ctor()
       call      qword ptr [7FF9CE651030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-20]
M01_L01:
       mov       rcx,[rbp-20]
       mov       rdx,7FF9CEE1F998
       mov       rdx,7FF9CEE1F998
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-28],rax
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-30],rcx
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9CEE3B510]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FF9CEE3B510]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-38]
       mov       rdx,[rbp-38]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 460
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE3F888]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEE3F618]
       jmp       short M02_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE65CD8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEE3F618]
       jmp       short M03_L00
; Total bytes of code 108
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       short M04_L03
       mov       ecx,4
M04_L00:
       cmp       ecx,7FFFFFC7
       ja        short M04_L05
M04_L01:
       cmp       ecx,edx
       mov       [rsp+24],ecx
       jl        short M04_L04
M04_L02:
       mov       rcx,rsi
       mov       edx,[rsp+24]
       call      qword ptr [7FF9CE7F7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       movsxd    rdx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       short M04_L00
M04_L04:
       mov       [rsp+24],edx
       jmp       short M04_L02
M04_L05:
       mov       eax,7FFFFFC7
       mov       ecx,eax
       jmp       short M04_L01
; Total bytes of code 120
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+68]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9CEEA1468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9CEEA1478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      qword ptr [7FF9CE659018]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+58],xmm4
       xor       eax,eax
       mov       [rsp+68],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L55
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L56
       cmp       qword ptr [rsp+0D0],0
       jne       near ptr M06_L47
M06_L00:
       xor       ebx,ebx
       mov       [rsp+40],rbx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       mov       [rsp+48],eax
       lea       edx,[rax-1]
       test      edx,edx
       jl        short M06_L04
       cmp       eax,edx
       jle       near ptr M06_L17
M06_L01:
       mov       [rsp+74],edx
       mov       ecx,edx
       mov       r8,[rsi+rcx*8+10]
       test      r8,r8
       je        near ptr M06_L18
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L05
M06_L02:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L57
M06_L03:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L01
M06_L04:
       test      rbp,rbp
       je        near ptr M06_L35
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF9CE91B090]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L34
       mov       edi,[rbp+14]
       xor       eax,eax
       jmp       near ptr M06_L14
M06_L05:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L15
M06_L06:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L09
M06_L07:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       jbe       near ptr M06_L16
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L08:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L42
       jmp       short M06_L11
M06_L09:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       je        short M06_L13
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L10:
       jmp       near ptr M06_L07
M06_L11:
       mov       eax,[rbp+10]
       inc       eax
       mov       r8d,eax
       xor       edx,edx
       xor       ecx,ecx
       mov       eax,r8d
M06_L12:
       test      ecx,ecx
       jne       near ptr M06_L32
       jmp       near ptr M06_L34
M06_L13:
       mov       rdx,1C2614082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L10
M06_L14:
       mov       rcx,rbp
       cmp       edi,[rcx+14]
       jne       near ptr M06_L08
       cmp       eax,[rbp+10]
       jae       short M06_L11
       mov       rcx,[rbp+8]
       cmp       eax,[rcx+8]
       jae       near ptr M06_L85
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       inc       eax
       mov       ecx,1
       jmp       short M06_L12
M06_L15:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L58
       jmp       near ptr M06_L06
M06_L16:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L17:
       cmp       edx,eax
       jae       near ptr M06_L85
       mov       [rsp+74],edx
       mov       r8d,edx
       mov       r8,[rsi+r8*8+10]
       test      r8,r8
       jne       short M06_L19
M06_L18:
       mov       ecx,2E
       mov       edx,33
       call      qword ptr [7FF9CE947768]
       int       3
M06_L19:
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L22
M06_L20:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L68
M06_L21:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L17
       jmp       near ptr M06_L04
M06_L22:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L31
M06_L23:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L26
M06_L24:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       ja        short M06_L25
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L25:
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L26:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jge       short M06_L28
M06_L27:
       mov       ecx,16
       mov       edx,0C
       call      qword ptr [7FF9CE9477F8]
       int       3
M06_L28:
       test      eax,eax
       je        short M06_L30
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L29:
       jmp       near ptr M06_L24
M06_L30:
       mov       rdx,1C2614082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L29
M06_L31:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L69
       jmp       near ptr M06_L23
M06_L32:
       mov       [rsp+30],rdx
       test      dword ptr [rdx+34],200000
       jne       near ptr M06_L79
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M06_L80
M06_L33:
       test      dword ptr [rdx+34],10000000
       jne       near ptr M06_L81
       jmp       near ptr M06_L14
M06_L34:
       mov       eax,[rsp+48]
M06_L35:
       test      r13d,r13d
       je        short M06_L37
       test      r14,r14
       jne       near ptr M06_L84
M06_L36:
       or        r12d,r15d
       jne       near ptr M06_L45
M06_L37:
       mov       eax,r13d
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L38:
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE919270]
       test      eax,eax
       jne       short M06_L40
M06_L39:
       mov       rax,[rsp+58]
       mov       edx,[rsp+6C]
       cmp       edx,[rax+14]
       jne       short M06_L41
       mov       edx,[rsp+68]
       cmp       edx,[rax+10]
       jae       short M06_L43
       mov       rax,[rax+8]
       mov       edx,[rax+8]
       cmp       [rsp+68],edx
       jae       near ptr M06_L85
       mov       edx,[rsp+68]
       mov       rax,[rax+rdx*8+10]
       mov       [rsp+60],rax
       mov       eax,[rsp+68]
       inc       eax
       mov       [rsp+68],eax
       mov       edi,1
       jmp       short M06_L44
M06_L40:
       mov       eax,[rsp+48]
       jmp       short M06_L36
M06_L41:
       mov       eax,[rsp+6C]
       mov       rdx,[rsp+58]
       cmp       eax,[rdx+14]
       je        short M06_L43
M06_L42:
       call      qword ptr [7FF9CE947A80]
       int       3
M06_L43:
       mov       rcx,[rsp+58]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rsp+68],ecx
       xor       ecx,ecx
       mov       [rsp+60],rcx
       xor       edi,edi
M06_L44:
       test      edi,edi
       jne       near ptr M06_L38
       mov       eax,[rsp+48]
       jmp       near ptr M06_L36
M06_L45:
       test      r15d,r15d
       jne       short M06_L48
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE91B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE91B720]
       int       3
M06_L47:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       je        near ptr M06_L00
       jmp       short M06_L46
M06_L48:
       xor       r15d,r15d
       jmp       near ptr M06_L54
M06_L49:
       cmp       r15d,eax
       jae       near ptr M06_L85
       mov       ecx,r15d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       mov       edx,1
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE919720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE9197B0]
       mov       rbx,[rsp+40]
       test      rbx,rbx
       jne       short M06_L52
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r13+78]
       mov       edi,[rcx+8]
       test      edi,edi
       jl        near ptr M06_L27
       test      edi,edi
       jne       short M06_L51
       mov       rcx,7FF9CE644C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1C2614082C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L52
M06_L50:
       mov       rbx,[rsp+40]
       jmp       short M06_L53
M06_L51:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L52:
       mov       r8,[r13+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      qword ptr [7FF9CE7F7E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FF9CE9479D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FF9CE9477B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FF9CE9477E0]
       int       3
M06_L57:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L64
       mov       r15d,1
       jmp       near ptr M06_L65
M06_L58:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE919AB0]
       test      eax,eax
       je        short M06_L59
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L60
M06_L59:
       xor       edx,edx
M06_L60:
       movzx     r9d,dl
       mov       r8d,r9d
       mov       [rsp+70],r8d
       test      r8d,r8d
       mov       eax,[rsp+48]
       jne       near ptr M06_L02
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L62
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L61
       mov       rdx,1C2614082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L62
M06_L61:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L62:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L63
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L63:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L64:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L65
       mov       r12d,1
M06_L65:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L03
       test      r14,r14
       jne       short M06_L66
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L66:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L67
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L67:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L68:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L75
       mov       r15d,1
       jmp       near ptr M06_L76
M06_L69:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE919AB0]
       test      eax,eax
       je        short M06_L70
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L71
M06_L70:
       xor       edx,edx
M06_L71:
       movzx     r9d,dl
       mov       edx,r9d
       mov       [rsp+70],edx
       test      edx,edx
       mov       eax,[rsp+48]
       jne       near ptr M06_L20
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L73
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L72
       mov       rdx,1C2614082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L73
M06_L72:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L73:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L74
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L74:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L75:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L76
       mov       r12d,1
M06_L76:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L21
       test      r14,r14
       jne       short M06_L77
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L77:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L78
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L78:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L79:
       mov       r15d,1
       jmp       near ptr M06_L33
M06_L80:
       mov       r12d,1
       jmp       near ptr M06_L33
M06_L81:
       test      r14,r14
       jne       short M06_L82
       mov       [rsp+4C],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+4C]
M06_L82:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L83
       mov       [rsp+4C],eax
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r9d
       mov       rcx,r8
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L83:
       mov       [rsp+4C],eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7F7D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE989F50],0
       cmp       dword ptr [7FF9CE989F50],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9CE779018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FF9CE779018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE3B6C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEE3B6C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE3B6C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEE3B6C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2B6C6289270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 240
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       sub       rsp,50
       sub       rsp,50
       lea       rbp,[rsp+50]
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-18]
M01_L01:
       mov       rcx,[rbp-18]
       mov       rdx,7FF9C7D21218
       mov       rdx,7FF9C7D21218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rdx,[rbp-28]
       mov       rdx,[rbp-28]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,50
       add       rsp,50
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 450
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M02_L00
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M03_L00
; Total bytes of code 106
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9C7C177E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9C7C179A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
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
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+0A0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L48
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L49
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L20
M06_L00:
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       lea       edx,[rax-1]
       test      edx,edx
       jl        near ptr M06_L19
M06_L01:
       cmp       edx,eax
       jae       near ptr M06_L55
       mov       [rsp+44],edx
       movsxd    rcx,edx
       mov       r8,[rsi+rcx*8+10]
       mov       [rsp+28],r8
       test      r8,r8
       je        near ptr M06_L50
       mov       ecx,[r8+34]
       test      ecx,1600000
       setne     r9b
       movzx     r9d,r9b
       mov       [rsp+40],r9d
       test      r9d,r9d
       jne       near ptr M06_L13
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0A0],0
       je        near ptr M06_L06
M06_L02:
       mov       [rsp+30],eax
       mov       [rsp+3C],eax
       test      rbp,rbp
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+3C]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L03:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L05
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L04:
       mov       rdx,2B6C6289270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L03
M06_L05:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L06:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rcx,r8
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L07
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       jmp       short M06_L08
M06_L07:
       xor       ecx,ecx
M06_L08:
       movzx     r9d,cl
       mov       edx,r9d
       mov       [rsp+40],edx
       test      edx,edx
       jne       near ptr M06_L10
       mov       r8d,[rsp+30]
       mov       [rsp+38],r8d
       test      rbp,rbp
       jne       short M06_L09
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+38]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L11
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L09:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L12
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L10:
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L11:
       mov       rdx,2B6C6289270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L09
M06_L12:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L13:
       cmp       dword ptr [rsp+40],0
       je        near ptr M06_L18
       mov       r8,[rsp+28]
       test      dword ptr [r8+34],200000
       je        short M06_L14
       mov       r15d,1
       jmp       short M06_L15
M06_L14:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L15
       mov       r12d,1
M06_L15:
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L18
       test      r14,r14
       jne       short M06_L16
       mov       [rsp+30],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+30]
M06_L16:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L17
       mov       [rsp+30],eax
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L18
M06_L17:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L18:
       mov       edx,[rsp+44]
       dec       edx
       test      edx,edx
       jge       near ptr M06_L01
M06_L19:
       test      rbp,rbp
       je        near ptr M06_L31
       mov       [rsp+30],eax
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0A0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L30
       mov       edi,[rbp+14]
       xor       ecx,ecx
       jmp       short M06_L22
M06_L20:
       mov       rcx,[rsp+0A0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L52
       jmp       near ptr M06_L00
M06_L21:
       mov       [rsp+34],ecx
       mov       rcx,r8
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       ecx,[rsp+34]
M06_L22:
       mov       rax,rbp
       cmp       edi,[rax+14]
       jne       near ptr M06_L33
       cmp       ecx,[rbp+10]
       jae       near ptr M06_L34
       jmp       near ptr M06_L28
       mov       [rsp+30],edi
       mov       ecx,edx
       mov       edi,r13d
       mov       r13d,eax
       jmp       short M06_L22
M06_L23:
       test      dword ptr [rax+34],200000
       je        short M06_L24
       mov       r15d,1
       jmp       short M06_L25
M06_L24:
       mov       edx,[rax+34]
       and       edx,600000
       cmp       edx,400000
       jne       short M06_L25
       mov       r12d,1
M06_L25:
       test      dword ptr [rax+34],10000000
       mov       [rsp+20],rax
       mov       ecx,[rsp+34]
       je        short M06_L22
       test      r14,r14
       jne       short M06_L27
       mov       [rsp+34],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+20]
       mov       ecx,[rsp+34]
M06_L26:
       mov       r8,r14
       inc       dword ptr [r8+14]
       mov       r9,[r8+8]
       mov       edx,[r8+10]
       cmp       [r9+8],edx
       jbe       near ptr M06_L21
       mov       [rsp+34],ecx
       lea       r10d,[rdx+1]
       mov       [r8+10],r10d
       mov       rcx,r9
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+34]
       jmp       near ptr M06_L22
M06_L27:
       mov       rax,[rsp+20]
       jmp       short M06_L26
M06_L28:
       mov       rax,[rbp+8]
       cmp       ecx,[rax+8]
       jae       near ptr M06_L55
       movsxd    rdx,ecx
       mov       rax,[rax+rdx*8+10]
       inc       ecx
       mov       [rsp+34],ecx
       mov       edx,1
M06_L29:
       test      edx,edx
       jne       near ptr M06_L23
M06_L30:
       mov       eax,[rsp+30]
M06_L31:
       test      r13d,r13d
       je        near ptr M06_L47
       test      r14,r14
       je        short M06_L32
       mov       edi,[r14+14]
       xor       ebp,ebp
       jmp       short M06_L36
M06_L32:
       mov       [rsp+30],eax
       jmp       short M06_L38
M06_L33:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L53
M06_L34:
       mov       ecx,[rbp+10]
       inc       ecx
       mov       edx,ecx
       xor       ecx,ecx
       xor       r8d,r8d
       mov       [rsp+34],edx
       mov       rax,rcx
       mov       edx,r8d
       jmp       short M06_L29
M06_L35:
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L38
       mov       eax,[rsp+30]
M06_L36:
       mov       rcx,r14
       cmp       edi,[rcx+14]
       jne       near ptr M06_L45
       cmp       ebp,[r14+10]
       jae       near ptr M06_L46
       mov       rcx,[r14+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M06_L55
       movsxd    rdx,ebp
       mov       rcx,[rcx+rdx*8+10]
       inc       ebp
       mov       edx,1
M06_L37:
       test      edx,edx
       mov       [rsp+30],eax
       jne       short M06_L35
M06_L38:
       or        r12d,r15d
       je        near ptr M06_L47
       test      r15d,r15d
       jne       short M06_L39
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L44
M06_L39:
       xor       edi,edi
       mov       r12d,[rsp+30]
       test      r12d,r12d
       jle       near ptr M06_L51
M06_L40:
       cmp       edi,r12d
       jae       near ptr M06_L55
       movsxd    rcx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,1
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.GetExceptions(Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M06_L42
       mov       rcx,r14
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.UpdateExceptionObservedStatus()
       test      rbx,rbx
       jne       short M06_L41
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rbp+78]
       mov       edx,[rdx+8]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L43
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L41:
       mov       r8,[rbp+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
M06_L42:
       inc       edi
       cmp       r12d,edi
       jle       near ptr M06_L51
       jmp       near ptr M06_L40
M06_L43:
       mov       rcx,7FF9C76E4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2B6C6289280
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L41
M06_L44:
       mov       rax,[rsp+0A0]
       cmp       dword ptr [rax+20],0
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M06_L39
       jmp       short M06_L52
M06_L45:
       cmp       edi,[r14+14]
       jne       short M06_L53
M06_L46:
       mov       ebp,[r14+10]
       inc       ebp
       xor       ecx,ecx
       xor       edx,edx
       jmp       near ptr M06_L37
M06_L47:
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L48:
       mov       ecx,33
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L49:
       mov       ecx,3C
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L50:
       mov       ecx,2C
       mov       edx,33
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L51:
       mov       rcx,rbx
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L52:
       lea       rcx,[rsp+0A0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L53:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M06_L54:
       mov       ecx,16
       mov       edx,0B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M06_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1721
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       jmp       short M07_L03
       jmp       short M07_L03
M07_L03:
       mov       rcx,rsp
M07_L03:
       mov       rcx,rsp
       call      M07_L04
       call      M07_L04
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L04:
       push      rbp
M07_L04:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L05
       je        short M07_L05
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L05:
       nop
M07_L05:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 512
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CEE593C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,19A4F4082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9CE9B5E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9CE9B5E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE817A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE817A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FF9CE817F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE93B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FF9CEE59468]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 254
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE9A9F50],0
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF9CE671030]; System.Object..ctor()
       call      qword ptr [7FF9CE671030]; System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9CE671030]; System.Object..ctor()
       call      qword ptr [7FF9CE671030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-20]
M01_L01:
       mov       rcx,[rbp-20]
       mov       rdx,7FF9CEE723F8
       mov       rdx,7FF9CEE723F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-28],rax
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-30],rcx
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9CEE59510]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FF9CEE59510]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-38]
       mov       rdx,[rbp-38]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 460
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE5D888]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEE5D618]
       jmp       short M02_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE83CD8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEE5D618]
       jmp       short M03_L00
; Total bytes of code 108
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       short M04_L03
       mov       ecx,4
M04_L00:
       cmp       ecx,7FFFFFC7
       ja        short M04_L05
M04_L01:
       cmp       ecx,edx
       mov       [rsp+24],ecx
       jl        short M04_L04
M04_L02:
       mov       rcx,rsi
       mov       edx,[rsp+24]
       call      qword ptr [7FF9CE817960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       movsxd    rdx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       short M04_L00
M04_L04:
       mov       [rsp+24],edx
       jmp       short M04_L02
M04_L05:
       mov       eax,7FFFFFC7
       mov       ecx,eax
       jmp       short M04_L01
; Total bytes of code 120
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+68]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9CEEA3468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9CEEA3478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      qword ptr [7FF9CE679018]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+58],xmm4
       xor       eax,eax
       mov       [rsp+68],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L55
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L56
       cmp       qword ptr [rsp+0D0],0
       jne       near ptr M06_L47
M06_L00:
       xor       ebx,ebx
       mov       [rsp+40],rbx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       mov       [rsp+48],eax
       lea       edx,[rax-1]
       test      edx,edx
       jl        short M06_L04
       cmp       eax,edx
       jle       near ptr M06_L17
M06_L01:
       mov       [rsp+74],edx
       mov       ecx,edx
       mov       r8,[rsi+rcx*8+10]
       test      r8,r8
       je        near ptr M06_L18
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L05
M06_L02:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L57
M06_L03:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L01
M06_L04:
       test      rbp,rbp
       je        near ptr M06_L35
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF9CE93B090]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L34
       mov       edi,[rbp+14]
       xor       eax,eax
       jmp       near ptr M06_L14
M06_L05:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L15
M06_L06:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L09
M06_L07:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       jbe       near ptr M06_L16
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L08:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L42
       jmp       short M06_L11
M06_L09:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       je        short M06_L13
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L10:
       jmp       near ptr M06_L07
M06_L11:
       mov       eax,[rbp+10]
       inc       eax
       mov       r8d,eax
       xor       edx,edx
       xor       ecx,ecx
       mov       eax,r8d
M06_L12:
       test      ecx,ecx
       jne       near ptr M06_L32
       jmp       near ptr M06_L34
M06_L13:
       mov       rdx,19A4F4082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L10
M06_L14:
       mov       rcx,rbp
       cmp       edi,[rcx+14]
       jne       near ptr M06_L08
       cmp       eax,[rbp+10]
       jae       short M06_L11
       mov       rcx,[rbp+8]
       cmp       eax,[rcx+8]
       jae       near ptr M06_L85
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       inc       eax
       mov       ecx,1
       jmp       short M06_L12
M06_L15:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L58
       jmp       near ptr M06_L06
M06_L16:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE817A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L17:
       cmp       edx,eax
       jae       near ptr M06_L85
       mov       [rsp+74],edx
       mov       r8d,edx
       mov       r8,[rsi+r8*8+10]
       test      r8,r8
       jne       short M06_L19
M06_L18:
       mov       ecx,2E
       mov       edx,33
       call      qword ptr [7FF9CE967768]
       int       3
M06_L19:
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L22
M06_L20:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L68
M06_L21:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L17
       jmp       near ptr M06_L04
M06_L22:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L31
M06_L23:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L26
M06_L24:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       ja        short M06_L25
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE817A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L25:
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L26:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jge       short M06_L28
M06_L27:
       mov       ecx,16
       mov       edx,0C
       call      qword ptr [7FF9CE9677F8]
       int       3
M06_L28:
       test      eax,eax
       je        short M06_L30
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L29:
       jmp       near ptr M06_L24
M06_L30:
       mov       rdx,19A4F4082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L29
M06_L31:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L69
       jmp       near ptr M06_L23
M06_L32:
       mov       [rsp+30],rdx
       test      dword ptr [rdx+34],200000
       jne       near ptr M06_L79
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M06_L80
M06_L33:
       test      dword ptr [rdx+34],10000000
       jne       near ptr M06_L81
       jmp       near ptr M06_L14
M06_L34:
       mov       eax,[rsp+48]
M06_L35:
       test      r13d,r13d
       je        short M06_L37
       test      r14,r14
       jne       near ptr M06_L84
M06_L36:
       or        r12d,r15d
       jne       near ptr M06_L45
M06_L37:
       mov       eax,r13d
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L38:
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE939270]
       test      eax,eax
       jne       short M06_L40
M06_L39:
       mov       rax,[rsp+58]
       mov       edx,[rsp+6C]
       cmp       edx,[rax+14]
       jne       short M06_L41
       mov       edx,[rsp+68]
       cmp       edx,[rax+10]
       jae       short M06_L43
       mov       rax,[rax+8]
       mov       edx,[rax+8]
       cmp       [rsp+68],edx
       jae       near ptr M06_L85
       mov       edx,[rsp+68]
       mov       rax,[rax+rdx*8+10]
       mov       [rsp+60],rax
       mov       eax,[rsp+68]
       inc       eax
       mov       [rsp+68],eax
       mov       edi,1
       jmp       short M06_L44
M06_L40:
       mov       eax,[rsp+48]
       jmp       short M06_L36
M06_L41:
       mov       eax,[rsp+6C]
       mov       rdx,[rsp+58]
       cmp       eax,[rdx+14]
       je        short M06_L43
M06_L42:
       call      qword ptr [7FF9CE967A80]
       int       3
M06_L43:
       mov       rcx,[rsp+58]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rsp+68],ecx
       xor       ecx,ecx
       mov       [rsp+60],rcx
       xor       edi,edi
M06_L44:
       test      edi,edi
       jne       near ptr M06_L38
       mov       eax,[rsp+48]
       jmp       near ptr M06_L36
M06_L45:
       test      r15d,r15d
       jne       short M06_L48
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE93B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE93B720]
       int       3
M06_L47:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       je        near ptr M06_L00
       jmp       short M06_L46
M06_L48:
       xor       r15d,r15d
       jmp       near ptr M06_L54
M06_L49:
       cmp       r15d,eax
       jae       near ptr M06_L85
       mov       ecx,r15d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       mov       edx,1
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE939720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE9397B0]
       mov       rbx,[rsp+40]
       test      rbx,rbx
       jne       short M06_L52
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r13+78]
       mov       edi,[rcx+8]
       test      edi,edi
       jl        near ptr M06_L27
       test      edi,edi
       jne       short M06_L51
       mov       rcx,7FF9CE664C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,19A4F4082C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L52
M06_L50:
       mov       rbx,[rsp+40]
       jmp       short M06_L53
M06_L51:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L52:
       mov       r8,[r13+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      qword ptr [7FF9CE817E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FF9CE9679D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FF9CE9677B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FF9CE9677E0]
       int       3
M06_L57:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L64
       mov       r15d,1
       jmp       near ptr M06_L65
M06_L58:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE939AB0]
       test      eax,eax
       je        short M06_L59
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L60
M06_L59:
       xor       edx,edx
M06_L60:
       movzx     r9d,dl
       mov       r8d,r9d
       mov       [rsp+70],r8d
       test      r8d,r8d
       mov       eax,[rsp+48]
       jne       near ptr M06_L02
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L62
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L61
       mov       rdx,19A4F4082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L62
M06_L61:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L62:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L63
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L63:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE817A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L64:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L65
       mov       r12d,1
M06_L65:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L03
       test      r14,r14
       jne       short M06_L66
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L66:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L67
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L67:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE817A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L68:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L75
       mov       r15d,1
       jmp       near ptr M06_L76
M06_L69:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE939AB0]
       test      eax,eax
       je        short M06_L70
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L71
M06_L70:
       xor       edx,edx
M06_L71:
       movzx     r9d,dl
       mov       edx,r9d
       mov       [rsp+70],edx
       test      edx,edx
       mov       eax,[rsp+48]
       jne       near ptr M06_L20
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L73
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L72
       mov       rdx,19A4F4082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L73
M06_L72:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L73:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L74
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L74:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE817A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L75:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L76
       mov       r12d,1
M06_L76:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L21
       test      r14,r14
       jne       short M06_L77
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L77:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L78
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L78:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE817A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L79:
       mov       r15d,1
       jmp       near ptr M06_L33
M06_L80:
       mov       r12d,1
       jmp       near ptr M06_L33
M06_L81:
       test      r14,r14
       jne       short M06_L82
       mov       [rsp+4C],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+4C]
M06_L82:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L83
       mov       [rsp+4C],eax
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r9d
       mov       rcx,r8
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L83:
       mov       [rsp+4C],eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FF9CE817A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE817D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE9A9F50],0
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9CE799018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FF9CE799018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE596C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEE596C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE596C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEE596C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,168ADAD9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 240
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       sub       rsp,50
       sub       rsp,50
       lea       rbp,[rsp+50]
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-18]
M01_L01:
       mov       rcx,[rbp-18]
       mov       rdx,7FF9C7D11218
       mov       rdx,7FF9C7D11218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rdx,[rbp-28]
       mov       rdx,[rbp-28]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,50
       add       rsp,50
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 450
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M02_L00
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M03_L00
; Total bytes of code 106
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9C7C078C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9C7C078D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
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
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+0A0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L48
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L49
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L20
M06_L00:
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       lea       edx,[rax-1]
       test      edx,edx
       jl        near ptr M06_L19
M06_L01:
       cmp       edx,eax
       jae       near ptr M06_L55
       mov       [rsp+44],edx
       movsxd    rcx,edx
       mov       r8,[rsi+rcx*8+10]
       mov       [rsp+28],r8
       test      r8,r8
       je        near ptr M06_L50
       mov       ecx,[r8+34]
       test      ecx,1600000
       setne     r9b
       movzx     r9d,r9b
       mov       [rsp+40],r9d
       test      r9d,r9d
       jne       near ptr M06_L13
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0A0],0
       je        near ptr M06_L06
M06_L02:
       mov       [rsp+30],eax
       mov       [rsp+3C],eax
       test      rbp,rbp
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+3C]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L03:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L05
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L04:
       mov       rdx,168ADAD9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L03
M06_L05:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L06:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rcx,r8
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L07
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       jmp       short M06_L08
M06_L07:
       xor       ecx,ecx
M06_L08:
       movzx     r9d,cl
       mov       edx,r9d
       mov       [rsp+40],edx
       test      edx,edx
       jne       near ptr M06_L10
       mov       r8d,[rsp+30]
       mov       [rsp+38],r8d
       test      rbp,rbp
       jne       short M06_L09
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+38]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L11
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L09:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L12
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L10:
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L11:
       mov       rdx,168ADAD9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L09
M06_L12:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L13:
       cmp       dword ptr [rsp+40],0
       je        near ptr M06_L18
       mov       r8,[rsp+28]
       test      dword ptr [r8+34],200000
       je        short M06_L14
       mov       r15d,1
       jmp       short M06_L15
M06_L14:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L15
       mov       r12d,1
M06_L15:
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L18
       test      r14,r14
       jne       short M06_L16
       mov       [rsp+30],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+30]
M06_L16:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L17
       mov       [rsp+30],eax
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L18
M06_L17:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L18:
       mov       edx,[rsp+44]
       dec       edx
       test      edx,edx
       jge       near ptr M06_L01
M06_L19:
       test      rbp,rbp
       je        near ptr M06_L31
       mov       [rsp+30],eax
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0A0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L30
       mov       edi,[rbp+14]
       xor       ecx,ecx
       jmp       short M06_L22
M06_L20:
       mov       rcx,[rsp+0A0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L52
       jmp       near ptr M06_L00
M06_L21:
       mov       [rsp+34],ecx
       mov       rcx,r8
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       ecx,[rsp+34]
M06_L22:
       mov       rax,rbp
       cmp       edi,[rax+14]
       jne       near ptr M06_L33
       cmp       ecx,[rbp+10]
       jae       near ptr M06_L34
       jmp       near ptr M06_L28
       mov       [rsp+30],edi
       mov       ecx,edx
       mov       edi,r13d
       mov       r13d,eax
       jmp       short M06_L22
M06_L23:
       test      dword ptr [rax+34],200000
       je        short M06_L24
       mov       r15d,1
       jmp       short M06_L25
M06_L24:
       mov       edx,[rax+34]
       and       edx,600000
       cmp       edx,400000
       jne       short M06_L25
       mov       r12d,1
M06_L25:
       test      dword ptr [rax+34],10000000
       mov       [rsp+20],rax
       mov       ecx,[rsp+34]
       je        short M06_L22
       test      r14,r14
       jne       short M06_L27
       mov       [rsp+34],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+20]
       mov       ecx,[rsp+34]
M06_L26:
       mov       r8,r14
       inc       dword ptr [r8+14]
       mov       r9,[r8+8]
       mov       edx,[r8+10]
       cmp       [r9+8],edx
       jbe       near ptr M06_L21
       mov       [rsp+34],ecx
       lea       r10d,[rdx+1]
       mov       [r8+10],r10d
       mov       rcx,r9
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+34]
       jmp       near ptr M06_L22
M06_L27:
       mov       rax,[rsp+20]
       jmp       short M06_L26
M06_L28:
       mov       rax,[rbp+8]
       cmp       ecx,[rax+8]
       jae       near ptr M06_L55
       movsxd    rdx,ecx
       mov       rax,[rax+rdx*8+10]
       inc       ecx
       mov       [rsp+34],ecx
       mov       edx,1
M06_L29:
       test      edx,edx
       jne       near ptr M06_L23
M06_L30:
       mov       eax,[rsp+30]
M06_L31:
       test      r13d,r13d
       je        near ptr M06_L47
       test      r14,r14
       je        short M06_L32
       mov       edi,[r14+14]
       xor       ebp,ebp
       jmp       short M06_L36
M06_L32:
       mov       [rsp+30],eax
       jmp       short M06_L38
M06_L33:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L53
M06_L34:
       mov       ecx,[rbp+10]
       inc       ecx
       mov       edx,ecx
       xor       ecx,ecx
       xor       r8d,r8d
       mov       [rsp+34],edx
       mov       rax,rcx
       mov       edx,r8d
       jmp       short M06_L29
M06_L35:
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L38
       mov       eax,[rsp+30]
M06_L36:
       mov       rcx,r14
       cmp       edi,[rcx+14]
       jne       near ptr M06_L45
       cmp       ebp,[r14+10]
       jae       near ptr M06_L46
       mov       rcx,[r14+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M06_L55
       movsxd    rdx,ebp
       mov       rcx,[rcx+rdx*8+10]
       inc       ebp
       mov       edx,1
M06_L37:
       test      edx,edx
       mov       [rsp+30],eax
       jne       short M06_L35
M06_L38:
       or        r12d,r15d
       je        near ptr M06_L47
       test      r15d,r15d
       jne       short M06_L39
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L44
M06_L39:
       xor       edi,edi
       mov       r12d,[rsp+30]
       test      r12d,r12d
       jle       near ptr M06_L51
M06_L40:
       cmp       edi,r12d
       jae       near ptr M06_L55
       movsxd    rcx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,1
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.GetExceptions(Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M06_L42
       mov       rcx,r14
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.UpdateExceptionObservedStatus()
       test      rbx,rbx
       jne       short M06_L41
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rbp+78]
       mov       edx,[rdx+8]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L43
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L41:
       mov       r8,[rbp+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
M06_L42:
       inc       edi
       cmp       r12d,edi
       jle       near ptr M06_L51
       jmp       near ptr M06_L40
M06_L43:
       mov       rcx,7FF9C76D4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,168ADAD9280
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L41
M06_L44:
       mov       rax,[rsp+0A0]
       cmp       dword ptr [rax+20],0
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M06_L39
       jmp       short M06_L52
M06_L45:
       cmp       edi,[r14+14]
       jne       short M06_L53
M06_L46:
       mov       ebp,[r14+10]
       inc       ebp
       xor       ecx,ecx
       xor       edx,edx
       jmp       near ptr M06_L37
M06_L47:
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L48:
       mov       ecx,33
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L49:
       mov       ecx,3C
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L50:
       mov       ecx,2C
       mov       edx,33
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L51:
       mov       rcx,rbx
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L52:
       lea       rcx,[rsp+0A0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L53:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M06_L54:
       mov       ecx,16
       mov       edx,0B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M06_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1721
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       jmp       short M07_L03
       jmp       short M07_L03
M07_L03:
       mov       rcx,rsp
M07_L03:
       mov       rcx,rsp
       call      M07_L04
       call      M07_L04
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L04:
       push      rbp
M07_L04:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L05
       je        short M07_L05
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L05:
       nop
M07_L05:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 512
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CEE490C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,26FBE8082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9CE9A5E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9CE9A5E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE807A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE807A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FF9CE807F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE92B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FF9CEE49168]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 254
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE999F50],0
       cmp       dword ptr [7FF9CE999F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF9CE661030]; System.Object..ctor()
       call      qword ptr [7FF9CE661030]; System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9CE661030]; System.Object..ctor()
       call      qword ptr [7FF9CE661030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-20]
M01_L01:
       mov       rcx,[rbp-20]
       mov       rdx,7FF9CEE2FFB8
       mov       rdx,7FF9CEE2FFB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-28],rax
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-30],rcx
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9CEE49210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FF9CEE49210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-38]
       mov       rdx,[rbp-38]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 460
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE4D3A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEE4D138]
       jmp       short M02_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE73798]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEE4D138]
       jmp       short M03_L00
; Total bytes of code 108
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       short M04_L03
       mov       ecx,4
M04_L00:
       cmp       ecx,7FFFFFC7
       ja        short M04_L05
M04_L01:
       cmp       ecx,edx
       mov       [rsp+24],ecx
       jl        short M04_L04
M04_L02:
       mov       rcx,rsi
       mov       edx,[rsp+24]
       call      qword ptr [7FF9CE807960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       movsxd    rdx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       short M04_L00
M04_L04:
       mov       [rsp+24],edx
       jmp       short M04_L02
M04_L05:
       mov       eax,7FFFFFC7
       mov       ecx,eax
       jmp       short M04_L01
; Total bytes of code 120
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+68]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9CEEA3578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9CEEA3588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      qword ptr [7FF9CE669018]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+58],xmm4
       xor       eax,eax
       mov       [rsp+68],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L55
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L56
       cmp       qword ptr [rsp+0D0],0
       jne       near ptr M06_L47
M06_L00:
       xor       ebx,ebx
       mov       [rsp+40],rbx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       mov       [rsp+48],eax
       lea       edx,[rax-1]
       test      edx,edx
       jl        short M06_L04
       cmp       eax,edx
       jle       near ptr M06_L17
M06_L01:
       mov       [rsp+74],edx
       mov       ecx,edx
       mov       r8,[rsi+rcx*8+10]
       test      r8,r8
       je        near ptr M06_L18
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L05
M06_L02:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L57
M06_L03:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L01
M06_L04:
       test      rbp,rbp
       je        near ptr M06_L35
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF9CE92B090]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L34
       mov       edi,[rbp+14]
       xor       eax,eax
       jmp       near ptr M06_L14
M06_L05:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L15
M06_L06:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L09
M06_L07:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       jbe       near ptr M06_L16
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L08:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L42
       jmp       short M06_L11
M06_L09:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       je        short M06_L13
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L10:
       jmp       near ptr M06_L07
M06_L11:
       mov       eax,[rbp+10]
       inc       eax
       mov       r8d,eax
       xor       edx,edx
       xor       ecx,ecx
       mov       eax,r8d
M06_L12:
       test      ecx,ecx
       jne       near ptr M06_L32
       jmp       near ptr M06_L34
M06_L13:
       mov       rdx,26FBE8082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L10
M06_L14:
       mov       rcx,rbp
       cmp       edi,[rcx+14]
       jne       near ptr M06_L08
       cmp       eax,[rbp+10]
       jae       short M06_L11
       mov       rcx,[rbp+8]
       cmp       eax,[rcx+8]
       jae       near ptr M06_L85
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       inc       eax
       mov       ecx,1
       jmp       short M06_L12
M06_L15:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L58
       jmp       near ptr M06_L06
M06_L16:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE807A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L17:
       cmp       edx,eax
       jae       near ptr M06_L85
       mov       [rsp+74],edx
       mov       r8d,edx
       mov       r8,[rsi+r8*8+10]
       test      r8,r8
       jne       short M06_L19
M06_L18:
       mov       ecx,2E
       mov       edx,33
       call      qword ptr [7FF9CE957768]
       int       3
M06_L19:
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L22
M06_L20:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L68
M06_L21:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L17
       jmp       near ptr M06_L04
M06_L22:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L31
M06_L23:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L26
M06_L24:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       ja        short M06_L25
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE807A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L25:
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L26:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jge       short M06_L28
M06_L27:
       mov       ecx,16
       mov       edx,0C
       call      qword ptr [7FF9CE9577F8]
       int       3
M06_L28:
       test      eax,eax
       je        short M06_L30
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L29:
       jmp       near ptr M06_L24
M06_L30:
       mov       rdx,26FBE8082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L29
M06_L31:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L69
       jmp       near ptr M06_L23
M06_L32:
       mov       [rsp+30],rdx
       test      dword ptr [rdx+34],200000
       jne       near ptr M06_L79
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M06_L80
M06_L33:
       test      dword ptr [rdx+34],10000000
       jne       near ptr M06_L81
       jmp       near ptr M06_L14
M06_L34:
       mov       eax,[rsp+48]
M06_L35:
       test      r13d,r13d
       je        short M06_L37
       test      r14,r14
       jne       near ptr M06_L84
M06_L36:
       or        r12d,r15d
       jne       near ptr M06_L45
M06_L37:
       mov       eax,r13d
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L38:
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE929270]
       test      eax,eax
       jne       short M06_L40
M06_L39:
       mov       rax,[rsp+58]
       mov       edx,[rsp+6C]
       cmp       edx,[rax+14]
       jne       short M06_L41
       mov       edx,[rsp+68]
       cmp       edx,[rax+10]
       jae       short M06_L43
       mov       rax,[rax+8]
       mov       edx,[rax+8]
       cmp       [rsp+68],edx
       jae       near ptr M06_L85
       mov       edx,[rsp+68]
       mov       rax,[rax+rdx*8+10]
       mov       [rsp+60],rax
       mov       eax,[rsp+68]
       inc       eax
       mov       [rsp+68],eax
       mov       edi,1
       jmp       short M06_L44
M06_L40:
       mov       eax,[rsp+48]
       jmp       short M06_L36
M06_L41:
       mov       eax,[rsp+6C]
       mov       rdx,[rsp+58]
       cmp       eax,[rdx+14]
       je        short M06_L43
M06_L42:
       call      qword ptr [7FF9CE957A80]
       int       3
M06_L43:
       mov       rcx,[rsp+58]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rsp+68],ecx
       xor       ecx,ecx
       mov       [rsp+60],rcx
       xor       edi,edi
M06_L44:
       test      edi,edi
       jne       near ptr M06_L38
       mov       eax,[rsp+48]
       jmp       near ptr M06_L36
M06_L45:
       test      r15d,r15d
       jne       short M06_L48
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE92B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE92B720]
       int       3
M06_L47:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       je        near ptr M06_L00
       jmp       short M06_L46
M06_L48:
       xor       r15d,r15d
       jmp       near ptr M06_L54
M06_L49:
       cmp       r15d,eax
       jae       near ptr M06_L85
       mov       ecx,r15d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       mov       edx,1
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE929720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE9297B0]
       mov       rbx,[rsp+40]
       test      rbx,rbx
       jne       short M06_L52
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r13+78]
       mov       edi,[rcx+8]
       test      edi,edi
       jl        near ptr M06_L27
       test      edi,edi
       jne       short M06_L51
       mov       rcx,7FF9CE654C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,26FBE8082C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L52
M06_L50:
       mov       rbx,[rsp+40]
       jmp       short M06_L53
M06_L51:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L52:
       mov       r8,[r13+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      qword ptr [7FF9CE807E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FF9CE9579D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FF9CE9577B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FF9CE9577E0]
       int       3
M06_L57:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L64
       mov       r15d,1
       jmp       near ptr M06_L65
M06_L58:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE929AB0]
       test      eax,eax
       je        short M06_L59
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L60
M06_L59:
       xor       edx,edx
M06_L60:
       movzx     r9d,dl
       mov       r8d,r9d
       mov       [rsp+70],r8d
       test      r8d,r8d
       mov       eax,[rsp+48]
       jne       near ptr M06_L02
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L62
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L61
       mov       rdx,26FBE8082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L62
M06_L61:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L62:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L63
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L63:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE807A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L64:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L65
       mov       r12d,1
M06_L65:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L03
       test      r14,r14
       jne       short M06_L66
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L66:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L67
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L67:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE807A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L68:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L75
       mov       r15d,1
       jmp       near ptr M06_L76
M06_L69:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE929AB0]
       test      eax,eax
       je        short M06_L70
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L71
M06_L70:
       xor       edx,edx
M06_L71:
       movzx     r9d,dl
       mov       edx,r9d
       mov       [rsp+70],edx
       test      edx,edx
       mov       eax,[rsp+48]
       jne       near ptr M06_L20
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L73
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L72
       mov       rdx,26FBE8082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L73
M06_L72:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L73:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L74
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L74:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE807A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L75:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L76
       mov       r12d,1
M06_L76:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L21
       test      r14,r14
       jne       short M06_L77
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L77:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L78
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L78:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE807A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L79:
       mov       r15d,1
       jmp       near ptr M06_L33
M06_L80:
       mov       r12d,1
       jmp       near ptr M06_L33
M06_L81:
       test      r14,r14
       jne       short M06_L82
       mov       [rsp+4C],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+4C]
M06_L82:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L83
       mov       [rsp+4C],eax
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r9d
       mov       rcx,r8
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L83:
       mov       [rsp+4C],eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FF9CE807A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE807D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE999F50],0
       cmp       dword ptr [7FF9CE999F50],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9CE789018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FF9CE789018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE493C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEE493C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE493C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEE493C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,24C3A6A6E60
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 240
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       sub       rsp,50
       sub       rsp,50
       lea       rbp,[rsp+50]
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-18]
M01_L01:
       mov       rcx,[rbp-18]
       mov       rdx,7FF9C7D21218
       mov       rdx,7FF9C7D21218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rdx,[rbp-28]
       mov       rdx,[rbp-28]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,50
       add       rsp,50
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 450
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M02_L00
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M03_L00
; Total bytes of code 106
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9C7C17800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9C7C17810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
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
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+0A0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L48
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L49
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L20
M06_L00:
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       lea       edx,[rax-1]
       test      edx,edx
       jl        near ptr M06_L19
M06_L01:
       cmp       edx,eax
       jae       near ptr M06_L55
       mov       [rsp+44],edx
       movsxd    rcx,edx
       mov       r8,[rsi+rcx*8+10]
       mov       [rsp+28],r8
       test      r8,r8
       je        near ptr M06_L50
       mov       ecx,[r8+34]
       test      ecx,1600000
       setne     r9b
       movzx     r9d,r9b
       mov       [rsp+40],r9d
       test      r9d,r9d
       jne       near ptr M06_L13
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0A0],0
       je        near ptr M06_L06
M06_L02:
       mov       [rsp+30],eax
       mov       [rsp+3C],eax
       test      rbp,rbp
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+3C]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L03:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L05
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L04:
       mov       rdx,24C3A6A6E60
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L03
M06_L05:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L06:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rcx,r8
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L07
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       jmp       short M06_L08
M06_L07:
       xor       ecx,ecx
M06_L08:
       movzx     r9d,cl
       mov       edx,r9d
       mov       [rsp+40],edx
       test      edx,edx
       jne       near ptr M06_L10
       mov       r8d,[rsp+30]
       mov       [rsp+38],r8d
       test      rbp,rbp
       jne       short M06_L09
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+38]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L11
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L09:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L12
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L10:
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L11:
       mov       rdx,24C3A6A6E60
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L09
M06_L12:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L13:
       cmp       dword ptr [rsp+40],0
       je        near ptr M06_L18
       mov       r8,[rsp+28]
       test      dword ptr [r8+34],200000
       je        short M06_L14
       mov       r15d,1
       jmp       short M06_L15
M06_L14:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L15
       mov       r12d,1
M06_L15:
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L18
       test      r14,r14
       jne       short M06_L16
       mov       [rsp+30],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+30]
M06_L16:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L17
       mov       [rsp+30],eax
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L18
M06_L17:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L18:
       mov       edx,[rsp+44]
       dec       edx
       test      edx,edx
       jge       near ptr M06_L01
M06_L19:
       test      rbp,rbp
       je        near ptr M06_L31
       mov       [rsp+30],eax
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0A0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L30
       mov       edi,[rbp+14]
       xor       ecx,ecx
       jmp       short M06_L22
M06_L20:
       mov       rcx,[rsp+0A0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L52
       jmp       near ptr M06_L00
M06_L21:
       mov       [rsp+34],ecx
       mov       rcx,r8
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       ecx,[rsp+34]
M06_L22:
       mov       rax,rbp
       cmp       edi,[rax+14]
       jne       near ptr M06_L33
       cmp       ecx,[rbp+10]
       jae       near ptr M06_L34
       jmp       near ptr M06_L28
       mov       [rsp+30],edi
       mov       ecx,edx
       mov       edi,r13d
       mov       r13d,eax
       jmp       short M06_L22
M06_L23:
       test      dword ptr [rax+34],200000
       je        short M06_L24
       mov       r15d,1
       jmp       short M06_L25
M06_L24:
       mov       edx,[rax+34]
       and       edx,600000
       cmp       edx,400000
       jne       short M06_L25
       mov       r12d,1
M06_L25:
       test      dword ptr [rax+34],10000000
       mov       [rsp+20],rax
       mov       ecx,[rsp+34]
       je        short M06_L22
       test      r14,r14
       jne       short M06_L27
       mov       [rsp+34],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+20]
       mov       ecx,[rsp+34]
M06_L26:
       mov       r8,r14
       inc       dword ptr [r8+14]
       mov       r9,[r8+8]
       mov       edx,[r8+10]
       cmp       [r9+8],edx
       jbe       near ptr M06_L21
       mov       [rsp+34],ecx
       lea       r10d,[rdx+1]
       mov       [r8+10],r10d
       mov       rcx,r9
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+34]
       jmp       near ptr M06_L22
M06_L27:
       mov       rax,[rsp+20]
       jmp       short M06_L26
M06_L28:
       mov       rax,[rbp+8]
       cmp       ecx,[rax+8]
       jae       near ptr M06_L55
       movsxd    rdx,ecx
       mov       rax,[rax+rdx*8+10]
       inc       ecx
       mov       [rsp+34],ecx
       mov       edx,1
M06_L29:
       test      edx,edx
       jne       near ptr M06_L23
M06_L30:
       mov       eax,[rsp+30]
M06_L31:
       test      r13d,r13d
       je        near ptr M06_L47
       test      r14,r14
       je        short M06_L32
       mov       edi,[r14+14]
       xor       ebp,ebp
       jmp       short M06_L36
M06_L32:
       mov       [rsp+30],eax
       jmp       short M06_L38
M06_L33:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L53
M06_L34:
       mov       ecx,[rbp+10]
       inc       ecx
       mov       edx,ecx
       xor       ecx,ecx
       xor       r8d,r8d
       mov       [rsp+34],edx
       mov       rax,rcx
       mov       edx,r8d
       jmp       short M06_L29
M06_L35:
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L38
       mov       eax,[rsp+30]
M06_L36:
       mov       rcx,r14
       cmp       edi,[rcx+14]
       jne       near ptr M06_L45
       cmp       ebp,[r14+10]
       jae       near ptr M06_L46
       mov       rcx,[r14+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M06_L55
       movsxd    rdx,ebp
       mov       rcx,[rcx+rdx*8+10]
       inc       ebp
       mov       edx,1
M06_L37:
       test      edx,edx
       mov       [rsp+30],eax
       jne       short M06_L35
M06_L38:
       or        r12d,r15d
       je        near ptr M06_L47
       test      r15d,r15d
       jne       short M06_L39
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L44
M06_L39:
       xor       edi,edi
       mov       r12d,[rsp+30]
       test      r12d,r12d
       jle       near ptr M06_L51
M06_L40:
       cmp       edi,r12d
       jae       near ptr M06_L55
       movsxd    rcx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,1
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.GetExceptions(Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M06_L42
       mov       rcx,r14
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.UpdateExceptionObservedStatus()
       test      rbx,rbx
       jne       short M06_L41
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rbp+78]
       mov       edx,[rdx+8]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L43
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L41:
       mov       r8,[rbp+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
M06_L42:
       inc       edi
       cmp       r12d,edi
       jle       near ptr M06_L51
       jmp       near ptr M06_L40
M06_L43:
       mov       rcx,7FF9C76E4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,24C3A6A6E70
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L41
M06_L44:
       mov       rax,[rsp+0A0]
       cmp       dword ptr [rax+20],0
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M06_L39
       jmp       short M06_L52
M06_L45:
       cmp       edi,[r14+14]
       jne       short M06_L53
M06_L46:
       mov       ebp,[r14+10]
       inc       ebp
       xor       ecx,ecx
       xor       edx,edx
       jmp       near ptr M06_L37
M06_L47:
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L48:
       mov       ecx,33
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L49:
       mov       ecx,3C
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L50:
       mov       ecx,2C
       mov       edx,33
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L51:
       mov       rcx,rbx
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L52:
       lea       rcx,[rsp+0A0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L53:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M06_L54:
       mov       ecx,16
       mov       edx,0B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M06_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1721
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       jmp       short M07_L03
       jmp       short M07_L03
M07_L03:
       mov       rcx,rsp
M07_L03:
       mov       rcx,rsp
       call      M07_L04
       call      M07_L04
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L04:
       push      rbp
M07_L04:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L05
       je        short M07_L05
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L05:
       nop
M07_L05:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 512
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CEA693C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,21345C082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9CE5C5E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9CE5C5E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE427A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE427A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FF9CE427F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE54B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FF9CEA69468]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 254
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE5B9F50],0
       cmp       dword ptr [7FF9CE5B9F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF9CE281030]; System.Object..ctor()
       call      qword ptr [7FF9CE281030]; System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9CE281030]; System.Object..ctor()
       call      qword ptr [7FF9CE281030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-20]
M01_L01:
       mov       rcx,[rbp-20]
       mov       rdx,7FF9CEA823F8
       mov       rdx,7FF9CEA823F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-28],rax
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-30],rcx
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9CEA69510]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FF9CEA69510]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-38]
       mov       rdx,[rbp-38]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 460
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEA6D888]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEA6D618]
       jmp       short M02_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEA93CD8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEA6D618]
       jmp       short M03_L00
; Total bytes of code 108
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       short M04_L03
       mov       ecx,4
M04_L00:
       cmp       ecx,7FFFFFC7
       ja        short M04_L05
M04_L01:
       cmp       ecx,edx
       mov       [rsp+24],ecx
       jl        short M04_L04
M04_L02:
       mov       rcx,rsi
       mov       edx,[rsp+24]
       call      qword ptr [7FF9CE427960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       movsxd    rdx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       short M04_L00
M04_L04:
       mov       [rsp+24],edx
       jmp       short M04_L02
M04_L05:
       mov       eax,7FFFFFC7
       mov       ecx,eax
       jmp       short M04_L01
; Total bytes of code 120
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+68]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9CEAB3468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9CEAB3478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      qword ptr [7FF9CE289018]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+58],xmm4
       xor       eax,eax
       mov       [rsp+68],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L55
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L56
       cmp       qword ptr [rsp+0D0],0
       jne       near ptr M06_L47
M06_L00:
       xor       ebx,ebx
       mov       [rsp+40],rbx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       mov       [rsp+48],eax
       lea       edx,[rax-1]
       test      edx,edx
       jl        short M06_L04
       cmp       eax,edx
       jle       near ptr M06_L17
M06_L01:
       mov       [rsp+74],edx
       mov       ecx,edx
       mov       r8,[rsi+rcx*8+10]
       test      r8,r8
       je        near ptr M06_L18
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L05
M06_L02:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L57
M06_L03:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L01
M06_L04:
       test      rbp,rbp
       je        near ptr M06_L35
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF9CE54B090]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L34
       mov       edi,[rbp+14]
       xor       eax,eax
       jmp       near ptr M06_L14
M06_L05:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L15
M06_L06:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L09
M06_L07:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       jbe       near ptr M06_L16
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L08:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L42
       jmp       short M06_L11
M06_L09:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       je        short M06_L13
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L10:
       jmp       near ptr M06_L07
M06_L11:
       mov       eax,[rbp+10]
       inc       eax
       mov       r8d,eax
       xor       edx,edx
       xor       ecx,ecx
       mov       eax,r8d
M06_L12:
       test      ecx,ecx
       jne       near ptr M06_L32
       jmp       near ptr M06_L34
M06_L13:
       mov       rdx,21345C082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L10
M06_L14:
       mov       rcx,rbp
       cmp       edi,[rcx+14]
       jne       near ptr M06_L08
       cmp       eax,[rbp+10]
       jae       short M06_L11
       mov       rcx,[rbp+8]
       cmp       eax,[rcx+8]
       jae       near ptr M06_L85
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       inc       eax
       mov       ecx,1
       jmp       short M06_L12
M06_L15:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L58
       jmp       near ptr M06_L06
M06_L16:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE427A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L17:
       cmp       edx,eax
       jae       near ptr M06_L85
       mov       [rsp+74],edx
       mov       r8d,edx
       mov       r8,[rsi+r8*8+10]
       test      r8,r8
       jne       short M06_L19
M06_L18:
       mov       ecx,2E
       mov       edx,33
       call      qword ptr [7FF9CE577768]
       int       3
M06_L19:
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L22
M06_L20:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L68
M06_L21:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L17
       jmp       near ptr M06_L04
M06_L22:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L31
M06_L23:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L26
M06_L24:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       ja        short M06_L25
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE427A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L25:
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L26:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jge       short M06_L28
M06_L27:
       mov       ecx,16
       mov       edx,0C
       call      qword ptr [7FF9CE5777F8]
       int       3
M06_L28:
       test      eax,eax
       je        short M06_L30
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L29:
       jmp       near ptr M06_L24
M06_L30:
       mov       rdx,21345C082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L29
M06_L31:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L69
       jmp       near ptr M06_L23
M06_L32:
       mov       [rsp+30],rdx
       test      dword ptr [rdx+34],200000
       jne       near ptr M06_L79
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M06_L80
M06_L33:
       test      dword ptr [rdx+34],10000000
       jne       near ptr M06_L81
       jmp       near ptr M06_L14
M06_L34:
       mov       eax,[rsp+48]
M06_L35:
       test      r13d,r13d
       je        short M06_L37
       test      r14,r14
       jne       near ptr M06_L84
M06_L36:
       or        r12d,r15d
       jne       near ptr M06_L45
M06_L37:
       mov       eax,r13d
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L38:
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE549270]
       test      eax,eax
       jne       short M06_L40
M06_L39:
       mov       rax,[rsp+58]
       mov       edx,[rsp+6C]
       cmp       edx,[rax+14]
       jne       short M06_L41
       mov       edx,[rsp+68]
       cmp       edx,[rax+10]
       jae       short M06_L43
       mov       rax,[rax+8]
       mov       edx,[rax+8]
       cmp       [rsp+68],edx
       jae       near ptr M06_L85
       mov       edx,[rsp+68]
       mov       rax,[rax+rdx*8+10]
       mov       [rsp+60],rax
       mov       eax,[rsp+68]
       inc       eax
       mov       [rsp+68],eax
       mov       edi,1
       jmp       short M06_L44
M06_L40:
       mov       eax,[rsp+48]
       jmp       short M06_L36
M06_L41:
       mov       eax,[rsp+6C]
       mov       rdx,[rsp+58]
       cmp       eax,[rdx+14]
       je        short M06_L43
M06_L42:
       call      qword ptr [7FF9CE577A80]
       int       3
M06_L43:
       mov       rcx,[rsp+58]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rsp+68],ecx
       xor       ecx,ecx
       mov       [rsp+60],rcx
       xor       edi,edi
M06_L44:
       test      edi,edi
       jne       near ptr M06_L38
       mov       eax,[rsp+48]
       jmp       near ptr M06_L36
M06_L45:
       test      r15d,r15d
       jne       short M06_L48
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE54B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE54B720]
       int       3
M06_L47:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       je        near ptr M06_L00
       jmp       short M06_L46
M06_L48:
       xor       r15d,r15d
       jmp       near ptr M06_L54
M06_L49:
       cmp       r15d,eax
       jae       near ptr M06_L85
       mov       ecx,r15d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       mov       edx,1
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE549720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE5497B0]
       mov       rbx,[rsp+40]
       test      rbx,rbx
       jne       short M06_L52
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r13+78]
       mov       edi,[rcx+8]
       test      edi,edi
       jl        near ptr M06_L27
       test      edi,edi
       jne       short M06_L51
       mov       rcx,7FF9CE274C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,21345C082C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L52
M06_L50:
       mov       rbx,[rsp+40]
       jmp       short M06_L53
M06_L51:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L52:
       mov       r8,[r13+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      qword ptr [7FF9CE427E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FF9CE5779D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FF9CE5777B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FF9CE5777E0]
       int       3
M06_L57:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L64
       mov       r15d,1
       jmp       near ptr M06_L65
M06_L58:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE549AB0]
       test      eax,eax
       je        short M06_L59
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L60
M06_L59:
       xor       edx,edx
M06_L60:
       movzx     r9d,dl
       mov       r8d,r9d
       mov       [rsp+70],r8d
       test      r8d,r8d
       mov       eax,[rsp+48]
       jne       near ptr M06_L02
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L62
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L61
       mov       rdx,21345C082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L62
M06_L61:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L62:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L63
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L63:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE427A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L64:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L65
       mov       r12d,1
M06_L65:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L03
       test      r14,r14
       jne       short M06_L66
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L66:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L67
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L67:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE427A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L68:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L75
       mov       r15d,1
       jmp       near ptr M06_L76
M06_L69:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE549AB0]
       test      eax,eax
       je        short M06_L70
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L71
M06_L70:
       xor       edx,edx
M06_L71:
       movzx     r9d,dl
       mov       edx,r9d
       mov       [rsp+70],edx
       test      edx,edx
       mov       eax,[rsp+48]
       jne       near ptr M06_L20
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L73
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L72
       mov       rdx,21345C082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L73
M06_L72:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L73:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L74
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L74:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE427A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L75:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L76
       mov       r12d,1
M06_L76:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L21
       test      r14,r14
       jne       short M06_L77
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L77:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L78
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L78:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE427A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L79:
       mov       r15d,1
       jmp       near ptr M06_L33
M06_L80:
       mov       r12d,1
       jmp       near ptr M06_L33
M06_L81:
       test      r14,r14
       jne       short M06_L82
       mov       [rsp+4C],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+4C]
M06_L82:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L83
       mov       [rsp+4C],eax
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r9d
       mov       rcx,r8
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L83:
       mov       [rsp+4C],eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FF9CE427A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE427D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE5B9F50],0
       cmp       dword ptr [7FF9CE5B9F50],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9CE3A9018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FF9CE3A9018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEA696C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEA696C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEA696C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEA696C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,17ECE4E9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 240
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       sub       rsp,50
       sub       rsp,50
       lea       rbp,[rsp+50]
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-18]
M01_L01:
       mov       rcx,[rbp-18]
       mov       rdx,7FF9C7D21218
       mov       rdx,7FF9C7D21218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rdx,[rbp-28]
       mov       rdx,[rbp-28]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,50
       add       rsp,50
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 450
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M02_L00
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M03_L00
; Total bytes of code 106
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9C7C17800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9C7C17810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
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
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+0A0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L48
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L49
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L20
M06_L00:
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       lea       edx,[rax-1]
       test      edx,edx
       jl        near ptr M06_L19
M06_L01:
       cmp       edx,eax
       jae       near ptr M06_L55
       mov       [rsp+44],edx
       movsxd    rcx,edx
       mov       r8,[rsi+rcx*8+10]
       mov       [rsp+28],r8
       test      r8,r8
       je        near ptr M06_L50
       mov       ecx,[r8+34]
       test      ecx,1600000
       setne     r9b
       movzx     r9d,r9b
       mov       [rsp+40],r9d
       test      r9d,r9d
       jne       near ptr M06_L13
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0A0],0
       je        near ptr M06_L06
M06_L02:
       mov       [rsp+30],eax
       mov       [rsp+3C],eax
       test      rbp,rbp
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+3C]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L03:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L05
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L04:
       mov       rdx,17ECE4E9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L03
M06_L05:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L06:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rcx,r8
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L07
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       jmp       short M06_L08
M06_L07:
       xor       ecx,ecx
M06_L08:
       movzx     r9d,cl
       mov       edx,r9d
       mov       [rsp+40],edx
       test      edx,edx
       jne       near ptr M06_L10
       mov       r8d,[rsp+30]
       mov       [rsp+38],r8d
       test      rbp,rbp
       jne       short M06_L09
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+38]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L11
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L09:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L12
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L10:
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L11:
       mov       rdx,17ECE4E9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L09
M06_L12:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L13:
       cmp       dword ptr [rsp+40],0
       je        near ptr M06_L18
       mov       r8,[rsp+28]
       test      dword ptr [r8+34],200000
       je        short M06_L14
       mov       r15d,1
       jmp       short M06_L15
M06_L14:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L15
       mov       r12d,1
M06_L15:
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L18
       test      r14,r14
       jne       short M06_L16
       mov       [rsp+30],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+30]
M06_L16:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L17
       mov       [rsp+30],eax
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L18
M06_L17:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L18:
       mov       edx,[rsp+44]
       dec       edx
       test      edx,edx
       jge       near ptr M06_L01
M06_L19:
       test      rbp,rbp
       je        near ptr M06_L31
       mov       [rsp+30],eax
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0A0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L30
       mov       edi,[rbp+14]
       xor       ecx,ecx
       jmp       short M06_L22
M06_L20:
       mov       rcx,[rsp+0A0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L52
       jmp       near ptr M06_L00
M06_L21:
       mov       [rsp+34],ecx
       mov       rcx,r8
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       ecx,[rsp+34]
M06_L22:
       mov       rax,rbp
       cmp       edi,[rax+14]
       jne       near ptr M06_L33
       cmp       ecx,[rbp+10]
       jae       near ptr M06_L34
       jmp       near ptr M06_L28
       mov       [rsp+30],edi
       mov       ecx,edx
       mov       edi,r13d
       mov       r13d,eax
       jmp       short M06_L22
M06_L23:
       test      dword ptr [rax+34],200000
       je        short M06_L24
       mov       r15d,1
       jmp       short M06_L25
M06_L24:
       mov       edx,[rax+34]
       and       edx,600000
       cmp       edx,400000
       jne       short M06_L25
       mov       r12d,1
M06_L25:
       test      dword ptr [rax+34],10000000
       mov       [rsp+20],rax
       mov       ecx,[rsp+34]
       je        short M06_L22
       test      r14,r14
       jne       short M06_L27
       mov       [rsp+34],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+20]
       mov       ecx,[rsp+34]
M06_L26:
       mov       r8,r14
       inc       dword ptr [r8+14]
       mov       r9,[r8+8]
       mov       edx,[r8+10]
       cmp       [r9+8],edx
       jbe       near ptr M06_L21
       mov       [rsp+34],ecx
       lea       r10d,[rdx+1]
       mov       [r8+10],r10d
       mov       rcx,r9
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+34]
       jmp       near ptr M06_L22
M06_L27:
       mov       rax,[rsp+20]
       jmp       short M06_L26
M06_L28:
       mov       rax,[rbp+8]
       cmp       ecx,[rax+8]
       jae       near ptr M06_L55
       movsxd    rdx,ecx
       mov       rax,[rax+rdx*8+10]
       inc       ecx
       mov       [rsp+34],ecx
       mov       edx,1
M06_L29:
       test      edx,edx
       jne       near ptr M06_L23
M06_L30:
       mov       eax,[rsp+30]
M06_L31:
       test      r13d,r13d
       je        near ptr M06_L47
       test      r14,r14
       je        short M06_L32
       mov       edi,[r14+14]
       xor       ebp,ebp
       jmp       short M06_L36
M06_L32:
       mov       [rsp+30],eax
       jmp       short M06_L38
M06_L33:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L53
M06_L34:
       mov       ecx,[rbp+10]
       inc       ecx
       mov       edx,ecx
       xor       ecx,ecx
       xor       r8d,r8d
       mov       [rsp+34],edx
       mov       rax,rcx
       mov       edx,r8d
       jmp       short M06_L29
M06_L35:
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L38
       mov       eax,[rsp+30]
M06_L36:
       mov       rcx,r14
       cmp       edi,[rcx+14]
       jne       near ptr M06_L45
       cmp       ebp,[r14+10]
       jae       near ptr M06_L46
       mov       rcx,[r14+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M06_L55
       movsxd    rdx,ebp
       mov       rcx,[rcx+rdx*8+10]
       inc       ebp
       mov       edx,1
M06_L37:
       test      edx,edx
       mov       [rsp+30],eax
       jne       short M06_L35
M06_L38:
       or        r12d,r15d
       je        near ptr M06_L47
       test      r15d,r15d
       jne       short M06_L39
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L44
M06_L39:
       xor       edi,edi
       mov       r12d,[rsp+30]
       test      r12d,r12d
       jle       near ptr M06_L51
M06_L40:
       cmp       edi,r12d
       jae       near ptr M06_L55
       movsxd    rcx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,1
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.GetExceptions(Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M06_L42
       mov       rcx,r14
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.UpdateExceptionObservedStatus()
       test      rbx,rbx
       jne       short M06_L41
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rbp+78]
       mov       edx,[rdx+8]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L43
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L41:
       mov       r8,[rbp+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
M06_L42:
       inc       edi
       cmp       r12d,edi
       jle       near ptr M06_L51
       jmp       near ptr M06_L40
M06_L43:
       mov       rcx,7FF9C76E4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,17ECE4E9280
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L41
M06_L44:
       mov       rax,[rsp+0A0]
       cmp       dword ptr [rax+20],0
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M06_L39
       jmp       short M06_L52
M06_L45:
       cmp       edi,[r14+14]
       jne       short M06_L53
M06_L46:
       mov       ebp,[r14+10]
       inc       ebp
       xor       ecx,ecx
       xor       edx,edx
       jmp       near ptr M06_L37
M06_L47:
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L48:
       mov       ecx,33
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L49:
       mov       ecx,3C
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L50:
       mov       ecx,2C
       mov       edx,33
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L51:
       mov       rcx,rbx
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L52:
       lea       rcx,[rsp+0A0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L53:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M06_L54:
       mov       ecx,16
       mov       edx,0B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M06_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1721
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       jmp       short M07_L03
       jmp       short M07_L03
M07_L03:
       mov       rcx,rsp
M07_L03:
       mov       rcx,rsp
       call      M07_L04
       call      M07_L04
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L04:
       push      rbp
M07_L04:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L05
       je        short M07_L05
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L05:
       nop
M07_L05:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 512
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CEA890C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,27BCF0082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9CE5E5E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9CE5E5E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE447A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE447A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FF9CE447F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE56B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FF9CEA89168]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 254
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE5D9F50],0
       cmp       dword ptr [7FF9CE5D9F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF9CE2A1030]; System.Object..ctor()
       call      qword ptr [7FF9CE2A1030]; System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9CE2A1030]; System.Object..ctor()
       call      qword ptr [7FF9CE2A1030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-20]
M01_L01:
       mov       rcx,[rbp-20]
       mov       rdx,7FF9CEA6FBA0
       mov       rdx,7FF9CEA6FBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-28],rax
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-30],rcx
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9CEA89210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FF9CEA89210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-38]
       mov       rdx,[rbp-38]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 460
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEA8D3A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEA8D138]
       jmp       short M02_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEAB3798]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEA8D138]
       jmp       short M03_L00
; Total bytes of code 108
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       short M04_L03
       mov       ecx,4
M04_L00:
       cmp       ecx,7FFFFFC7
       ja        short M04_L05
M04_L01:
       cmp       ecx,edx
       mov       [rsp+24],ecx
       jl        short M04_L04
M04_L02:
       mov       rcx,rsi
       mov       edx,[rsp+24]
       call      qword ptr [7FF9CE447960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       movsxd    rdx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       short M04_L00
M04_L04:
       mov       [rsp+24],edx
       jmp       short M04_L02
M04_L05:
       mov       eax,7FFFFFC7
       mov       ecx,eax
       jmp       short M04_L01
; Total bytes of code 120
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+68]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9CEAE1468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9CEAE1478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      qword ptr [7FF9CE2A9018]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+58],xmm4
       xor       eax,eax
       mov       [rsp+68],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L55
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L56
       cmp       qword ptr [rsp+0D0],0
       jne       near ptr M06_L47
M06_L00:
       xor       ebx,ebx
       mov       [rsp+40],rbx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       mov       [rsp+48],eax
       lea       edx,[rax-1]
       test      edx,edx
       jl        short M06_L04
       cmp       eax,edx
       jle       near ptr M06_L17
M06_L01:
       mov       [rsp+74],edx
       mov       ecx,edx
       mov       r8,[rsi+rcx*8+10]
       test      r8,r8
       je        near ptr M06_L18
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L05
M06_L02:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L57
M06_L03:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L01
M06_L04:
       test      rbp,rbp
       je        near ptr M06_L35
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF9CE56B090]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L34
       mov       edi,[rbp+14]
       xor       eax,eax
       jmp       near ptr M06_L14
M06_L05:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L15
M06_L06:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L09
M06_L07:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       jbe       near ptr M06_L16
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L08:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L42
       jmp       short M06_L11
M06_L09:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       je        short M06_L13
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L10:
       jmp       near ptr M06_L07
M06_L11:
       mov       eax,[rbp+10]
       inc       eax
       mov       r8d,eax
       xor       edx,edx
       xor       ecx,ecx
       mov       eax,r8d
M06_L12:
       test      ecx,ecx
       jne       near ptr M06_L32
       jmp       near ptr M06_L34
M06_L13:
       mov       rdx,27BCF0082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L10
M06_L14:
       mov       rcx,rbp
       cmp       edi,[rcx+14]
       jne       near ptr M06_L08
       cmp       eax,[rbp+10]
       jae       short M06_L11
       mov       rcx,[rbp+8]
       cmp       eax,[rcx+8]
       jae       near ptr M06_L85
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       inc       eax
       mov       ecx,1
       jmp       short M06_L12
M06_L15:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L58
       jmp       near ptr M06_L06
M06_L16:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE447A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L17:
       cmp       edx,eax
       jae       near ptr M06_L85
       mov       [rsp+74],edx
       mov       r8d,edx
       mov       r8,[rsi+r8*8+10]
       test      r8,r8
       jne       short M06_L19
M06_L18:
       mov       ecx,2E
       mov       edx,33
       call      qword ptr [7FF9CE597768]
       int       3
M06_L19:
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L22
M06_L20:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L68
M06_L21:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L17
       jmp       near ptr M06_L04
M06_L22:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L31
M06_L23:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L26
M06_L24:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       ja        short M06_L25
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE447A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L25:
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L26:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jge       short M06_L28
M06_L27:
       mov       ecx,16
       mov       edx,0C
       call      qword ptr [7FF9CE5977F8]
       int       3
M06_L28:
       test      eax,eax
       je        short M06_L30
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L29:
       jmp       near ptr M06_L24
M06_L30:
       mov       rdx,27BCF0082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L29
M06_L31:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L69
       jmp       near ptr M06_L23
M06_L32:
       mov       [rsp+30],rdx
       test      dword ptr [rdx+34],200000
       jne       near ptr M06_L79
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M06_L80
M06_L33:
       test      dword ptr [rdx+34],10000000
       jne       near ptr M06_L81
       jmp       near ptr M06_L14
M06_L34:
       mov       eax,[rsp+48]
M06_L35:
       test      r13d,r13d
       je        short M06_L37
       test      r14,r14
       jne       near ptr M06_L84
M06_L36:
       or        r12d,r15d
       jne       near ptr M06_L45
M06_L37:
       mov       eax,r13d
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L38:
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE569270]
       test      eax,eax
       jne       short M06_L40
M06_L39:
       mov       rax,[rsp+58]
       mov       edx,[rsp+6C]
       cmp       edx,[rax+14]
       jne       short M06_L41
       mov       edx,[rsp+68]
       cmp       edx,[rax+10]
       jae       short M06_L43
       mov       rax,[rax+8]
       mov       edx,[rax+8]
       cmp       [rsp+68],edx
       jae       near ptr M06_L85
       mov       edx,[rsp+68]
       mov       rax,[rax+rdx*8+10]
       mov       [rsp+60],rax
       mov       eax,[rsp+68]
       inc       eax
       mov       [rsp+68],eax
       mov       edi,1
       jmp       short M06_L44
M06_L40:
       mov       eax,[rsp+48]
       jmp       short M06_L36
M06_L41:
       mov       eax,[rsp+6C]
       mov       rdx,[rsp+58]
       cmp       eax,[rdx+14]
       je        short M06_L43
M06_L42:
       call      qword ptr [7FF9CE597A80]
       int       3
M06_L43:
       mov       rcx,[rsp+58]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rsp+68],ecx
       xor       ecx,ecx
       mov       [rsp+60],rcx
       xor       edi,edi
M06_L44:
       test      edi,edi
       jne       near ptr M06_L38
       mov       eax,[rsp+48]
       jmp       near ptr M06_L36
M06_L45:
       test      r15d,r15d
       jne       short M06_L48
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE56B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE56B720]
       int       3
M06_L47:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       je        near ptr M06_L00
       jmp       short M06_L46
M06_L48:
       xor       r15d,r15d
       jmp       near ptr M06_L54
M06_L49:
       cmp       r15d,eax
       jae       near ptr M06_L85
       mov       ecx,r15d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       mov       edx,1
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE569720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE5697B0]
       mov       rbx,[rsp+40]
       test      rbx,rbx
       jne       short M06_L52
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r13+78]
       mov       edi,[rcx+8]
       test      edi,edi
       jl        near ptr M06_L27
       test      edi,edi
       jne       short M06_L51
       mov       rcx,7FF9CE294C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,27BCF0082C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L52
M06_L50:
       mov       rbx,[rsp+40]
       jmp       short M06_L53
M06_L51:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L52:
       mov       r8,[r13+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      qword ptr [7FF9CE447E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FF9CE5979D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FF9CE5977B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FF9CE5977E0]
       int       3
M06_L57:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L64
       mov       r15d,1
       jmp       near ptr M06_L65
M06_L58:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE569AB0]
       test      eax,eax
       je        short M06_L59
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L60
M06_L59:
       xor       edx,edx
M06_L60:
       movzx     r9d,dl
       mov       r8d,r9d
       mov       [rsp+70],r8d
       test      r8d,r8d
       mov       eax,[rsp+48]
       jne       near ptr M06_L02
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L62
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L61
       mov       rdx,27BCF0082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L62
M06_L61:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L62:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L63
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L63:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE447A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L64:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L65
       mov       r12d,1
M06_L65:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L03
       test      r14,r14
       jne       short M06_L66
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L66:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L67
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L67:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE447A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L68:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L75
       mov       r15d,1
       jmp       near ptr M06_L76
M06_L69:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE569AB0]
       test      eax,eax
       je        short M06_L70
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L71
M06_L70:
       xor       edx,edx
M06_L71:
       movzx     r9d,dl
       mov       edx,r9d
       mov       [rsp+70],edx
       test      edx,edx
       mov       eax,[rsp+48]
       jne       near ptr M06_L20
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L73
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L72
       mov       rdx,27BCF0082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L73
M06_L72:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L73:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L74
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L74:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE447A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L75:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L76
       mov       r12d,1
M06_L76:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L21
       test      r14,r14
       jne       short M06_L77
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L77:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L78
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L78:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE447A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L79:
       mov       r15d,1
       jmp       near ptr M06_L33
M06_L80:
       mov       r12d,1
       jmp       near ptr M06_L33
M06_L81:
       test      r14,r14
       jne       short M06_L82
       mov       [rsp+4C],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+4C]
M06_L82:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L83
       mov       [rsp+4C],eax
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r9d
       mov       rcx,r8
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L83:
       mov       [rsp+4C],eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FF9CE447A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE447D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE5D9F50],0
       cmp       dword ptr [7FF9CE5D9F50],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9CE3C9018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FF9CE3C9018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEA893C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEA893C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEA893C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEA893C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2B117BC9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 240
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       sub       rsp,50
       sub       rsp,50
       lea       rbp,[rsp+50]
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      System.Object..ctor()
       call      System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-18]
M01_L01:
       mov       rcx,[rbp-18]
       mov       rdx,7FF9C7D11218
       mov       rdx,7FF9C7D11218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rdx,[rbp-28]
       mov       rdx,[rbp-28]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,50
       add       rsp,50
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 450
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M02_L00
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M03_L00
; Total bytes of code 106
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9C7C078C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9C7C078D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
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
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+0A0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L48
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L49
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L20
M06_L00:
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       lea       edx,[rax-1]
       test      edx,edx
       jl        near ptr M06_L19
M06_L01:
       cmp       edx,eax
       jae       near ptr M06_L55
       mov       [rsp+44],edx
       movsxd    rcx,edx
       mov       r8,[rsi+rcx*8+10]
       mov       [rsp+28],r8
       test      r8,r8
       je        near ptr M06_L50
       mov       ecx,[r8+34]
       test      ecx,1600000
       setne     r9b
       movzx     r9d,r9b
       mov       [rsp+40],r9d
       test      r9d,r9d
       jne       near ptr M06_L13
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0A0],0
       je        near ptr M06_L06
M06_L02:
       mov       [rsp+30],eax
       mov       [rsp+3C],eax
       test      rbp,rbp
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+3C]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L03:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L05
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L04:
       mov       rdx,2B117BC9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L03
M06_L05:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
       jmp       near ptr M06_L13
M06_L06:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rcx,r8
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L07
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       jmp       short M06_L08
M06_L07:
       xor       ecx,ecx
M06_L08:
       movzx     r9d,cl
       mov       edx,r9d
       mov       [rsp+40],edx
       test      edx,edx
       jne       near ptr M06_L10
       mov       r8d,[rsp+30]
       mov       [rsp+38],r8d
       test      rbp,rbp
       jne       short M06_L09
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       edx,[rsp+38]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L11
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L09:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L12
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L10:
       mov       eax,[rsp+30]
       jmp       short M06_L13
M06_L11:
       mov       rdx,2B117BC9270
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L09
M06_L12:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L13:
       cmp       dword ptr [rsp+40],0
       je        near ptr M06_L18
       mov       r8,[rsp+28]
       test      dword ptr [r8+34],200000
       je        short M06_L14
       mov       r15d,1
       jmp       short M06_L15
M06_L14:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L15
       mov       r12d,1
M06_L15:
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L18
       test      r14,r14
       jne       short M06_L16
       mov       [rsp+30],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+30]
M06_L16:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L17
       mov       [rsp+30],eax
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+30]
       jmp       short M06_L18
M06_L17:
       mov       [rsp+30],eax
       mov       r8,[rsp+28]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+30]
M06_L18:
       mov       edx,[rsp+44]
       dec       edx
       test      edx,edx
       jge       near ptr M06_L01
M06_L19:
       test      rbp,rbp
       je        near ptr M06_L31
       mov       [rsp+30],eax
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0A0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L30
       mov       edi,[rbp+14]
       xor       ecx,ecx
       jmp       short M06_L22
M06_L20:
       mov       rcx,[rsp+0A0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L52
       jmp       near ptr M06_L00
M06_L21:
       mov       [rsp+34],ecx
       mov       rcx,r8
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       ecx,[rsp+34]
M06_L22:
       mov       rax,rbp
       cmp       edi,[rax+14]
       jne       near ptr M06_L33
       cmp       ecx,[rbp+10]
       jae       near ptr M06_L34
       jmp       near ptr M06_L28
       mov       [rsp+30],edi
       mov       ecx,edx
       mov       edi,r13d
       mov       r13d,eax
       jmp       short M06_L22
M06_L23:
       test      dword ptr [rax+34],200000
       je        short M06_L24
       mov       r15d,1
       jmp       short M06_L25
M06_L24:
       mov       edx,[rax+34]
       and       edx,600000
       cmp       edx,400000
       jne       short M06_L25
       mov       r12d,1
M06_L25:
       test      dword ptr [rax+34],10000000
       mov       [rsp+20],rax
       mov       ecx,[rsp+34]
       je        short M06_L22
       test      r14,r14
       jne       short M06_L27
       mov       [rsp+34],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+20]
       mov       ecx,[rsp+34]
M06_L26:
       mov       r8,r14
       inc       dword ptr [r8+14]
       mov       r9,[r8+8]
       mov       edx,[r8+10]
       cmp       [r9+8],edx
       jbe       near ptr M06_L21
       mov       [rsp+34],ecx
       lea       r10d,[rdx+1]
       mov       [r8+10],r10d
       mov       rcx,r9
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+34]
       jmp       near ptr M06_L22
M06_L27:
       mov       rax,[rsp+20]
       jmp       short M06_L26
M06_L28:
       mov       rax,[rbp+8]
       cmp       ecx,[rax+8]
       jae       near ptr M06_L55
       movsxd    rdx,ecx
       mov       rax,[rax+rdx*8+10]
       inc       ecx
       mov       [rsp+34],ecx
       mov       edx,1
M06_L29:
       test      edx,edx
       jne       near ptr M06_L23
M06_L30:
       mov       eax,[rsp+30]
M06_L31:
       test      r13d,r13d
       je        near ptr M06_L47
       test      r14,r14
       je        short M06_L32
       mov       edi,[r14+14]
       xor       ebp,ebp
       jmp       short M06_L36
M06_L32:
       mov       [rsp+30],eax
       jmp       short M06_L38
M06_L33:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L53
M06_L34:
       mov       ecx,[rbp+10]
       inc       ecx
       mov       edx,ecx
       xor       ecx,ecx
       xor       r8d,r8d
       mov       [rsp+34],edx
       mov       rax,rcx
       mov       edx,r8d
       jmp       short M06_L29
M06_L35:
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L38
       mov       eax,[rsp+30]
M06_L36:
       mov       rcx,r14
       cmp       edi,[rcx+14]
       jne       near ptr M06_L45
       cmp       ebp,[r14+10]
       jae       near ptr M06_L46
       mov       rcx,[r14+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M06_L55
       movsxd    rdx,ebp
       mov       rcx,[rcx+rdx*8+10]
       inc       ebp
       mov       edx,1
M06_L37:
       test      edx,edx
       mov       [rsp+30],eax
       jne       short M06_L35
M06_L38:
       or        r12d,r15d
       je        near ptr M06_L47
       test      r15d,r15d
       jne       short M06_L39
       cmp       qword ptr [rsp+0A0],0
       jne       near ptr M06_L44
M06_L39:
       xor       edi,edi
       mov       r12d,[rsp+30]
       test      r12d,r12d
       jle       near ptr M06_L51
M06_L40:
       cmp       edi,r12d
       jae       near ptr M06_L55
       movsxd    rcx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,1
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.GetExceptions(Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M06_L42
       mov       rcx,r14
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.UpdateExceptionObservedStatus()
       test      rbx,rbx
       jne       short M06_L41
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rbp+78]
       mov       edx,[rdx+8]
       test      edx,edx
       jl        near ptr M06_L54
       test      edx,edx
       je        short M06_L43
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L41:
       mov       r8,[rbp+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
M06_L42:
       inc       edi
       cmp       r12d,edi
       jle       near ptr M06_L51
       jmp       near ptr M06_L40
M06_L43:
       mov       rcx,7FF9C76D4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2B117BC9280
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L41
M06_L44:
       mov       rax,[rsp+0A0]
       cmp       dword ptr [rax+20],0
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M06_L39
       jmp       short M06_L52
M06_L45:
       cmp       edi,[r14+14]
       jne       short M06_L53
M06_L46:
       mov       ebp,[r14+10]
       inc       ebp
       xor       ecx,ecx
       xor       edx,edx
       jmp       near ptr M06_L37
M06_L47:
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L48:
       mov       ecx,33
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L49:
       mov       ecx,3C
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L50:
       mov       ecx,2C
       mov       edx,33
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L51:
       mov       rcx,rbx
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L52:
       lea       rcx,[rsp+0A0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L53:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M06_L54:
       mov       ecx,16
       mov       edx,0B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M06_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1721
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       jmp       short M07_L03
       jmp       short M07_L03
M07_L03:
       mov       rcx,rsp
M07_L03:
       mov       rcx,rsp
       call      M07_L04
       call      M07_L04
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L04:
       push      rbp
M07_L04:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L05
       je        short M07_L05
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L05:
       nop
M07_L05:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 512
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CEE393C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,24A240082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9CE995E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9CE995E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FF9CE7F7F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE91B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FF9CEE39468]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rdx,[rsi+18]
       mov       [rdx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 254
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE989F50],0
       cmp       dword ptr [7FF9CE989F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF9CE651030]; System.Object..ctor()
       call      qword ptr [7FF9CE651030]; System.Object..ctor()
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9CE651030]; System.Object..ctor()
       call      qword ptr [7FF9CE651030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-20]
M01_L01:
       mov       rcx,[rbp-20]
       mov       rdx,7FF9CEE1FBC0
       mov       rdx,7FF9CEE1FBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-28],rax
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-30],rcx
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9CEE39510]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FF9CEE39510]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-38],rax
       mov       [rbp-38],rax
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       lea       rcx,[rdx+8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-38]
       mov       rdx,[rbp-38]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 460
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE3D888]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEE3D618]
       jmp       short M02_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE63CD8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9CEE3D618]
       jmp       short M03_L00
; Total bytes of code 108
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       short M04_L03
       mov       ecx,4
M04_L00:
       cmp       ecx,7FFFFFC7
       ja        short M04_L05
M04_L01:
       cmp       ecx,edx
       mov       [rsp+24],ecx
       jl        short M04_L04
M04_L02:
       mov       rcx,rsi
       mov       edx,[rsp+24]
       call      qword ptr [7FF9CE7F7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       movsxd    rdx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       short M04_L00
M04_L04:
       mov       [rsp+24],edx
       jmp       short M04_L02
M04_L05:
       mov       eax,7FFFFFC7
       mov       ecx,eax
       jmp       short M04_L01
; Total bytes of code 120
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
       je        short M05_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+68]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF9CEE91488
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rdx,7FF9CEE91498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      qword ptr [7FF9CE659018]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+58],xmm4
       xor       eax,eax
       mov       [rsp+68],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L55
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L56
       cmp       qword ptr [rsp+0D0],0
       jne       near ptr M06_L47
M06_L00:
       xor       ebx,ebx
       mov       [rsp+40],rbx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r12d,r12d
       mov       r13d,1
       mov       eax,[rsi+8]
       mov       [rsp+48],eax
       lea       edx,[rax-1]
       test      edx,edx
       jl        short M06_L04
       cmp       eax,edx
       jle       near ptr M06_L17
M06_L01:
       mov       [rsp+74],edx
       mov       ecx,edx
       mov       r8,[rsi+rcx*8+10]
       test      r8,r8
       je        near ptr M06_L18
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L05
M06_L02:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L57
M06_L03:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L01
M06_L04:
       test      rbp,rbp
       je        near ptr M06_L35
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF9CE91B090]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M06_L34
       mov       edi,[rbp+14]
       xor       eax,eax
       jmp       near ptr M06_L14
M06_L05:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L15
M06_L06:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L09
M06_L07:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       jbe       near ptr M06_L16
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L08:
       cmp       edi,[rbp+14]
       jne       near ptr M06_L42
       jmp       short M06_L11
M06_L09:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       je        short M06_L13
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L10:
       jmp       near ptr M06_L07
M06_L11:
       mov       eax,[rbp+10]
       inc       eax
       mov       r8d,eax
       xor       edx,edx
       xor       ecx,ecx
       mov       eax,r8d
M06_L12:
       test      ecx,ecx
       jne       near ptr M06_L32
       jmp       near ptr M06_L34
M06_L13:
       mov       rdx,24A240082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L10
M06_L14:
       mov       rcx,rbp
       cmp       edi,[rcx+14]
       jne       near ptr M06_L08
       cmp       eax,[rbp+10]
       jae       short M06_L11
       mov       rcx,[rbp+8]
       cmp       eax,[rcx+8]
       jae       near ptr M06_L85
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       inc       eax
       mov       ecx,1
       jmp       short M06_L12
M06_L15:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L58
       jmp       near ptr M06_L06
M06_L16:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L17:
       cmp       edx,eax
       jae       near ptr M06_L85
       mov       [rsp+74],edx
       mov       r8d,edx
       mov       r8,[rsi+r8*8+10]
       test      r8,r8
       jne       short M06_L19
M06_L18:
       mov       ecx,2E
       mov       edx,33
       call      qword ptr [7FF9CE947768]
       int       3
M06_L19:
       mov       [rsp+38],r8
       xor       r9d,r9d
       test      dword ptr [r8+34],1600000
       setne     r9b
       mov       [rsp+70],r9d
       test      r9d,r9d
       je        short M06_L22
M06_L20:
       cmp       dword ptr [rsp+70],0
       jne       near ptr M06_L68
M06_L21:
       mov       edx,[rsp+74]
       dec       edx
       jns       short M06_L17
       jmp       near ptr M06_L04
M06_L22:
       cmp       edi,0FFFFFFFF
       je        near ptr M06_L31
M06_L23:
       mov       [rsp+54],eax
       test      rbp,rbp
       je        short M06_L26
M06_L24:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       cmp       [r10+8],r11d
       ja        short M06_L25
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L25:
       lea       ebx,[r11+1]
       mov       [rcx+10],ebx
       movsxd    rdx,r11d
       mov       rcx,r10
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       short M06_L20
M06_L26:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+54]
       test      eax,eax
       jge       short M06_L28
M06_L27:
       mov       ecx,16
       mov       edx,0C
       call      qword ptr [7FF9CE9477F8]
       int       3
M06_L28:
       test      eax,eax
       je        short M06_L30
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L29:
       jmp       near ptr M06_L24
M06_L30:
       mov       rdx,24A240082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L29
M06_L31:
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M06_L69
       jmp       near ptr M06_L23
M06_L32:
       mov       [rsp+30],rdx
       test      dword ptr [rdx+34],200000
       jne       near ptr M06_L79
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M06_L80
M06_L33:
       test      dword ptr [rdx+34],10000000
       jne       near ptr M06_L81
       jmp       near ptr M06_L14
M06_L34:
       mov       eax,[rsp+48]
M06_L35:
       test      r13d,r13d
       je        short M06_L37
       test      r14,r14
       jne       near ptr M06_L84
M06_L36:
       or        r12d,r15d
       jne       near ptr M06_L45
M06_L37:
       mov       eax,r13d
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L38:
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE919270]
       test      eax,eax
       jne       short M06_L40
M06_L39:
       mov       rax,[rsp+58]
       mov       edx,[rsp+6C]
       cmp       edx,[rax+14]
       jne       short M06_L41
       mov       edx,[rsp+68]
       cmp       edx,[rax+10]
       jae       short M06_L43
       mov       rax,[rax+8]
       mov       edx,[rax+8]
       cmp       [rsp+68],edx
       jae       near ptr M06_L85
       mov       edx,[rsp+68]
       mov       rax,[rax+rdx*8+10]
       mov       [rsp+60],rax
       mov       eax,[rsp+68]
       inc       eax
       mov       [rsp+68],eax
       mov       edi,1
       jmp       short M06_L44
M06_L40:
       mov       eax,[rsp+48]
       jmp       short M06_L36
M06_L41:
       mov       eax,[rsp+6C]
       mov       rdx,[rsp+58]
       cmp       eax,[rdx+14]
       je        short M06_L43
M06_L42:
       call      qword ptr [7FF9CE947A80]
       int       3
M06_L43:
       mov       rcx,[rsp+58]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rsp+68],ecx
       xor       ecx,ecx
       mov       [rsp+60],rcx
       xor       edi,edi
M06_L44:
       test      edi,edi
       jne       near ptr M06_L38
       mov       eax,[rsp+48]
       jmp       near ptr M06_L36
M06_L45:
       test      r15d,r15d
       jne       short M06_L48
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE91B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF9CE91B720]
       int       3
M06_L47:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       je        near ptr M06_L00
       jmp       short M06_L46
M06_L48:
       xor       r15d,r15d
       jmp       near ptr M06_L54
M06_L49:
       cmp       r15d,eax
       jae       near ptr M06_L85
       mov       ecx,r15d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       mov       edx,1
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE919720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE9197B0]
       mov       rbx,[rsp+40]
       test      rbx,rbx
       jne       short M06_L52
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r13+78]
       mov       edi,[rcx+8]
       test      edi,edi
       jl        near ptr M06_L27
       test      edi,edi
       jne       short M06_L51
       mov       rcx,7FF9CE644C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,24A240082C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L52
M06_L50:
       mov       rbx,[rsp+40]
       jmp       short M06_L53
M06_L51:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L52:
       mov       r8,[r13+78]
       mov       edx,[rbx+10]
       mov       rcx,rbx
       call      qword ptr [7FF9CE7F7E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FF9CE9479D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FF9CE9477B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FF9CE9477E0]
       int       3
M06_L57:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L64
       mov       r15d,1
       jmp       near ptr M06_L65
M06_L58:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE919AB0]
       test      eax,eax
       je        short M06_L59
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L60
M06_L59:
       xor       edx,edx
M06_L60:
       movzx     r9d,dl
       mov       r8d,r9d
       mov       [rsp+70],r8d
       test      r8d,r8d
       mov       eax,[rsp+48]
       jne       near ptr M06_L02
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L62
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L61
       mov       rdx,24A240082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L62
M06_L61:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L62:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L63
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L63:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L02
M06_L64:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L65
       mov       r12d,1
M06_L65:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L03
       test      r14,r14
       jne       short M06_L66
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L66:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L67
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L67:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L03
M06_L68:
       mov       r8,[rsp+38]
       test      dword ptr [r8+34],200000
       je        near ptr M06_L75
       mov       r15d,1
       jmp       near ptr M06_L76
M06_L69:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rcx,r8
       call      qword ptr [7FF9CE919AB0]
       test      eax,eax
       je        short M06_L70
       mov       rax,[rsp+38]
       xor       edx,edx
       test      dword ptr [rax+34],1600000
       setne     dl
       jmp       short M06_L71
M06_L70:
       xor       edx,edx
M06_L71:
       movzx     r9d,dl
       mov       edx,r9d
       mov       [rsp+70],edx
       test      edx,edx
       mov       eax,[rsp+48]
       jne       near ptr M06_L20
       mov       [rsp+50],eax
       test      rbp,rbp
       jne       short M06_L73
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       eax,[rsp+50]
       test      eax,eax
       jl        near ptr M06_L27
       test      eax,eax
       jne       short M06_L72
       mov       rdx,24A240082B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L73
M06_L72:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L73:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r11d,[rcx+10]
       mov       [rsp+28],r10
       cmp       [r10+8],r11d
       jbe       short M06_L74
       lea       r10d,[r11+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r11d
       mov       rcx,[rsp+28]
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L74:
       mov       r8,[rsp+38]
       mov       [rsp+38],r8
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L20
M06_L75:
       mov       ecx,[r8+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L76
       mov       r12d,1
M06_L76:
       mov       [rsp+38],r8
       test      dword ptr [r8+34],10000000
       je        near ptr M06_L21
       test      r14,r14
       jne       short M06_L77
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+48]
M06_L77:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L78
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       movsxd    rdx,r10d
       mov       rcx,r9
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L78:
       mov       r8,[rsp+38]
       mov       rdx,r8
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+48]
       jmp       near ptr M06_L21
M06_L79:
       mov       r15d,1
       jmp       near ptr M06_L33
M06_L80:
       mov       r12d,1
       jmp       near ptr M06_L33
M06_L81:
       test      r14,r14
       jne       short M06_L82
       mov       [rsp+4C],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+4C]
M06_L82:
       mov       rcx,r14
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L83
       mov       [rsp+4C],eax
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       movsxd    rdx,r9d
       mov       rcx,r8
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L83:
       mov       [rsp+4C],eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FF9CE7F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7F7D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE989F50],0
       cmp       dword ptr [7FF9CE989F50],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9CE779018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FF9CE779018]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE396C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEE396C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE396C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FF9CEE396C0]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 95
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CE539660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CE5391C8]
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CE5390C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CDD44C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CE539450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE539858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CDE77210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE539858]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE019AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE019270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CE5390D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 95
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE39660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE391C8]
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE390C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE644C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE39450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE39858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE777210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE39858]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE919AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE919270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE390D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 95
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76F4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE59660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE591C8]
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE590C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE664C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE59450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE797210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59858]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE939AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE939270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE590D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 95
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76E4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE49660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE491C8]
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE490C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE654C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE49450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE49858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE787210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE49858]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE929AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE929270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE490D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 95
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEA69960]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEA694C8]
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEA693C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE274C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEA69750]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA69B58]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE3A7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA69B58]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE549AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE549270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEA693D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 95
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76E4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE29660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE291C8]
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE290C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE634C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE29450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE29858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE767210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE29858]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE909AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE909270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE290D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 95
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE49660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE491C8]
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE490C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE654C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE49450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE49858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE787210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE49858]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE929AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE929270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE490D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CE549960]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CE5494C8]
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CE5493C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CDD54C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CE549750]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE549B58]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CDE87210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE549B58]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE029AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE029270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CE5493D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76E4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEE39660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE391C8]
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE390C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE644C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE39450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE39858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE777210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE39858]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE919AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE919270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE390D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76F4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEE29660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE291C8]
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE290C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE634C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE29450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE29858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE767210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE29858]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE909AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE909270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE290D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76F4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEE49960]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE494C8]
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE493C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE654C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE49750]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE49B58]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE787210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE49B58]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE929AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE929270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE493D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEA79960]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEA794C8]
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEA793C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE284C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEA79750]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA79B58]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE3B7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA79B58]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE559AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE559270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEA793D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76E4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEE59660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE591C8]
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE590C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE664C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE59450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE797210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59858]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE939AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE939270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE590D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEE59960]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE594C8]
       jmp       short M00_L00
; Total bytes of code 98
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE593C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE664C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE59750]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59B58]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE797210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59B58]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE939AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE939270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE593D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 89
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CE53B438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CE53B1C8]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CE53B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CDD44C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CE53B300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE53B630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CDE77210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE53B630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE019AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE019270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CE53B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 89
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CE539438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CE5391C8]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CE5390C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CDD44C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CE539300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE539630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CDE77210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE539630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE019AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE019270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CE5390D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 89
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE59438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE591C8]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE590C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE664C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE59300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE797210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE939AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE939270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE590D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 89
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76F4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE59438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE591C8]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE590C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE664C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE59300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE797210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE939AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE939270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE590D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 89
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEA59738]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEA594C8]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEA593C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE264C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEA59600]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA59930]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE397210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA59930]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE539AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE539270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEA593D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 89
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76E4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEA69738]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEA694C8]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEA693C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE274C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEA69600]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA69930]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE3A7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA69930]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE549AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE549270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEA693D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 89
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76F4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9CEE59438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE591C8]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE590C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE664C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE59300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE797210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE939AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE939270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE590D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76E4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CE54B438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CE54B1C8]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CE54B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CDD44C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CE54B300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE54B630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CDE77210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE54B630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE019AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE019270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CE54B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76E4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CE539738]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CE5394C8]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CE5393C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CDD44C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CE539600]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE539930]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CDE77210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE539930]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE019AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE019270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CE5393D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEE39438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE391C8]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE390C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE644C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE39300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE39630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE777210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE39630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE919AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE919270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE390D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEE29438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE291C8]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE290C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE634C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE29300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE29630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE767210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE29630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE909AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE909270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE290D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEA89438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEA891C8]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEA890C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE294C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEA89300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA89630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE3C7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA89630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE569AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE569270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEA890D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76F4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEA6B438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEA6B1C8]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEA6B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE274C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEA6B300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA6B630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE3A7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEA6B630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE549AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE549270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEA6B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C76F4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9CEE59438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9CEE591C8]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9CEE590C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9CE664C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FF9CEE59300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9CE797210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CEE59630]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9CE939AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9CE939270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9CEE590D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

