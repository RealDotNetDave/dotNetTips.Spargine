## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1383BD14E78
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD67BBFB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 106
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
       mov       rdx,7FFD67AD5C88
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
       mov       rdx,7FFD67AD5C98
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
       mov       rdx,1383BD14E78
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
       mov       rdx,1383BD14E78
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
       mov       rcx,7FFD675B4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1383BD14E88
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
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 174
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4628B0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,20811808280
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD45DE5E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD45DE5E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFD45C47F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD45D6B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FFD4628B168]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD462A0100
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FFD4628B210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 107
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
       call      qword ptr [7FFD4628F3A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD4628F138]
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
       call      qword ptr [7FFD462B5798]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD4628F138]
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
       call      qword ptr [7FFD45C47960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFD461496B8
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
       mov       rdx,7FFD461496C8
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
       call      qword ptr [7FFD45AA9018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFD45D6B090]
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
       mov       rdx,20811808280
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D97768]
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D977F8]
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
       mov       rdx,20811808280
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
       call      qword ptr [7FFD45D69270]
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
       call      qword ptr [7FFD45D97A80]
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
       call      qword ptr [7FFD45D6B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFD45D6B720]
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
       call      qword ptr [7FFD45D69720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFD45D697B0]
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
       mov       rcx,7FFD45A94C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,20811808298
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
       call      qword ptr [7FFD45C47E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FFD45D979D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FFD45D977B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FFD45D977E0]
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
       call      qword ptr [7FFD45D69AB0]
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
       mov       rdx,20811808280
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D69AB0]
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
       mov       rdx,20811808280
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFD45C47D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      qword ptr [7FFD45BC9030]
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,19D8BF64E78
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD67BCFB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 106
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
       mov       rdx,7FFD67AE5C78
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
       mov       rdx,7FFD67AE5E38
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
       mov       rdx,19D8BF64E78
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
       mov       rdx,19D8BF64E78
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
       mov       rcx,7FFD675C4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,19D8BF64E88
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
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 174
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD462793C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,21C03808280
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD45DD5E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD45DD5E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFD45C37F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD45D5B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FFD46279468]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD462904C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FFD46279510]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 107
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
       call      qword ptr [7FFD4627D888]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD4627D618]
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
       call      qword ptr [7FFD462A3CD8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD4627D618]
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
       call      qword ptr [7FFD45C37960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFD4629FF50
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
       mov       rdx,7FFD4629FF60
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
       call      qword ptr [7FFD45A99018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFD45D5B090]
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
       mov       rdx,21C03808280
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D87768]
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D877F8]
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
       mov       rdx,21C03808280
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
       call      qword ptr [7FFD45D59270]
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
       call      qword ptr [7FFD45D87A80]
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
       call      qword ptr [7FFD45D5B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFD45D5B720]
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
       call      qword ptr [7FFD45D59720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFD45D597B0]
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
       mov       rcx,7FFD45A84C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,21C03808298
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
       call      qword ptr [7FFD45C37E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FFD45D879D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FFD45D877B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FFD45D877E0]
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
       call      qword ptr [7FFD45D59AB0]
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
       mov       rdx,21C03808280
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D59AB0]
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
       mov       rdx,21C03808280
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFD45C37D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      qword ptr [7FFD45BB9030]
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,166AE564E78
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD67BCFB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 106
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
       mov       rdx,7FFD67AE5B90
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
       mov       rdx,7FFD67AE5BA0
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
       mov       rdx,166AE564E78
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
       mov       rdx,166AE564E78
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
       mov       rcx,7FFD675C4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,166AE564E88
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
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 174
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4628B0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2170E408280
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD45DE5E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD45DE5E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFD45C47F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD45D6B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FFD4628B168]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD4627F8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FFD4628B210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 107
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
       call      qword ptr [7FFD4628F3A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD4628F138]
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
       call      qword ptr [7FFD462B5798]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD4628F138]
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
       call      qword ptr [7FFD45C47960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFD462ADF50
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
       mov       rdx,7FFD462ADF60
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
       call      qword ptr [7FFD45AA9018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFD45D6B090]
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
       mov       rdx,2170E408280
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D97768]
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D977F8]
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
       mov       rdx,2170E408280
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
       call      qword ptr [7FFD45D69270]
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
       call      qword ptr [7FFD45D97A80]
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
       call      qword ptr [7FFD45D6B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFD45D6B720]
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
       call      qword ptr [7FFD45D69720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFD45D697B0]
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
       mov       rcx,7FFD45A94C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2170E408298
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
       call      qword ptr [7FFD45C47E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FFD45D979D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FFD45D977B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FFD45D977E0]
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
       call      qword ptr [7FFD45D69AB0]
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
       mov       rdx,2170E408280
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D69AB0]
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
       mov       rdx,2170E408280
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFD45C47D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      qword ptr [7FFD45BC9030]
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,29C4B744E78
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD67BCFB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 106
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
       mov       rdx,7FFD67AE5C50
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
       mov       rdx,7FFD67AE5C60
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
       mov       rdx,29C4B744E78
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
       mov       rdx,29C4B744E78
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
       mov       rcx,7FFD675C4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,29C4B744E88
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
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 174
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4627B0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1C08E808280
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD45DD5E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD45DD5E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFD45C37F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD45D5B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FFD4627B168]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD4626EBF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FFD4627B210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 107
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
       call      qword ptr [7FFD4627F3A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD4627F138]
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
       call      qword ptr [7FFD462A5798]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD4627F138]
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
       call      qword ptr [7FFD45C37960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFD4629FF50
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
       mov       rdx,7FFD4629FF60
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
       call      qword ptr [7FFD45A99018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFD45D5B090]
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
       mov       rdx,1C08E808280
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D87768]
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D877F8]
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
       mov       rdx,1C08E808280
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
       call      qword ptr [7FFD45D59270]
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
       call      qword ptr [7FFD45D87A80]
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
       call      qword ptr [7FFD45D5B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFD45D5B720]
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
       call      qword ptr [7FFD45D59720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFD45D597B0]
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
       mov       rcx,7FFD45A84C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1C08E808298
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
       call      qword ptr [7FFD45C37E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FFD45D879D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FFD45D877B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FFD45D877E0]
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
       call      qword ptr [7FFD45D59AB0]
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
       mov       rdx,1C08E808280
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D59AB0]
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
       mov       rdx,1C08E808280
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFD45C37D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      qword ptr [7FFD45BB9030]
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,243C38F9280
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD67BDFB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 106
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
       mov       rdx,7FFD67AF5B90
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
       mov       rdx,7FFD67AF5BA0
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
       mov       rdx,243C38F9280
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
       mov       rdx,243C38F9280
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
       mov       rcx,7FFD675D4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,243C38F9290
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
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 174
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4627B0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1F819808280
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD45DD5E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD45DD5E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFD45C37F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD45D5B060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FFD4627B168]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD46290100
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FFD4627B210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 107
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
       call      qword ptr [7FFD4627F3A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD4627F138]
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
       call      qword ptr [7FFD462A5798]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD4627F138]
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
       call      qword ptr [7FFD45C37960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFD461396B8
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
       mov       rdx,7FFD461396C8
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
       call      qword ptr [7FFD45A99018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFD45D5B090]
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
       mov       rdx,1F819808280
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D87768]
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D877F8]
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
       mov       rdx,1F819808280
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
       call      qword ptr [7FFD45D59270]
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
       call      qword ptr [7FFD45D87A80]
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
       call      qword ptr [7FFD45D5B510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFD45D5B720]
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
       call      qword ptr [7FFD45D59720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFD45D597B0]
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
       mov       rcx,7FFD45A84C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1F819808298
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
       call      qword ptr [7FFD45C37E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FFD45D879D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FFD45D877B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FFD45D877E0]
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
       call      qword ptr [7FFD45D59AB0]
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
       mov       rdx,1F819808280
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45D59AB0]
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
       mov       rdx,1F819808280
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD45C37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFD45C37D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      qword ptr [7FFD45BB9030]
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,25A3D824E78
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD67BCFB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 106
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
       mov       rdx,7FFD67AE5B70
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
       mov       rdx,7FFD67AE5D30
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
       mov       rdx,25A3D824E78
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
       mov       rdx,25A3D824E78
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
       mov       rcx,7FFD675C4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,25A3D824E88
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
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 174
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AD90C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,20798008280
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD52635E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD52635E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFD52497F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD525BB060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FFD52AD9168]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD52ABEDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FFD52AD9210]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 107
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
       call      qword ptr [7FFD52ADD3A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD52ADD138]
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
       call      qword ptr [7FFD52B03798]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD52ADD138]
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
       call      qword ptr [7FFD52497960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFD52B31F50
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
       mov       rdx,7FFD52B31F60
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
       call      qword ptr [7FFD522F9018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFD525BB090]
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
       mov       rdx,20798008280
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD525E7768]
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD525E77F8]
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
       mov       rdx,20798008280
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
       call      qword ptr [7FFD525B9270]
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
       call      qword ptr [7FFD525E7A80]
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
       call      qword ptr [7FFD525BB510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFD525BB720]
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
       call      qword ptr [7FFD525B9720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFD525B97B0]
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
       mov       rcx,7FFD522E4C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,20798008298
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
       call      qword ptr [7FFD52497E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FFD525E79D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FFD525E77B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FFD525E77E0]
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
       call      qword ptr [7FFD525B9AB0]
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
       mov       rdx,20798008280
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD525B9AB0]
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
       mov       rdx,20798008280
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFD52497D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      qword ptr [7FFD52419030]
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,170F88C4E70
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD67BDF7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 106
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
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+68]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FFD67C15A00
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
       mov       rdx,7FFD67C159F8
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
       mov       rdx,170F88C4E70
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
       mov       rdx,170F88C4E70
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
       mov       rcx,7FFD675D4938
       mov       edx,59
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,170F88C4E88
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
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 174
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AE93C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+288]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1A2B2408280
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD52645E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD52645E28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFD524A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFD524A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFD524A7F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD525CB060]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rdi
       call      qword ptr [7FFD52AE9468]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFD52ACEDD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FFD52AE9510]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 107
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
       call      qword ptr [7FFD52AED888]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD52AED618]
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
       call      qword ptr [7FFD52B13CD8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD52AED618]
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
       call      qword ptr [7FFD524A7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFD52B42080
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
       mov       rdx,7FFD52B42090
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
       call      qword ptr [7FFD52309018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFD525CB090]
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
       mov       rdx,1A2B2408280
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
       call      qword ptr [7FFD524A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD525F7768]
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
       call      qword ptr [7FFD524A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD525F77F8]
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
       mov       rdx,1A2B2408280
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
       call      qword ptr [7FFD525C9270]
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
       call      qword ptr [7FFD525F7A80]
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
       call      qword ptr [7FFD525CB510]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       mov       eax,[rsp+48]
       je        short M06_L48
M06_L46:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFD525CB720]
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
       call      qword ptr [7FFD525C9720]
       mov       r13,rax
       test      r13,r13
       je        short M06_L50
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFD525C97B0]
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
       mov       rcx,7FFD522F4C10
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1A2B2408298
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
       call      qword ptr [7FFD524A7E28]
M06_L53:
       inc       r15d
       mov       [rsp+40],rbx
       mov       eax,[rsp+48]
M06_L54:
       cmp       eax,r15d
       jg        near ptr M06_L49
       mov       rbx,[rsp+40]
       mov       rcx,rbx
       call      qword ptr [7FFD525F79D8]
       int       3
M06_L55:
       mov       ecx,33
       call      qword ptr [7FFD525F77B0]
       int       3
M06_L56:
       mov       ecx,3C
       call      qword ptr [7FFD525F77E0]
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
       call      qword ptr [7FFD525C9AB0]
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
       mov       rdx,1A2B2408280
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
       call      qword ptr [7FFD524A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD524A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD525C9AB0]
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
       mov       rdx,1A2B2408280
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
       call      qword ptr [7FFD524A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD524A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFD524A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       eax,[rsp+4C]
       jmp       near ptr M06_L14
M06_L84:
       lea       rdx,[rsp+58]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFD524A7D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L39
M06_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2558
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L01
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L02
       mov       edi,0FFFFFFFF
M07_L00:
       jmp       short M07_L03
M07_L01:
       call      qword ptr [7FFD52429030]
       int       3
M07_L02:
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp-18],0
       je        short M07_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L04:
       mov       eax,edi
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
       cmp       byte ptr [rbp-18],0
       je        short M07_L05
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675D4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD46269660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD462691C8]
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
       jmp       qword ptr [7FFD462690C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45A74C10
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
       call      qword ptr [7FFD46269450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
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
       call      qword ptr [7FFD46269858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BA7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD46269858]
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
       call      qword ptr [7FFD45D49AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D49270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD462690D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675B4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4627B660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD4627B1C8]
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
       jmp       qword ptr [7FFD4627B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45A84C10
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
       call      qword ptr [7FFD4627B450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
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
       call      qword ptr [7FFD4627B858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BB7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD4627B858]
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
       call      qword ptr [7FFD45D59AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D59270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD4627B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675B4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AF9660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD52AF91C8]
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
       jmp       qword ptr [7FFD52AF90C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD52304C10
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
       call      qword ptr [7FFD52AF9450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
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
       call      qword ptr [7FFD52AF9858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD52437210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD52AF9858]
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
       call      qword ptr [7FFD525D9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD525D9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD52AF90D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675E4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD46299660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD462991C8]
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
       jmp       qword ptr [7FFD462990C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45AA4C10
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
       call      qword ptr [7FFD46299450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
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
       call      qword ptr [7FFD46299858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BD7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD46299858]
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
       call      qword ptr [7FFD45D79AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D79270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD462990D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675B4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AFB960]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD52AFB4C8]
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
       jmp       qword ptr [7FFD52AFB3C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD52304C10
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
       call      qword ptr [7FFD52AFB750]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
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
       call      qword ptr [7FFD52AFBB58]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD52437210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD52AFBB58]
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
       call      qword ptr [7FFD525D9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD525D9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD52AFB3D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675E4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AF9660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD52AF91C8]
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
       jmp       qword ptr [7FFD52AF90C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD52304C10
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
       call      qword ptr [7FFD52AF9450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
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
       call      qword ptr [7FFD52AF9858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD52437210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD52AF9858]
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
       call      qword ptr [7FFD525D9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD525D9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD52AF90D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675B4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B1B660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD52B1B1C8]
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
       jmp       qword ptr [7FFD52B1B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD52324C10
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
       call      qword ptr [7FFD52B1B450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__7.MoveNext()
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
       call      qword ptr [7FFD52B1B858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD52457210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD52B1B858]
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
       call      qword ptr [7FFD525F9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD525F9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD52B1B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675A4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4627B660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD4627B1C8]
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
       jmp       qword ptr [7FFD4627B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45A84C10
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
       call      qword ptr [7FFD4627B450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
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
       call      qword ptr [7FFD4627B858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BB7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD4627B858]
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
       call      qword ptr [7FFD45D59AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D59270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD4627B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675C4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD46279660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD462791C8]
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
       jmp       qword ptr [7FFD462790C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45A84C10
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
       call      qword ptr [7FFD46279450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
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
       call      qword ptr [7FFD46279858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BB7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD46279858]
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
       call      qword ptr [7FFD45D59AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D59270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD462790D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675D4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4629B660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD4629B1C8]
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
       jmp       qword ptr [7FFD4629B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45AA4C10
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
       call      qword ptr [7FFD4629B450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
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
       call      qword ptr [7FFD4629B858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BD7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD4629B858]
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
       call      qword ptr [7FFD45D79AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D79270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD4629B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675C4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD462A9660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD462A91C8]
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
       jmp       qword ptr [7FFD462A90C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45AB4C10
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
       call      qword ptr [7FFD462A9450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
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
       call      qword ptr [7FFD462A9858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BE7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD462A9858]
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
       call      qword ptr [7FFD45D89AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D89270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD462A90D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675B4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4628B660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD4628B1C8]
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
       jmp       qword ptr [7FFD4628B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45A94C10
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
       call      qword ptr [7FFD4628B450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
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
       call      qword ptr [7FFD4628B858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BC7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD4628B858]
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
       call      qword ptr [7FFD45D69AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D69270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD4628B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675D4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AEB660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD52AEB1C8]
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
       jmp       qword ptr [7FFD52AEB0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD522F4C10
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
       call      qword ptr [7FFD52AEB450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
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
       call      qword ptr [7FFD52AEB858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD52427210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD52AEB858]
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
       call      qword ptr [7FFD525C9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD525C9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD52AEB0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675A4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AD9660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD52AD91C8]
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
       jmp       qword ptr [7FFD52AD90C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD522E4C10
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
       call      qword ptr [7FFD52AD9450]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__6.MoveNext()
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
       call      qword ptr [7FFD52AD9858]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD52417210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD52AD9858]
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
       call      qword ptr [7FFD525B9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD525B9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD52AD90D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675B4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD46269438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD462691C8]
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
       jmp       qword ptr [7FFD462690C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45A74C10
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
       call      qword ptr [7FFD46269300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
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
       call      qword ptr [7FFD46269630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BA7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD46269630]
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
       call      qword ptr [7FFD45D49AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D49270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD462690D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675E4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD462AB438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD462AB1C8]
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
       jmp       qword ptr [7FFD462AB0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45AB4C10
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
       call      qword ptr [7FFD462AB300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
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
       call      qword ptr [7FFD462AB630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BE7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD462AB630]
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
       call      qword ptr [7FFD45D89AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D89270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD462AB0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675A4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD46299438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD462991C8]
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
       jmp       qword ptr [7FFD462990C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45AA4C10
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
       call      qword ptr [7FFD46299300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
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
       call      qword ptr [7FFD46299630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BD7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD46299630]
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
       call      qword ptr [7FFD45D79AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D79270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD462990D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675D4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4629B438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD4629B1C8]
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
       jmp       qword ptr [7FFD4629B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45AA4C10
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
       call      qword ptr [7FFD4629B300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
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
       call      qword ptr [7FFD4629B630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BD7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD4629B630]
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
       call      qword ptr [7FFD45D79AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D79270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD4629B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675B4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4628D438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD4628D1C8]
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
       jmp       qword ptr [7FFD4628D0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45A94C10
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
       call      qword ptr [7FFD4628D300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
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
       call      qword ptr [7FFD4628D630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BC7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD4628D630]
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
       call      qword ptr [7FFD45D69AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D69270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD4628D0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675E4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AE9738]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD52AE94C8]
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
       jmp       qword ptr [7FFD52AE93C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD522F4C10
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
       call      qword ptr [7FFD52AE9600]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
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
       call      qword ptr [7FFD52AE9930]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD52427210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD52AE9930]
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
       call      qword ptr [7FFD525C9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD525C9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD52AE93D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675D4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AE9438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD52AE91C8]
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
       jmp       qword ptr [7FFD52AE90C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD522F4C10
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
       call      qword ptr [7FFD52AE9300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__4.MoveNext()
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
       call      qword ptr [7FFD52AE9630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD52427210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD52AE9630]
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
       call      qword ptr [7FFD525C9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD525C9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD52AE90D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675D4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4629B438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD4629B1C8]
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
       jmp       qword ptr [7FFD4629B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45AA4C10
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
       call      qword ptr [7FFD4629B300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
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
       call      qword ptr [7FFD4629B630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BD7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD4629B630]
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
       call      qword ptr [7FFD45D79AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D79270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD4629B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675C4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4627B438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD4627B1C8]
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
       jmp       qword ptr [7FFD4627B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45A84C10
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
       call      qword ptr [7FFD4627B300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
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
       call      qword ptr [7FFD4627B630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BB7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD4627B630]
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
       call      qword ptr [7FFD45D59AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D59270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD4627B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675B4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4629D438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD4629D1C8]
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
       jmp       qword ptr [7FFD4629D0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45AA4C10
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
       call      qword ptr [7FFD4629D300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
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
       call      qword ptr [7FFD4629D630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BD7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD4629D630]
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
       call      qword ptr [7FFD45D79AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D79270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD4629D0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675B4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD4627B438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD4627B1C8]
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
       jmp       qword ptr [7FFD4627B0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45A84C10
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
       call      qword ptr [7FFD4627B300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
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
       call      qword ptr [7FFD4627B630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BB7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD4627B630]
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
       call      qword ptr [7FFD45D59AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D59270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD4627B0D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675C4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD462AB738]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD462AB4C8]
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
       jmp       qword ptr [7FFD462AB3C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD45AB4C10
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
       call      qword ptr [7FFD462AB600]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
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
       call      qword ptr [7FFD462AB930]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD45BE7210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD462AB930]
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
       call      qword ptr [7FFD45D89AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD45D89270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD462AB3D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675C4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52ADB738]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD52ADB4C8]
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
       jmp       qword ptr [7FFD52ADB3C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD522E4C10
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
       call      qword ptr [7FFD52ADB600]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
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
       call      qword ptr [7FFD52ADB930]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD52417210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD52ADB930]
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
       call      qword ptr [7FFD525B9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD525B9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD52ADB3D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD675D4938
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AE9438]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__3 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD52AE91C8]
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
       jmp       qword ptr [7FFD52AE90C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
       mov       rcx,7FFD522F4C10
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
       call      qword ptr [7FFD52AE9300]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__3.MoveNext()
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
       call      qword ptr [7FFD52AE9630]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFD52427210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FFD52AE9630]
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
       call      qword ptr [7FFD525C9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFD525C9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFD52AE90D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

